using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrBuilding
    {
        public uint Id { get; set; }
        public string AllianceName { get; set; }
        public string HordeName { get; set; }
        public string Description { get; set; }
        public string Tooltip { get; set; }
        public int HordeGameObjectId { get; set; }
        public int AllianceGameObjectId { get; set; }
        public int IconFileDataId { get; set; }
        public ushort CurrencyTypeId { get; set; }
        public ushort HordeUiTextureKitId { get; set; }
        public ushort AllianceUiTextureKitId { get; set; }
        public ushort AllianceSceneScriptPackageId { get; set; }
        public ushort HordeSceneScriptPackageId { get; set; }
        public ushort GarrAbilityId { get; set; }
        public ushort BonusGarrAbilityId { get; set; }
        public ushort GoldCost { get; set; }
        public byte GarrSiteId { get; set; }
        public byte BuildingType { get; set; }
        public byte UpgradeLevel { get; set; }
        public byte Flags { get; set; }
        public byte ShipmentCapacity { get; set; }
        public byte GarrTypeId { get; set; }
        public int BuildSeconds { get; set; }
        public int CurrencyQty { get; set; }
        public int MaxAssignments { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
