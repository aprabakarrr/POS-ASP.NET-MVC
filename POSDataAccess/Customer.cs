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
    
    public partial class Customer
    {
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Phone2 { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
