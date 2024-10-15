using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
  public  class ExpenseModel
    {
        public int ID { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public string ExpenseType { get; set; }
        public string ExpenseDesc { get; set; }
        public Nullable<decimal> ExpenseAmount { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public DateTime? AdjustedDate { get; set; }

    }

  public class ExpenseEditModel
  {
      public int ID { get; set; }
      public DateTime? ExpenseDate { get; set; }
      public string ExpenseType { get; set; }
      public string ExpenseDesc { get; set; }
      public Nullable<decimal> ExpenseAmount { get; set; }
      public string Remarks { get; set; }
      public string Status { get; set; }
      public DateTime? AdjustedDate { get; set; }

  }
}
