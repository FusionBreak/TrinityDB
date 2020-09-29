using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemSearchNameLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string DisplayLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
