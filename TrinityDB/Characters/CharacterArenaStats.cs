using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterArenaStats
    {
        public long Guid { get; set; }
        public sbyte Slot { get; set; }
        public short MatchMakerRating { get; set; }
    }
}
