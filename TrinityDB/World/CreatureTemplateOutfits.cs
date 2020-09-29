using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureTemplateOutfits
    {
        public uint Entry { get; set; }
        public uint Npcsoundsid { get; set; }
        public byte Race { get; set; }
        public byte Class { get; set; }
        public byte Gender { get; set; }
        public byte Skin { get; set; }
        public byte Face { get; set; }
        public byte Hair { get; set; }
        public byte Haircolor { get; set; }
        public byte Facialhair { get; set; }
        public byte Feature1 { get; set; }
        public byte Feature2 { get; set; }
        public byte Feature3 { get; set; }
        public long Head { get; set; }
        public uint HeadAppearance { get; set; }
        public long Shoulders { get; set; }
        public uint ShouldersAppearance { get; set; }
        public long Body { get; set; }
        public uint BodyAppearance { get; set; }
        public long Chest { get; set; }
        public uint ChestAppearance { get; set; }
        public long Waist { get; set; }
        public uint WaistAppearance { get; set; }
        public long Legs { get; set; }
        public uint LegsAppearance { get; set; }
        public long Feet { get; set; }
        public uint FeetAppearance { get; set; }
        public long Wrists { get; set; }
        public uint WristsAppearance { get; set; }
        public long Hands { get; set; }
        public uint HandsAppearance { get; set; }
        public long Back { get; set; }
        public uint BackAppearance { get; set; }
        public long Tabard { get; set; }
        public uint TabardAppearance { get; set; }
        public ulong Guildid { get; set; }
        public string Description { get; set; }
    }
}
