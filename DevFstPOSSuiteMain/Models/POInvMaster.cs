using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite
{
    class POInvMaster
    {
        public int ID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<decimal> DealerDisPct { get; set; }
        public Nullable<decimal> FreightCharges { get; set; }
    }
}
