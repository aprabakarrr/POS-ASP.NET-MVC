//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public Login()
        {
            this.Journals = new HashSet<Journal>();
            this.Journals1 = new HashSet<Journal>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Last_Login { get; set; }
        public string User_Type { get; set; }
        public Nullable<int> Address_ID { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> Manager_ID { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Journal> Journals1 { get; set; }
    }
}
