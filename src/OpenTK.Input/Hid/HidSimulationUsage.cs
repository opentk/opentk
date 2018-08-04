namespace OpenTK.Input.Hid
{
    /// <summary>
    /// Describes usages for the <see cref="HidPage.Simulation"/> page.
    /// </summary>
    public enum HidSimulationUsage : ushort
    {
        /// <summary>
        /// This usage definition allows a device to be generally classified as one that uses the
        /// standard controls found on an airplane.
        /// </summary>
        FlightSimulationDevice = 0x01,

        /// <summary>
        /// This usage definition allows a device to be generally classified as one that uses the
        /// standard controls found in an automobile or truck.
        /// </summary>
        AutomobileSimulationDevice = 0x02,

        /// <summary>
        /// This usage definition allows a device to be generally classified as one that uses
        /// standard controls found in a tank or a treaded vehicle.
        /// </summary>
        TankSimulationDevice = 0x03,

        /// <summary>
        /// This usage definition allows a device to be generally classified as one that uses
        /// standard controls found on a spaceship.
        /// </summary>
        SpaceshipSimulationDevice = 0x04,

        /// <summary>
        /// Allows a device to be generally classified as one that uses the standard controls of a submarine.
        /// </summary>
        SubmarineSimulationDevice = 0x05,

        /// <summary>
        /// Allows a device to be generally classified as one that uses the standard controls of a sailboat.
        /// </summary>
        SailingSimulationDevice = 0x06,

        /// <summary>
        /// Allows a device to be generally classified as one that uses the standard controls of a motorcycle.
        /// </summary>
        MotorcycleSimulationDevice = 0x07,

        /// <summary>
        /// This usage definition allows a device to be generally classified as one that uses
        /// standard controls found on a sports simulation device.
        /// </summary>
        SportsSimulationDevice = 0x08,

        /// <summary>
        /// This usage definition allows a device to be generally classified as one that uses
        /// standard controls found on an airplane.
        /// </summary>
        AirplaneSimulationDevice = 0x09,

        /// <summary>
        /// This usage definition allows a device to be generally classified as one that uses
        /// standard controls found on a helicopter.
        /// </summary>
        HelicopterSimulationDevice = 0x0A,

        /// <summary>
        /// Allows a device to be generally classified as one that uses the standard control of a magic carpet.
        /// </summary>
        MagicCarpetSimulationDevice = 0x0B,

        /// <summary>
        /// Allows a device to be generally classified as one that uses the standard controls of a bicycle.
        /// </summary>
        BicycleSimulationDevice = 0x0C,

        // 0x0D - 0x1F                      // Reserved

        /// <summary>
        /// A Flight Control Stick controls the Pitch and Roll of an airplane.
        /// </summary>
        FlightControlStick = 0x20,

        /// <summary>
        /// A Flight Stick defines a class of device commonly used for flight simulator games.
        /// </summary>
        FlightStick = 0x21,

        /// <summary>
        /// This control is specifically for a helicopter.<para/>
        /// A cyclic control is a stick between the pilot’s legs that moves in two axes.
        /// </summary>
        CyclicControl = 0x22,

        /// <summary>
        /// This control is specifically for a helicopter.<para/>
        /// Cyclic Trim allows fine adjustment of the cyclic position in two dimensions.
        /// </summary>
        CyclicTrim = 0x23,

        /// <summary>
        /// A flight yoke (also called a control wheel) controls the pitch and roll of an airplane.
        /// </summary>
        FlightYoke = 0x24,

        /// <summary>
        /// A device for controlling the direction and velocity of a vehicle that is driven by tracks.
        /// </summary>
        TrackControl = 0x25,

        // 0x26 - 0xAF                      // Reserved

        /// <summary>
        /// An aileron is one of two movable flaps on the wings of an airplane that can be used
        /// to control the plane’s rolling and banking movements.
        /// </summary>
        Aileron = 0xB0,

        /// <summary>
        /// Allows fine adjustment of the Aileron position.
        /// </summary>
        AileronTrim = 0xB1,

        /// <summary>
        /// This control mechanically behaves the same as rudder pedals.
        /// </summary>
        AntiTorqueControl = 0xB2,

        /// <summary>
        /// This control enables or disables an airplane’s autopilot.
        /// </summary>
        AutopilotEnable = 0xB3,

        /// <summary>
        /// Chaff is used to reflect electromagnetic energy as a radar countermeasure.
        /// </summary>
        ChaffRelease = 0xB4,

        /// <summary>
        /// This control is specifically for a helicopter.
        /// It controls the vertical acceleration or lift of the helicopter.
        /// </summary>
        CollectiveControl = 0xB5,

        /// <summary>
        /// A flap that can be extended on an aircraft to increase drag and reduce the speed of descent.
        /// </summary>
        DiveBrake = 0xB6,

        /// <summary>
        /// A pushbutton that enables electronic countermeasures.
        /// </summary>
        ElectronicCountermeasures = 0xB7,

        /// <summary>
        /// A movable control surface, usually attached to the horizontal stabilizer of an aircraft,
        /// that is used to produce motion up or down.
        /// </summary>
        Elevator = 0xB8,

        /// <summary>
        /// Elevator Trim allows fine adjustment of the Elevator position.
        /// </summary>
        ElevatorTrim = 0xB9,

        /// <summary>
        /// The zero position is centered, positive values turn right, and negative values turn left.
        /// </summary>
        Rudder = 0xBA,

        /// <summary>
        /// A valve that regulates the flow of a fluid, such as the valve in an internal-combustion engine
        /// that controls the amount of vaporized fuel entering the cylinders.
        /// </summary>
        Throttle = 0xBB,

        /// <summary>
        /// Typically this is a two-position pushbutton where the first position enables communications with the
        /// crew and the second position enables the transmitter for communication external to the plane.
        /// </summary>
        FlightCommunications = 0xBC,

        /// <summary>
        /// A flare is a device that produces a bright light for signaling, illumination, identification,
        /// or heat for infrared missile countermeasures.
        /// </summary>
        FlareRelease = 0xBD,

        /// <summary>
        /// A control for raising or lowering an airplane’s landing gear.
        /// </summary>
        LandingGear = 0xBE,

        /// <summary>
        /// A device for slowing or stopping the motion of an airplane when it is on the ground.
        /// </summary>
        ToeBrake = 0xBF,

        /// <summary>
        /// A lever pressed by the finger to release or activate a mechanism, typically used to discharge a firearm.
        /// </summary>
        Trigger = 0xC0,

        /// <summary>
        /// This device is normally a covered toggle switch that must be selected to enable the weapons system.
        /// </summary>
        WeaponsArm = 0xC1,

        /// <summary>
        /// This device can either be a pushbutton that steps through the available weapons or
        /// a radio button that selects them individually.
        /// </summary>
        WeaponsSelect = 0xC2,

        /// <summary>
        /// Wing flap controls are usually powered either hydraulically or by electric motors,
        /// and are used for low-speed control of an airplane.
        /// </summary>
        WingFlaps = 0xC3,

        /// <summary>
        /// A device, especially the gas pedal of a motor vehicle, for increasing speed.
        /// </summary>
        Accelerator = 0xC4,

        /// <summary>
        /// A device for slowing or stopping motion, as of a vehicle, especially by contact friction.
        /// </summary>
        Brake = 0xC5,

        /// <summary>
        /// A device for disengaging the transmission of a vehicle to allow shifting of gears.
        /// </summary>
        Clutch = 0xC6,

        /// <summary>
        /// A device for shifting gears in a vehicle.
        /// </summary>
        Shifter = 0xC7,

        /// <summary>
        /// A steering wheel is a single degree-of-freedom device that rotates about an axis.
        /// </summary>
        Steering = 0xC8,

        /// <summary>
        /// This control determines the right-to-left positioning of the tank turret.
        /// </summary>
        TurretDirection = 0xC9,

        /// <summary>
        /// This control determines the elevation of the gun barrel in a turret.
        /// </summary>
        BarrelElevation = 0xCA,

        /// <summary>
        /// Dive planes control the vertical ascent or descent of the submarine under power.
        /// </summary>
        DivePlane = 0xCB,

        /// <summary>
        /// Ballast controls the vertical ascent or descent of the submarine.
        /// </summary>
        Ballast = 0xCC,

        /// <summary>
        /// A foot-operated assembly of pedals attached to a crank that is used for powering a bicycle.
        /// </summary>
        BicycleCrank = 0xCD,

        /// <summary>
        /// A steering control, held in both hands, for a motorcycle or bicycle.
        /// </summary>
        HandleBars = 0xCE,

        /// <summary>
        /// Engages the front brake of the motorcycle to slow the vehicle.
        /// </summary>
        FrontBrake = 0xCF,

        /// <summary>
        /// Engages the rear brake of the motorcycle to slow the vehicle.
        /// </summary>
        RearBrake = 0xD0,

        // 0xD1 - 0xFFFF                    // Reserved
    }
}
