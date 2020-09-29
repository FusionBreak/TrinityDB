using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterDeclinedname
    {
        public ulong Guid { get; set; }
        public string Genitive { get; set; }
        public string Dative { get; set; }
        public string Accusative { get; set; }
        public string Instrumental { get; set; }
        public string Prepositional { get; set; }
    }
}
