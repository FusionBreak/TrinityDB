using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MailTemplate
    {
        public uint Id { get; set; }
        public string Body { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
