using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CriteriaTree
    {
        public uint Id { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public short Flags { get; set; }
        public sbyte Operator { get; set; }
        public uint CriteriaId { get; set; }
        public uint Parent { get; set; }
        public int OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
