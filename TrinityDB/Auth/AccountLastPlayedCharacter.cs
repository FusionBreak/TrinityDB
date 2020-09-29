using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class AccountLastPlayedCharacter
    {
        public uint AccountId { get; set; }
        public byte Region { get; set; }
        public byte Battlegroup { get; set; }
        public uint? RealmId { get; set; }
        public string CharacterName { get; set; }
        public ulong? CharacterGuid { get; set; }
        public uint? LastPlayedTime { get; set; }
    }
}
