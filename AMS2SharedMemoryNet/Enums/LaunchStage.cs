namespace AMS2SharedMemoryNet.Enums
{
    public enum LaunchStage
    {
        LAUNCH_INVALID = -1,    // Launch control unavailable
        LAUNCH_OFF = 0,         // Launch control inactive
        LAUNCH_REV,             // Launch control revving to optimum engine speed
        LAUNCH_ON,
    }
}
