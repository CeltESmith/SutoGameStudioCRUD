using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class RpgstoryMaker
    {
        public RpgstoryMaker()
        {
            LoyaltyCharts = new HashSet<LoyaltyChart>();
        }

        public int RpgstoryMakerId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string GameCompleted { get; set; } = null!;
        public string OwnRpgstoryMakerGame { get; set; } = null!;

        public virtual ICollection<LoyaltyChart> LoyaltyCharts { get; set; }
    }
}
