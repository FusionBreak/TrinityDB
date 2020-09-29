using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ConversationActorTemplate
    {
        public uint Id { get; set; }
        public uint CreatureId { get; set; }
        public uint CreatureModelId { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}
