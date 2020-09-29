using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlePets
    {
        public long Guid { get; set; }
        public int BattlenetAccountId { get; set; }
        public int Species { get; set; }
        public short Breed { get; set; }
        public short Level { get; set; }
        public short Exp { get; set; }
        public int Health { get; set; }
        public sbyte Quality { get; set; }
        public short Flags { get; set; }
        public string Name { get; set; }
    }
}
