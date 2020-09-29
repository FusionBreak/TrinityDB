using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ScenarioStepLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string DescriptionLang { get; set; }
        public string TitleLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
