//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StattonManage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cashier
    {
        public int CashierID { get; set; }
        public string Cashier_Status { get; set; }
        public string Cashier_login { get; set; }
        public string Cashier_password { get; set; }
        public int ID_Person { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
