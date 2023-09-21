using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class Mmoslasher
    {
        public Mmoslasher()
        {
            LoyaltyCharts = new HashSet<LoyaltyChart>();
        }

        public int MmoslasherId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string Expansion1 { get; set; } = null!;
        public string ActiveLast30Days { get; set; } = null!;
        public string OwnMmoslasherGame { get; set; } = null!;

        public virtual ICollection<LoyaltyChart> LoyaltyCharts { get; set; }
    }
}
