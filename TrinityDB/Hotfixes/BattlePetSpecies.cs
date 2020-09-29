using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BattlePetSpecies
    {
        public string SourceText { get; set; }
        public string Description { get; set; }
        public int CreatureId { get; set; }
        public int IconFileDataId { get; set; }
        public int SummonSpellId { get; set; }
        public ushort Flags { get; set; }
        public byte PetTypeEnum { get; set; }
        public sbyte SourceTypeEnum { get; set; }
        public uint Id { get; set; }
        public int CardUimodelSceneId { get; set; }
        public int LoadoutUimodelSceneId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
