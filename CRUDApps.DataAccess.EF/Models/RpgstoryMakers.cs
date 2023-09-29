using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class RpgstoryMakers
    {

        public int RpgstoryMakerId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string GameCompleted { get; set; } = null!;
        public string OwnRpgstoryMakerGame { get; set; } = null!;

        public virtual ICollection<LoyaltyCharts> LoyaltyCharts { get; set; }

        public RpgstoryMakers (int rpgstoryMakerId, string userName, TimeSpan timePlayed, string gameCompleted, string ownRpgstoryMakerGame, ICollection<LoyaltyCharts> loyaltyChart)
        {
            RpgstoryMakerId = rpgstoryMakerId;
            UserName = userName;
            TimePlayed = timePlayed;
            GameCompleted = gameCompleted;
            OwnRpgstoryMakerGame = ownRpgstoryMakerGame;
            LoyaltyCharts = new HashSet<LoyaltyCharts>(loyaltyChart);
        }

        public RpgstoryMakers()
        {
            LoyaltyCharts = new HashSet<LoyaltyCharts>();
        }
    }
}
