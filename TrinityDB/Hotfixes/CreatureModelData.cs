using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CreatureModelData
    {
        public uint Id { get; set; }
        public float ModelScale { get; set; }
        public float FootprintTextureLength { get; set; }
        public float FootprintTextureWidth { get; set; }
        public float FootprintParticleScale { get; set; }
        public float CollisionWidth { get; set; }
        public float CollisionHeight { get; set; }
        public float MountHeight { get; set; }
        public float GeoBox1 { get; set; }
        public float GeoBox2 { get; set; }
        public float GeoBox3 { get; set; }
        public float GeoBox4 { get; set; }
        public float GeoBox5 { get; set; }
        public float GeoBox6 { get; set; }
        public float WorldEffectScale { get; set; }
        public float AttachedEffectScale { get; set; }
        public float MissileCollisionRadius { get; set; }
        public float MissileCollisionPush { get; set; }
        public float MissileCollisionRaise { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
        public float OverrideSelectionRadius { get; set; }
        public float TamedPetBaseScale { get; set; }
        public float HoverHeight { get; set; }
        public uint Flags { get; set; }
        public uint FileDataId { get; set; }
        public uint SizeClass { get; set; }
        public uint BloodId { get; set; }
        public uint FootprintTextureId { get; set; }
        public uint FoleyMaterialId { get; set; }
        public uint FootstepCameraEffectId { get; set; }
        public uint DeathThudCameraEffectId { get; set; }
        public uint SoundId { get; set; }
        public uint CreatureGeosetDataId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
