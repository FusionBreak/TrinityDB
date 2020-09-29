using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterQueststatusObjectivesCriteriaProgress
    {
        public ulong Guid { get; set; }
        public uint CriteriaId { get; set; }
        public ulong Counter { get; set; }
        public uint Date { get; set; }
    }
}
