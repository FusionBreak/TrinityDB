using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CreatureDisplayInfo
    {
        public uint Id { get; set; }
        public float CreatureModelScale { get; set; }
        public ushort ModelId { get; set; }
        public ushort NpcsoundId { get; set; }
        public sbyte SizeClass { get; set; }
        public byte Flags { get; set; }
        public sbyte Gender { get; set; }
        public int ExtendedDisplayInfoId { get; set; }
        public int PortraitTextureFileDataId { get; set; }
        public byte CreatureModelAlpha { get; set; }
        public ushort SoundId { get; set; }
        public float PlayerOverrideScale { get; set; }
        public int PortraitCreatureDisplayInfoId { get; set; }
        public byte BloodId { get; set; }
        public ushort ParticleColorId { get; set; }
        public uint CreatureGeosetData { get; set; }
        public ushort ObjectEffectPackageId { get; set; }
        public ushort AnimReplacementSetId { get; set; }
        public sbyte UnarmedWeaponType { get; set; }
        public int StateSpellVisualKitId { get; set; }
        public float PetInstanceScale { get; set; }
        public int MountPoofSpellVisualKitId { get; set; }
        public int TextureVariationFileDataId1 { get; set; }
        public int TextureVariationFileDataId2 { get; set; }
        public int TextureVariationFileDataId3 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
