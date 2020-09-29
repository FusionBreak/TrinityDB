using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemClassLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string ClassNameLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
