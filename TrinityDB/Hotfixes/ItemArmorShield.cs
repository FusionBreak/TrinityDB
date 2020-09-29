using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemArmorShield
    {
        public uint Id { get; set; }
        public float Quality1 { get; set; }
        public float Quality2 { get; set; }
        public float Quality3 { get; set; }
        public float Quality4 { get; set; }
        public float Quality5 { get; set; }
        public float Quality6 { get; set; }
        public float Quality7 { get; set; }
        public ushort ItemLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
