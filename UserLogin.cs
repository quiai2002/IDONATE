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
    
    public partial class UserLogin
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> roleId { get; set; }
        public string code { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public Nullable<System.DateTime> date_modified { get; set; }
    
        public virtual Role Role { get; set; }
    }
}