using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class AreaTableLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string AreaNameLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
