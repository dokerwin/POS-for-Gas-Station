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
    
    public partial class MOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOP()
        {
            this.LoyaltyCards = new HashSet<LoyaltyCard>();
        }
    
        public int MopID { get; set; }
        public string Mop_Type { get; set; }
        public string Currency { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoyaltyCard> LoyaltyCards { get; set; }
    }
}
