using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class EmotesTextSound
    {
        public uint Id { get; set; }
        public byte RaceId { get; set; }
        public byte SexId { get; set; }
        public byte ClassId { get; set; }
        public uint SoundId { get; set; }
        public ushort EmotesTextId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
