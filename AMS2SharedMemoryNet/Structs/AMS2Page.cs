using System.Runtime.InteropServices;

namespace AMS2SharedMemoryNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AMS2Page
    {
        public uint mVersion;                           // [ RANGE = 0->... ]
        public uint mBuildVersionNumber;                // [ RANGE = 0->... ]   [ UNSET = 0 ]

        // Game States
        public uint mGameState;                         // [ enum (Type#1) Game state ]
        public uint mSessionState;                      // [ enum (Type#2) Session state ]
        public uint mRaceState;                         // [ enum (Type#3) Race State ]

        // Participant Info
        public int mViewedParticipantIndex;                                  // [ RANGE = 0->STORED_PARTICIPANTS_MAX ]   [ UNSET = -1 ]
        public int mNumParticipants;                                         // [ RANGE = 0->STORED_PARTICIPANTS_MAX ]   [ UNSET = -1 ]

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public PInfo[] mParticipantInfo;// [STORED_PARTICIPANTS_MAX];    // [ struct (Type#13) ParticipantInfo struct ]

        // Unfiltered Input
        public float mUnfilteredThrottle;                        // [ RANGE = 0.0f->1.0f ]
        public float mUnfilteredBrake;                           // [ RANGE = 0.0f->1.0f ]
        public float mUnfilteredSteering;                        // [ RANGE = -1.0f->1.0f ]
        public float mUnfilteredClutch;                          // [ RANGE = 0.0f->1.0f ]

        // Vehicle information
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] mCarName;//[STRING_LENGTH_MAX];                 // [ string ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] mCarClassName;// [STRING_LENGTH_MAX];            // [ string ]

        // Event information
        public uint mLapsInEvent;                        // [ RANGE = 0->... ]   [ UNSET = 0 ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] mTrackLocation;// [STRING_LENGTH_MAX];           // [ string ] - untranslated shortened English name
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] mTrackVariation;// [STRING_LENGTH_MAX];          // [ string ]- untranslated shortened English variation description
        public float mTrackLength;                               // [ UNITS = Metres ]   [ RANGE = 0.0f->... ]    [ UNSET = 0.0f ]

        // Timings
        public int mNumSectors;                                  // [ RANGE = 0->... ]   [ UNSET = -1 ]
        public byte mLapInvalidated;                             // [ UNITS = boolean ]   [ RANGE = false->true ]   [ UNSET = false ]
        public float mBestLapTime;                               // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mLastLapTime;                               // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mCurrentTime;                               // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mSplitTimeAhead;                            // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mSplitTimeBehind;                           // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mSplitTime;                                 // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mEventTimeRemaining;                        // [ UNITS = milli-seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mPersonalFastestLapTime;                    // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mWorldFastestLapTime;                       // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mCurrentSector1Time;                        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mCurrentSector2Time;                        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mCurrentSector3Time;                        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mFastestSector1Time;                        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mFastestSector2Time;                        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mFastestSector3Time;                        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mPersonalFastestSector1Time;                // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mPersonalFastestSector2Time;                // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mPersonalFastestSector3Time;                // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mWorldFastestSector1Time;                   // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mWorldFastestSector2Time;                   // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public float mWorldFastestSector3Time;                   // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]

        // Flags
        public uint mHighestFlagColour;                 // [ enum (Type#5) Flag Colour ]
        public uint mHighestFlagReason;                 // [ enum (Type#6) Flag Reason ]

        // Pit Info
        public uint mPitMode;                           // [ enum (Type#7) Pit Mode ]
        public uint mPitSchedule;                       // [ enum (Type#8) Pit Stop Schedule ]

        // Car State
        public uint mCarFlags;                          // [ enum (Type#9) Car Flags ]
        public float mOilTempCelsius;                           // [ UNITS = Celsius ]   [ UNSET = 0.0f ]
        public float mOilPressureKPa;                           // [ UNITS = Kilopascal ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mWaterTempCelsius;                         // [ UNITS = Celsius ]   [ UNSET = 0.0f ]
        public float mWaterPressureKPa;                         // [ UNITS = Kilopascal ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mFuelPressureKPa;                          // [ UNITS = Kilopascal ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mFuelLevel;                                // [ RANGE = 0.0f->1.0f ]
        public float mFuelCapacity;                             // [ UNITS = Liters ]   [ RANGE = 0.0f->1.0f ]   [ UNSET = 0.0f ]
        public float mSpeed;                                    // [ UNITS = Metres per-second ]   [ RANGE = 0.0f->... ]
        public float mRpm;                                      // [ UNITS = Revolutions per minute ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mMaxRPM;                                   // [ UNITS = Revolutions per minute ]   [ RANGE = 0.0f->... ]   [ UNSET = 0.0f ]
        public float mBrake;                                    // [ RANGE = 0.0f->1.0f ]
        public float mThrottle;                                 // [ RANGE = 0.0f->1.0f ]
        public float mClutch;                                   // [ RANGE = 0.0f->1.0f ]
        public float mSteering;                                 // [ RANGE = -1.0f->1.0f ]
        public int mGear;                                       // [ RANGE = -1 (Reverse)  0 (Neutral)  1 (Gear 1)  2 (Gear 2)  etc... ]   [ UNSET = 0 (Neutral) ]
        public int mNumGears;                                   // [ RANGE = 0->... ]   [ UNSET = -1 ]
        public float mOdometerKM;                               // [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        public byte mAntiLockActive;                            // [ UNITS = boolean ]   [ RANGE = false->true ]   [ UNSET = false ]
        public int mLastOpponentCollisionIndex;                 // [ RANGE = 0->STORED_PARTICIPANTS_MAX ]   [ UNSET = -1 ]
        public float mLastOpponentCollisionMagnitude;           // [ RANGE = 0.0f->... ]
        public byte mBoostActive;                               // [ UNITS = boolean ]   [ RANGE = false->true ]   [ UNSET = false ]
        public float mBoostAmount;                              // [ RANGE = 0.0f->100.0f ] 

        // Motion & Device Related
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mOrientation;// [VEC_MAX];                     // [ UNITS = Euler Angles ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mLocalVelocity;//[VEC_MAX];                   // [ UNITS = Metres per-second ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mWorldVelocity;// [VEC_MAX];                   // [ UNITS = Metres per-second ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mAngularVelocity;//[VEC_MAX];                 // [ UNITS = Radians per-second ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mLocalAcceleration;// [VEC_MAX];               // [ UNITS = Metres per-second ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mWorldAcceleration;// [VEC_MAX];               // [ UNITS = Metres per-second ]#
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] mExtentsCentre;// [VEC_MAX];                   // [ UNITS = Local Space  X  Y  Z ]

        // Wheels / Tyres
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] mTyreFlags;// [TYRE_MAX];               // [ enum (Type#10) Tyre Flags ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] mTerrain;// [TYRE_MAX];                 // [ enum (Type#11) Terrain Materials ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreY;// [TYRE_MAX];                          // [ UNITS = Local Space  Y ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreRPS;// [TYRE_MAX];                        // [ UNITS = Revolutions per second ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreSlipSpeed;// [TYRE_MAX];                  // OBSOLETE, kept for backward compatibility only
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreTemp;// [TYRE_MAX];                       // [ UNITS = Celsius ]   [ UNSET = 0.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreGrip;// [TYRE_MAX];                       // OBSOLETE, kept for backward compatibility only
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreHeightAboveGround;// [TYRE_MAX];          // [ UNITS = Local Space  Y ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreLateralStiffness;// [TYRE_MAX];           // OBSOLETE, kept for backward compatibility only
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreWear;// [TYRE_MAX];                       // [ RANGE = 0.0f->1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mBrakeDamage;// [TYRE_MAX];                    // [ RANGE = 0.0f->1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mSuspensionDamage;// [TYRE_MAX];               // [ RANGE = 0.0f->1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mBrakeTempCelsius;// [TYRE_MAX];               // [ UNITS = Celsius ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreTreadTemp;// [TYRE_MAX];                  // [ UNITS = Kelvin ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreLayerTemp;// [TYRE_MAX];                  // [ UNITS = Kelvin ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreCarcassTemp;// [TYRE_MAX];                // [ UNITS = Kelvin ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreRimTemp;// [TYRE_MAX];                    // [ UNITS = Kelvin ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreInternalAirTemp;// [TYRE_MAX];            // [ UNITS = Kelvin ]

        // Car Damage
        public uint mCrashState;                        // [ enum (Type#12) Crash Damage State ]
        public float mAeroDamage;                               // [ RANGE = 0.0f->1.0f ]
        public float mEngineDamage;                             // [ RANGE = 0.0f->1.0f ]

        // Weather
        public float mAmbientTemperature;                       // [ UNITS = Celsius ]   [ UNSET = 25.0f ]
        public float mTrackTemperature;                         // [ UNITS = Celsius ]   [ UNSET = 30.0f ]
        public float mRainDensity;                              // [ UNITS = How much rain will fall ]   [ RANGE = 0.0f->1.0f ]
        public float mWindSpeed;                                // [ RANGE = 0.0f->100.0f ]   [ UNSET = 2.0f ]
        public float mWindDirectionX;                           // [ UNITS = Normalised Vector X ]
        public float mWindDirectionY;                           // [ UNITS = Normalised Vector Y ]
        public float mCloudBrightness;                          // [ RANGE = 0.0f->... ]

        //PCars2 additions start, version 8
        // Sequence Number to help slightly with data integrity reads
        public uint mSequenceNumber;          // 0 at the start, incremented at start and end of writing, so odd when Shared Memory is being filled, even when the memory is not being touched

        //Additional car variables
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mWheelLocalPositionY;// [TYRE_MAX];           // [ UNITS = Local Space  Y ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mSuspensionTravel;// [TYRE_MAX];              // [ UNITS = meters ] [ RANGE 0.f =>... ]  [ UNSET =  0.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mSuspensionVelocity;// [TYRE_MAX];            // [ UNITS = Rate of change of pushrod deflection ] [ RANGE 0.f =>... ]  [ UNSET =  0.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mAirPressure;// [TYRE_MAX];                   // [ UNITS = PSI ]  [ RANGE 0.f =>... ]  [ UNSET =  0.0f ]
        public float mEngineSpeed;                             // [ UNITS = Rad/s ] [UNSET = 0.f ]
        public float mEngineTorque;                            // [ UNITS = Newton Meters] [UNSET = 0.f ] [ RANGE = 0.0f->... ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] mWings;// [2];                                // [ RANGE = 0.0f->1.0f ] [UNSET = 0.f ]
        public float mHandBrake;                               // [ RANGE = 0.0f->1.0f ] [UNSET = 0.f ]

        // additional race variables
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mCurrentSector1Times;// [STORED_PARTICIPANTS_MAX];        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mCurrentSector2Times;// [STORED_PARTICIPANTS_MAX];        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mCurrentSector3Times;// [STORED_PARTICIPANTS_MAX];        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mFastestSector1Times;// [STORED_PARTICIPANTS_MAX];        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mFastestSector2Times;// [STORED_PARTICIPANTS_MAX];        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mFastestSector3Times;// [STORED_PARTICIPANTS_MAX];        // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mFastestLapTimes;// [STORED_PARTICIPANTS_MAX];            // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mLastLapTimes;// [STORED_PARTICIPANTS_MAX];               // [ UNITS = seconds ]   [ RANGE = 0.0f->... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] mLapsInvalidated;// [STORED_PARTICIPANTS_MAX];            // [ UNITS = boolean for all participants ]   [ RANGE = false->true ]   [ UNSET = false ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] mRaceStates;// [STORED_PARTICIPANTS_MAX];         // [ enum (Type#3) Race State ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] mPitModes;// [STORED_PARTICIPANTS_MAX];           // [ enum (Type#7)  Pit Mode ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 192)]
        public float[] mOrientations;// [STORED_PARTICIPANTS_MAX][VEC_MAX];      // [ UNITS = Euler Angles ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public float[] mSpeeds;// [STORED_PARTICIPANTS_MAX];                     // [ UNITS = Metres per-second ]   [ RANGE = 0.0f->... ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)]
        public char[] mCarNames;// [STORED_PARTICIPANTS_MAX][STRING_LENGTH_MAX]; // [ string ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)]
        public char[] mCarClassNames;// [STORED_PARTICIPANTS_MAX][STRING_LENGTH_MAX]; // [ string ]

        // additional race variables
        public int mEnforcedPitStopLap;                          // [ UNITS = in which lap there will be a mandatory pitstop] [ RANGE = 0.0f->... ] [ UNSET = -1 ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] mTranslatedTrackLocation;// [STRING_LENGTH_MAX];  // [ string ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] mTranslatedTrackVariation;// [STRING_LENGTH_MAX]; // [ string ]
        public float mBrakeBias;                                                                       // [ RANGE = 0.0f->1.0f... ]   [ UNSET = -1.0f ]
        public float mTurboBoostPressure;                                                  //	 RANGE = 0.0f->1.0f... ]   [ UNSET = -1.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 160)]
        public char[] mTyreCompound;// [TYRE_MAX][TYRE_COMPOUND_NAME_LENGTH_MAX];// [ strings  ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] mPitSchedules;// [STORED_PARTICIPANTS_MAX];  // [ enum (Type#7)  Pit Mode ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] mHighestFlagColours;// [STORED_PARTICIPANTS_MAX];                 // [ enum (Type#5) Flag Colour ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] mHighestFlagReasons;// [STORED_PARTICIPANTS_MAX];                 // [ enum (Type#6) Flag Reason ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] mNationalities;// [STORED_PARTICIPANTS_MAX];                                         // [ nationality table , SP AND UNSET = 0 ]
        public float mSnowDensity;                                                             // [ UNITS = How much snow will fall ]   [ RANGE = 0.0f->1.0f ], this is non zero only in Winter and Snow seasons

        // AMS2 Additions (v10...)

        // Session info
        public float mSessionDuration;           // [ UNITS = minutes ]   [ UNSET = 0.0f ]  The scheduled session Length (unset means laps race. See mLapsInEvent)
        public int mSessionAdditionalLaps;     // The number of additional complete laps lead lap drivers must complete to finish a timed race after the session duration has elapsed.

        // Tyres
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreTempLeft;// [TYRE_MAX];    // [ UNITS = Celsius ]   [ UNSET = 0.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreTempCenter;// [TYRE_MAX];  // [ UNITS = Celsius ]   [ UNSET = 0.0f ]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mTyreTempRight;// [TYRE_MAX];   // [ UNITS = Celsius ]   [ UNSET = 0.0f ]

        // DRS
        public uint mDrsState;           // [ enum (Type#14) DrsState ]

        // Suspension
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mRideHeight;// [TYRE_MAX];      // [ UNITS = cm ]

        // Input
        public uint mJoyPad0;            // button mask
        public uint mDPad;               // button mask

        public int mAntiLockSetting;             // [ UNSET = -1 ] Current ABS garage setting. Valid under player control only.
        public int mTractionControlSetting;      // [ UNSET = -1 ] Current ABS garage setting. Valid under player control only.

        // ERS
        public int mErsDeploymentMode;           // [ enum (Type#15)  ErsDeploymentMode ]
        public byte mErsAutoModeEnabled;         // true if the deployment mode was selected by auto system. Valid only when mErsDeploymentMode > ERS_DEPLOYMENT_MODE_NONE

        // Clutch State & Damage
        public float mClutchTemp;                // [ UNITS = Kelvin ] [ UNSET = -273.16 ]
        public float mClutchWear;                // [ RANGE = 0.0f->1.0f... ]
        public byte mClutchOverheated;          // true if clutch performance is degraded due to overheating
        public byte mClutchSlipping;            // true if clutch is slipping (can be induced by overheating or wear)

        public int mYellowFlagState;             // [ enum (Type#16) YellowFlagState ]

        public byte mSessionIsPrivate;           // true if this is a private session where users cannot see or interact with other drivers (and so would not need positional awareness of them etc)
        public int mLaunchStage;                 // [ enum (Type#17) LaunchStage
    }
}
