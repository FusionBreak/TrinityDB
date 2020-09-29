using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MountCapability
    {
        public int ReqSpellKnownId { get; set; }
        public int ModSpellAuraId { get; set; }
        public ushort ReqRidingSkill { get; set; }
        public ushort ReqAreaId { get; set; }
        public short ReqMapId { get; set; }
        public byte Flags { get; set; }
        public uint Id { get; set; }
        public uint ReqSpellAuraId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
