using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class UnitPowerBarLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string NameLang { get; set; }
        public string CostLang { get; set; }
        public string OutOfErrorLang { get; set; }
        public string ToolTipLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
