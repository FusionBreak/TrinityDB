using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BroadcastText
    {
        public uint Id { get; set; }
        public string Text { get; set; }
        public string Text1 { get; set; }
        public ushort EmoteId1 { get; set; }
        public ushort EmoteId2 { get; set; }
        public ushort EmoteId3 { get; set; }
        public ushort EmoteDelay1 { get; set; }
        public ushort EmoteDelay2 { get; set; }
        public ushort EmoteDelay3 { get; set; }
        public ushort EmotesId { get; set; }
        public byte LanguageId { get; set; }
        public byte Flags { get; set; }
        public int ConditionId { get; set; }
        public uint SoundEntriesId1 { get; set; }
        public uint SoundEntriesId2 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
