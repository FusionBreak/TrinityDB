﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class TrainerLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string GreetingLang { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
