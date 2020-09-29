using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Emotes
    {
        public uint Id { get; set; }
        public long RaceMask { get; set; }
        public string EmoteSlashCommand { get; set; }
        public uint EmoteFlags { get; set; }
        public uint SpellVisualKitId { get; set; }
        public short AnimId { get; set; }
        public byte EmoteSpecProc { get; set; }
        public int ClassMask { get; set; }
        public uint EmoteSpecProcParam { get; set; }
        public uint EventSoundId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
