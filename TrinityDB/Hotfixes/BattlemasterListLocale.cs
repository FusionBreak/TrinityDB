using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BattlemasterListLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string NameLang { get; set; }
        public string GameTypeLang { get; set; }
        public string ShortDescriptionLang { get; set; }
        public string LongDescriptionLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
