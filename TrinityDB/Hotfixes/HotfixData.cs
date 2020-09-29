using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class HotfixData
    {
        public int Id { get; set; }
        public uint TableHash { get; set; }
        public int RecordId { get; set; }
        public byte? Deleted { get; set; }
    }
}
