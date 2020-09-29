using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Creature
    {
        public uint Id { get; set; }
        public uint ItemId1 { get; set; }
        public uint ItemId2 { get; set; }
        public uint ItemId3 { get; set; }
        public uint Mount { get; set; }
        public uint DisplayId1 { get; set; }
        public uint DisplayId2 { get; set; }
        public uint DisplayId3 { get; set; }
        public uint DisplayId4 { get; set; }
        public float DisplayIdprobability1 { get; set; }
        public float DisplayIdprobability2 { get; set; }
        public float DisplayIdprobability3 { get; set; }
        public float DisplayIdprobability4 { get; set; }
        public string Name { get; set; }
        public string FemaleName { get; set; }
        public string SubName { get; set; }
        public string FemaleSubName { get; set; }
        public uint Type { get; set; }
        public byte Family { get; set; }
        public byte Classification { get; set; }
        public byte InhabitType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
