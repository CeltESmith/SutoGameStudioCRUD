using System;
using System.Collections.Generic;

namespace CRUDApps.DataAccess.EF.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string CustomerFirstName { get; set; } = null!;
        public string CustomerLastName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerState { get; set; } = null!;

        public virtual LoyaltyChart UserNameNavigation { get; set; } = null!;
    }
}
