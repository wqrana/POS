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
    
    public partial class SAL_InvoiceMaster
    {
        public string InvoiceNo { get; set; }
        public string CustomerCode { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string Status { get; set; }
        public Nullable<int> LoginHistoryID { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> dtStamp { get; set; }
        public string PostedBy_Code { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public string Invoiceof { get; set; }
        public int AutoID { get; set; }
        public string AddaId { get; set; }
        public string GodownId { get; set; }
        public string OrderNo { get; set; }
        public string DCNo { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string SSName { get; set; }
        public string SSAddress { get; set; }
        public string SSCity { get; set; }
        public string Bilty { get; set; }
        public int CCode { get; set; }
        public string ReferenceNo { get; set; }
        public string InvoiceType { get; set; }
        public string CashAcNo { get; set; }
        public string DisAcNo { get; set; }
        public Nullable<double> Discount { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> IsNotify { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<decimal> ReceivedAmount { get; set; }
        public Nullable<decimal> BalanceAmount { get; set; }
    }
}
