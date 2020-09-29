using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BattlePetSpeciesState
    {
        public uint Id { get; set; }
        public int Value { get; set; }
        public byte BattlePetStateId { get; set; }
        public ushort BattlePetSpeciesId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
