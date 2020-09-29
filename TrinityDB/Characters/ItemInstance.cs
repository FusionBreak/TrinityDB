using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemInstance
    {
        public ulong Guid { get; set; }
        public uint ItemEntry { get; set; }
        public ulong OwnerGuid { get; set; }
        public ulong CreatorGuid { get; set; }
        public ulong GiftCreatorGuid { get; set; }
        public uint Count { get; set; }
        public int Duration { get; set; }
        public string Charges { get; set; }
        public uint Flags { get; set; }
        public string Enchantments { get; set; }
        public byte RandomPropertyType { get; set; }
        public uint RandomPropertyId { get; set; }
        public ushort Durability { get; set; }
        public uint PlayedTime { get; set; }
        public string Text { get; set; }
        public uint Transmogrification { get; set; }
        public uint UpgradeId { get; set; }
        public uint EnchantIllusion { get; set; }
        public uint BattlePetSpeciesId { get; set; }
        public uint BattlePetBreedData { get; set; }
        public ushort BattlePetLevel { get; set; }
        public uint BattlePetDisplayId { get; set; }
        public byte Context { get; set; }
        public string BonusListIds { get; set; }
    }
}
