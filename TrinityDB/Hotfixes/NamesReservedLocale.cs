using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class NamesReservedLocale
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public byte LocaleMask { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
