using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics.Wgl;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public class X11DialogComponent : IDialogComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11DialogComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Dialog;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal bool HasZenity = false;

        internal Version? ZenityVersion;

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("zenity", "--version");
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            RemoveVSCodeEnvironmentVariables(startInfo.Environment);
            Process? process = Process.Start(startInfo);
            if (process == null)
            {
                Logger?.LogWarning($"Could not create new process to detect zenity.");
                HasZenity = false;
                return;
            }

            process.WaitForExit();

            string stderr = process.StandardError.ReadToEnd();
            if (string.IsNullOrWhiteSpace(stderr) == false)
            {
                Logger?.LogWarning($"zenity stderr while getting version: {stderr}");
            }

            string version = process.StandardOutput.ReadToEnd();

            HasZenity = true;
            if (Version.TryParse(version, out ZenityVersion) == false)
            {
            

                Logger?.LogWarning($"Unable to parse zenity version: '{version}'");
            }
            else
            {
                Logger?.LogInfo($"Detected Zenity version {ZenityVersion}.");
            }
        }

        /// <inheritdoc/>
        public bool CanTargetFolders => HasZenity;

        private static void RemoveVSCodeEnvironmentVariables(IDictionary<string, string?> environmentVars)
        {
            // To be able to run Zenity (GTK) from VSCode we need to unset 
            // these environment variables that are set in the VSCode snap.
            // See: 
            // https://askubuntu.com/questions/1462295/ubuntu-22-04-both-eye-of-gnome-and-gimp-failing-with-undefined-symbol-error/1462494#1462494
            // https://github.com/microsoft/vscode/issues/179086
            // These issues only mention GTK_PATH and GIO_MODULE_DIR but there are more 
            // variables that need to be unset in order for zenity to work correctly.
            // Specifically GDK_PIXBUF_MODULE_FILE needs to be removed for zenity to work correctly.
            // I remove a lot of the other GDK and GTK related variables that are set in VSCode for good measure.
            // - Noggin_bops 2024-07-18
            environmentVars.Remove("GTK_PATH");
            environmentVars.Remove("GIO_MODULE_DIR");
            environmentVars.Remove("GTK_EXE_PREFIX");
            environmentVars.Remove("GIO_LAUNCHED_DESKTOP_FILE");
            environmentVars.Remove("GIO_LAUNCHED_DESKTOP_FILE_PID");
            environmentVars.Remove("GTK_IM_MODULE_FILE");
            environmentVars.Remove("GDK_PIXBUF_MODULEDIR");
            environmentVars.Remove("GDK_PIXBUF_MODULE_FILE");
            environmentVars.Remove("GSETTINGS_SCHEMA_DIR");
        }

        private unsafe XWindow? FindProcessWindow(Process process)
        {
            Queue<XWindow> toCheck = new Queue<XWindow>();
            toCheck.Enqueue(X11.DefaultRootWindow);

            List<XWindow> matchingWindows = new List<XWindow>();
            while (toCheck.TryDequeue(out XWindow check))
            {
                int status = XGetWindowProperty(
                    X11.Display, 
                    check,
                    X11.Atoms[KnownAtoms._NET_WM_PID],
                    0, 1,
                    false,
                    X11.Atoms[KnownAtoms.CARDINAL],
                    out _,
                    out _,
                    out long nItems,
                    out _,
                    out IntPtr pidPtr);

                if (status == X11.Success && pidPtr != IntPtr.Zero)
                {
                    ulong windowPid = *(ulong*)pidPtr;
                    if (windowPid == (ulong)process.Id)
                    {
                        // Zenity creates a hidden InputOnly XWindow which is not the window we want.
                        // So we need to also filter so we only get the relevant InputOutput window that is the dialog.
                        XStatus status3 = (XStatus)XGetWindowAttributes(X11.Display, check, out XWindowAttributes attribs);
                        if (attribs.Class == WindowClass.InputOutput)
                        {
                            return check;
                        }
                    }
                }

                if (pidPtr != IntPtr.Zero)
                    XFree(pidPtr);

                if (XQueryTree(X11.Display, check, out _, out _, out XWindow* children, out uint nChildern) != 0)
                {
                    for (int i = 0; i < nChildern; i++)
                    {
                        toCheck.Enqueue(children[i]);
                    }
                }

                if (children != null)
                    XFree(children);
            }

            return null;
        }

        private unsafe void RunModalLoop(Process process, XWindowHandle transientFor)
        {
            int tries = 0;
            const int MaxTries = 10;

            XWindow? dialogWindow = null;
            // FIXME: If dialogWindow is null it's likely because the dialog
            // was slow when opening, so trying to get the window again seems like a good idea.
            // Unless this a more reliable way to find the window, in which case we should do that.
            // - Noggin_bops 2024-07-18
            while (process.HasExited == false)
            {
                Thread.Sleep(10);
                if (dialogWindow == null && tries < MaxTries)
                {
                    dialogWindow = FindProcessWindow(process);
                    if (dialogWindow != null)
                    {
                        // Make the dialog modal.
                        {
                            XEvent e = new XEvent();
                            ref XClientMessageEvent client = ref e.ClientMessage;

                            client.Type = XEventType.ClientMessage;
                            client.Serial = 0;
                            client.SendEvent = 1;
                            client.Display = X11.Display;
                            client.Window = dialogWindow.Value;
                            client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
                            client.Format = 32;
                            unsafe
                            {
                                client.l[0] = X11._NET_WM_STATE_ADD;
                                client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_MODAL].Id;
                                client.l[2] = 0;
                                client.l[3] = 1;
                                client.l[4] = 0;
                            }

                            XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify | XEventMask.PropertyChange, e);
                        }

                        Logger?.LogInfo($"Found Zenity window XID: 0x{dialogWindow.Value:X}");
                    }
                    else
                    {
                        Logger?.LogDebug($"Was not able to find Zenity window XID. Try: {tries + 1}");
                    }
                }
                else if (dialogWindow == null && tries == MaxTries)
                {
                    Logger?.LogWarning($"Could not find Zenity window after {MaxTries} tries.");
                    tries = int.MaxValue;
                }

                // Loop through all events we care about before continuing.
                while (XCheckIfEvent(X11.Display, out XEvent @event, IsModalEventLoopEvent, IntPtr.Zero))
                {
                    Logger?.LogDebug($"{@event.Type}");
                    if (@event.Type == XEventType.ClientMessage)
                    {
                        if (@event.ClientMessage.Format == 32 &&
                            @event.ClientMessage.l[0] == (long)X11.Atoms[KnownAtoms._NET_WM_PING].Id)
                        {
                            // Ping events to know that we are still responsive.
                            XEvent reply = @event;
                            reply.ClientMessage.Window = X11.DefaultRootWindow;

                            XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureNotify | XEventMask.SubstructureRedirect, reply);
                        }
                    }
                    // FIXME: We want to send the KeyPress and
                    // KeyRelease events after the modal loop so
                    // we get an accurate picture of the keyboard state.
                    else if (@event.Type == XEventType.KeyPress ||
                             @event.Type == XEventType.KeyRelease)
                    {
                        // Keep track of the keyboard state.
                        XKeySym keysym = default;
                        Scancode scancode = X11KeyboardComponent.ToScancode(@event.KeyPressed.keycode);
                        Key key = X11KeyboardComponent.TranslateKeySym(new Span<XKeySym>(ref keysym));

                        KeyModifier modifiers = X11KeyboardComponent.ModifiersFromState(@event.KeyPressed.state);

                        bool changed = X11KeyboardComponent.KeyStateChanged(scancode, @event.Type == XEventType.KeyPress);
                    }
                    // FIXME: We want to send the correct ButtonPress and ButtonRelease
                    // events at the end of the modal loop to match the current state
                    // of the mouse.
                    else if (@event.Type == XEventType.ButtonPress ||
                             @event.Type == XEventType.ButtonRelease)
                    {
                        XButtonEvent buttonPressed = @event.ButtonPressed;

                        // Buttons 4 to 7 are used for scroll.
                        if (buttonPressed.button >= 4 && buttonPressed.button <= 7)
                        {
                            int xdelta = 0;
                            int ydelta = 0;
                            switch (buttonPressed.button)
                            {
                                case 4: ydelta = 1; break; // up
                                case 5: ydelta = -1; break; // down
                                case 6: xdelta = -1; break; // left
                                case 7: xdelta = 1; break; // right
                                default: throw new Exception("This should never happen.");
                            }

                            X11MouseComponent.RegisterMouseWheelDelta((xdelta, ydelta));
                        }
                        else
                        {
                            if (buttonPressed.button == 1 && transientFor.HitTest != null)
                            {
                                // We do a hit test here to see if we should do something.
                                HitType type = transientFor.HitTest(transientFor, new Vector2(buttonPressed.x, buttonPressed.y));
                                if (type != HitType.Default)
                                {
                                    // FIXME: Handle the hit type!
                                    Logger?.LogWarning("Hit testing is not supported in x11 yet.");
                                    continue;
                                }
                            }

                            MouseButton button;
                            switch (buttonPressed.button)
                            {
                                case 1: button = MouseButton.Button1; break; // Left
                                case 2: button = MouseButton.Button3; break; // Middle
                                case 3: button = MouseButton.Button2; break; // Right
                                case 8: button = MouseButton.Button4; break; // X1
                                case 9: button = MouseButton.Button5; break; // X2
                                default: continue; // Skip this event.
                            }

                            KeyModifier modifiers = X11KeyboardComponent.ModifiersFromState(buttonPressed.state);

                            X11MouseComponent.RegisterButtonState(button, true);
                        }
                    }
                    else if (@event.Type == XEventType.MotionNotify)
                    {
                        // Eat these events so that we don't spam input to the window
                        // when we exit the modal loop.
                    }
                    // FIXME: We want to send the appropriate events 
                    // when we leave the modal loop so that we for example
                    // miss a LeaveNotify or EnterNotify when the modal is done.
                    else if (@event.Type == XEventType.EnterNotify ||
                             @event.Type == XEventType.LeaveNotify)
                    {
                        
                    }
                    else
                    {
                        Logger?.LogWarning($"Unhandled event {@event.Type}. This is an OpenTK bug, please report an issue.");
                    }
                }
            }

            static unsafe bool IsModalEventLoopEvent(XDisplayPtr display, ref XEvent @event, IntPtr arg)
            {
                // Respond to ping messages.
                if (@event.Type == XEventType.ClientMessage &&
                    @event.ClientMessage.Format == 32 &&
                    @event.ClientMessage.l[0] == (long)X11.Atoms[KnownAtoms._NET_WM_PING].Id)
                {
                    return true;
                }
                else if (@event.Type == XEventType.ButtonPress ||
                         @event.Type == XEventType.ButtonRelease ||
                         @event.Type == XEventType.KeyPress || 
                         @event.Type == XEventType.KeyRelease ||
                         @event.Type == XEventType.MotionNotify ||
                         @event.Type == XEventType.EnterNotify ||
                         @event.Type == XEventType.LeaveNotify)
                {
                    return true;
                }

                return false;
            }
        }

        /// <inheritdoc/>
        public unsafe MessageBoxButton ShowMessageBox(WindowHandle parent, string title, string content, MessageBoxType messageBoxType, IconHandle? customIcon = null)
        {
            XWindowHandle xwindow = parent.As<XWindowHandle>(this);
            XIconHandle? icon = customIcon?.As<XIconHandle>(this);

            // FIXME: Support for custom icons.
            if (icon != null)
            {
                Logger?.LogWarning("We don't support custom dialog icons on linux using zenity.");
            }

            if (HasZenity == false)
            {
                Logger?.LogError("Zenity support not detected, can't create dialogs. If your window manager doesn't work with Zenity please open a OpenTK issue.");
                return MessageBoxButton.None;
            }

            StringBuilder arguments = new StringBuilder();

            switch (messageBoxType)
            {
                case MessageBoxType.Information:
                    arguments.Append("--info ");
                    // FIXME: Escape the string so we have have special characters!
                    arguments.Append($"--title=\"{title}\" ");
                    arguments.Append($"--text=\"{content}\" ");
                    break;
                case MessageBoxType.Warning:
                    arguments.Append("--warning ");
                    // FIXME: Escape the string so we have have special characters!
                    arguments.Append($"--title=\"{title}\" ");
                    arguments.Append($"--text=\"{content}\" ");
                    break;
                case MessageBoxType.Error:
                    arguments.Append("--error ");
                    // FIXME: Escape the string so we have have special characters!
                    arguments.Append($"--title=\"{title}\" ");
                    arguments.Append($"--text=\"{content}\" ");
                    break;
                case MessageBoxType.Confirmation:
                    arguments.Append("--question ");
                    // FIXME: Escape the string so we have have special characters!
                    arguments.Append($"--title=\"{title}\" ");
                    arguments.Append($"--text=\"{content}\" ");
                    // FIXME: Add a cancel button using --extra-button
                    // For some reason this flag doesn't work on my version
                    // of zenity (it says 3.42.1) but according to the zenity
                    // git log --extra-buttons is supported since 3.16.2.
                    // Something weird is going on here.
                    // - Noggin_bops 2024-07-18
                    break;
                case MessageBoxType.Retry:
                    arguments.Append("--question ");
                    // FIXME: Escape the string so we have have special characters!
                    arguments.Append($"--title=\"{title}\" ");
                    arguments.Append($"--text=\"{content}\" ");
                    arguments.Append("--ok-label \"Retry\" ");
                    arguments.Append("--cancel-label \"Cancel\" ");
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(messageBoxType), (int)messageBoxType, messageBoxType.GetType());
            }

            arguments.Append($"--attach={xwindow.Window.Id} ");

            Logger?.LogDebug($"Running: zenity {arguments}");
            ProcessStartInfo startInfo = new ProcessStartInfo("zenity", arguments.ToString());
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            RemoveVSCodeEnvironmentVariables(startInfo.Environment);
            Process? process = Process.Start(startInfo);
            if (process == null)
            {
                Logger?.LogWarning($"Could not create new process to create zenity message box.");
                return MessageBoxButton.None;
            }

            RunModalLoop(process, xwindow);

            int exitCode = process.ExitCode;
            Logger?.LogInfo($"Zenity exit code: {exitCode}");
            string stderr = process.StandardError.ReadToEnd();
            if (exitCode > 5 || string.IsNullOrWhiteSpace(stderr) == false)
            {
                Logger?.LogWarning($"Zenity exited with exit code {exitCode}. stderr: {process.StandardError.ReadToEnd()}");
            }
            
            Logger?.LogInfo($"Zenity exited with exit code {exitCode}.");

            MessageBoxButton button;
            switch (messageBoxType)
            {
                case MessageBoxType.Information:
                    // We treat pressing the exit button of the
                    // info dialog as pressing OK.
                    if (exitCode == 0 || exitCode == 1)
                        button = MessageBoxButton.Ok;
                    else
                        button = MessageBoxButton.None;
                    break;
                case MessageBoxType.Warning:
                    // We treat pressing the exit button of the
                    // warning dialog as pressing OK.
                    if (exitCode == 0 || exitCode == 1)
                        button = MessageBoxButton.Ok;
                    else
                        button = MessageBoxButton.None;
                    break;
                case MessageBoxType.Error:
                    // We treat pressing the exit button of the
                    // error dialog as pressing OK.
                    if (exitCode == 0 || exitCode == 1)
                        button = MessageBoxButton.Ok;
                    else
                        button = MessageBoxButton.None;
                    break;
                case MessageBoxType.Confirmation:
                    if (exitCode == 0)
                        button = MessageBoxButton.Yes;
                    else if (exitCode == 1)
                        button = MessageBoxButton.No;
                    // FIXME: See above about extra buttons.
                    else if (exitCode == 2)
                        button = MessageBoxButton.Cancel;
                    else
                        button = MessageBoxButton.None;
                    break;
                case MessageBoxType.Retry:
                    if (exitCode == 0)
                        button = MessageBoxButton.Retry;
                    else if (exitCode == 1)
                        button = MessageBoxButton.Cancel;
                    else
                        button = MessageBoxButton.None;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(messageBoxType), (int)messageBoxType, messageBoxType.GetType());
            }

            process.Dispose();
            return button;
        }

        /// <inheritdoc/>
        public List<string>? ShowOpenDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, OpenDialogOptions options)
        {
            XWindowHandle xwindow = parent.As<XWindowHandle>(this);

            if (HasZenity == false)
            {
                Logger?.LogError("Zenity support not detected, can't create dialogs. If your window manager doesn't work with Zenity please open a OpenTK issue.");
                return null;
            }

            StringBuilder arguments = new StringBuilder();
            arguments.Append("--file-selection ");
            arguments.Append($"--attach={xwindow.Window.Id} ");

            arguments.Append($"--title \"{title}\" ");

            arguments.Append($"--filename=\"{directory}\" ");
            if (options.HasFlag(OpenDialogOptions.AllowMultiSelect))
                arguments.Append("--multiple ");

            if (options.HasFlag(OpenDialogOptions.SelectDirectory))
                arguments.Append("--directory ");
            
            // FIXME: Extensions...
            if (allowedExtensions != null && allowedExtensions.Length > 0)
            {
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    // FIXME: Remove linq usage and reduce allocations...
                    // - Noggin_bops 2024-07-22
                    string[] exts = allowedExtensions[i].Filter.Split(';');
                    arguments.Append($"--file-filter=\"{allowedExtensions[i].Name}|*.{string.Join(" *.", exts).Substring(1)}\"");
                }
            }

            Logger?.LogDebug($"Running: zenity {arguments}");
            ProcessStartInfo startInfo = new ProcessStartInfo("zenity", arguments.ToString());
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            RemoveVSCodeEnvironmentVariables(startInfo.Environment);
            Process? process = Process.Start(startInfo);
            if (process == null)
            {
                Logger?.LogWarning($"Could not create new process to create zenity message box.");
                return null;
            }

            RunModalLoop(process, xwindow);

            List<string> outputList;

            string output = process.StandardOutput.ReadToEnd();
            if (output.Contains('|'))
            {
                outputList = new List<string>(output.Split('|', StringSplitOptions.RemoveEmptyEntries));
            }
            else
            {
                outputList = new List<string>{ output };
            }

            process.Dispose();
            return outputList;
        }

        /// <inheritdoc/>
        public string? ShowSaveDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, SaveDialogOptions options)
        {
            XWindowHandle xwindow = parent.As<XWindowHandle>(this);

            if (HasZenity == false)
            {
                Logger?.LogError("Zenity support not detected, can't create dialogs. If your window manager doesn't work with Zenity please open a OpenTK issue.");
                return null;
            }

            StringBuilder arguments = new StringBuilder();
            arguments.Append("--file-selection ");
            arguments.Append($"--attach={xwindow.Window.Id} ");

            arguments.Append($"--title \"{title}\" ");

            arguments.Append($"--filename=\"{directory}\" ");
            arguments.Append($"--save ");
            
            // FIXME: Extensions...
            if (allowedExtensions != null && allowedExtensions.Length > 0)
            {
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    // FIXME: Remove linq usage and reduce allocations...
                    // - Noggin_bops 2024-07-22
                    string[] exts = allowedExtensions[i].Filter.Split(';');
                    arguments.Append($"--file-filter=\"{allowedExtensions[i].Name}|*.{string.Join(" *.", exts).Substring(1)}\"");
                }
            }

            Logger?.LogDebug($"Running: zenity {arguments}");
            ProcessStartInfo startInfo = new ProcessStartInfo("zenity", arguments.ToString());
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            RemoveVSCodeEnvironmentVariables(startInfo.Environment);
            Process? process = Process.Start(startInfo);
            if (process == null)
            {
                Logger?.LogWarning($"Could not create new process to create zenity message box.");
                return null;
            }

            RunModalLoop(process, xwindow);

            string output = process.StandardOutput.ReadToEnd();
            process.Dispose();
            return output;
        }
    }
}

