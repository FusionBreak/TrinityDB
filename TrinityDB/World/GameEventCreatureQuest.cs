using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameEventCreatureQuest
    {
        public byte EventEntry { get; set; }
        public uint Id { get; set; }
        public uint Quest { get; set; }
    }
}
