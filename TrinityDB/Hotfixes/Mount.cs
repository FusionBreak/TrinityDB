using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Mount
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceText { get; set; }
        public int SourceSpellId { get; set; }
        public float MountFlyRideHeight { get; set; }
        public ushort MountTypeId { get; set; }
        public ushort Flags { get; set; }
        public sbyte SourceTypeEnum { get; set; }
        public uint Id { get; set; }
        public uint PlayerConditionId { get; set; }
        public int UiModelSceneId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
