using System.Runtime.InteropServices;

namespace AMS2SharedMemoryNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PInfo
    {
        public byte mIsActive;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] mName;//[STRING_LENGTH_MAX];                   // [ string ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mWorldPosition;// [VEC_MAX];                   // [ UNITS = World Space  X  Y  Z ]
        public float mCurrentLapDistance;                       // [ UNITS = Metres ]   [ RANGE = 0.0f->... ]    [ UNSET = 0.0f ]
        public uint mRacePosition;                      // [ RANGE = 1->... ]   [ UNSET = 0 ]
        public uint mLapsCompleted;                     // [ RANGE = 0->... ]   [ UNSET = 0 ]
        public uint mCurrentLap;                        // [ RANGE = 0->... ]   [ UNSET = 0 ]
        public int vmCurrentSector;
    }
}
