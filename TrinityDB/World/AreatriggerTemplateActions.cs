using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class AreatriggerTemplateActions
    {
        public uint AreaTriggerId { get; set; }
        public uint ActionType { get; set; }
        public uint ActionParam { get; set; }
        public uint TargetType { get; set; }
    }
}
