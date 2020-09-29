using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ConversationLineTemplate
    {
        public uint Id { get; set; }
        public uint StartTime { get; set; }
        public uint UiCameraId { get; set; }
        public byte ActorIdx { get; set; }
        public byte Flags { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}
