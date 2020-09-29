using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ChrRacesLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string NameLang { get; set; }
        public string NameFemaleLang { get; set; }
        public string NameLowercaseLang { get; set; }
        public string NameFemaleLowercaseLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
