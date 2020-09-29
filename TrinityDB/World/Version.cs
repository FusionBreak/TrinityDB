using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class Version
    {
        public string CoreVersion { get; set; }
        public string CoreRevision { get; set; }
        public string DbVersion { get; set; }
        public int? CacheId { get; set; }
        public int HotfixCacheId { get; set; }
    }
}
