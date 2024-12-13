namespace AMS2SharedMemoryNet.Enums
{
    internal enum DrsState
    {
        DRS_INSTALLED = 1 << 0,  // Vehicle has DRS capability
        DRS_ZONE_RULES = 1 << 1,  // 1 if DRS uses F1 style rules
        DRS_AVAILABLE_NEXT = 1 << 2,  // detection zone was triggered (only applies to f1 style rules)
        DRS_AVAILABLE_NOW = 1 << 3,  // detection zone was triggered and we are now in the zone (only applies to f1 style rules)
        DRS_ACTIVE = 1 << 4,  // Wing is in activated state
    }
}
