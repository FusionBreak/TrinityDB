using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TransmogSet
    {
        public string Name { get; set; }
        public ushort ParentTransmogSetId { get; set; }
        public short UiOrder { get; set; }
        public byte ExpansionId { get; set; }
        public uint Id { get; set; }
        public int Flags { get; set; }
        public uint TrackingQuestId { get; set; }
        public int ClassMask { get; set; }
        public int ItemNameDescriptionId { get; set; }
        public uint TransmogSetGroupId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
