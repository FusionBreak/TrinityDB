﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class AchievementRewardLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
