using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Artifact
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int UiBarOverlayColor { get; set; }
        public int UiBarBackgroundColor { get; set; }
        public int UiNameColor { get; set; }
        public ushort UiTextureKitId { get; set; }
        public ushort ChrSpecializationId { get; set; }
        public byte ArtifactCategoryId { get; set; }
        public byte Flags { get; set; }
        public uint UiModelSceneId { get; set; }
        public uint SpellVisualKitId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
