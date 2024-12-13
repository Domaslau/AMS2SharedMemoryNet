namespace AMS2SharedMemoryNet.Enums
{
    public enum YellowFlagState
    {
        YFS_INVALID = -1,
        YFS_NONE,           // No yellow flag pending on track
        YFS_PENDING,        // Flag has been thrown, but not yet taken by leader
        YFS_PITS_CLOSED,    // Flag taken by leader, pits not yet open
        YFS_PIT_LEAD_LAP,   // Those on the lead lap may pit
        YFS_PITS_OPEN,      // Everyone may pit
        YFS_PITS_OPEN2,     // Everyone may pit
        YFS_LAST_LAP,       // On the last caution lap
        YFS_RESUME,         // About to restart (pace car will duck out)
        YFS_RACE_HALT,      // Safety car will lead field into pits
                            //-------------
        YFS_MAXIMUM,
    }
}
