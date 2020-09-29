using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string NameLang { get; set; }
        public string NameSubtextLang { get; set; }
        public string DescriptionLang { get; set; }
        public string AuraDescriptionLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
