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
    
    public partial class sp_rp_POPaymentHistoryDetailReport_Result
    {
        public string SupplierName { get; set; }
        public Nullable<int> DisbursementID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public string BankName { get; set; }
        public string PaymentAccount { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public string PaymentReference { get; set; }
        public string Remarks { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<decimal> PaidPayment { get; set; }
        public Nullable<decimal> AdjustedPayment { get; set; }
    }
}
