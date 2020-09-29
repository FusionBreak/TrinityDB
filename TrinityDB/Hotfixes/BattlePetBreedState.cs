using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BattlePetBreedState
    {
        public uint Id { get; set; }
        public ushort Value { get; set; }
        public byte BattlePetStateId { get; set; }
        public byte BattlePetBreedId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
