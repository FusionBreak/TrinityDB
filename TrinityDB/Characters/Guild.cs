using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class Guild
    {
        public ulong Guildid { get; set; }
        public string Name { get; set; }
        public ulong Leaderguid { get; set; }
        public byte EmblemStyle { get; set; }
        public byte EmblemColor { get; set; }
        public byte BorderStyle { get; set; }
        public byte BorderColor { get; set; }
        public byte BackgroundColor { get; set; }
        public string Info { get; set; }
        public string Motd { get; set; }
        public uint Createdate { get; set; }
        public ulong BankMoney { get; set; }
    }
}
