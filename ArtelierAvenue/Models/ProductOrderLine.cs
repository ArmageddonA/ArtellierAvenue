//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtelierAvenue.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductOrderLine
    {
        public int ProductID { get; set; }
        public int ProductSizeID { get; set; }
        public Nullable<int> PriceID { get; set; }
        public Nullable<int> ProductCount { get; set; }
        public int ProductOrderID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual ProductOrder ProductOrder { get; set; }
        public virtual ProductSize ProductSize { get; set; }
    }
}