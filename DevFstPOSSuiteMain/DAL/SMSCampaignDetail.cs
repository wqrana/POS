//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevFstPOSSuite.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SMSCampaignDetail
    {
        public int ID { get; set; }
        public Nullable<int> CampaignID { get; set; }
        public string ContactNo { get; set; }
        public string SendResponse { get; set; }
        public string SendStatus { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
