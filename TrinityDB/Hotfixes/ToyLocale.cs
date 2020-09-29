using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ToyLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string SourceTextLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
