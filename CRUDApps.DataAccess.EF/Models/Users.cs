using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string CustomerFirstName { get; set; } = null!;
        public string CustomerLastName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerState { get; set; } = null!;

        public virtual LoyaltyCharts UserNameNavigation { get; set; } = null!;

        public Users(int userId, string userName, string customerFirstName, string customerLastName, string customerEmail, string customerState, LoyaltyCharts userNameNavigation)
        {
            UserId = userId;
            UserName = userName;
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            CustomerEmail = customerEmail;
            CustomerState = customerState;

            UserNameNavigation = userNameNavigation;
        }

        public Users()
        {

        }
    }
}
