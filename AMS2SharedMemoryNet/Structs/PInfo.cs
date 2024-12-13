using System.Runtime.InteropServices;

namespace AMS2SharedMemoryNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PInfo
    {
        byte mIsActive;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        char[] mName;//[STRING_LENGTH_MAX];                   // [ string ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        float[] mWorldPosition;// [VEC_MAX];                   // [ UNITS = World Space  X  Y  Z ]
        float mCurrentLapDistance;                       // [ UNITS = Metres ]   [ RANGE = 0.0f->... ]    [ UNSET = 0.0f ]
        uint mRacePosition;                      // [ RANGE = 1->... ]   [ UNSET = 0 ]
        uint mLapsCompleted;                     // [ RANGE = 0->... ]   [ UNSET = 0 ]
        uint mCurrentLap;                        // [ RANGE = 0->... ]   [ UNSET = 0 ]
        int mCurrentSector;
    }
}
