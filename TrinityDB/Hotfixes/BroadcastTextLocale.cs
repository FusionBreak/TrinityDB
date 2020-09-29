using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BroadcastTextLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string TextLang { get; set; }
        public string Text1Lang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
