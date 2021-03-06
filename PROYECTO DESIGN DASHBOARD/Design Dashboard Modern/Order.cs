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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Order_detail = new HashSet<Order_detail>();
        }
    
        public int Order_id { get; set; }
        public string Order_note { get; set; }
        public Nullable<int> Cus_id { get; set; }
        public Nullable<int> WH_id { get; set; }
        public Nullable<int> Account_id { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> Order_day { get; set; }
        public Nullable<double> Total_Price { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_detail> Order_detail { get; set; }
    }
}
