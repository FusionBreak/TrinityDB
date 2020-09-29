using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class QuestSortLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string SortNameLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
