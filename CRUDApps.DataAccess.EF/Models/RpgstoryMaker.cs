using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class RpgstoryMaker
    {

        public int RpgstoryMakerId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string GameCompleted { get; set; } = null!;
        public string OwnRpgstoryMakerGame { get; set; } = null!;

        public virtual ICollection<LoyaltyChart> LoyaltyCharts { get; set; }

        public RpgstoryMaker (int rpgstoryMakerId, string userName, TimeSpan timePlayed, string gameCompleted, string ownRpgstoryMakerGame, ICollection<LoyaltyChart> loyaltyChart)
        {
            RpgstoryMakerId = rpgstoryMakerId;
            UserName = userName;
            TimePlayed = timePlayed;
            GameCompleted = gameCompleted;
            OwnRpgstoryMakerGame = ownRpgstoryMakerGame;
            LoyaltyCharts = new HashSet<LoyaltyChart>(loyaltyChart);
        }

        public RpgstoryMaker()
        {
            LoyaltyCharts = new HashSet<LoyaltyChart>();
        }
    }
}
