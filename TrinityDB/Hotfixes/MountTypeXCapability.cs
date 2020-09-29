using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MountTypeXCapability
    {
        public uint Id { get; set; }
        public ushort MountTypeId { get; set; }
        public ushort MountCapabilityId { get; set; }
        public byte OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
