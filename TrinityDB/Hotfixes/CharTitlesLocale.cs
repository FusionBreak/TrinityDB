using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CharTitlesLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string NameLang { get; set; }
        public string Name1Lang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
