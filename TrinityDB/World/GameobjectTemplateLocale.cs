using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameobjectTemplateLocale
    {
        public uint Entry { get; set; }
        public string Locale { get; set; }
        public string Name { get; set; }
        public string CastBarCaption { get; set; }
        public string Unk1 { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
