using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class Fpsblasts
    {

        public int FpsblastId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string Expansion1 { get; set; } = null!;
        public string OwnFpsblastGame { get; set; } = null!;

        public virtual ICollection<LoyaltyCharts> LoyaltyCharts { get; set; }

        public Fpsblasts(int fpsblastId, string userName, TimeSpan timePlayed, string expansion1, string ownFpsblastGame, ICollection<LoyaltyCharts> loyaltyCharts)
        {
            FpsblastId = fpsblastId;
            UserName = userName;
            TimePlayed = timePlayed;
            Expansion1 = expansion1;
            OwnFpsblastGame = ownFpsblastGame;
            LoyaltyCharts = new HashSet<LoyaltyCharts>(loyaltyCharts);
        }

        public Fpsblasts()
        {
            LoyaltyCharts = new HashSet<LoyaltyCharts>();
        }
    }
}
