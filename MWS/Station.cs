//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MWS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Station()
        {
            this.Shifts = new HashSet<Shift>();
            this.Shifts1 = new HashSet<Shift>();
        }
    
        public int StationID { get; set; }
        public string Station_Name { get; set; }
        public int ID_Forecourt { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Adres_country { get; set; }
        public string Adress_city { get; set; }
        public string Adress_street { get; set; }
        public string Adress_build { get; set; }
        public string Adress_zip { get; set; }
        public string Tax { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string WWW { get; set; }
    
        public virtual Forecourt Forecourt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shift> Shifts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shift> Shifts1 { get; set; }
    }
}
