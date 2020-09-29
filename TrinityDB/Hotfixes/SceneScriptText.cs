using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SceneScriptText
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Script { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
