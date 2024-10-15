using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
  public  class ProductModel
    {

        public string ProductID { get; set; }
        public string ShortName { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> ProductTypeID { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string UOMID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<double> MinLevel { get; set; }
        public Nullable<double> MaxLevel { get; set; }
        public Nullable<double> ReOrdQty { get; set; }
        public string UserName { get; set; }
        public Nullable<double> DisP { get; set; }
        public bool Active { get; set; }

        public Nullable<bool> POSShortcutBtn { get; set; }
        public Nullable<int> POSShortcutBtnSeq { get; set; }

    }

  public class ProductEditModel
  {

      public string ProductID { get; set; }
      public string ShortName { get; set; }
      public string ProductName { get; set; }
      public Nullable<int> ProductTypeID { get; set; }
      public Nullable<decimal> Rate { get; set; }
      public string UOMID { get; set; }
      public Nullable<int> SupplierID { get; set; }
      public Nullable<double> MinLevel { get; set; }
      public Nullable<double> MaxLevel { get; set; }
      public Nullable<double> ReOrdQty { get; set; }
      public string UserName { get; set; }
      public Nullable<double> DisP { get; set; }
      public bool Active { get; set; }
      public Nullable<bool> POSShortcutBtn { get; set; }
      public Nullable<int> POSShortcutBtnSeq { get; set; }

  }
}
