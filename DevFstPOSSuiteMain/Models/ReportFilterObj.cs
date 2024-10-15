using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite
{
   public class ReportFilterObj
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public int? orderId { get; set; }

        public int? supplierId { get; set; }
        public string InvoiceNo { get; set; }

        public bool ib_directPrint { get; set; }
    }
}
