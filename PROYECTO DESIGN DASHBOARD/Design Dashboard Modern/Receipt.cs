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
    
    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            this.Receipt_Detail = new HashSet<Receipt_Detail>();
        }
    
        public int Receipt_id { get; set; }
        public Nullable<int> Provider_id { get; set; }
        public Nullable<int> Account_id { get; set; }
        public Nullable<System.DateTime> Receipt_date { get; set; }
        public Nullable<double> Total_Receipt { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt_Detail> Receipt_Detail { get; set; }
    }
}
