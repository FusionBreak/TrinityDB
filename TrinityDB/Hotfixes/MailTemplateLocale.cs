using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MailTemplateLocale
    {
        public uint Id { get; set; }
        public string Locale { get; set; }
        public string BodyLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
