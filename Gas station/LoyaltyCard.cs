//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gas_station
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoyaltyCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoyaltyCard()
        {
            this.Customers = new HashSet<Customer>();
        }
    
        public int LoyaltyCardID { get; set; }
        public int ID_MOP { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual MOP MOP { get; set; }
    }
}
