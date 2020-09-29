using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PlayerConditionLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string FailureDescriptionLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
