using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellArea
    {
        public uint Spell { get; set; }
        public uint Area { get; set; }
        public uint QuestStart { get; set; }
        public uint QuestEnd { get; set; }
        public int AuraSpell { get; set; }
        public uint Racemask { get; set; }
        public byte Gender { get; set; }
        public byte Flags { get; set; }
        public int QuestStartStatus { get; set; }
        public int QuestEndStatus { get; set; }
    }
}
