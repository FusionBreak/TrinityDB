using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ChrClassesLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string NameLang { get; set; }
        public string NameFemaleLang { get; set; }
        public string NameMaleLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
