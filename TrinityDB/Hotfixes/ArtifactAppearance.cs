using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactAppearance
    {
        public string Name { get; set; }
        public int UiSwatchColor { get; set; }
        public float UiModelSaturation { get; set; }
        public float UiModelOpacity { get; set; }
        public uint OverrideShapeshiftDisplayId { get; set; }
        public ushort ArtifactAppearanceSetId { get; set; }
        public ushort UiCameraId { get; set; }
        public byte DisplayIndex { get; set; }
        public byte ItemAppearanceModifierId { get; set; }
        public byte Flags { get; set; }
        public byte OverrideShapeshiftFormId { get; set; }
        public uint Id { get; set; }
        public uint UnlockPlayerConditionId { get; set; }
        public uint UiItemAppearanceId { get; set; }
        public uint UiAltItemAppearanceId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
