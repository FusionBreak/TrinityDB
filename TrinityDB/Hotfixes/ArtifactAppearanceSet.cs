using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactAppearanceSet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort UiCameraId { get; set; }
        public ushort AltHandUicameraId { get; set; }
        public byte DisplayIndex { get; set; }
        public sbyte ForgeAttachmentOverride { get; set; }
        public byte Flags { get; set; }
        public uint Id { get; set; }
        public byte ArtifactId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
