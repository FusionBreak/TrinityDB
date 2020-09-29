using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class NameGen
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public byte RaceId { get; set; }
        public byte Sex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
