using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlenetAccounts
    {
        public BattlenetAccounts()
        {
            Account = new HashSet<Account>();
            BattlenetItemAppearances = new HashSet<BattlenetItemAppearances>();
            BattlenetItemFavoriteAppearances = new HashSet<BattlenetItemFavoriteAppearances>();
        }

        public uint Id { get; set; }
        public string Email { get; set; }
        public string ShaPassHash { get; set; }
        public DateTime Joindate { get; set; }
        public string LastIp { get; set; }
        public uint FailedLogins { get; set; }
        public byte Locked { get; set; }
        public string LockCountry { get; set; }
        public DateTime? LastLogin { get; set; }
        public byte Online { get; set; }
        public byte Locale { get; set; }
        public string Os { get; set; }
        public uint LastCharacterUndelete { get; set; }
        public string LoginTicket { get; set; }
        public uint? LoginTicketExpiry { get; set; }

        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<BattlenetItemAppearances> BattlenetItemAppearances { get; set; }
        public virtual ICollection<BattlenetItemFavoriteAppearances> BattlenetItemFavoriteAppearances { get; set; }
    }
}
