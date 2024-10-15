using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
 public class DaySaleClosureModel
    {
        public int ID { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? CashInHand { get; set; }
        public decimal? SaleClosure { get; set; }
        public string ClosureBy { get; set; }
        public string Remarks { get; set; }
        public decimal? AdjustedExpense { get; set; }
        public decimal? AdjustedIncomeLoss { get; set; }
        public Nullable<decimal> POCashAdjustment { get; set; }
        public decimal? TotalSale { get; set; }
       public decimal? WithdrawCash { get; set; }
        public string WithdrawBy { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? LastModifiedOn { get; set; }

    }
 public class DaySaleClosureEditModel
 {
     public int ID { get; set; }
     public DateTime? SaleDate { get; set; }
     public decimal? CashInHand { get; set; }
     public decimal? SaleClosure { get; set; }
     public string ClosureBy { get; set; }
     public string Remarks { get; set; }
     public decimal? AdjustedExpense { get; set; }
     public decimal? AdjustedIncomeLoss { get; set; }
     public Nullable<decimal> POCashAdjustment { get; set; }
     public decimal? TotalSale { get; set; }
     public decimal? TotalCashInHand { get; set; }
     public decimal? WithdrawCash { get; set; }
     public string WithdrawBy { get; set; }
     public decimal? CashForClosing { get; set; }
     public bool? IsClosed { get; set; }
     public DateTime? LastModifiedOn { get; set; }
 }



}
