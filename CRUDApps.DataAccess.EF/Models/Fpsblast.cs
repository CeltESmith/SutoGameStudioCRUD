using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class Fpsblast
    {

        public int FpsblastId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string Expansion1 { get; set; } = null!;
        public string OwnFpsblastGame { get; set; } = null!;

        public virtual ICollection<LoyaltyChart> LoyaltyCharts { get; set; }

        public Fpsblast(int fpsblastId, string userName, TimeSpan timePlayed, string expansion1, string ownFpsblastGame, ICollection<LoyaltyChart> loyaltyCharts)
        {
            FpsblastId = fpsblastId;
            UserName = userName;
            TimePlayed = timePlayed;
            Expansion1 = expansion1;
            OwnFpsblastGame = ownFpsblastGame;
            LoyaltyCharts = new HashSet<LoyaltyChart>(loyaltyCharts);
        }

        public Fpsblast()
        {
            LoyaltyCharts = new HashSet<LoyaltyChart>();
        }
    }
}
