using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class UnitPowerBar
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string OutOfError { get; set; }
        public string ToolTip { get; set; }
        public float RegenerationPeace { get; set; }
        public float RegenerationCombat { get; set; }
        public int FileDataId1 { get; set; }
        public int FileDataId2 { get; set; }
        public int FileDataId3 { get; set; }
        public int FileDataId4 { get; set; }
        public int FileDataId5 { get; set; }
        public int FileDataId6 { get; set; }
        public int Color1 { get; set; }
        public int Color2 { get; set; }
        public int Color3 { get; set; }
        public int Color4 { get; set; }
        public int Color5 { get; set; }
        public int Color6 { get; set; }
        public float StartInset { get; set; }
        public float EndInset { get; set; }
        public ushort StartPower { get; set; }
        public ushort Flags { get; set; }
        public byte CenterPower { get; set; }
        public byte BarType { get; set; }
        public uint MinPower { get; set; }
        public uint MaxPower { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
