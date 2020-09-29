using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameEventPrerequisite
    {
        public byte EventEntry { get; set; }
        public uint PrerequisiteEvent { get; set; }
    }
}
