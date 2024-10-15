using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
 public  class POPaymentModel
    {
        public int ID { get; set; }
        public int? SupplierID { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentReference { get; set; }
        public int? PaymentBankID { get; set; }
        public string PaymentAccount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? AdjustmentAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Remarks { get; set; }
      
    }

 public class POPaymentDetailModel
 {
     public int ID { get; set; }
     public string OrderNo { get; set; }
     public string InvoiceNo { get; set; }
     public Nullable<System.DateTime> InvoiceDate { get; set; }
     public Nullable<decimal> InvoiceAmount { get; set; }
     public Nullable<System.DateTime> DueDate { get; set; }
     public Nullable<int> SupplierID { get; set; }
     public Nullable<decimal> PaidPaymentAmount { get; set; }
     public decimal PaymentAmount { get; set; }
     public decimal AdjustedAmount { get; set; }


 }

 public class POPaymentHistoryModel
 {
 }

 public class POPaymentHistoryDetailModel
 {
 }

}
