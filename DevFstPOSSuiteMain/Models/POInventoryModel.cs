using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
   public class POInventoryMasterModel
   {
       public int ID { get; set; }
       public string OrderNo { get; set; }
       public DateTime? OrderDate { get; set; }
       public string InvoiceNo { get; set; }
       public DateTime? InvoiceDate { get; set; }
       public decimal? StdDisPct { get; set; }
       public decimal? BreakupDisPct { get; set; }
       public decimal? CatDisPct { get; set; }
       public decimal? InvoiceAmount { get; set; }
       public DateTime? DueDate { get; set; }
       public DateTime? PaymentDate { get; set; }
       public string Reference { get; set; }
       public decimal? PaymentDisPct { get; set; }
       public decimal? FreightCharges { get; set; }
       public decimal? DealerDisPct { get; set; }
       public DateTime? CreationDate { get; set; }
       public DateTime? LastUpdateDate { get; set; }
       public int? SupplierID { get; set; }
       public string PaymentStatus { get; set; }
   }
   public class POInventoryMasterEditModel
   {
       public int ID { get; set; }
       public string OrderNo { get; set; }
       public DateTime? OrderDate { get; set; }
       public string InvoiceNo { get; set; }
       public DateTime? InvoiceDate { get; set; }
       public decimal? StdDisPct { get; set; }
       public decimal? BreakupDisPct { get; set; }
       public decimal? CatDisPct { get; set; }
       public decimal? InvoiceAmount { get; set; }
       public DateTime? DueDate { get; set; }
       public DateTime? PaymentDate { get; set; }
       public string Reference { get; set; }
       public decimal? PaymentDisPct { get; set; }
       public decimal? FreightCharges { get; set; }
       public decimal? DealerDisPct { get; set; }
       public DateTime? CreationDate { get; set; }
       public DateTime? LastUpdateDate { get; set; }
       public int? SupplierID { get; set; }
       public string PaymentStatus { get; set; }
   }
   public class POInventoryDetailModel
   {
       public int ID { get; set; }
       public int? OrderID { get; set; }
       public string ProductCode { get; set; }
       public decimal? RetailPrice { get; set; }
       public int? Qty { get; set; }
       public decimal? ProductDiscount { get; set; }
       public decimal? DealerPrice { get; set; }
       public decimal? NetProductDiscPct { get; set; }
       public decimal? NetDealerPrice { get; set; }
       public string Remarks { get; set; }
       public decimal? DealerDiscPct { get; set; }
       public DateTime? CreationDate { get; set; }
       public DateTime? LastModifiedDate { get; set; }
       public string UserName { get; set; }
       public bool? IsManualRate { get; set; }
   }

}
