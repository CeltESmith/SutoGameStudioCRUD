using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class LoyaltyCharts
    {

        public int LoyaltyChartId { get; set; }
        public string UserName { get; set; } = null!;
        public string OwnFpsblastGame { get; set; } = null!;
        public string OwnMmoslasherGame { get; set; } = null!;
        public string OwnRpgstoryMakerGame { get; set; } = null!;
        public string IsLoyalCustomer { get; set; } = null!;

        public virtual Fpsblasts OwnFpsblastGameNavigation { get; set; } = null!;
        public virtual Mmoslashers OwnMmoslasherGameNavigation { get; set; } = null!;
        public virtual RpgstoryMakers OwnRpgstoryMakerGameNavigation { get; set; } = null!;
        public virtual ICollection<Users> Users { get; set; }

        public LoyaltyCharts(int loyaltyChartId, string userName, string ownFpsblastGame, string ownMmoslasherGame, string ownRpgstoryMakerGame, string isLoyalCustomer, Fpsblasts ownFpsblastGameNavigation, Mmoslashers ownMmoslasherGameNavigation, RpgstoryMakers ownRpgstoryMakerGameNavigation,  ICollection<Users> users)
        {
            LoyaltyChartId = loyaltyChartId;
            UserName = userName;
            OwnFpsblastGame = ownFpsblastGame;
            OwnMmoslasherGame = ownMmoslasherGame;
            OwnRpgstoryMakerGame = ownRpgstoryMakerGame;
            IsLoyalCustomer = isLoyalCustomer;

            OwnFpsblastGameNavigation = ownFpsblastGameNavigation;
            OwnMmoslasherGameNavigation = ownMmoslasherGameNavigation;
            OwnRpgstoryMakerGameNavigation = ownRpgstoryMakerGameNavigation;
            Users = new HashSet<Users>(users);
        }
        public LoyaltyCharts()
        {
            Users = new HashSet<Users>();
        }
    }
}
