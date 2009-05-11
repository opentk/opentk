
using System;

namespace OpenTK.Platform.MacOS
{
    public class MacOSException : Exception
    {
        OSStatus errorCode;

        public MacOSException()
        {}
        public MacOSException(OSStatus errorCode)
            : base("Error Code " + ((int)errorCode).ToString() + ": " + errorCode.ToString())
        {
            this.errorCode = errorCode;
        }
        public MacOSException(OSStatus errorCode, string message)
            : base(message)
        {
            this.errorCode = errorCode;
        }
        internal MacOSException(Agl.AglError errorCode, string message)
            : base(message)
        {
            this.errorCode = (OSStatus)errorCode;
        }

        public OSStatus ErrorCode
        {
            get { return errorCode; }
        }
    }

    public enum OSStatus
    {
        NoError = 0,
        
        ParameterError               = -50,                          /*error in user parameter list*/
        NoHardwareError             = -200,                         /*Sound Manager Error Returns*/
        NotEnoughHardwareError      = -201,                         /*Sound Manager Error Returns*/
        UserCanceledError           = -128,
        QueueError                  = -1,                           /*queue element not found during deletion*/
        VTypErr                     = -2,                           /*invalid queue element*/
        CorErr                      = -3,                           /*core routine number out of range*/
        UnimpErr                    = -4,                           /*unimplemented core routine*/
        SlpTypeErr                  = -5,                           /*invalid queue element*/
        SeNoDB                      = -8,                           /*no debugger installed to handle debugger command*/
        ControlErr                  = -17,                          /*I/O System Errors*/
        StatusErr                   = -18,                          /*I/O System Errors*/
        ReadErr                     = -19,                          /*I/O System Errors*/
        WritErr                     = -20,                          /*I/O System Errors*/
        BadUnitErr                  = -21,                          /*I/O System Errors*/
        UnitEmptyErr                = -22,                          /*I/O System Errors*/
        OpenErr                     = -23,                          /*I/O System Errors*/
        ClosErr                     = -24,                          /*I/O System Errors*/
        DRemovErr                   = -25,                          /*tried to remove an open driver*/
        DInstErr                    = -26,                          /*DrvrInstall couldn't find driver in resources*/

        // Window Manager result codes.
        InvalidWindowPtr = -5600,
        UnsupportedWindowAttributesForClass = -5601,
        WindowDoesNotHaveProxy = -5602,
        WindowPropertyNotFound = -5604,
        UnrecognizedWindowClass = -5605,
        CorruptWindowDescription = -5606,
        UserWantsToDragWindow = -5607,
        WindowsAlreadyInitialized = -5608,
        FloatingWindowsNotInitialized = -5609,
        WindowNotFound = -5610,
        WindowDoesNotFitOnscreen = -5611,
        WindowAttributeImmutable = -5612,
        WindowAttributesConflict = -5613,
        WindowManagerInternalError = -5614,
        WindowWrongState = -5615,
        WindowGroupInvalid = -5616,
        WindowAppModalStateAlreadyExists = -5617,
        WindowNoAppModalState = -5618,
        WindowDoesntSupportFocus = -30583,
        WindowRegionCodeInvalid = -30593,

        // Event Manager result codes
        EventAlreadyPosted = -9860,
        EventTargetBusy = -9861,
        EventDeferAccessibilityEvent = -9865,
        EventInternalError = -9868,
        EventParameterNotFound = -9870,
        EventNotHandled = -9874,
        EventLoopTimedOut = -9875,
        EventLoopQuit = -9876,
        EventNotInQueue = -9877,
        HotKeyExists = -9878,
        EventPassToNextTarget = -9880

    }

}
