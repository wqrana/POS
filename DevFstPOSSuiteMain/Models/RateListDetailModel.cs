using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
 public class RateListDetailModel
    {
        public string RateListId { get; set; }
        public string ProductCode { get; set; }
        public Nullable<double> Rate { get; set; }
      
    }


public class RateListDetailEditModel
    {
        public string RateListId { get; set; }
        public string ProductCode { get; set; }
        public Nullable<double> Rate { get; set; }
      
    }
}