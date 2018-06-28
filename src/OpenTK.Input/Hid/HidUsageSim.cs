namespace OpenTK.Input.Hid
{
    public enum HidUsageSim : ushort
    {
        FlightSimulationDevice = 0x01,      // Application Collection
        AutomobileSimulationDevice = 0x02,  // Application Collection
        TankSimulationDevice = 0x03,        // Application Collection
        SpaceshipSimulationDevice = 0x04,   // Application Collection
        SubmarineSimulationDevice = 0x05,   // Application Collection
        SailingSimulationDevice = 0x06,     // Application Collection
        MotorcycleSimulationDevice = 0x07,  // Application Collection
        SportsSimulationDevice = 0x08,      // Application Collection
        AirplaneSimulationDevice = 0x09,    // Application Collection
        HelicopterSimulationDevice = 0x0A,  // Application Collection
        MagicCarpetSimulationDevice = 0x0B, // Application Collection
        BicycleSimulationDevice = 0x0C,     // Application Collection

        // 0x0D - 0x1F                      // Reserved
        FlightControlStick = 0x20,          // Application Collection
        FlightStick = 0x21,                 // Application Collection
        CyclicControl = 0x22,               // Physical Collection
        CyclicTrim = 0x23,                  // Physical Collection
        FlightYoke = 0x24,                  // Application Collection
        TrackControl = 0x25,                // Physical Collection

        // 0x26 - 0xAF                      // Reserved
        Aileron = 0xB0,                     // Dynamic Value
        AileronTrim = 0xB1,                 // Dynamic Value
        AntiTorqueControl = 0xB2,           // Dynamic Value
        AutopilotEnable = 0xB3,             // On/Off Control
        ChaffRelease = 0xB4,                // One-Shot Control
        CollectiveControl = 0xB5,           // Dynamic Value
        DiveBrake = 0xB6,                   // Dynamic Value
        ElectronicCountermeasures = 0xB7,   // On/Off Control
        Elevator = 0xB8,                    // Dynamic Value
        ElevatorTrim = 0xB9,                // Dynamic Value
        Rudder = 0xBA,                      // Dynamic Value
        Throttle = 0xBB,                    // Dynamic Value
        FlightCommunications = 0xBC,        // On/Off Control
        FlareRelease = 0xBD,                // One-Shot Control
        LandingGear = 0xBE,                 // On/Off Control
        ToeBrake = 0xBF,                    // Dynamic Value
        Trigger = 0xC0,                     // Momentary Control
        WeaponsArm = 0xC1,                  // On/Off Control
        Weapons = 0xC2,                     // Selector
        WingFlaps = 0xC3,                   // Dynamic Value
        Accelerator = 0xC4,                 // Dynamic Value
        Brake = 0xC5,                       // Dynamic Value
        Clutch = 0xC6,                      // Dynamic Value
        Shifter = 0xC7,                     // Dynamic Value
        Steering = 0xC8,                    // Dynamic Value
        TurretDirection = 0xC9,             // Dynamic Value
        BarrelElevation = 0xCA,             // Dynamic Value
        DivePlane = 0xCB,                   // Dynamic Value
        Ballast = 0xCC,                     // Dynamic Value
        BicycleCrank = 0xCD,                // Dynamic Value
        HandleBars = 0xCE,                  // Dynamic Value
        FrontBrake = 0xCF,                  // Dynamic Value
        RearBrake = 0xD0,                   // Dynamic Value

        // 0xD1 - 0xFFFF                    // Reserved
        Reserved = 0xFFFF
    }
}
