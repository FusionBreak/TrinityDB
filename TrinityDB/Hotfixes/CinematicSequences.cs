using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CinematicSequences
    {
        public uint Id { get; set; }
        public uint SoundId { get; set; }
        public ushort Camera1 { get; set; }
        public ushort Camera2 { get; set; }
        public ushort Camera3 { get; set; }
        public ushort Camera4 { get; set; }
        public ushort Camera5 { get; set; }
        public ushort Camera6 { get; set; }
        public ushort Camera7 { get; set; }
        public ushort Camera8 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
