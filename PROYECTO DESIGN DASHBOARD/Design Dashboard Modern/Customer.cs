//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Design_Dashboard_Modern
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int Cus_id { get; set; }
        public string Cus_name { get; set; }
        public string Cus_phone { get; set; }
        public string Cus_address { get; set; }
        public string Cus_email { get; set; }
        public Nullable<double> Cus_Point { get; set; }
        public Nullable<int> Cus_level { get; set; }
        public Nullable<System.DateTime> Cus_DOB { get; set; }
    
        public virtual Level Level { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}