using System;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    internal enum IOPSLowBatteryWarningLevel : uint
    {
        None = 1,
        Early = 2,
        Final = 3,
    }

    internal static class IOPS
    {
        public const string Lib = "/System/Library/Frameworks/IOKit.framework/IOKit";

        internal const double kIOPSTimeRemainingUnknown = -1;
        internal const double kIOPSTimeRemainingUnlimited = -2;

        internal static readonly IntPtr kIOPSUPSPowerKey = ToNSString("UPS Power"u8);
        internal static readonly IntPtr kIOPSBatteryPowerKey = ToNSString("Battery Power"u8);
        internal static readonly IntPtr kIOPSACPowerKey = ToNSString("AC Power"u8);

        internal static readonly IntPtr kIOPSPowerAdapterKey = ToNSString("AdapterID"u8);
        internal static readonly IntPtr kIOPSPowerAdapterWattsKey = ToNSString("Watts"u8);
        internal static readonly IntPtr kIOPSPowerAdapterRevisionKey = ToNSString("AdapterRevision"u8);
        internal static readonly IntPtr kIOPSPowerAdapterSerialNumberKey = ToNSString("SerialNumber"u8);
        internal static readonly IntPtr kIOPSPowerAdapterFamilyKey = ToNSString("FamilyCode"u8);
        internal static readonly IntPtr kIOPSPowerAdapterCurrentKey = ToNSString("Current"u8);
        internal static readonly IntPtr kIOPSPowerAdapterSourceKey = ToNSString("Source"u8);

        internal static readonly IntPtr kIOPSLowWarnLevelKey = ToNSString("Low Warn Level"u8);
        internal static readonly IntPtr kIOPSDeadWarnLevelKey = ToNSString("Shutdown Level"u8);

        internal static readonly IntPtr kIOPSPowerSourceIDKey = ToNSString("Power Source ID"u8);
        internal static readonly IntPtr kIOPSPowerSourceStateKey = ToNSString("Power Source State"u8);
        internal static readonly IntPtr kIOPSCurrentCapacityKey = ToNSString("Current Capacity"u8);
        internal static readonly IntPtr kIOPSMaxCapacityKey = ToNSString("Max Capacity"u8);
        internal static readonly IntPtr kIOPSDesignCapacityKey = ToNSString("DesignCapacity"u8);
        internal static readonly IntPtr kIOPSTimeToEmptyKey = ToNSString("Time to Empty"u8);
        internal static readonly IntPtr kIOPSTimeToFullChargeKey = ToNSString("Time to Full Charge"u8);
        internal static readonly IntPtr kIOPSIsChargingKey = ToNSString("Is Charging"u8);
        internal static readonly IntPtr kIOPSIsPresentKey = ToNSString("Is Present"u8);
        internal static readonly IntPtr kIOPSVoltageKey = ToNSString("Voltage"u8);
        internal static readonly IntPtr kIOPSCurrentKey = ToNSString("Current"u8);
        internal static readonly IntPtr kIOPSNameKey = ToNSString("Name"u8);
        internal static readonly IntPtr kIOPSTypeKey = ToNSString("Type"u8);
        internal static readonly IntPtr kIOPSTransportTypeKey = ToNSString("Transport Type"u8);
        internal static readonly IntPtr kIOPSVendorDataKey = ToNSString("Vendor Specific Data"u8);
        internal static readonly IntPtr kIOPSBatteryHealthKey = ToNSString("BatteryHealth"u8);
        internal static readonly IntPtr kIOPSBatteryHealthConditionKey = ToNSString("BatteryHealthCondition"u8);
        internal static readonly IntPtr kIOPSBatteryFailureModesKey = ToNSString("BatteryFailureModes"u8);
        internal static readonly IntPtr kIOPSBatteryHealthConfidenceKey = ToNSString("BatteryHealthConfidence"u8);
        internal static readonly IntPtr kIOPSMaxErrKey = ToNSString("MaxErr"u8);
        internal static readonly IntPtr kIOPSIsChargedKey = ToNSString("Is Charged"u8);
        internal static readonly IntPtr kIOPSIsFinishingChargeKey = ToNSString("Is Finishing Charge"u8);
        internal static readonly IntPtr kIOPSHardwareSerialNumberKey = ToNSString("Hardware Serial Number"u8);

        internal static readonly IntPtr kIOPSSerialTransportType = ToNSString("Serial"u8);
        internal static readonly IntPtr kIOPSUSBTransportType = ToNSString("USB"u8);
        internal static readonly IntPtr kIOPSNetworkTransportType = ToNSString("Ethernet"u8);
        internal static readonly IntPtr kIOPSInternalTransportType = ToNSString("Internal"u8);

        internal static readonly IntPtr kIOPSInternalBatteryType = ToNSString("InternalBattery"u8);
        internal static readonly IntPtr kIOPSUPSType = ToNSString("UPS"u8);

        internal static readonly IntPtr kIOPSOffLineValue = ToNSString("Off Line"u8);
        internal static readonly IntPtr kIOPSACPowerValue = ToNSString("AC Power"u8);
        internal static readonly IntPtr kIOPSBatteryPowerValue = ToNSString("Battery Power"u8);

        internal static readonly IntPtr kIOPSPoorValue = ToNSString("Poor"u8);
        internal static readonly IntPtr kIOPSFairValue = ToNSString("Fair"u8);
        internal static readonly IntPtr kIOPSGoodValue = ToNSString("Good"u8);

        internal static readonly IntPtr kIOPSCheckBatteryValue = ToNSString("Check Battery"u8);
        internal static readonly IntPtr kIOPSPermanentFailureValue = ToNSString("Permanent Battery Failure"u8);

        internal static readonly IntPtr kIOPSFailureExternalInput = ToNSString("Externally Indicated Failure"u8);
        internal static readonly IntPtr kIOPSFailureSafetyOverVoltage = ToNSString("Safety Over-Voltage"u8);
        internal static readonly IntPtr kIOPSFailureChargeOverTemp = ToNSString("Charge Over-Temperature"u8);
        internal static readonly IntPtr kIOPSFailureDischargeOverTemp = ToNSString("Discharge Over-Temperature"u8);
        internal static readonly IntPtr kIOPSFailureCellImbalance = ToNSString("Cell Imbalance"u8);
        internal static readonly IntPtr kIOPSFailureChargeFET = ToNSString("Charge FET"u8);
        internal static readonly IntPtr kIOPSFailureDischargeFET = ToNSString("Discharge FET"u8);
        internal static readonly IntPtr kIOPSFailureDataFlushFault = ToNSString("Data Flush Fault"u8);
        internal static readonly IntPtr kIOPSFailurePermanentAFEComms = ToNSString("Permanent AFE Comms"u8);
        internal static readonly IntPtr kIOPSFailurePeriodicAFEComms = ToNSString("Periodic AFE Comms"u8);
        internal static readonly IntPtr kIOPSFailureChargeOverCurrent = ToNSString("Charge Over-Current"u8);
        internal static readonly IntPtr kIOPSFailureDischargeOverCurrent = ToNSString("Discharge Over-Current"u8);
        internal static readonly IntPtr kIOPSFailureOpenThermistor = ToNSString("Open Thermistor"u8);
        internal static readonly IntPtr kIOPSFailureFuseBlown = ToNSString("Fuse Blown"u8);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double /* CFTimeInterval */ IOPSGetTimeRemainingEstimate();

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFDictionaryRef */ IOPSCopyExternalPowerAdapterDetails();

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFTypeRef */ IOPSCopyPowerSourcesInfo();

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFArrayRef */ IOPSCopyPowerSourcesList(IntPtr /* CFTypeRef */ blob);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFDictionaryRef */ IOPSGetPowerSourceDescription(IntPtr /* CFTypeRef */ blob, IntPtr /* CFTypeRef */ ps);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFStringRef */ IOPSGetProvidingPowerSourceType(IntPtr /* CFTypeRef */ snapshot);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IOPSLowBatteryWarningLevel IOPSGetBatteryWarningLevel();
    }
}

