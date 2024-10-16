//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevFstPOSSuite.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class POInventoryMaster
    {
        public int ID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<decimal> StdDisPct { get; set; }
        public Nullable<decimal> BreakupDisPct { get; set; }
        public Nullable<decimal> CatDisPct { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string Reference { get; set; }
        public Nullable<decimal> PaymentDisPct { get; set; }
        public Nullable<decimal> FreightCharges { get; set; }
        public Nullable<decimal> DealerDisPct { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string PaymentStatus { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
    }
}
