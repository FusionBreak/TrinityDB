using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class AchievementLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string TitleLang { get; set; }
        public string DescriptionLang { get; set; }
        public string RewardLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
