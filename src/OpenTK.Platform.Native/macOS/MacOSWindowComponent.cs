using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSWindowComponent : IWindowComponent
    {
        internal static IntPtr nsApplication;

        internal static readonly SEL selSetMainMenu = sel_registerName("setMainMenu:"u8);
        internal static readonly SEL selInitWithTitle = sel_registerName("initWithTitle:"u8);
        internal static readonly SEL selAddItem = sel_registerName("addItem:"u8);
        internal static readonly SEL selSetSubmenu = sel_registerName("setSubmenu:"u8);
        internal static readonly SEL selInitWithTitle_Action_KeyEquivalent = sel_registerName("initWithTitle:action:keyEquivalent:"u8);

        internal static readonly SEL selQuit = sel_registerName("quit"u8);
        internal static readonly SEL selSharedApplication = sel_registerName("sharedApplication"u8);
        internal static readonly SEL selSetActivationPolicy = sel_registerName("setActivationPolicy:"u8);
        internal static readonly SEL selDiscardEventsMatchingMask_beforeEvent = sel_registerName("discardEventsMatchingMask:beforeEvent:"u8);
        internal static readonly SEL selMainMenu = sel_registerName("mainMenu"u8);
        internal static readonly SEL selApplicationIconImage = sel_registerName("applicationIconImage"u8);
        internal static readonly SEL selSetApplicationIconImage = sel_registerName("setApplicationIconImage:"u8);

        internal static readonly SEL selType = sel_registerName("type"u8);
        internal static readonly SEL selSendEvent = sel_registerName("sendEvent:"u8);
        internal static readonly SEL selNextEventMatchingMask_untilDate_inMode_dequeue = sel_registerName("nextEventMatchingMask:untilDate:inMode:dequeue:"u8);
        internal static readonly SEL selWindow = sel_registerName("window"u8);
        internal static readonly SEL selButtonNumber = sel_registerName("buttonNumber"u8);
        internal static readonly SEL selLocationInWindow = sel_registerName("locationInWindow"u8);
        internal static readonly SEL selDeltaX = sel_registerName("deltaX"u8);
        internal static readonly SEL selDeltaY = sel_registerName("deltaY"u8);
        internal static readonly SEL selMouseLocation = sel_registerName("mouseLocation"u8);
        internal static readonly SEL selScrollingDeltaX = sel_registerName("scrollingDeltaX"u8);
        internal static readonly SEL selScrollingDeltaY = sel_registerName("scrollingDeltaY"u8);
        internal static readonly SEL selHasPreciseScrollingDeltas = sel_registerName("hasPreciseScrollingDeltas"u8);
        internal static readonly SEL selTrackingNumber = sel_registerName("trackingNumber"u8);
        internal static readonly SEL selKeyCode = sel_registerName("keyCode"u8);
        internal static readonly SEL selARepeat = sel_registerName("isARepeat"u8);
        internal static readonly SEL selModifierFlags = sel_registerName("modifierFlags"u8);


        internal static readonly SEL selInitWithContentRect_styleMask_backing_defer = sel_registerName("initWithContentRect:styleMask:backing:defer:"u8);
        internal static readonly SEL selInitWithFrame = sel_registerName("initWithFrame:"u8);

        internal static readonly SEL selAddTrackingRect_owner_userData_assumeInside = sel_registerName("addTrackingRect:owner:userData:assumeInside:"u8);

        internal static readonly SEL selScreen = sel_registerName("screen"u8);
        internal static readonly SEL selFrame = sel_registerName("frame"u8);
        internal static readonly SEL selBounds = sel_registerName("bounds"u8);
        internal static readonly SEL selSetFrameTopLeftPoint = sel_registerName("setFrameTopLeftPoint:"u8);
        internal static readonly SEL selContentView = sel_registerName("contentView"u8);
        internal static readonly SEL selSetContentView = sel_registerName("setContentView:"u8);
        internal static readonly SEL selInterpretKeyEvents = sel_registerName("interpretKeyEvents:"u8);
        internal static readonly SEL selSetFrame_Display = sel_registerName("setFrame:display:"u8);
        internal static readonly SEL selSetContentSize = sel_registerName("setContentSize:"u8);
        internal static readonly SEL selSetContentMinSize = sel_registerName("setContentMinSize:"u8);
        internal static readonly SEL selSetContentMaxSize = sel_registerName("setContentMaxSize:"u8);
        internal static readonly SEL selDockTile = sel_registerName("dockTile"u8);
        internal static readonly SEL selTerminate = sel_registerName("terminate:"u8);
        internal static readonly SEL selClose = sel_registerName("close"u8);
        internal static readonly SEL selSetTitle = sel_registerName("setTitle:"u8);
        internal static readonly SEL selTitle = sel_registerName("title"u8);
        internal static readonly SEL selSetDelegate = sel_registerName("setDelegate:"u8);
        internal static readonly SEL selMakeFirstResponder = sel_registerName("makeFirstResponder:"u8);
        internal static readonly SEL selMakeKeyWindow = sel_registerName("makeKeyWindow"u8);
        internal static readonly SEL selCenter = sel_registerName("center"u8);
        internal static readonly SEL selInputContext = sel_registerName("inputContext"u8);

        internal static readonly SEL selMakeKeyAndOrderFront = sel_registerName("makeKeyAndOrderFront:"u8);

        internal static readonly SEL selRequestUserAttention = sel_registerName("requestUserAttention"u8);

        internal static readonly SEL selConvertRectToBacking = sel_registerName("convertRectToBacking:"u8);
        internal static readonly SEL selConvertRectToScreen = sel_registerName("convertRectToScreen:"u8);

        internal static readonly SEL selIsMiniaturized = sel_registerName("isMiniaturized"u8);
        internal static readonly SEL selMiniaturize = sel_registerName("miniaturize:"u8);
        internal static readonly SEL selDeminiaturize = sel_registerName("deminiaturize:"u8);
        internal static readonly SEL selIsZoomed = sel_registerName("isZoomed"u8);
        internal static readonly SEL selZoom = sel_registerName("zoom:"u8);
        internal static readonly SEL selToggleFullScreen = sel_registerName("toggleFullScreen:"u8);
        internal static readonly SEL selIsVisible = sel_registerName("isVisible"u8);
        internal static readonly SEL selOrderFront = sel_registerName("orderFront:"u8);
        internal static readonly SEL selOrderOut = sel_registerName("orderOut:"u8);
        internal static readonly SEL selSetMovableByWindowBackground = sel_registerName("setMovableByWindowBackground:"u8);

        internal static readonly SEL selStyleMask = sel_registerName("styleMask"u8);
        internal static readonly SEL selSetStyleMask = sel_registerName("setStyleMask:"u8);

        internal static readonly SEL selLevel = sel_registerName("level"u8);
        internal static readonly SEL selSetLevel = sel_registerName("setLevel:"u8);
        internal static readonly SEL selHidesOnDeactivate = sel_registerName("hidesOnDeactivate"u8);
        internal static readonly SEL selSetHidesOnDeactivate = sel_registerName("setHidesOnDeactivate:"u8);

        internal static readonly SEL selScreens = sel_registerName("screens"u8);
        internal static readonly SEL selCount = sel_registerName("count"u8);
        internal static readonly SEL selObjectAtIndex = sel_registerName("objectAtIndex:"u8);

        internal static readonly SEL selObject = sel_registerName("object"u8);

        internal static readonly SEL selUpdate = sel_registerName("update"u8);

        internal static readonly SEL selArray = sel_registerName("array"u8);
        internal static readonly SEL selArrayWithObject = sel_registerName("arrayWithObject:"u8);

        internal static readonly SEL selLength = sel_registerName("length"u8);

        internal static readonly SEL selIsKindOfClass = sel_registerName("isKindOfClass:"u8);
        internal static readonly SEL selInitWithAttributedString = sel_registerName("initWithAttributedString:"u8);
        internal static readonly SEL selInitWithString = sel_registerName("initWithString:"u8);
        internal static readonly SEL selMutableString = sel_registerName("mutableString"u8);
        internal static readonly SEL selString = sel_registerName("string"u8);
        internal static readonly SEL selSetString = sel_registerName("setString:"u8);

        internal static readonly SEL selAddCursorRect_Cursor = sel_registerName("addCursorRect:cursor:"u8);
        internal static readonly SEL selInvalidateCursorRectsForView = sel_registerName("invalidateCursorRectsForView:"u8);
        internal static readonly SEL selEnableCursorRects = sel_registerName("enableCursorRects"u8);
        internal static readonly SEL selDisableCursorRects = sel_registerName("disableCursorRects"u8);

        internal static readonly SEL selSuperclass = sel_registerName("superclass"u8);

        internal static readonly SEL selImageViewWithImage = sel_registerName("imageViewWithImage:"u8);
        internal static readonly SEL selImageWithSymbolConfiguration = sel_registerName("imageWithSymbolConfiguration:"u8);
        internal static readonly SEL selDisplay = sel_registerName("display"u8);
        internal static readonly SEL selSetSymbolConfiguration = sel_registerName("setSymbolConfiguration:"u8);

        internal static readonly SEL selDefaultCenter = sel_registerName("defaultCenter"u8);
        internal static readonly SEL selAddObserver_selector_name_object = sel_registerName("addObserver:selector:name:object:"u8);

        // The mouseConfinementRect property is not part of public headers, but
        // somehow SDL developers figured out it exists...
        // See: https://github.com/libsdl-org/SDL/commit/35d90f17e1c7d3740c75641ef94b5e5c938c20c6
        // - Noggin_bops 2024-04-13
        internal static readonly SEL selSetMouseConfinementRect = sel_registerName("setMouseConfinementRect:"u8);
        internal static readonly SEL selMouseConfinementRect = sel_registerName("mouseConfinementRect"u8);

        internal static readonly SEL selHide = sel_registerName("hide"u8);
        internal static readonly SEL selUnhide = sel_registerName("unhide"u8);

        internal static readonly SEL selRegisterForDraggedTypes = sel_registerName("registerForDraggedTypes:"u8);
        internal static readonly SEL selDraggingLocation = sel_registerName("draggingLocation"u8);
        internal static readonly SEL selDraggingDestinationWindow = sel_registerName("draggingDestinationWindow"u8);
        internal static readonly SEL selDraggingPasteboard = sel_registerName("draggingPasteboard"u8);
        internal static readonly SEL selPasteboardItems = sel_registerName("pasteboardItems"u8);
        internal static readonly SEL selDataForType = sel_registerName("dataForType:"u8);
        internal static readonly SEL selURLWithString = sel_registerName("URLWithString:"u8);
        internal static readonly SEL selInitWithData_encoding = sel_registerName("initWithData:encoding:"u8);
        internal static readonly SEL selFileSystemRepresentation = sel_registerName("fileSystemRepresentation"u8);


        internal static readonly IntPtr NSPasteboardTypeFileURL = GetStringConstant(AppKitLibrary, "NSPasteboardTypeFileURL"u8);

        internal static readonly IntPtr NSDefaultRunLoop = GetStringConstant(FoundationLibrary, "NSDefaultRunLoopMode"u8);

        internal static readonly ObjCClass NSWindowClass = objc_getClass("NSWindow"u8);
        internal static readonly ObjCClass NSApplicationClass = objc_getClass("NSApplication"u8);
        internal static readonly ObjCClass NSMenuClass = objc_getClass("NSMenu"u8);
        internal static readonly ObjCClass NSMenuItemClass = objc_getClass("NSMenuItem"u8);
        internal static readonly ObjCClass NSEventClass = objc_getClass("NSEvent"u8);
        internal static readonly ObjCClass NSScreenClass = objc_getClass("NSScreen"u8);
        internal static readonly ObjCClass NSArrayClass = objc_getClass("NSArray"u8);
        internal static readonly ObjCClass NSAttributedStringClass = objc_getClass("NSAttributedString"u8);
        internal static readonly ObjCClass NSMutableAttributedStringClass = objc_getClass("NSMutableAttributedString"u8);
        internal static readonly ObjCClass NSImageViewClass = objc_getClass("NSImageView"u8);
        internal static readonly ObjCClass NSNotificationCenterClass = objc_getClass("NSNotificationCenter"u8);
        internal static readonly ObjCClass NSCursorClass = objc_getClass("NSCursor"u8);
        internal static readonly ObjCClass NSStringClass = objc_getClass("NSString"u8);
        internal static readonly ObjCClass NSURLClass = objc_getClass("NSURL"u8);

        internal static ObjCClass NSOpenTKWindowClass;
        internal static ObjCClass NSOpenTKViewClass;

        internal static readonly Dictionary<IntPtr, NSWindowHandle> NSWindowDict = new Dictionary<nint, NSWindowHandle>();

        internal static ReadOnlySpan<byte> OtkCompoenntFieldName => "otkPALWindowComponent"u8;

        /// <inheritdoc/>
        public string Name => nameof(MacOSWindowComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Window;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            // This method is called from the Quit menu option.
            class_addMethod(NSApplicationClass, selQuit, (IntPtr)Menu_QuitInst, "v@:"u8);

            nsApplication = objc_msgSend_IntPtr((IntPtr)NSApplicationClass, selSharedApplication);

            objc_msgSend_bool(nsApplication, selSetActivationPolicy, (long)NSApplicationActivationpolicy.Regular);
            objc_msgSend(nsApplication, selDiscardEventsMatchingMask_beforeEvent, (ulong)NSEventMask.Any, IntPtr.Zero);

            IntPtr mainMenu = objc_msgSend_IntPtr(nsApplication, selMainMenu);
            if (mainMenu == IntPtr.Zero)
            {
                IntPtr menubar = objc_msgSend_IntPtr((IntPtr)NSMenuClass, Alloc);
                objc_msgSend(nsApplication, selSetMainMenu, menubar);

                // Application menu
                IntPtr appMenuItem = objc_msgSend_IntPtr((IntPtr)NSMenuItemClass, Alloc);
                objc_msgSend(menubar, selAddItem, appMenuItem);

                // We don't init the name for this item and it will become the "app" menu.
                // FIXME: Make the application name better!
                // Seems like this needs to be done using something like Info.plist?
                // We want to figure out how to do that and write a little documentation about it...
                IntPtr appMenu = objc_msgSend_IntPtr((IntPtr)NSMenuClass, Alloc);
                objc_msgSend(appMenuItem, selSetSubmenu, appMenu);

                IntPtr quitMenuItem = objc_msgSend_IntPtr(
                        objc_msgSend_IntPtr((IntPtr)NSMenuItemClass, Alloc),
                        selInitWithTitle_Action_KeyEquivalent,
                        ToNSString("Quit"u8),
                        selQuit,
                        ToNSString("q"u8));
                objc_msgSend(appMenu, selAddItem, quitMenuItem);

                // View menu
                IntPtr viewMenuItem = objc_msgSend_IntPtr((IntPtr)NSMenuItemClass, Alloc);
                objc_msgSend(menubar, selAddItem, viewMenuItem);

                IntPtr viewMenu = objc_msgSend_IntPtr(
                    objc_msgSend_IntPtr((IntPtr)NSMenuClass, Alloc),
                    selInitWithTitle,
                    ToNSString("View"u8));
                objc_msgSend(viewMenuItem, selSetSubmenu, viewMenu);

                IntPtr enterFullScreenItem = objc_msgSend_IntPtr(
                    objc_msgSend_IntPtr((IntPtr)NSMenuItemClass, Alloc),
                    selInitWithTitle_Action_KeyEquivalent,
                    ToNSString("Enter Full Screen"u8),
                    selToggleFullScreen,
                    ToNSString(""u8));
                objc_msgSend(viewMenu, selAddItem, enterFullScreenItem);

                objc_msgSend(nsApplication, sel_registerName("finishLaunching"u8));
            }

            // Allocate a window class
            NSOpenTKWindowClass = objc_allocateClassPair(NSWindowClass, "NSOpenTKWindow"u8, 0);

            // Define a Ivar where we can pass a GCHandle so we can retreive it in callbacks.
            class_addIvar(NSOpenTKWindowClass, OtkCompoenntFieldName, (nuint)nuint.Size, (nuint)int.Log2(nuint.Size), "^v"u8);

            // NSWindow methods.
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowShouldClose:"u8), (IntPtr)NSOtkWindow_WindowShouldCloseInst, "b@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("zoom:"u8), (IntPtr)NSOtkWindow_ZoomInst, "v@:@"u8);
            //class_addMethod(opentkWindowClass, sel_registerName("keyDown:"u8), (KeyDownDelegate)keyDown, "v@:@"u8);

            // NSWindowDelegate methods. We set the window as it's own delegate.
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidBecomeKey:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidBecomeKeyInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidResignKey:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidResignKeyInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidResize:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidResizeInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidMove:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidMoveInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidMiniaturize:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidMiniaturizeInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidDeminiaturize:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidDeminiaturizeInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidEnterFullScreen:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidEnterFullScreenInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidExitFullScreen:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidExitFullScreenInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("didChangeScreenParameters:"u8), (IntPtr)NSOtkWindowDelegate_DidChangeScreenParametersInst, "v@:@"u8);
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowDidChangeBackingProperties:"u8), (IntPtr)NSOtkWindowDelegate_WindowDidChangeBackingPropertiesInst, "v@:@"u8);

            objc_registerClassPair(NSOpenTKWindowClass);

            NSOpenTKViewClass = objc_allocateClassPair(objc_getClass("NSView"u8), "NSOpenTKView"u8, 0);

            // Define a Ivar where we can pass a GCHandle so we can retreive it in callbacks.
            class_addIvar(NSOpenTKViewClass, OtkCompoenntFieldName, (nuint)nuint.Size, (nuint)int.Log2(nuint.Size), "^v"u8);

            // Add an IVar for the markedText, so we can use it without finding the managed window object.
            class_addIvar(NSOpenTKViewClass, "markedText"u8, (nuint)nuint.Size, (nuint)int.Log2(nuint.Size), "@"u8);

            class_addMethod(NSOpenTKViewClass, sel_registerName("resetCursorRects"u8), (IntPtr)NSOtkView_ResetCursorRectsInst, "v@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("mouseEntered:"u8), (IntPtr)NSOtkView_MouseEnteredInst, "v@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("mouseExited:"u8), (IntPtr)NSOtkView_MouseExitedInst, "v@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("keyDown:"u8), (IntPtr)NSOtkView_KeyDownInst, "v@:@"u8);

            // TODO: canBecomeKeyView, 
            class_addMethod(NSOpenTKViewClass, sel_registerName("acceptsFirstResponder"u8), (IntPtr)NSOtkView_AcceptsFirstResponderInst, "c@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("viewDidChangeEffectiveAppearance"u8), (IntPtr)NSOtkView_ViewDidChangeEffectiveAppearanceInst, "v@:"u8);

            // NSTextInputClientProtocol functions
            IntPtr NSTextInputClientProtocol = objc_getProtocol("NSTextInputClient"u8);
            class_addProtocol(NSOpenTKViewClass, NSTextInputClientProtocol);
            // FIXME: The method type encoding strings only work for 64-bit, as NSRange is defined using NSUInteger so it changes size depending on arch.
            // So {_NSRange=QQ} and {_NSPoint=dd} would have to have something else other than QQ and dd, but I can't figure out what it's supposed to be atm..
            // - Noggin_bops 2023-11-11
            class_addMethod(NSOpenTKViewClass, sel_registerName("hasMarkedText"u8), (IntPtr)NSOtkView_NSTextInputClient_HasMarkedTextInst, "c@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("markedRange"u8), (IntPtr)NSOtkView_NSTextInputClient_MarkedRangeInst, "{_NSRange=QQ}@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("selectedRange"u8), (IntPtr)NSOtkView_NSTextInputClient_SelectedRangeInst, "{_NSRange=QQ}@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("setMarkedText:selectedRange:replacementRange:"u8), (IntPtr)NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRangeInst, "v@:@{_NSRange=QQ}{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("unmarkText"u8), (IntPtr)NSOtkView_NSTextInputClient_UnmarkTextInst, "v@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("validAttributesForMarkedText"u8), (IntPtr)NSOtkView_NSTextInputClient_ValidAttributesForMarkedTextInst, "@@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("attributedSubstringForProposedRange:actualRange:"u8), (IntPtr)NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRangeInst, "@@:{_NSRange=QQ}^{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("insertText:replacementRange:"u8), (IntPtr)NSOtkView_NSTextInputClient_InsertText_ReplacementRangeInst, "v@:@{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("characterIndexForPoint:"u8), (IntPtr)NSOtkView_NSTextInputClient_CharacterIndexForPointInst, "Q@:{_NSPoint=dd}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("firstRectForCharacterRange:actualRange:"u8), (IntPtr)NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRangeInst, "{_NSRect={_NSPoint=dd}{_NSSize=dd}}@:{_NSRange=QQ}^{_NSRange=QQ}"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("doCommandBySelector:"u8), (IntPtr)NSOtkView_NSTextInputClient_DoCommandBySelectorInst, "v@::"u8);;

            IntPtr NSDraggingDestinationProtocol = objc_getProtocol("NSDraggingDestination"u8);
            class_addProtocol(NSOpenTKViewClass, NSDraggingDestinationProtocol);
            class_addMethod(NSOpenTKViewClass, sel_registerName("draggingEntered:"u8), (IntPtr)NSOtkView_NSDraggingDestination_DraggingEnteredInst, "L@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("wantsPeriodicDraggingUpdates"u8), (IntPtr)NSOtkView_NSDraggingDestination_WantsPeriodicDraggingUpdatesInst, "c@:"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("draggingUpdated:"u8), (IntPtr)NSOtkView_NSDraggingDestination_DraggingUpdatedInst, "L@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("draggingExited:"u8), (IntPtr)NSOtkView_NSDraggingDestination_DraggingExitedInst, "v@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("draggingEnded:"u8), (IntPtr)NSOtkView_NSDraggingDestination_DraggingEndedInst, "v@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("prepareForDragOperation:"u8), (IntPtr)NSOtkView_NSDraggingDestination_PrepareForDragOperationInst, "c@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("performDragOperation:"u8), (IntPtr)NSOtkView_NSDraggingDestination_PerformDragOperationInst, "c@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("concludeDragOperation:"u8), (IntPtr)NSOtkView_NSDraggingDestination_ConcludeDragOperationInst, "v@:@"u8);
            class_addMethod(NSOpenTKViewClass, sel_registerName("updateDraggingItemsForDrag:"u8), (IntPtr)NSOtkView_NSDraggingDestination_UpdateDraggingItemsForDragInst, "v@:@"u8);

            objc_registerClassPair(NSOpenTKViewClass);
        }

        private static MacOSWindowComponent GetComponentFromWindow(IntPtr window)
        {
            object_getInstanceVariable(window, OtkCompoenntFieldName, out IntPtr windowCompPtr);
            return (MacOSWindowComponent)((GCHandle)windowCompPtr).Target!;
        }

        private static MacOSWindowComponent GetComponentFromView(IntPtr view)
        {
            object_getInstanceVariable(view, OtkCompoenntFieldName, out IntPtr windowCompPtr);
            return (MacOSWindowComponent)((GCHandle)windowCompPtr).Target!;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, void> Menu_QuitInst = &Menu_Quit;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void Menu_Quit(IntPtr self, SEL cmd)
        {
            GetComponentFromWindow(self).Logger?.LogInfo("On quit!");

            // FIXME: Send an event for this?
            //EventQueue.Raise(null, 0, new ApplicationExitEventArgs());

            // Actually quit.
            objc_msgSend(nsApplication, selTerminate, nsApplication);
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, sbyte> NSOtkWindow_WindowShouldCloseInst = &NSOtkWindow_WindowShouldClose;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static sbyte NSOtkWindow_WindowShouldClose(IntPtr window, SEL selector, IntPtr sender)
        {
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.Close, new CloseEventArgs(nswindow));

                // Let the user handle closing the window.
                return (sbyte)NO;
            }
            else
            {
                // We don't know about this window, let it close.
                return (sbyte)YES;
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindow_ZoomInst = &NSOtkWindow_Zoom;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindow_Zoom(IntPtr window, SEL selector, IntPtr sender)
        {
            objc_super super;
            super.receiver = window;
            super.pclass = (ObjCClass)objc_msgSend_IntPtr(window, selSuperclass);
            objc_msgSendSuper(super, selector);

            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                // FIXME: BOOL
                bool zoomed = objc_msgSend_bool(window, selIsZoomed);
                if (zoomed)
                {
                    EventQueue.Raise(nswindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(nswindow, WindowMode.Maximized));
                }
                else
                {
                    EventQueue.Raise(nswindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(nswindow, WindowMode.Normal));
                }
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidBecomeKeyInst = &NSOtkWindowDelegate_WindowDidBecomeKey;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidBecomeKey(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                if (nswindow.CursorCaptureMode == CursorCaptureMode.Locked)
                {
                    // FIXME: While we are resizing we don't want to center
                    // the mosue cursor...
                    CG.CGAssociateMouseAndMouseCursorPosition(false);
                    CenterCursor(nswindow);
                }
                else
                {
                    // We don't have a locked cursor anymore.
                    CG.CGAssociateMouseAndMouseCursorPosition(true);
                }

                EventQueue.Raise(nswindow, PlatformEventType.Focus, new FocusEventArgs(nswindow, true));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidBecomeKey for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidResignKeyInst = &NSOtkWindowDelegate_WindowDidResignKey;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidResignKey(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.Focus, new FocusEventArgs(nswindow, false));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidResignKey for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidResizeInst = &NSOtkWindowDelegate_WindowDidResize;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidResize(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                if (nswindow.Context != null)
                {
                    objc_msgSend(nswindow.Context.Context, selUpdate);
                }

                if (nswindow.CursorCaptureMode == CursorCaptureMode.Locked)
                {
                    // FIXME: While we are resizing we don't want to center
                    // the mosue cursor...
                    //CenterCursor(nswindow);
                }

                CGRect bounds = objc_msgSend_CGRect(nswindow.View, selBounds);
                CGRect backing = objc_msgSend_CGRect(nswindow.View, selConvertRectToBacking, bounds);
                // FIXME: Framebuffer size event?

                // FIXME: Do not cast to int?
                Vector2i newSize = new Vector2i((int)bounds.size.x, (int)bounds.size.y);
                EventQueue.Raise(nswindow, PlatformEventType.WindowResize, new WindowResizeEventArgs(nswindow, newSize));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidResize for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidMoveInst = &NSOtkWindowDelegate_WindowDidMove;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidMove(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                if (nswindow.Context != null)
                {
                    objc_msgSend(nswindow.Context.Context, selUpdate);
                }

                if (nswindow.CursorCaptureMode == CursorCaptureMode.Locked)
                {
                    // FIXME: While we are resizing we don't want to center
                    // the mosue cursor...
                    //CenterCursor(nswindow);
                }

                CGRect windowFrame = objc_msgSend_CGRect(nswindow.Window, selFrame);
                CGRect viewFrame = objc_msgSend_CGRect(nswindow.View, selFrame);

                windowFrame = CG.FlipYCoordinate(windowFrame);
                viewFrame = CG.FlipYCoordinate(viewFrame);

                // FIXME: Do not cast to int?
                Vector2i windowPosition = new Vector2i((int)windowFrame.size.x, (int)windowFrame.size.y);
                Vector2i viewPosition = new Vector2i((int)viewFrame.size.x, (int)viewFrame.size.y);
                EventQueue.Raise(nswindow, PlatformEventType.WindowMove, new WindowMoveEventArgs(nswindow, windowPosition, viewPosition));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidMove for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidMiniaturizeInst = &NSOtkWindowDelegate_WindowDidMiniaturize;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidMiniaturize(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(nswindow, WindowMode.Minimized));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidMiniaturize for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidDeminiaturizeInst = &NSOtkWindowDelegate_WindowDidDeminiaturize;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidDeminiaturize(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(nswindow, WindowMode.Normal));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidDeminiaturize for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidEnterFullScreenInst = &NSOtkWindowDelegate_WindowDidEnterFullScreen;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidEnterFullScreen(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                // FIXME: Exclusive or Windowed fullscreen? Should we differentiate on mac?
                EventQueue.Raise(nswindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(nswindow, WindowMode.WindowedFullscreen));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidEnterFullScreen for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidExitFullScreenInst = &NSOtkWindowDelegate_WindowDidExitFullScreen;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidExitFullScreen(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            IntPtr window = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(nswindow, WindowMode.Normal));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug($"Got WindowDidEnterFullScreen for unknown window: 0x{window}");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_DidChangeScreenParametersInst = &NSOtkWindowDelegate_DidChangeScreenParameters;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_DidChangeScreenParameters(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            ILogger? logger = GetComponentFromWindow(@delegate).Logger;
            MacOSDisplayComponent.UpdateDisplays(logger, true);
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkWindowDelegate_WindowDidChangeBackingPropertiesInst = &NSOtkWindowDelegate_WindowDidChangeBackingProperties;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkWindowDelegate_WindowDidChangeBackingProperties(IntPtr @delegate, SEL selector, IntPtr /* NSNotification */ notification)
        {
            // FIXME: Scale factors on mac seem to be a bit weird.
            // Changing display resolution doesn't always change the scaling.
            // At really high resoltions and very low resolutions
            // the scale factor seems to be 1?
            // But at "normal" resolutions it seems to be mostly 2.
            // Not sure what is going on.
            // - Noggin_bops 2024-06-04
            IntPtr wnd = objc_msgSend_IntPtr(notification, selObject);
            if (NSWindowDict.TryGetValue(wnd, out NSWindowHandle? nswindow))
            {
                CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);
                CGRect frameBacking = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, frame);

                float scaleX = (float)(frameBacking.size.x / frame.size.x);
                float scaleY = (float)(frameBacking.size.y / frame.size.y);

                EventQueue.Raise(nswindow, PlatformEventType.WindowScaleChange, new WindowScaleChangeEventArgs(nswindow, scaleX, scaleY));
            }
            else
            {
                GetComponentFromWindow(@delegate).Logger?.LogDebug("Got windowDidChangeBackingProperties for unknown window.");
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, void> NSOtkView_ResetCursorRectsInst = &NSOtkView_ResetCursorRects;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_ResetCursorRects(IntPtr view, SEL selector)
        {
            objc_super super;
            super.receiver = view;
            super.pclass = (ObjCClass)objc_msgSend_IntPtr(view, selSuperclass);
            objc_msgSendSuper(super, selector);

            IntPtr window = objc_msgSend_IntPtr(view, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) == false)
            {
                GetComponentFromView(view).Logger?.LogDebug($"Received ResetCurorRects event for unknown window: {window}");
                return;
            }

            IntPtr cursor;
            if (nswindow.Cursor != null)
            {
                switch (nswindow.Cursor.Mode)
                {
                    // If the cursor is animated, pick the current frame.
                    case NSCursorHandle.CursorMode.SystemAnimatedCursor:
                        cursor = nswindow.Cursor.CursorFrames![nswindow.Cursor.Frame];
                        break;
                    default:
                        cursor = nswindow.Cursor.Cursor;
                        break;
                }
            }
            else
            {
                cursor = MacOSCursorComponent.GetInvisibleCursor();
            }

            CGRect bounds = objc_msgSend_CGRect(view, selBounds);
            objc_msgSend(view, selAddCursorRect_Cursor, bounds, cursor);
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkView_MouseEnteredInst = &NSOtkView_MouseEntered;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_MouseEntered(IntPtr view, SEL selector, IntPtr @event)
        {
            IntPtr window = objc_msgSend_IntPtr(@event, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) == false)
            {
                GetComponentFromView(view).Logger?.LogDebug($"Received MouseEntered event with unknown window: {window}");
                return;
            }

            EventQueue.Raise(nswindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(nswindow, true));
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkView_MouseExitedInst = &NSOtkView_MouseExited;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_MouseExited(IntPtr view, SEL selector, IntPtr @event)
        {
            IntPtr window = objc_msgSend_IntPtr(@event, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) == false)
            {
                GetComponentFromView(view).Logger?.LogDebug($"Received MouseExited event with unknown window: {window}");
                return;
            }

            EventQueue.Raise(nswindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(nswindow, false));
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkView_KeyDownInst = &NSOtkView_KeyDown;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_KeyDown(IntPtr view, SEL selector, IntPtr @event)
        {
            IntPtr array = objc_msgSend_IntPtr((IntPtr)NSArrayClass, selArrayWithObject, @event);
            objc_msgSend_IntPtr(view, selInterpretKeyEvents, array);
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, byte> NSOtkView_AcceptsFirstResponderInst = &NSOtkView_AcceptsFirstResponder;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static byte NSOtkView_AcceptsFirstResponder(IntPtr view, SEL selector)
        {
            return YES;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, void> NSOtkView_ViewDidChangeEffectiveAppearanceInst = &NSOtkView_ViewDidChangeEffectiveAppearance;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_ViewDidChangeEffectiveAppearance(IntPtr view, SEL selector)
        {
            MacOSShellComponent.CheckPreferredThemeChange();
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, sbyte> NSOtkView_NSTextInputClient_HasMarkedTextInst = &NSOtkView_NSTextInputClient_HasMarkedText;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static sbyte /* BOOL */ NSOtkView_NSTextInputClient_HasMarkedText(IntPtr view, SEL selector)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            ulong length = (ulong)objc_msgSend_IntPtr(markedText, selLength);
            return length > 0 ? (sbyte)YES : (sbyte)NO;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, NSRange> NSOtkView_NSTextInputClient_MarkedRangeInst = &NSOtkView_NSTextInputClient_MarkedRange;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static NSRange NSOtkView_NSTextInputClient_MarkedRange(IntPtr view, SEL selector)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            ulong length = (ulong)objc_msgSend_IntPtr(markedText, selLength);
            if (length > 0)
            {
                return new NSRange(0, (nuint)length-1);
            }
            else
            {
                return NSRange.kEmptyRange;
            }
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, NSRange> NSOtkView_NSTextInputClient_SelectedRangeInst = &NSOtkView_NSTextInputClient_SelectedRange;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static NSRange NSOtkView_NSTextInputClient_SelectedRange(IntPtr view, SEL selector)
        {
            return NSRange.kEmptyRange;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, NSRange, NSRange, void> NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRangeInst = &NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRange;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSTextInputClient_SetMarkedText_SelectedRange_ReplacementRange(IntPtr view, SEL selector, IntPtr /* id */ @string, NSRange selectedRange, NSRange replacementRange)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            objc_msgSend(markedText, Release);
            // FIXME: BOOL
            if (objc_msgSend_bool(@string, selIsKindOfClass, (IntPtr)objc_getClass("NSAttributedString"u8)))
            {
                markedText = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSMutableAttributedStringClass, Alloc), selInitWithAttributedString, @string);

            }
            else
            {
                markedText = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSMutableAttributedStringClass, Alloc), selInitWithString, @string);
            }
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_setInstanceVariable(view, "markedText"u8, markedText);
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, void> NSOtkView_NSTextInputClient_UnmarkTextInst = &NSOtkView_NSTextInputClient_UnmarkText;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSTextInputClient_UnmarkText(IntPtr view, SEL selector)
        {
            // FIXME: Store the Ivar somewhere to be able to use object_getIvar?
            object_getInstanceVariable(view, "markedText"u8, out IntPtr markedText);
            // FIXME: Do not create a new NSString every time!
            objc_msgSend(objc_msgSend_IntPtr(markedText, selMutableString), selSetString, ToNSString(""));
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr> NSOtkView_NSTextInputClient_ValidAttributesForMarkedTextInst = &NSOtkView_NSTextInputClient_ValidAttributesForMarkedText;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static IntPtr /* NSArray<NSAttributedStringKey>* */ NSOtkView_NSTextInputClient_ValidAttributesForMarkedText(IntPtr view, SEL selector)
        {
            return objc_msgSend_IntPtr((IntPtr)NSArrayClass, selArray);
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, NSRange, NSRange*, IntPtr> NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRangeInst = &NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRange;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static unsafe IntPtr /* NSAttributedString* */ NSOtkView_NSTextInputClient_AttributedSubstringForProposedRange_ActualRange(IntPtr view, SEL selector, NSRange range, NSRange* actualRange)
        {
            return IntPtr.Zero;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, NSRange, void> NSOtkView_NSTextInputClient_InsertText_ReplacementRangeInst = &NSOtkView_NSTextInputClient_InsertText_ReplacementRange;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSTextInputClient_InsertText_ReplacementRange(IntPtr view, SEL selector, IntPtr /* id */ @string, NSRange range)
        {
            IntPtr windowPtr = objc_msgSend_IntPtr(view, selWindow);
            if (NSWindowDict.TryGetValue(windowPtr, out NSWindowHandle? nswindow) == false)
            {
                GetComponentFromView(view).Logger?.LogDebug($"Could not find NSWindow for NSView 0x{view}");
                return;
            }

            string str;
            if (objc_msgSend_bool(@string, selIsKindOfClass, (IntPtr)objc_getClass("NSAttributedString"u8)))
            {
                str = FromNSString(objc_msgSend_IntPtr(@string, selString));
            }
            else
            {
                str = FromNSString(@string);
            }

            EventQueue.Raise(nswindow, PlatformEventType.TextInput, new TextInputEventArgs(nswindow, str));
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, CGPoint, nuint> NSOtkView_NSTextInputClient_CharacterIndexForPointInst = &NSOtkView_NSTextInputClient_CharacterIndexForPoint;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static nuint NSOtkView_NSTextInputClient_CharacterIndexForPoint(IntPtr view, SEL selector, CGPoint point)
        {
            return 0;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, CGPoint, CGRect> NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRangeInst = &NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRange;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static CGRect NSOtkView_NSTextInputClient_FirstRectForCharacterRange_ActualRange(IntPtr view, SEL selector, CGPoint point)
        {
            // FIXME: Why do we do this?
            CGRect frame = objc_msgSend_CGRect(view, selFrame);
            return new CGRect(frame.origin, CGPoint.Zero);
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, SEL, void> NSOtkView_NSTextInputClient_DoCommandBySelectorInst = &NSOtkView_NSTextInputClient_DoCommandBySelector;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSTextInputClient_DoCommandBySelector(IntPtr view, SEL _selector, SEL selector)
        {
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, nuint> NSOtkView_NSDraggingDestination_DraggingEnteredInst = &NSOtkView_NSDraggingDestination_DraggingEntered;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static nuint /* NSDragOperation */ NSOtkView_NSDraggingDestination_DraggingEntered(IntPtr view, SEL _selector, IntPtr sender)
        {
            Console.WriteLine("Dragging Entered");
            return (nuint)NSDragOperation.Copy;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, sbyte> NSOtkView_NSDraggingDestination_WantsPeriodicDraggingUpdatesInst = &NSOtkView_NSDraggingDestination_WantsPeriodicDraggingUpdates;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static sbyte /* BOOL */ NSOtkView_NSDraggingDestination_WantsPeriodicDraggingUpdates(IntPtr view, SEL _selector)
        {
            Console.WriteLine("Wants periodic drag update");
            return 1;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, nuint> NSOtkView_NSDraggingDestination_DraggingUpdatedInst = &NSOtkView_NSDraggingDestination_DraggingUpdated;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static nuint /* NSDragOperation */ NSOtkView_NSDraggingDestination_DraggingUpdated(IntPtr view, SEL _selector, IntPtr sender)
        {
            Console.WriteLine("Drag update");
            return (nuint)NSDragOperation.Copy;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkView_NSDraggingDestination_DraggingExitedInst = &NSOtkView_NSDraggingDestination_DraggingExited;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSDraggingDestination_DraggingExited(IntPtr view, SEL _selector, IntPtr sender)
        {
            Console.WriteLine("Dragging exited");
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkView_NSDraggingDestination_DraggingEndedInst = &NSOtkView_NSDraggingDestination_DraggingEnded;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSDraggingDestination_DraggingEnded(IntPtr view, SEL _selector, IntPtr sender)
        {
            Console.WriteLine("Dragging ended");
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, sbyte> NSOtkView_NSDraggingDestination_PrepareForDragOperationInst = &NSOtkView_NSDraggingDestination_PrepareForDragOperation;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static sbyte /* BOOL */ NSOtkView_NSDraggingDestination_PrepareForDragOperation(IntPtr view, SEL _selector, IntPtr sender)
        {
            Console.WriteLine("Prepare drag");
            return 1;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, sbyte> NSOtkView_NSDraggingDestination_PerformDragOperationInst = &NSOtkView_NSDraggingDestination_PerformDragOperation;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static sbyte /* BOOL */ NSOtkView_NSDraggingDestination_PerformDragOperation(IntPtr view, SEL _selector, IntPtr sender)
        {
            CGPoint location = objc_msgSend_CGPoint(sender, selDraggingLocation);
            IntPtr wnd = objc_msgSend_IntPtr(sender, selDraggingDestinationWindow);
            if (NSWindowDict.TryGetValue(wnd, out NSWindowHandle? nswindow))
            {
                IntPtr pasteboard = objc_msgSend_IntPtr(sender, selDraggingPasteboard);
                IntPtr items = objc_msgSend_IntPtr(pasteboard, selPasteboardItems);

                nuint count = (nuint)objc_msgSend_IntPtr(items, selCount);
                List<string>? files = new List<string>(int.CreateSaturating(count));
                for (nuint i = 0; i < count; i++)
                {
                    IntPtr item = objc_msgSend_IntPtr(items, selObjectAtIndex, i);
                    IntPtr itemData = objc_msgSend_IntPtr(item, selDataForType, NSPasteboardTypeFileURL);
                    if (itemData != IntPtr.Zero)
                    {
                        IntPtr dataStr = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSStringClass, Alloc), selInitWithData_encoding, itemData, (ulong)NSStringEncoding.UTF8);
                        IntPtr url = objc_msgSend_IntPtr((IntPtr)NSURLClass, selURLWithString, dataStr);
                        string path = Marshal.PtrToStringUTF8(objc_msgSend_IntPtr(url, selFileSystemRepresentation))!;
                        files.Add(path);
                        objc_msgSend(dataStr, Release);
                        // FIXME: Are there any other objects we need to release?
                    }
                }

                Vector2i position = (Vector2i)CG.FlipYCoordinate(location);
                EventQueue.Raise(nswindow, PlatformEventType.FileDrop, new FileDropEventArgs(nswindow, files, position));
            }
            else
            {
                GetComponentFromView(view).Logger?.LogDebug("Received performDragOperation for unknown window.");
            }

            return 1;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkView_NSDraggingDestination_ConcludeDragOperationInst = &NSOtkView_NSDraggingDestination_ConcludeDragOperation;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSDraggingDestination_ConcludeDragOperation(IntPtr view, SEL _selector, IntPtr sender)
        {
            Console.WriteLine("Conclude drag");
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkView_NSDraggingDestination_UpdateDraggingItemsForDragInst = &NSOtkView_NSDraggingDestination_UpdateDraggingItemsForDrag;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static void NSOtkView_NSDraggingDestination_UpdateDraggingItemsForDrag(IntPtr view, SEL _selector, IntPtr sender)
        {
            Console.WriteLine("Update dragging items");
        }



        private bool ProcessHitTest(IntPtr @event)
        {
            IntPtr windowPtr = objc_msgSend_IntPtr(@event, selWindow);
            // Ignore windows we don't recognize.
            if (NSWindowDict.TryGetValue(windowPtr, out NSWindowHandle? window) == false)
            {
                return false;
            }

            CGPoint point = objc_msgSend_CGPoint(@event, selLocationInWindow);
            GetClientSize(window, out _, out int height);
            // FIXME: Potentially a -1 is needed here.
            point.y = height - point.y;

            return DoHitTest(window, point);
        }

        private bool DoHitTest(NSWindowHandle window, CGPoint point)
        {
            bool draggable = false;
            if (window.HitTest != null)
            {
                HitType type = window.HitTest(window, new Vector2((float)point.x, (float)point.y));
                if (type == HitType.Draggable)
                {
                    draggable = true;
                }
            }

            if (window.BackgroundDragEnabled != draggable)
            {
                window.BackgroundDragEnabled = draggable;
                objc_msgSend(window.Window, selSetMovableByWindowBackground, draggable);
            }

            return draggable;
        }

        /// <inheritdoc/>
        public bool CanSetIcon => true;

        /// <inheritdoc/>
        public bool CanGetDisplay => true;

        /// <inheritdoc/>
        public bool CanSetCursor => true;

        /// <inheritdoc/>
        public bool CanCaptureCursor => true;

        /// <inheritdoc/>
        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowBorderStyle> SupportedStyles => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowMode> SupportedModes => throw new NotImplementedException();

        private long clipboardUpdateTime = 0;

        /// <inheritdoc/>
        public void ProcessEvents(bool waitForEvents = false)
        {
            // FIXME: Implement waitForEvents=true.
            IntPtr @event;
            while((@event = objc_msgSend_IntPtr(nsApplication, selNextEventMatchingMask_untilDate_inMode_dequeue, NSEventMask.Any, IntPtr.Zero, NSDefaultRunLoop, true)) != IntPtr.Zero)
            {
                NSEventType type = (NSEventType)objc_msgSend_ulong(@event, selType);

                IntPtr windowPtr = objc_msgSend_IntPtr(@event, selWindow);
                if (NSWindowDict.TryGetValue(windowPtr, out NSWindowHandle? nswindow) == false)
                {
                    if (type == NSEventType.MouseMoved ||
                        type == NSEventType.SystemDefined ||
                        type == NSEventType.AppKitDefined)
                    {
                        // Do not log the more spammy events..
                    }
                    else
                    {
                        Logger?.LogDebug($"Event for non opentk window: {type} (0x{windowPtr})");
                    }
                    
                    objc_msgSend(nsApplication, selSendEvent, @event);

                    continue;
                }

                switch (type)
                {
                    case NSEventType.LeftMouseDown:
                    case NSEventType.RightMouseDown:
                    case NSEventType.OtherMouseDown:
                        {
                            CGRect frame = objc_msgSend_CGRect(objc_msgSend_IntPtr(objc_msgSend_IntPtr(@event, selWindow), selContentView), selFrame);
                            CGPoint location = objc_msgSend_CGPoint(@event, selLocationInWindow);
                            if (frame.Contains(location) == false)
                            {
                                objc_msgSend(nsApplication, selSendEvent, @event);
                                continue;
                            }

                            // We don't want to process this event further.
                            if (ProcessHitTest(@event))
                            {
                                continue;
                            }

                            // FIXME: This should be a long, not ulong
                            ulong button = objc_msgSend_ulong(@event, selButtonNumber);
                            MouseButton mouseButton;
                            switch (button)
                            {
                                case 0: mouseButton = MouseButton.Button1; break;
                                case 1: mouseButton = MouseButton.Button2; break;
                                case 2: mouseButton = MouseButton.Button3; break;
                                case 3: mouseButton = MouseButton.Button4; break;
                                case 4: mouseButton = MouseButton.Button5; break;
                                case 5: mouseButton = MouseButton.Button6; break;
                                case 6: mouseButton = MouseButton.Button7; break;
                                case 7: mouseButton = MouseButton.Button8; break;
                                default: throw new PalException(this, $"Unknown mouse button: {button}");
                            }

                            ModifierFlags modifierFlags = (ModifierFlags)((UIntPtr)objc_msgSend_IntPtr(@event, selModifierFlags)).ToUInt64();
                            KeyModifier modifiers = MacOSKeyboardComponent.ToKeyModifiers(modifierFlags);

                            EventQueue.Raise(nswindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(nswindow, mouseButton, modifiers));

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.LeftMouseUp:
                    case NSEventType.RightMouseUp:
                    case NSEventType.OtherMouseUp:
                        {
                            if (ProcessHitTest(@event))
                            {
                                objc_msgSend(nsApplication, selSendEvent, @event);
                                continue;
                            }

                            // FIXME: This should be a long, not ulong
                            ulong button = objc_msgSend_ulong(@event, selButtonNumber);
                            MouseButton mouseButton;
                            switch (button)
                            {
                                case 0: mouseButton = MouseButton.Button1; break;
                                case 1: mouseButton = MouseButton.Button2; break;
                                case 2: mouseButton = MouseButton.Button3; break;
                                case 3: mouseButton = MouseButton.Button4; break;
                                case 4: mouseButton = MouseButton.Button5; break;
                                case 5: mouseButton = MouseButton.Button6; break;
                                case 6: mouseButton = MouseButton.Button7; break;
                                case 7: mouseButton = MouseButton.Button8; break;
                                default: throw new PalException(this, $"Unknown mouse button: {button}");
                            }

                            ModifierFlags modifierFlags = (ModifierFlags)((UIntPtr)objc_msgSend_IntPtr(@event, selModifierFlags)).ToUInt64();
                            KeyModifier modifiers = MacOSKeyboardComponent.ToKeyModifiers(modifierFlags);

                            EventQueue.Raise(nswindow, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(nswindow, mouseButton, modifiers));

                            // FIXME: If the mouse is outside of the window after a drag we want to send a mouse exit event here

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.MouseMoved:
                    case NSEventType.LeftMouseDragged:
                    case NSEventType.RightMouseDragged:
                    case NSEventType.OtherMouseDragged:
                        {
                            if (ProcessHitTest(@event))
                            {
                                objc_msgSend(nsApplication, selSendEvent, @event);
                                continue;
                            }

                            CGPoint point = objc_msgSend_CGPoint(@event, selLocationInWindow);

                            CGRect pointRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, new CGRect(point, CGPoint.Zero));

                            CGRect backing = objc_msgSend_CGRect(
                                nswindow.Window,
                                selConvertRectToBacking,
                                objc_msgSend_CGRect(nswindow.View, selBounds));

                            // FIXME: Coordinate space
                            CGPoint pos = new CGPoint(pointRect.origin.x, backing.size.y - pointRect.origin.y);

                            if (nswindow.CursorCaptureMode == CursorCaptureMode.Locked)
                            {
                                // Handle virtual cursor position
                                NFloat dx = objc_msgSend_nfloat(@event, selDeltaX);
                                NFloat dy = objc_msgSend_nfloat(@event, selDeltaY);

                                nswindow.VirtualCursorPosition += new CGPoint(dx, dy);

                                EventQueue.Raise(nswindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(nswindow, (Vector2)nswindow.VirtualCursorPosition));
                            }
                            else
                            {
                                // Do normal mouse events
                                EventQueue.Raise(nswindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(nswindow, (Vector2)pos));

                                objc_msgSend(nsApplication, selSendEvent, @event);
                            }

                            nswindow.LastMousePosition = pos;
                            break;
                        }
                    case NSEventType.ScrollWheel:
                        {
                            float scrollX = objc_msgSend_float(@event, selScrollingDeltaX);
                            float scrollY = objc_msgSend_float(@event, selScrollingDeltaY);

                            bool preciseScrollingDeltas = objc_msgSend_bool(@event, selHasPreciseScrollingDeltas);

                            // FIXME: We might need to flip the horizontal direction?
                            // FIXME: Consider precise deltas...
                            Vector2 delta = new Vector2(scrollX, scrollY);
                            Vector2 distance = new Vector2(scrollX, scrollY);

                            if (preciseScrollingDeltas)
                            {
                                // FIXME: This is an ok hack for now but we want to do this
                                // "properly" in the future.
                                delta *= 0.1f;
                            }

                            MacOSMouseComponent.RegisterMouseWheelDelta(delta);
                            EventQueue.Raise(nswindow, PlatformEventType.Scroll, new ScrollEventArgs(nswindow, delta, distance));

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.KeyDown:
                        {
                            ushort keyCode = objc_msgSend_ushort(@event, selKeyCode);
                            // FIXME: BOOL
                            bool isRepeat = objc_msgSend_bool(@event, selARepeat);
                            Console.WriteLine($"Key down: 0x{keyCode:X}");

                            Scancode scancode = MacOSKeyboardComponent.ScancodeFromVK((VK)keyCode);

                            ModifierFlags modifierFlags = (ModifierFlags)((UIntPtr)objc_msgSend_IntPtr(@event, selModifierFlags)).ToUInt64();
                            KeyModifier modifiers = MacOSKeyboardComponent.ToKeyModifiers(modifierFlags);

                            MacOSKeyboardComponent.KeyStateChanged(scancode, true);

                            // FIXME: Figure out what we want to do with the Keys enum...
                            switch (keyCode)
                            {
                                case 0x24: // kVK_Return
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.Return, scancode, isRepeat, modifiers));
                                    break;
                                case 0x33: // kVK_Delete
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.Backspace, scancode, isRepeat, modifiers));
                                    break;
                                case 0x35: // kVK_Escape
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.Escape, scancode, isRepeat, modifiers));
                                    break;
                                case 0x7B: // kVK_LeftArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.LeftArrow, scancode, isRepeat, modifiers));
                                    break;
                                case 0x7C: // kVK_RightArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.RightArrow, scancode, isRepeat, modifiers));
                                    break;
                                case 0x7D: // kVK_DownArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.DownArrow, scancode, isRepeat, modifiers));
                                    break;
                                case 0x7E: // kVK_UpArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.UpArrow, scancode, isRepeat, modifiers));
                                    break;
                                default:
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, Key.Unknown, scancode, isRepeat, modifiers));
                                    break;
                            }

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.KeyUp:
                        {
                            ushort keyCode = objc_msgSend_ushort(@event, selKeyCode);
                            Console.WriteLine($"Key up: 0x{keyCode:X}");

                            Scancode scancode = MacOSKeyboardComponent.ScancodeFromVK((VK)keyCode);

                            ModifierFlags modifierFlags = (ModifierFlags)((UIntPtr)objc_msgSend_IntPtr(@event, selModifierFlags)).ToUInt64();
                            KeyModifier modifiers = MacOSKeyboardComponent.ToKeyModifiers(modifierFlags);

                            MacOSKeyboardComponent.KeyStateChanged(scancode, false);

                            // FIXME: Figure out what we want to do with the Keys enum...
                            switch (keyCode)
                            {
                                case 0x24: // kVK_Return
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.Return, scancode, modifiers));
                                    break;
                                case 0x33: // kVK_Delete
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.Backspace, scancode, modifiers));
                                    break;
                                case 0x35: // kVK_Escape
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.Escape, scancode, modifiers));
                                    break;
                                case 0x7B: // kVK_LeftArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.LeftArrow, scancode, modifiers));
                                    break;
                                case 0x7C: // kVK_RightArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.RightArrow, scancode, modifiers));
                                    break;
                                case 0x7D: // kVK_DownArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.DownArrow, scancode, modifiers));
                                    break;
                                case 0x7E: // kVK_UpArrow
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.UpArrow, scancode, modifiers));
                                    break;
                                default:
                                    EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, Key.Unknown, scancode, modifiers));
                                    break;
                            }

                            objc_msgSend(nsApplication, selSendEvent, @event);
                            break;
                        }
                    case NSEventType.FlagsChanged:
                        {
                            ModifierFlags modifierFlags = (ModifierFlags)((UIntPtr)objc_msgSend_IntPtr(@event, selModifierFlags)).ToUInt64();
                            KeyModifier modifiers = MacOSKeyboardComponent.ToKeyModifiers(modifierFlags);

                            // FIXME: Handle CapsLock key state?
                            // SDL subscribes to flagsChanged: and
                            // sends KeyDown and KeyUp events then
                            // the internal state doesn't match OS state..
                            // Might be the only solution we have but
                            // I would like to investigate further.
                            // - Noggin_bops 2024-02-28

                            // FIXME: We probably wont get repeats for modifier keys?
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICELCTLKEYMASK, Scancode.LeftControl, Key.LeftControl, modifiers);
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICELSHIFTKEYMASK, Scancode.LeftShift, Key.LeftShift, modifiers);
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICERSHIFTKEYMASK, Scancode.RightShift, Key.RightShift, modifiers);
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICELCMDKEYMASK, Scancode.LeftGUI, Key.LeftGUI, modifiers);
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICERCMDKEYMASK, Scancode.RightGUI, Key.RightGUI, modifiers);
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICELALTKEYMASK, Scancode.LeftAlt, Key.LeftAlt, modifiers);
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICERALTKEYMASK, Scancode.RightAlt, Key.RightAlt, modifiers);
                            CheckKey(nswindow, modifierFlags, ModifierFlags.NX_DEVICERCTLKEYMASK, Scancode.RightControl, Key.RightControl, modifiers);

                            static void CheckKey(NSWindowHandle nswindow, ModifierFlags flags, ModifierFlags modKey, Scancode scancode, Key key, KeyModifier modifiers)
                            {
                                bool pressed = flags.HasFlag(modKey);
                                if (MacOSKeyboardComponent.KeyStateChanged(scancode, pressed))
                                {
                                    if (pressed)
                                    {
                                        EventQueue.Raise(nswindow, PlatformEventType.KeyDown, new KeyDownEventArgs(nswindow, key, scancode, false, modifiers));
                                    }
                                    else
                                    {
                                        EventQueue.Raise(nswindow, PlatformEventType.KeyUp, new KeyUpEventArgs(nswindow, key, scancode, modifiers));
                                    }
                                }
                            }

                            break;
                        }
                    default:
                        //Console.WriteLine($"Event type: {type}");
                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                }
            }

            {
                // Clipboard updates on macos seem to take some time.
                // If we try to read the clipboard formats the moment the
                // clipboard change count changed we would get zero clipboard
                // formats and no pasteboard content. So we unfortunately need
                // to delay our poll of the pasteboard formats to a time
                // where the pasteboard hopefully is populated with data.
                // Ideally we would have some other way of checking
                // that the pasteboard contents are not ready yet, but
                // e.g. waiting for there to be non-zero number of
                // formats would fail if the clipboard is simply cleared.
                // This solution also has issues with waitForEvents=true,
                // but that might be a lower priority...
                // - Noggin_bops 2024-06-04
                long currTime = Stopwatch.GetTimestamp();
                if (MacOSClipboardComponent.CheckClipboardUpdate())
                {
                    clipboardUpdateTime = currTime + (long)(0.5f * Stopwatch.Frequency);
                }

                if (currTime >= clipboardUpdateTime)
                {
                    ClipboardFormat format = MacOSClipboardComponent.GetClipboardFormatInternal(Logger);
                    EventQueue.Raise(null, PlatformEventType.ClipboardUpdate, new ClipboardUpdateEventArgs(format));

                    clipboardUpdateTime = long.MaxValue;
                }
            }
        }

        /// <inheritdoc/>
        public WindowHandle Create(GraphicsApiHints hints)
        {
            // FIXME: Better default placement of window?
            CGRect windowRect = new CGRect(500, 500, 500, 500);
            NSWindowStyleMask style = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable;

            IntPtr windowPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKWindowClass, Alloc),
                selInitWithContentRect_styleMask_backing_defer,
                windowRect, style, NSBackingStoreType.Buffered, false);

            IntPtr viewPtr = objc_msgSend_IntPtr(windowPtr, selContentView);
            // FIXME: Error checking!

            // Replace the view!
            viewPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKViewClass, Alloc),
                selInitWithFrame,
                objc_msgSend_CGRect(viewPtr, selBounds));

            objc_msgSend(windowPtr, selSetContentView, viewPtr);

            NSWindowHandle nswindow = new NSWindowHandle(windowPtr, viewPtr, hints);

            NSWindowDict.Add(windowPtr, nswindow);

            // FIXME: Move this somewhere?
            objc_msgSend(windowPtr, selSetDelegate, windowPtr);
            // Makes the view able to get text input?
            objc_msgSend(windowPtr, selMakeFirstResponder, viewPtr);
            objc_msgSend(windowPtr, selMakeKeyWindow);
            objc_msgSend(windowPtr, selCenter);
            objc_msgSend(windowPtr, selMakeKeyAndOrderFront, windowPtr);

            // FIXME: Store the Ivars somewhere so we can use it later?
            GCHandle gchandle = GCHandle.Alloc(this, GCHandleType.Normal);
            object_setInstanceVariable(windowPtr, OtkCompoenntFieldName, (IntPtr)gchandle);
            object_setInstanceVariable(viewPtr, OtkCompoenntFieldName, (IntPtr)gchandle);

            IntPtr notificationCenter = objc_msgSend_IntPtr((IntPtr)NSNotificationCenterClass, selDefaultCenter);
            objc_msgSend(notificationCenter, selAddObserver_selector_name_object,
                windowPtr,
                sel_registerName("didChangeScreenParameters:"u8),
                NSApplicationDidChangeScreenParametersNotification,
                IntPtr.Zero);

            IntPtr inputContext = objc_msgSend_IntPtr(viewPtr, selInputContext);

            // Register the view for mouse enter/exit notifications.
            objc_msgSend_IntPtr(viewPtr, selAddTrackingRect_owner_userData_assumeInside,
                objc_msgSend_CGRect(viewPtr, selBounds),
                viewPtr,
                IntPtr.Zero,
                false);

            // Register that we are a drag destination for files.
            objc_msgSend(viewPtr, selRegisterForDraggedTypes, objc_msgSend_IntPtr((IntPtr)NSArrayClass, selArrayWithObject, MacOSClipboardComponent.NSPasteboardTypeFileURL));

            return nswindow;
        }

        /// <inheritdoc/>
        public void Destroy(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (nswindow.CursorCaptureMode == CursorCaptureMode.Locked)
            {
                // Restore the cursor.
                CG.CGAssociateMouseAndMouseCursorPosition(true);
            }

            NSWindowDict.Remove(nswindow.Window);

            // This also releases the window if the releaseWhenClosed property is true
            // This is the default.
            objc_msgSend(nswindow.Window, selClose);

            // Maybe make sure that there are no references to the window?

            nswindow.Destroyed = true;
        }

        /// <inheritdoc/>
        public bool IsWindowDestroyed(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            return nswindow.Destroyed;
        }

        /// <inheritdoc/>
        public string GetTitle(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            IntPtr nsStringTitle = objc_msgSend_IntPtr(nswindow.Window, selTitle);
            string title = FromNSString(nsStringTitle);
            return title;
        }

        /// <inheritdoc/>
        public void SetTitle(WindowHandle handle, string title)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, selSetTitle, ToNSString(title));
        }

        /// <inheritdoc/>
        public IconHandle? GetIcon(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            return nswindow.Icon;
        }

        /// <inheritdoc/>
        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            NSIconHandle nsicon = icon.As<NSIconHandle>(this);

            nswindow.Icon = nsicon;

            // FIXME: Is there something we should do here?
        }

        // FIXME: Should we pass a window handle here?
        // FIXME: Maybe move this to MacOSShellComponent.
        public void SetDockIcon(WindowHandle handle, IconHandle icon)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            NSIconHandle nsicon = icon.As<NSIconHandle>(this);

            IntPtr image = nsicon.Image;
            // FIXME: Allocation?
            // FIXME: It seems like the symbol configuration isn't quite working
            // I'm not sure why though...
            // - Noggin_bops 2023-11-25
            if (nsicon.SymbolConfiguration != 0)
                image = objc_msgSend_IntPtr(nsicon.Image, selImageWithSymbolConfiguration, nsicon.SymbolConfiguration);

            objc_msgSend(nsApplication, selSetApplicationIconImage, image);
            
            // FIXME: Maybe make a function for setting the minimized icon...
            /*
            IntPtr dockTile = objc_msgSend_IntPtr(nswindow.Window, selDockTile);

            IntPtr imageView = objc_msgSend_IntPtr((IntPtr)NSImageViewClass, selImageViewWithImage, nsicon.Image);
            if (nsicon.SymbolConfiguration != 0)
                objc_msgSend(imageView, selSetSymbolConfiguration, nsicon.SymbolConfiguration);
            objc_msgSend(dockTile, selSetContentView, imageView);

            objc_msgSend(dockTile, selDisplay);
            */
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);

            x = (int)frame.origin.x;
            y = (int)CG.FlipYCoordinate(frame.origin.y + frame.size.y);
        }

        /// <inheritdoc/>
        public void SetPosition(WindowHandle handle, int x, int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            float flippedY = CG.FlipYCoordinate(y);

            // FIXME: Coordinate space?
            objc_msgSend(nswindow.Window, selSetFrameTopLeftPoint, new CGPoint(x, flippedY));
        }

        /// <inheritdoc/>
        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);

            // FIXME: Do not cast to int?
            width = (int)frame.size.x;
            height = (int)frame.size.y;
        }

        /// <inheritdoc/>
        public void SetSize(WindowHandle handle, int width, int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);
            frame.size.x = width;
            frame.size.y = height;

            // FIXME: BOOL
            objc_msgSend(nswindow.Window, selSetFrame_Display, frame, true);
        }

        /// <inheritdoc/>
        public void GetBounds(WindowHandle handle, out int x, out int y, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);

            // FIXME: Do not cast to int?
            x = (int)frame.origin.x;
            y = (int)CG.FlipYCoordinate(frame.origin.y + frame.size.y);
            width = (int)frame.size.x;
            height = (int)frame.size.y;
        }

        /// <inheritdoc/>
        public void SetBounds(WindowHandle handle, int x, int y, int width, int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            float flippedY = CG.FlipYCoordinate(y);

            CGRect frame;
            frame.origin.x = x;
            frame.origin.y = flippedY;
            frame.size.x = width;
            frame.size.y = height;

            // FIXME: BOOL
            objc_msgSend(nswindow.Window, selSetFrame_Display, frame, true);
        }

        /// <inheritdoc/>
        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.View, selFrame);

            CGRect screenFrame = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, frame);

            x = (int)screenFrame.origin.x;
            y = (int)CG.FlipYCoordinate(screenFrame.origin.y + screenFrame.size.y);
        }

        /// <inheritdoc/>
        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            // FIXME:
            //throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.View, selFrame);

            CGRect screenFrame = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, frame);
            
            width = (int)(screenFrame.size.x);
            height = (int)(screenFrame.size.y);
        }

        /// <inheritdoc/>
        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSSize size = new NSSize(width, height);

            objc_msgSend(nswindow.Window, selSetContentSize, size);
        }

        /// <inheritdoc/>
        public void GetClientBounds(WindowHandle handle, out int x, out int y, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.View, selFrame);

            CGRect screenFrame = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, frame);

            // FIXME: Do not cast to int?
            x = (int)screenFrame.origin.x;
            y = (int)CG.FlipYCoordinate(screenFrame.origin.y + screenFrame.size.y);
            width = (int)screenFrame.size.x;
            height = (int)screenFrame.size.y;
        }

        /// <inheritdoc/>
        public void SetClientBounds(WindowHandle handle, int x, int y, int width, int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            throw new NotImplementedException();
        }

        // FIXME: Separate the window size from the framebuffer size?
        public void GetFramebufferSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect bounds = objc_msgSend_CGRect(nswindow.View, selBounds);
            CGRect boundsBacking = objc_msgSend_CGRect(nswindow.View, selConvertRectToBacking, bounds);

            width = (int)(boundsBacking.size.x);
            height = (int)(boundsBacking.size.y);
        }

        /// <inheritdoc/>
        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            width = nswindow.MaxWidth;
            height = nswindow.MaxHeight;
        }

        /// <inheritdoc/>
        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            nswindow.MaxWidth = width;
            nswindow.MaxHeight = height;

            float fWidth = width ?? 10000.0f;
            float fheight = height ?? 10000.0f;

            objc_msgSend(nswindow.Window, selSetContentMaxSize, new NSSize(fWidth, fheight));
        }

        /// <inheritdoc/>
        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            width = nswindow.MinWidth;
            height = nswindow.MinHeight;
        }

        /// <inheritdoc/>
        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            nswindow.MinWidth = width;
            nswindow.MinHeight = height;

            float fWidth = width ?? 0.0f;
            float fheight = height ?? 0.0f;

            objc_msgSend(nswindow.Window, selSetContentMinSize, new NSSize(fWidth, fheight));
        }

        /// <inheritdoc/>
        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect windowFrame = objc_msgSend_CGRect(nswindow.Window, selFrame);
            windowFrame = CG.FlipYCoordinate(windowFrame);

            Box2 windowBounds = new Box2(
                (float)windowFrame.origin.x,
                (float)windowFrame.origin.y,
                (float)(windowFrame.origin.x + windowFrame.size.x),
                (float)(windowFrame.origin.y + windowFrame.size.y));

            // X11DisplayComponent.GetDisplay contains a loop very similar to this one
            // - Noggin_bops 2023-11-09
            IntPtr bestScreen = 0;
            float bestArea = 0;
            float bestDistance = float.PositiveInfinity;

            // Get all screens.
            IntPtr screensNSArray = objc_msgSend_IntPtr((IntPtr)NSScreenClass, selScreens);
            nint count = (nint)objc_msgSend_IntPtr(screensNSArray, selCount);
            for (int screenIdx = 0; screenIdx < count; screenIdx++)
            {
                IntPtr nsscreen = objc_msgSend_IntPtr(screensNSArray, selObjectAtIndex, (IntPtr)screenIdx);
                CGRect frame = objc_msgSend_CGRect(nsscreen, selFrame);

                Box2 bounds = new Box2(
                    (float)frame.origin.x,
                    (float)frame.origin.y,
                    (float)(frame.origin.x + frame.size.x),
                    (float)(frame.origin.y + frame.size.y));

                Box2 overlap = bounds.Intersected(windowBounds);

                if (overlap.SizeX * overlap.SizeY > bestArea)
                {
                    bestArea = overlap.SizeX * overlap.SizeY;
                    bestScreen = nsscreen;
                }
                else if (bestArea <= 0)
                {
                    // If there is no overlap we are looking for the display which is closest.
                    float dist = Distance(bounds, windowBounds);
                    if (dist < bestDistance)
                    {
                        bestDistance = dist;
                        if (bestArea < 0)
                        {
                            bestScreen = nsscreen;
                        }
                    }
                }
            }

            // FIXME: Maybe throw here?
            Debug.Assert(bestScreen != IntPtr.Zero);

            DisplayHandle disp = MacOSDisplayComponent.FindDisplay(bestScreen);

            return disp;

            // FIXME: Add a function like this to all Box types.
            static float Distance(Box2 a, Box2 b)
            {
                return Math.Min(
                    Math.Min(
                        a.DistanceToNearestEdge(b.Min),
                        a.DistanceToNearestEdge(b.Max)),
                    Math.Min(
                        a.DistanceToNearestEdge((b.Min.X, b.Max.Y)),
                        a.DistanceToNearestEdge((b.Min.Y, b.Max.X))));
            }
        }

        /// <inheritdoc/>
        public WindowMode GetMode(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized, nswindow.Window))
            {
                return WindowMode.Minimized;
            }

            // FIXME: Should we change to fullscreen instead?
            if (objc_msgSend_bool(nswindow.Window, selIsZoomed, nswindow.Window))
            {
                return WindowMode.Maximized;
            }

            // FIXME: check for fullscreen!

            if (objc_msgSend_bool(nswindow.Window, selIsVisible, nswindow.Window) == false)
            {
                return WindowMode.Hidden;
            }
            else
            {
                return WindowMode.Normal;
            }
        }

        /// <inheritdoc/>
        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (nswindow.FullscreenScreen != null)
            {
                if (nswindow.InNonSpaceFullscreen)
                {
                    // FIXME: BOOL
                    objc_msgSend(nswindow.Window, selSetHidesOnDeactivate, false);

                    // Reapply window size limits
                    NFloat INF = NFloat.PositiveInfinity;
                    objc_msgSend(nswindow.Window, selSetContentMaxSize, new NSSize(nswindow.MaxWidth ?? INF, nswindow.MaxHeight ?? INF));
                    objc_msgSend(nswindow.Window, selSetContentMinSize, new NSSize(nswindow.MinWidth ?? 0, nswindow.MinHeight ?? 0));

                    objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nswindow.PreviousStyleMask);
                    objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)nswindow.PreviousLevel);

                    nswindow.InNonSpaceFullscreen = false;
                }
                else
                {
                    objc_msgSend(nswindow.Window, selToggleFullScreen, IntPtr.Zero);
                }

                // FIXME: There seems like there might be some timing related things going on here
                // where running this code normally it doesn't reset the frame after being in it's own space
                // but placing a breakpoint here and stepping through it the frame actually gets reset properly.
                // - Noggin_bops 2024-04-13
                // FIXME: BOOL
                objc_msgSend(nswindow.Window, selSetFrame_Display, nswindow.PreviousFrame, true);

                nswindow.FullscreenScreen = null;
            }

            NSWindowStyleMask mask = (NSWindowStyleMask)objc_msgSend_IntPtr(nswindow.Window, selStyleMask);
            // FIXME: Only go out of the space if we need to...
            if (mask.HasFlag(NSWindowStyleMask.FullScreen))
            {
                // Go out of fullscreen.
                objc_msgSend(nswindow.Window, selToggleFullScreen, IntPtr.Zero);
            }

            switch (mode)
            {
                case WindowMode.Hidden:
                    {
                        // FIXME: How should this work with fullscreen?
                        // Atm the window remains fullscreen but disappears...
                        objc_msgSend(nswindow.Window, selOrderOut, nswindow.Window);
                        break;
                    }
                case WindowMode.Minimized:
                    {
                        // FIXME: If we are in a fullscreen mode we can't really do this.
                        // This is also something macOS wants to avoid doing.
                        // Do we allow it?
                        // Do we log a message to the user that this is not expected on macOS?
                        objc_msgSend(nswindow.Window, selMiniaturize, nswindow.Window);
                        break;
                    }
                case WindowMode.Normal:
                    {
                        // FIXME: Is this everything we need to do?

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsZoomed))
                        {
                            objc_msgSend(nswindow.Window, selZoom, nswindow.Window);
                        }

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized))
                        {
                            objc_msgSend(nswindow.Window, selDeminiaturize, nswindow.Window);
                        }

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsVisible) == false)
                        {
                            objc_msgSend(nswindow.Window, selOrderFront, nswindow.Window);
                        }

                        break;
                    }
                case WindowMode.Maximized:
                    {
                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized))
                        {
                            objc_msgSend(nswindow.Window, selDeminiaturize, nswindow.Window);
                        }

                        // If the window was hidden, show it.
                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsVisible) == false)
                        {
                            objc_msgSend(nswindow.Window, selOrderFront, nswindow.Window);
                        }

                        // macos calls maximizing "zoom".
                        objc_msgSend(nswindow.Window, selZoom, nswindow.Window);
                        break;
                    }
                case WindowMode.WindowedFullscreen:
                    {
                        // FIXME: deminituarize, un-zoom or whatever else needs to be done.
                        SetFullscreenDisplay(nswindow, null);
                        break;
                    }
                case WindowMode.ExclusiveFullscreen:
                    {
                        throw new NotImplementedException();
                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, mode.GetType());
            }
        }

        /// <summary>
        /// Put a window into 'windowed fullscreen' on a specific display without creating a space for it.
        /// If <paramref name="display"/> is <c>null</c> then the window will be made fullscreen on the 'nearest' display.
        /// </summary>
        /// <param name="window">The window to make fullscreen.</param>
        /// <param name="display">The display to make the window fullscreen on.</param>
        public void SetFullscreenDisplayNoSpace(WindowHandle window, DisplayHandle? display)
        {
            if (display == null)
            {
                display = GetDisplay(window);
            }

            NSWindowHandle nswindow = window.As<NSWindowHandle>(this);
            NSScreenHandle nsscreen = display.As<NSScreenHandle>(this);

            // Disable min/max size constraints while fullscreen.
            objc_msgSend(nswindow.Window, selSetContentMaxSize, new NSSize(NFloat.PositiveInfinity, NFloat.PositiveInfinity));
            objc_msgSend(nswindow.Window, selSetContentMinSize, new NSSize(0, 0));

            nswindow.PreviousStyleMask = (NSWindowStyleMask)objc_msgSend_IntPtr(nswindow.Window, selStyleMask);
            objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)NSWindowStyleMask.Borderless);

            nswindow.PreviousLevel = (NSWindowLevel)objc_msgSend_IntPtr(nswindow.Window, selLevel);
            objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)(NSWindowLevel.MainMenu + 1));

            // FIXME: BOOL
            objc_msgSend(nswindow.Window, selSetHidesOnDeactivate, true);

            // FIXME: Remember the original frame!
            CGRect frame = objc_msgSend_CGRect(nsscreen.Screen, selFrame);
            // FIXME: Is this the correct frame to get?
            nswindow.PreviousFrame = objc_msgSend_CGRect(nswindow.Window, selFrame);
            // FIXME: BOOL
            objc_msgSend(nswindow.Window, selSetFrame_Display, frame, true);

            objc_msgSend(nswindow.Window, selMakeKeyAndOrderFront, nswindow.Window);

            nswindow.InNonSpaceFullscreen = true;
            nswindow.FullscreenScreen = nsscreen;
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle handle, DisplayHandle? display)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            NSScreenHandle? nsscreen = display?.As<NSScreenHandle>(this);

            nswindow.PreviousFrame = objc_msgSend_CGRect(nswindow.Window, selFrame);

            if (nsscreen != null)
            {
                CGRect frame = objc_msgSend_CGRect(nsscreen.Screen, selFrame);
                // FIXME: BOOL
                objc_msgSend(nswindow.Window, selSetFrame_Display, frame, true);
            }
            else
            {
                nsscreen = GetDisplay(nswindow).As<NSScreenHandle>(this);
            }

            nswindow.FullscreenScreen = nsscreen;

            objc_msgSend(nswindow.Window, selToggleFullScreen, nswindow.Window);
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle display, VideoMode videoMode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public bool GetFullscreenDisplay(WindowHandle window, [NotNullWhen(true)] out DisplayHandle? display)
        {
            NSWindowHandle nswindow = window.As<NSWindowHandle>(this);
            display = nswindow.FullscreenScreen;
            return display != null;
        }

        /// <inheritdoc/>
        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowStyleMask style = (NSWindowStyleMask)objc_msgSend_IntPtr(nswindow.Window, selStyleMask);

            // If the style mask is 0 it's the same as Borderless, it's not a flag.
            if (style == NSWindowStyleMask.Borderless)
            {
                return WindowBorderStyle.Borderless;
            }

            if (style.HasFlag(NSWindowStyleMask.UtilityWindow))
            {
                return WindowBorderStyle.ToolBox;
            }

            if (style.HasFlag(NSWindowStyleMask.Resizable))
            {
                return WindowBorderStyle.ResizableBorder;
            }

            return WindowBorderStyle.FixedBorder;
        }

        /// <inheritdoc/>
        public void SetBorderStyle(WindowHandle handle, WindowBorderStyle style)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            switch (style)
            {
                case WindowBorderStyle.Borderless:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Borderless;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.FixedBorder:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.ResizableBorder:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.ToolBox:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable | NSWindowStyleMask.UtilityWindow;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        // FIXME: We can only set the utility flag on a NSPanel and not NSWindow...
                        // We might need to recreate the window as a panel, alternatively maybe it's
                        // possible to change the window to be an NSPanel after it's been instantiated?

                        Logger?.LogError("WindowBorderStyle.ToolBox currently doesn't work on macos.");

                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(style), (int)style, style.GetType());
            }
        }

        /// <inheritdoc/>
        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (floating)
            {
                objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)NSWindowLevel.Floating);
            }
            else
            {
                objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)NSWindowLevel.Normal);
            }
        }

        /// <inheritdoc/>
        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowLevel level = (NSWindowLevel)objc_msgSend_IntPtr(nswindow.Window, selLevel);
            if (level == NSWindowLevel.Floating)
            {
                return true;
            }
            else
            {
                // FIXME: Maybe log if level isn't `NSWindowLevel.Normal`?
                return false;
            }
        }

        /// <inheritdoc/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            NSWindowHandle window = handle.As<NSWindowHandle>(this);
            window.HitTest = test;

            MacOSMouseComponent.GetPosition(out double x, out double y);
            //ScreenToClient
            GetClientPosition(window, out int cx, out int cy);
            CGPoint point = new CGPoint((NFloat)x - cx, (NFloat)y - cy);

            // FIXME: Do an initial check when setting the delegate.
            DoHitTest(window, point);
        }

        /// <inheritdoc/>
        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            NSCursorHandle? nscursor = cursor?.As<NSCursorHandle>(this);

            nswindow.Cursor = nscursor;

            objc_msgSend(nswindow.Window, selInvalidateCursorRectsForView, nswindow.View);
        }

        /// <inheritdoc/>
        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            return nswindow.CursorCaptureMode;
        }

        /// <inheritdoc/>
        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (nswindow.CursorCaptureMode == CursorCaptureMode.Confined &&
                mode != CursorCaptureMode.Confined)
            {
                // Remove the confinement rectangle.
                NFloat INF = NFloat.PositiveInfinity;
                CGRect rect = new CGRect(-INF, -INF, INF, INF);
                objc_msgSend(nswindow.Window, selSetMouseConfinementRect, rect);
            }

            if (nswindow.CursorCaptureMode == CursorCaptureMode.Locked &&
                mode != CursorCaptureMode.Locked)
            {
                CG.CGAssociateMouseAndMouseCursorPosition(true);
            }
            
            switch (mode)
            {
                case CursorCaptureMode.Normal:
                    // Getting out of the other modes is handled above.
                    nswindow.CursorCaptureMode = CursorCaptureMode.Normal;
                    break;
                case CursorCaptureMode.Confined:
                    // This undocumented property was found by the SDL developers
                    // See: https://github.com/libsdl-org/SDL/commit/35d90f17e1c7d3740c75641ef94b5e5c938c20c6
                    // - Noggin_bops 2024-04-13
                    CGRect rect = objc_msgSend_CGRect(nswindow.View, selFrame);
                    objc_msgSend(nswindow.Window, selSetMouseConfinementRect, rect);
                    nswindow.CursorCaptureMode = mode;
                    break;
                case CursorCaptureMode.Locked:
                    // FIXME: Set the mode to locked
                    // CGAssociateMouseAndMouseCursorPosition() to allow the mouse to move separately from the cursor
                    // [NSCursor hide] can be used to hide the cursor
                    // Then we need to disable this when we loose key status and enable it again when we get key status again
                    // We also need to handle warping the cursor back to the center of the window every time the cursor moves.
                    // - Noggin_bops 2024-04-13

                    // FIXME: Do we need to call CGAssociateMouseAndMouseCursorPosition?
                    // FIXME: We want to move the mouse display to the center of the screen.
                    // objc_msgSend((IntPtr)NSCursorClass, selHide);

                    // FIXME: With multiple windows we only want to apply this
                    // if this window is key...

                    //CG.CGAssociateMouseAndMouseCursorPosition(false);

                    //CenterCursor(nswindow);

                    nswindow.VirtualCursorPosition = nswindow.LastMousePosition;

                    nswindow.CursorCaptureMode = CursorCaptureMode.Locked;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Centers the cursor in the window.
        /// </summary>
        private static void CenterCursor(NSWindowHandle nswindow)
        {
            CGRect frame = objc_msgSend_CGRect(nswindow.View, selFrame);
            CGRect screenFrame = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, frame);

            CGPoint center = new CGPoint(screenFrame.origin.x + (screenFrame.size.x / 2),
                                         screenFrame.origin.y + (screenFrame.size.y / 2));

            // CGWarpMouseCursorPosition uses top-left coordinates.
            center = CG.FlipYCoordinate(center);

            CG.CGDisplayMoveCursorToPoint(CG.CGMainDisplayID(), center);
            CG.CGWarpMouseCursorPosition(center);
            nswindow.LastMousePosition = center;
        }

        /// <inheritdoc/>
        public void FocusWindow(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, selMakeKeyAndOrderFront, nswindow.Window);
        }

        /// <inheritdoc/>
        public void RequestAttention(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            // FIXME: Maybe store the requestID so we can cancel the request?
            ulong requestID = objc_msgSend_ulong(nsApplication, selRequestUserAttention, (ulong)NSRequestUserAttentionType.CriticalRequest);
        }

        /// <inheritdoc/>
        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetScaleFactor(WindowHandle handle, out float scaleX, out float scaleY)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);
            CGRect frameBacking = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, frame);

            scaleX = (float)(frameBacking.size.x / frame.size.x);
            scaleY = (float)(frameBacking.size.y / frame.size.y);
        }

        /// <summary>
        /// Returns the <c>NSWindow</c> used by the specified window handle.
        /// The Objective-C object returned is a subclass of <c>NSWindow</c> called <c>NSOpenTKWindow</c>.
        /// </summary>
        /// <param name="handle">A handle to a window to get the associated <c>NSWindow</c> from.</param>
        /// <returns>The <c>NSWindow</c> associated with the window handle.</returns>
        public IntPtr GetNSWindow(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            return nswindow.Window;
        }

        /// <summary>
        /// Returns the <c>NSView</c> used by the specified window handle.
        /// The Objective-C object returned is a subclass of <c>NSView</c> called <c>NSOpenTKView</c>
        /// </summary>
        /// <param name="handle">A handle to a window to get the associated <c>NSView</c> from.</param>
        /// <returns>The <c>NSView</c> associated with the window handle.</returns>
        public IntPtr GetNSView(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            return nswindow.View;
        }
    }
}
