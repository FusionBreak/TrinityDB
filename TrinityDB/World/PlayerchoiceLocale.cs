using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PlayerchoiceLocale
    {
        public int ChoiceId { get; set; }
        public string Locale { get; set; }
        public string Question { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
