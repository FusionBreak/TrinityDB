using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Achievement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Reward { get; set; }
        public int Flags { get; set; }
        public short InstanceId { get; set; }
        public short Supercedes { get; set; }
        public short Category { get; set; }
        public short UiOrder { get; set; }
        public short SharesCriteria { get; set; }
        public sbyte Faction { get; set; }
        public sbyte Points { get; set; }
        public sbyte MinimumCriteria { get; set; }
        public uint Id { get; set; }
        public int IconFileId { get; set; }
        public uint CriteriaTree { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
