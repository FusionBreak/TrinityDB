using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ChrClassesXPowerTypes
    {
        public uint Id { get; set; }
        public byte PowerType { get; set; }
        public byte ClassId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
