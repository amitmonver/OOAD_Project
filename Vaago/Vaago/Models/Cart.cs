//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vaago.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int ID { get; set; }
        public Nullable<int> account_ID { get; set; }
        public Nullable<int> itemID { get; set; }
        public Nullable<int> itemQuantity { get; set; }
        public Nullable<int> totalAmount { get; set; }
    
        public virtual Menu Menu { get; set; }
    }
}