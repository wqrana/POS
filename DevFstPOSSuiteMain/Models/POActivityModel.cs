using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
 public  class POActivityModel
    {
        public int ActivityID { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string SourceProductCode { get; set; }
        public int? SourceProductQty { get; set; }
        public string TargetProductCode { get; set; }
        public int? TargetProductQty { get; set; }
        public string ActivityType { get; set; }
        public string Status { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string TargetLocation { get; set; }
        public string ActivityDetailDesc { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public decimal? NetDealerPrice { get; set; }
        public string UserID { get; set; }
        public DateTime? CreatedOn { get; set; }
    }

 public class POActivitEdityModel
 {
     public int ActivityID { get; set; }
     public DateTime? ActivityDate { get; set; }
     public string SourceProductCode { get; set; }
     public int? SourceProductQty { get; set; }
     public string TargetProductCode { get; set; }
     public int? TargetProductQty { get; set; }
     public string ActivityType { get; set; }
     public string Status { get; set; }
     public DateTime? CompletionDate { get; set; }
     public string TargetLocation { get; set; }
     public string ActivityDetailDesc { get; set; }
     public DateTime? LastUpdatedOn { get; set; }
     public decimal? NetDealerPrice { get; set; }
     public string UserID { get; set; }
     public DateTime? CreatedOn { get; set; }
 }
}
