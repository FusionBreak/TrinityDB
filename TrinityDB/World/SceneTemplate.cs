using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SceneTemplate
    {
        public uint SceneId { get; set; }
        public uint Flags { get; set; }
        public uint ScriptPackageId { get; set; }
        public string ScriptName { get; set; }
    }
}
