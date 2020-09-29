using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CharacterTemplate
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Level { get; set; }
    }
}
