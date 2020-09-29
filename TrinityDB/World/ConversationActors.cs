using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ConversationActors
    {
        public uint ConversationId { get; set; }
        public uint ConversationActorId { get; set; }
        public ulong ConversationActorGuid { get; set; }
        public ushort Idx { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}
