using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class WmoAreaTable
    {
        public string AreaName { get; set; }
        public int WmoGroupId { get; set; }
        public ushort AmbienceId { get; set; }
        public ushort ZoneMusic { get; set; }
        public ushort IntroSound { get; set; }
        public ushort AreaTableId { get; set; }
        public ushort UwIntroSound { get; set; }
        public ushort UwAmbience { get; set; }
        public byte NameSetId { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public byte Flags { get; set; }
        public uint Id { get; set; }
        public uint UwZoneMusic { get; set; }
        public ushort WmoId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
