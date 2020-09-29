using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemArmorTotal
    {
        public uint Id { get; set; }
        public float Cloth { get; set; }
        public float Leather { get; set; }
        public float Mail { get; set; }
        public float Plate { get; set; }
        public short ItemLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
