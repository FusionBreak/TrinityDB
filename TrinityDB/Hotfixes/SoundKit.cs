using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SoundKit
    {
        public uint Id { get; set; }
        public float VolumeFloat { get; set; }
        public float MinDistance { get; set; }
        public float DistanceCutoff { get; set; }
        public ushort Flags { get; set; }
        public ushort SoundEntriesAdvancedId { get; set; }
        public byte SoundType { get; set; }
        public byte DialogType { get; set; }
        public byte Eaxdef { get; set; }
        public float VolumeVariationPlus { get; set; }
        public float VolumeVariationMinus { get; set; }
        public float PitchVariationPlus { get; set; }
        public float PitchVariationMinus { get; set; }
        public float PitchAdjust { get; set; }
        public ushort BusOverwriteId { get; set; }
        public byte MaxInstances { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
