using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
 public  class SaleInvoiceModel
    {
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string SSName { get; set; }
        public string Phone { get; set; }
        public string InvoiceModeType { get; set; } 

    }

 public class SaleInvoiceDetailListModel
 {
     public string InvoiceNo { get; set; }
     public int AutoID { get; set; }
     public string ProductCode { get; set; }
     public Nullable<int> Qty { get; set; }
     public Nullable<decimal> Rate { get; set; }
     public Nullable<double> DisP { get; set; }
     public Nullable<double> DisAmt { get; set; }
     public Nullable<int> CCode { get; set; }
     public Nullable<double> NetRate { get; set; }

     public double TotalAmount { get; set; }  
     public string Status { get; set; }
     public Nullable<int> ReferenceID { get; set; }

 }

 
   public class SaleInvoiceDetailEditModel
  {
      public string InvoiceNo { get; set; }
      public int AutoID { get; set; }
      public string ProductCode { get; set; }
      public Nullable<int> Qty { get; set; }
      public Nullable<decimal> Rate { get; set; }
      public Nullable<double> DisP { get; set; }
      public Nullable<double> DisAmt { get; set; }
      public Nullable<int> CCode { get; set; }
      public Nullable<double> NetRate { get; set; }
      public string Status { get; set; }
      public Nullable<int> ReferenceID { get; set; }

      public double TotalAmount { get; set; }  
  }
  
 public  class SaleInvoiceListModel
    {
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string SSName { get; set; }
        public string Phone { get; set; }

    }

 public class SaleInvoiceReturnDetailModel
 {
     public string InvoiceNo { get; set; }
     public int AutoID { get; set; }
     public string ProductCode { get; set; }
     public Nullable<int> Qty { get; set; }
     public int PrevReturnedQty { get; set; }
     public int AvailableQty { get; set; }

 }

 public class SaleInvoiceBillDetail 
 {
     public int TotalItem { get; set; }
     public double GrandTotal { get; set; }

     public double TotalDiscount { get; set; }

     public double NetTotal { get; set; }

     public string PaymentMode { get; set; }

     public string paymentRef { get; set;}
     public double CashReceived { get; set; }
     
     public double Balance { get; set; }

     public string UserName { get; set; }
 
 
 }

 public class InvoiceModeTypeModel
 {
     public string val { get; set; }
     public string display { get; set; }
 }

}
