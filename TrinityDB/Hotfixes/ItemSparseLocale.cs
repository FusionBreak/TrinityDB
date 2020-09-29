using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemSparseLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string DisplayLang { get; set; }
        public string Display1Lang { get; set; }
        public string Display2Lang { get; set; }
        public string Display3Lang { get; set; }
        public string DescriptionLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
