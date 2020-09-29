using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CharacterTemplateClass
    {
        public uint TemplateId { get; set; }
        public byte FactionGroup { get; set; }
        public byte Class { get; set; }
    }
}
