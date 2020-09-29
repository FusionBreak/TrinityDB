using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellRangeLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string DisplayNameLang { get; set; }
        public string DisplayNameShortLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
