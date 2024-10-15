using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
  public class POIncomeModel
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> PostingDate { get; set; }
        public Nullable<int> IncomeType { get; set; }
        public Nullable<decimal> PostingAmount { get; set; }
        public Nullable<bool> AdjustedInPOS { get; set; }
        public string Reference { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }

  public class POIncomeEditModel
  {
      public int ID { get; set; }
      public Nullable<System.DateTime> PostingDate { get; set; }
      public Nullable<int> IncomeType { get; set; }
      public Nullable<decimal> PostingAmount { get; set; }
      public Nullable<bool> AdjustedInPOS { get; set; }
      public string Reference { get; set; }
      public string CreatedBy { get; set; }
      public Nullable<System.DateTime> LastUpdatedDate { get; set; }
      public string LastUpdatedBy { get; set; }
  }
  public class POIncomeTypeModel
  {
      public int ID { get; set; }
      public string Name { get; set; }
  }



}
