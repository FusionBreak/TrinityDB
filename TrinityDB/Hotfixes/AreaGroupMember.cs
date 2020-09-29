using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class AreaGroupMember
    {
        public uint Id { get; set; }
        public ushort AreaId { get; set; }
        public ushort AreaGroupId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
