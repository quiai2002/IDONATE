//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DonationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.UserLogin = new HashSet<UserLogin>();
        }
    
        public int roleId { get; set; }
        public string roleName { get; set; }
    
        public virtual ICollection<UserLogin> UserLogin { get; set; }
    }
}
