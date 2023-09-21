using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class LoyaltyChart
    {
        public LoyaltyChart()
        {
            Users = new HashSet<User>();
        }

        public int LoyaltyChartId { get; set; }
        public string UserName { get; set; } = null!;
        public string OwnFpsblastGame { get; set; } = null!;
        public string OwnMmoslasherGame { get; set; } = null!;
        public string OwnRpgstoryMakerGame { get; set; } = null!;
        public string IsLoyalCustomer { get; set; } = null!;

        public virtual Fpsblast OwnFpsblastGameNavigation { get; set; } = null!;
        public virtual Mmoslasher OwnMmoslasherGameNavigation { get; set; } = null!;
        public virtual RpgstoryMaker OwnRpgstoryMakerGameNavigation { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; }
    }
}
