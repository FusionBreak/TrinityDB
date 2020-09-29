using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class InstanceScenarioProgress
    {
        public uint Id { get; set; }
        public uint Criteria { get; set; }
        public ulong Counter { get; set; }
        public uint Date { get; set; }
    }
}
