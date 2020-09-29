using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ArenaTeamMember
    {
        public uint ArenaTeamId { get; set; }
        public ulong Guid { get; set; }
        public ushort WeekGames { get; set; }
        public ushort WeekWins { get; set; }
        public ushort SeasonGames { get; set; }
        public ushort SeasonWins { get; set; }
        public ushort PersonalRating { get; set; }
    }
}
