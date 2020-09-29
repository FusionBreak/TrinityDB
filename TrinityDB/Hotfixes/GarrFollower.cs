using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrFollower
    {
        public string HordeSourceText { get; set; }
        public string AllianceSourceText { get; set; }
        public string TitleName { get; set; }
        public int HordeCreatureId { get; set; }
        public int AllianceCreatureId { get; set; }
        public int HordeIconFileDataId { get; set; }
        public int AllianceIconFileDataId { get; set; }
        public uint HordeSlottingBroadcastTextId { get; set; }
        public uint AllySlottingBroadcastTextId { get; set; }
        public ushort HordeGarrFollItemSetId { get; set; }
        public ushort AllianceGarrFollItemSetId { get; set; }
        public ushort ItemLevelWeapon { get; set; }
        public ushort ItemLevelArmor { get; set; }
        public ushort HordeUitextureKitId { get; set; }
        public ushort AllianceUitextureKitId { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public byte HordeGarrFollRaceId { get; set; }
        public byte AllianceGarrFollRaceId { get; set; }
        public byte Quality { get; set; }
        public byte HordeGarrClassSpecId { get; set; }
        public byte AllianceGarrClassSpecId { get; set; }
        public byte FollowerLevel { get; set; }
        public byte Gender { get; set; }
        public byte Flags { get; set; }
        public sbyte HordeSourceTypeEnum { get; set; }
        public sbyte AllianceSourceTypeEnum { get; set; }
        public byte GarrTypeId { get; set; }
        public byte Vitality { get; set; }
        public byte ChrClassId { get; set; }
        public byte HordeFlavorGarrStringId { get; set; }
        public byte AllianceFlavorGarrStringId { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
