using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
   public static class Global
    {
       
       public static int userID { get;set;}
       public static string userLogin { get; set; }
       public static UserModel userModel { get; set; }
       public static int paymentDays { get; set; }

       public static List<UserRightsModel> objectsList { get; set; }

       public static string GetSalesSMSTemplate()
       {
           //string smsTemplate = "Dear [Customer],@Thanks for your shopping detail as below!@" +
           //                     "Invoice:[InvoiceNo]@Date:[InvoiceDate]@Net Payable:[BillAmount]" +
           //                     "Paid:[PaidAmount]@Balance:[Balance]@Best Regards,@[BusinessName]@[PhoneNo]";

           string smsTemplate = "Dear [Customer],@Thanks for your shopping!@" +
                                "InvoiceNo:[InvoiceNo]@Amount:[BillAmount]" +
                                "@Best Regards,@[BusinessName]@[PhoneNo]";
           smsTemplate = smsTemplate.Replace("@",  Environment.NewLine);

           return smsTemplate;

       }
       public static async Task<string> SendSMS(SMSParamModel SMSObject)
       {    /*
           String URI = "https://sendpk.com" +
           "/api/sms.php?" +
           "username=" + MyUsername +
           "&password=" + MyPassword +
           "&sender=" + Masking +
           "&mobile=" + toNumber +
           "&message=" + Uri.UnescapeDataString(MessageText); // Visual Studio 10-15 
           */
          
           string responseMessage = ""; 
           String WebRequestMessage =
            SMSObject.SMSURI +
           "username=" + SMSObject.UserName +
           "&password=" + SMSObject.Password +
           "&sender=" + SMSObject.Masking +
           "&mobile=" + SMSObject.ToNumber +
           "&message=" + Uri.UnescapeDataString(SMSObject.MessageText);

        //   return WebRequestMessage;
           try
           {
               ServicePointManager.Expect100Continue = true;
               ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
               WebRequest req = WebRequest.Create(WebRequestMessage);
               WebResponse resp = req.GetResponse();
               var sr = new System.IO.StreamReader(resp.GetResponseStream());
               responseMessage= sr.ReadToEnd().Trim();
             
           }
           catch (WebException ex)
           {
               var httpWebResponse = ex.Response as HttpWebResponse;
               if (httpWebResponse != null)
               {
                   switch (httpWebResponse.StatusCode)
                   {
                       case HttpStatusCode.NotFound:
                           responseMessage= "404:URL not found :" + SMSObject.SMSURI;
                           break;
                       case HttpStatusCode.BadRequest:
                           responseMessage= "400:Bad Request";
                           break;
                       default:
                           responseMessage = httpWebResponse.StatusCode.ToString();
                           break;
                   }
               }
               else
               {
                   responseMessage = ex.Message;
               }
           }


           return responseMessage;
       } 
    }
}
