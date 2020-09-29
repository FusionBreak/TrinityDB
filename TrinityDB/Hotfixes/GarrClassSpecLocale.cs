using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrClassSpecLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string ClassSpecLang { get; set; }
        public string ClassSpecMaleLang { get; set; }
        public string ClassSpecFemaleLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
