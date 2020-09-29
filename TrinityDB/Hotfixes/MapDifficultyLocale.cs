using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MapDifficultyLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string MessageLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
