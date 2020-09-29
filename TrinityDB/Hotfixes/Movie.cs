using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Movie
    {
        public uint Id { get; set; }
        public uint AudioFileDataId { get; set; }
        public uint SubtitleFileDataId { get; set; }
        public byte Volume { get; set; }
        public byte KeyId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
