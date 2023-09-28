using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class Mmoslasher
    {

        public int MmoslasherId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string Expansion1 { get; set; } = null!;
        public string ActiveLast30Days { get; set; } = null!;
        public string OwnMmoslasherGame { get; set; } = null!;

        public virtual ICollection<LoyaltyChart> LoyaltyCharts { get; set; }

        public Mmoslasher(int mmoslasherId, string userName, TimeSpan timePlayed, string expansion1, string activeLast30Days, string ownMmoslasherGame, ICollection<LoyaltyChart> loyaltyChart)
        {
            MmoslasherId = mmoslasherId;
            UserName = userName;
            TimePlayed = timePlayed;
            Expansion1 = expansion1;
            ActiveLast30Days = activeLast30Days;
            OwnMmoslasherGame = ownMmoslasherGame;
            LoyaltyCharts = new HashSet<LoyaltyChart>(loyaltyChart);
        }

        public Mmoslasher()
        {
            LoyaltyCharts = new HashSet<LoyaltyChart>();
        }
    }
}
