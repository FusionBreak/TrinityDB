using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrBuildingLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string AllianceNameLang { get; set; }
        public string HordeNameLang { get; set; }
        public string DescriptionLang { get; set; }
        public string TooltipLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
