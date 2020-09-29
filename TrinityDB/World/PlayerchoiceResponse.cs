using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PlayerchoiceResponse
    {
        public int ChoiceId { get; set; }
        public int ResponseId { get; set; }
        public uint Index { get; set; }
        public int ChoiceArtFileId { get; set; }
        public string Header { get; set; }
        public string Answer { get; set; }
        public string Description { get; set; }
        public string Confirmation { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
