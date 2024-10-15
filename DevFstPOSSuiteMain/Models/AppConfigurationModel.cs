using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
   
        class AppConfigurationModel
        {
            public int ID { get; set; }
            public string BusinessCode { get; set; }
            public string BusinessName { get; set; }
            public string BusinessShortName { get; set; }
            public string BusinessAddress { get; set; }
            public string LandLine { get; set; }
            public string Mobile { get; set; }
            public string Email { get; set; }
            public string NotificationEmail { get; set; }
            public Nullable<bool> SalesNotification { get; set; }
            public Nullable<bool> SalesClosureNotification { get; set; }
            public Nullable<bool> DailyStockNotification { get; set; }
            public Nullable<bool> LowStockNotification { get; set; }
            public int PaymentDays { get; set; }
            public bool FirstPaymentNotification { get; set; }
            public int FirstNotificationDaysBefore { get; set; }
            public bool SecPaymentNotification { get; set; }
            public int SecNotificationDaysBefore { get; set; }
            public bool ThirdPaymentNotification { get; set; }
            public int ThirdNotificationDaysBefore { get; set; }
            public string NotificationEmailProfile { get; set; }
            public Nullable<bool> DailyExpenseNotification { get; set; }
            public string SMSGateWayURL { get; set; }
            public string SMSGateWayUser { get; set; }
            public string SMSGateWayPwd { get; set; }
            public Nullable<bool> SalesSMSNotification { get; set; }
            public string SMSCountryCode { get; set; }
           
        
    }
}
