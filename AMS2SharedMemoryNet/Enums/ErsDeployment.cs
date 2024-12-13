namespace AMS2SharedMemoryNet.Enums
{
    public enum ErsDeployment
    {
        ERS_DEPLOYMENT_MODE_NONE = 0, // The vehicle does not support deployment modes
        ERS_DEPLOYMENT_MODE_OFF, // Regen only, no deployment
        ERS_DEPLOYMENT_MODE_BUILD, // Heavy emphasis towards regen
        ERS_DEPLOYMENT_MODE_BALANCED, // Deployment map automatically adjusted to try and maintain target SoC
        ERS_DEPLOYMENT_MODE_ATTACK,  // More aggressive deployment, no target SoC
        ERS_DEPLOYMENT_MODE_QUAL, // Maximum deployment, no target Socwwwwww
    }
}
