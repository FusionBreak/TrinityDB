using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ConversationLine
    {
        public uint Id { get; set; }
        public uint BroadcastTextId { get; set; }
        public uint SpellVisualKitId { get; set; }
        public int AdditionalDuration { get; set; }
        public ushort NextConversationLineId { get; set; }
        public ushort AnimKitId { get; set; }
        public byte SpeechType { get; set; }
        public byte StartAnimation { get; set; }
        public byte EndAnimation { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
