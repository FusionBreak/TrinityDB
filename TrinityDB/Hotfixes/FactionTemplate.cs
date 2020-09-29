using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class FactionTemplate
    {
        public uint Id { get; set; }
        public ushort Faction { get; set; }
        public ushort Flags { get; set; }
        public ushort Enemies1 { get; set; }
        public ushort Enemies2 { get; set; }
        public ushort Enemies3 { get; set; }
        public ushort Enemies4 { get; set; }
        public ushort Friend1 { get; set; }
        public ushort Friend2 { get; set; }
        public ushort Friend3 { get; set; }
        public ushort Friend4 { get; set; }
        public byte FactionGroup { get; set; }
        public byte FriendGroup { get; set; }
        public byte EnemyGroup { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
