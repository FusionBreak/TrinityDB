using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CriteriaData
    {
        public int CriteriaId { get; set; }
        public byte Type { get; set; }
        public uint Value1 { get; set; }
        public uint Value2 { get; set; }
        public string ScriptName { get; set; }
    }
}
