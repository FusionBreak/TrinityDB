using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SceneScript
    {
        public uint Id { get; set; }
        public ushort FirstSceneScriptId { get; set; }
        public ushort NextSceneScriptId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
