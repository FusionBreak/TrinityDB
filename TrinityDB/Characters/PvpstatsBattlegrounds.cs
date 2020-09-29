using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class PvpstatsBattlegrounds
    {
        public ulong Id { get; set; }
        public sbyte WinnerFaction { get; set; }
        public byte BracketId { get; set; }
        public byte Type { get; set; }
        public DateTime Date { get; set; }
    }
}
