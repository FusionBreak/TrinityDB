using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrSiteLevel
    {
        public uint Id { get; set; }
        public float TownHallUiPosX { get; set; }
        public float TownHallUiPosY { get; set; }
        public ushort MapId { get; set; }
        public ushort UiTextureKitId { get; set; }
        public ushort UpgradeMovieId { get; set; }
        public ushort UpgradeCost { get; set; }
        public ushort UpgradeGoldCost { get; set; }
        public byte GarrLevel { get; set; }
        public byte GarrSiteId { get; set; }
        public byte MaxBuildingLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
