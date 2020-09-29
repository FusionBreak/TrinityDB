using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class QuestSort
    {
        public uint Id { get; set; }
        public string SortName { get; set; }
        public sbyte UiOrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
