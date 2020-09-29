using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MapLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string MapNameLang { get; set; }
        public string MapDescription0Lang { get; set; }
        public string MapDescription1Lang { get; set; }
        public string PvpShortDescriptionLang { get; set; }
        public string PvpLongDescriptionLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
