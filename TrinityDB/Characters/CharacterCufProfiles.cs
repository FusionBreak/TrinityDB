using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterCufProfiles
    {
        public ulong Guid { get; set; }
        public byte Id { get; set; }
        public string Name { get; set; }
        public ushort FrameHeight { get; set; }
        public ushort FrameWidth { get; set; }
        public byte SortBy { get; set; }
        public byte HealthText { get; set; }
        public uint BoolOptions { get; set; }
        public byte TopPoint { get; set; }
        public byte BottomPoint { get; set; }
        public byte LeftPoint { get; set; }
        public ushort TopOffset { get; set; }
        public ushort BottomOffset { get; set; }
        public ushort LeftOffset { get; set; }
    }
}
