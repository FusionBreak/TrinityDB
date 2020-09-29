using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class QuestXp
    {
        public uint Id { get; set; }
        public ushort Difficulty1 { get; set; }
        public ushort Difficulty2 { get; set; }
        public ushort Difficulty3 { get; set; }
        public ushort Difficulty4 { get; set; }
        public ushort Difficulty5 { get; set; }
        public ushort Difficulty6 { get; set; }
        public ushort Difficulty7 { get; set; }
        public ushort Difficulty8 { get; set; }
        public ushort Difficulty9 { get; set; }
        public ushort Difficulty10 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
