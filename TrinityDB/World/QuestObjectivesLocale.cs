using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class QuestObjectivesLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public uint QuestId { get; set; }
        public sbyte StorageIndex { get; set; }
        public string Description { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
