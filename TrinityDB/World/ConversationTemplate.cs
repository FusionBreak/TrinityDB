using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ConversationTemplate
    {
        public uint Id { get; set; }
        public uint FirstLineId { get; set; }
        public uint LastLineEndTime { get; set; }
        public string ScriptName { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}
