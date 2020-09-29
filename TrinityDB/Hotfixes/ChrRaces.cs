using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ChrRaces
    {
        public string ClientPrefix { get; set; }
        public string ClientFileString { get; set; }
        public string Name { get; set; }
        public string NameFemale { get; set; }
        public string NameLowercase { get; set; }
        public string NameFemaleLowercase { get; set; }
        public int Flags { get; set; }
        public uint MaleDisplayId { get; set; }
        public uint FemaleDisplayId { get; set; }
        public int CreateScreenFileDataId { get; set; }
        public int SelectScreenFileDataId { get; set; }
        public float MaleCustomizeOffset1 { get; set; }
        public float MaleCustomizeOffset2 { get; set; }
        public float MaleCustomizeOffset3 { get; set; }
        public float FemaleCustomizeOffset1 { get; set; }
        public float FemaleCustomizeOffset2 { get; set; }
        public float FemaleCustomizeOffset3 { get; set; }
        public int LowResScreenFileDataId { get; set; }
        public int StartingLevel { get; set; }
        public int UiDisplayOrder { get; set; }
        public short FactionId { get; set; }
        public short ResSicknessSpellId { get; set; }
        public short SplashSoundId { get; set; }
        public short CinematicSequenceId { get; set; }
        public sbyte BaseLanguage { get; set; }
        public sbyte CreatureType { get; set; }
        public sbyte Alliance { get; set; }
        public sbyte RaceRelated { get; set; }
        public sbyte UnalteredVisualRaceId { get; set; }
        public sbyte CharComponentTextureLayoutId { get; set; }
        public sbyte DefaultClassId { get; set; }
        public sbyte NeutralRaceId { get; set; }
        public sbyte DisplayRaceId { get; set; }
        public sbyte CharComponentTexLayoutHiResId { get; set; }
        public uint Id { get; set; }
        public uint HighResMaleDisplayId { get; set; }
        public uint HighResFemaleDisplayId { get; set; }
        public int HeritageArmorAchievementId { get; set; }
        public int MaleSkeletonFileDataId { get; set; }
        public int FemaleSkeletonFileDataId { get; set; }
        public uint AlteredFormStartVisualKitId1 { get; set; }
        public uint AlteredFormStartVisualKitId2 { get; set; }
        public uint AlteredFormStartVisualKitId3 { get; set; }
        public uint AlteredFormFinishVisualKitId1 { get; set; }
        public uint AlteredFormFinishVisualKitId2 { get; set; }
        public uint AlteredFormFinishVisualKitId3 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
