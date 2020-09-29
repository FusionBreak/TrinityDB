using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Gameobjects
    {
        public string Name { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Rot1 { get; set; }
        public float Rot2 { get; set; }
        public float Rot3 { get; set; }
        public float Rot4 { get; set; }
        public float Scale { get; set; }
        public int PropValue1 { get; set; }
        public int PropValue2 { get; set; }
        public int PropValue3 { get; set; }
        public int PropValue4 { get; set; }
        public int PropValue5 { get; set; }
        public int PropValue6 { get; set; }
        public int PropValue7 { get; set; }
        public int PropValue8 { get; set; }
        public ushort OwnerId { get; set; }
        public ushort DisplayId { get; set; }
        public ushort PhaseId { get; set; }
        public ushort PhaseGroupId { get; set; }
        public byte PhaseUseFlags { get; set; }
        public byte TypeId { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
