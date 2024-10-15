using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
  public  class ProductSearchModel
    {
        public string ProductID { get; set; }
        public string ShortName { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public int StockInHand { get; set; }


    }
}
