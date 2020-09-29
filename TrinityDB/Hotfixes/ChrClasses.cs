using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ChrClasses
    {
        public string PetNameToken { get; set; }
        public string Name { get; set; }
        public string NameFemale { get; set; }
        public string NameMale { get; set; }
        public string Filename { get; set; }
        public uint CreateScreenFileDataId { get; set; }
        public uint SelectScreenFileDataId { get; set; }
        public uint LowResScreenFileDataId { get; set; }
        public uint IconFileDataId { get; set; }
        public int StartingLevel { get; set; }
        public ushort Flags { get; set; }
        public ushort CinematicSequenceId { get; set; }
        public ushort DefaultSpec { get; set; }
        public byte DisplayPower { get; set; }
        public byte SpellClassSet { get; set; }
        public byte AttackPowerPerStrength { get; set; }
        public byte AttackPowerPerAgility { get; set; }
        public byte RangedAttackPowerPerAgility { get; set; }
        public byte PrimaryStatPriority { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
