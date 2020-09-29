using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PetNameGeneration
    {
        public uint Id { get; set; }
        public string Word { get; set; }
        public uint Entry { get; set; }
        public byte Half { get; set; }
    }
}
