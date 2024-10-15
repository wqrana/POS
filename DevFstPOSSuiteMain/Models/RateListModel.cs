using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
    public class RateListModel
    {
        public string RateListId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }

    }



    public class RateListEditModel
    {
        public string RateListId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }

    }
}