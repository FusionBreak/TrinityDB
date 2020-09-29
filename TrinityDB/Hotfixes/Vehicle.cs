using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Vehicle
    {
        public uint Id { get; set; }
        public int Flags { get; set; }
        public float TurnSpeed { get; set; }
        public float PitchSpeed { get; set; }
        public float PitchMin { get; set; }
        public float PitchMax { get; set; }
        public float MouseLookOffsetPitch { get; set; }
        public float CameraFadeDistScalarMin { get; set; }
        public float CameraFadeDistScalarMax { get; set; }
        public float CameraPitchOffset { get; set; }
        public float FacingLimitRight { get; set; }
        public float FacingLimitLeft { get; set; }
        public float CameraYawOffset { get; set; }
        public ushort SeatId1 { get; set; }
        public ushort SeatId2 { get; set; }
        public ushort SeatId3 { get; set; }
        public ushort SeatId4 { get; set; }
        public ushort SeatId5 { get; set; }
        public ushort SeatId6 { get; set; }
        public ushort SeatId7 { get; set; }
        public ushort SeatId8 { get; set; }
        public ushort VehicleUiindicatorId { get; set; }
        public ushort PowerDisplayId1 { get; set; }
        public ushort PowerDisplayId2 { get; set; }
        public ushort PowerDisplayId3 { get; set; }
        public byte FlagsB { get; set; }
        public byte UiLocomotionType { get; set; }
        public int MissileTargetingId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
