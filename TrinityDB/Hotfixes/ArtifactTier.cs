using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactTier
    {
        public uint Id { get; set; }
        public uint ArtifactTier1 { get; set; }
        public uint MaxNumTraits { get; set; }
        public uint MaxArtifactKnowledge { get; set; }
        public uint KnowledgePlayerCondition { get; set; }
        public uint MinimumEmpowerKnowledge { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
