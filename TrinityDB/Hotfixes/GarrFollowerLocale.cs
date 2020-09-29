using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrFollowerLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string HordeSourceTextLang { get; set; }
        public string AllianceSourceTextLang { get; set; }
        public string TitleNameLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
