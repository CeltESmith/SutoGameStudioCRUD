using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class Fpsblast
    {
        public Fpsblast()
        {
            LoyaltyCharts = new HashSet<LoyaltyChart>();
        }

        public int FpsblastId { get; set; }
        public string UserName { get; set; } = null!;
        public TimeSpan TimePlayed { get; set; }
        public string Expansion1 { get; set; } = null!;
        public string OwnFpsblastGame { get; set; } = null!;

        public virtual ICollection<LoyaltyChart> LoyaltyCharts { get; set; }
    }
}
