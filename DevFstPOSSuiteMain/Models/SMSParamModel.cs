using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
   public class SMSParamModel
    {
       public string SMSURI {get;set;}
       public string UserName {get;set;}
       public string Password {get;set;}
       public string Masking {get;set;}
       public string ToNumber{get;set;}
       public string MessageText { get; set; }
    }
}
