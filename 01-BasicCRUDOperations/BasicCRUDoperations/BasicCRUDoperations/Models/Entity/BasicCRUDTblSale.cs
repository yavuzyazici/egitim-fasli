//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasicCRUDoperations.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BasicCRUDTblSale
    {
        public int SalesId { get; set; }
        public Nullable<int> Product { get; set; }
        public Nullable<int> Customer { get; set; }
        public Nullable<byte> Period { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual BasicCRUDTblCustomer BasicCRUDTblCustomer { get; set; }
        public virtual BasicCRUDTblProduct BasicCRUDTblProduct { get; set; }
    }
}