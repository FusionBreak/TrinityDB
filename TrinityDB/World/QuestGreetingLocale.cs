using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class QuestGreetingLocale
    {
        public uint Id { get; set; }
        public byte Type { get; set; }
        public string Locale { get; set; }
        public string Greeting { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
