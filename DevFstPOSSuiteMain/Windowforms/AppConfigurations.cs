using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DevFstPOSSuite.DAL;
using DevFstPOSSuite.Models;
namespace DevFstPOSSuite.Windowforms
{
    public partial class AppConfigurations : MetroForm
    {
        RetailDBEntities1 context = null;
        public AppConfigurations()
        {
            InitializeComponent();

            context = new RetailDBEntities1();
        }

        

        private void AppConfigurations_Load(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void BindDataSource()
        {
            var dataSrc = context.CNF_AppConfiguration.Select(x => new AppConfigurationModel
            {
              ID = x.ID,
              BusinessCode = x.BusinessCode,
              BusinessName = x.BusinessName,
              BusinessShortName = x.BusinessShortName,
              BusinessAddress = x.BusinessAddress,
              LandLine = x.LandLine,
              Mobile = x.Mobile,
              Email = x.Email,
              NotificationEmail = x.NotificationEmail,
              SalesNotification = x.SalesNotification?? false,
              DailyStockNotification = x.DailyStockNotification ?? false,
              SalesClosureNotification = x.SalesClosureNotification ?? false,
              LowStockNotification = x.LowStockNotification??false,
              PaymentDays = x.PaymentDays?? 0,
              FirstPaymentNotification = x.FirstPaymentNotification?? false,
              FirstNotificationDaysBefore = x.FirstNotificationDaysBefore??0,
              SecPaymentNotification = x.SecPaymentNotification ?? false,
              SecNotificationDaysBefore = x.SecNotificationDaysBefore??0,
              ThirdPaymentNotification = x.ThirdPaymentNotification ?? false,
              ThirdNotificationDaysBefore = x.ThirdNotificationDaysBefore ?? 0,
              NotificationEmailProfile  = x.NotificationEmailProfile,
              DailyExpenseNotification  = x.DailyExpenseNotification ?? false,
              SMSGateWayURL             = x.SMSGateWayURL,
              SMSGateWayUser            = x.SMSGateWayUser,
              SMSGateWayPwd             = x.SMSGateWayPwd,
              SalesSMSNotification      = x.SalesSMSNotification??false,
              SMSCountryCode            = x.SMSCountryCode
                                      
               

             }

                ).FirstOrDefault();

            appConfigurationModelBindingSource.DataSource = dataSrc == null ? new AppConfigurationModel() : dataSrc;
        }

        private void businessShortNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            appConfigurationModelBindingSource.EndEdit();
            var saveAppConfigurationData = (AppConfigurationModel)appConfigurationModelBindingSource.DataSource;

            if (saveAppConfigurationData.ID == 0)
            {
                var newAppConfigEntity = new CNF_AppConfiguration
                {                    
                    BusinessCode = saveAppConfigurationData.BusinessCode,
                    BusinessName = saveAppConfigurationData.BusinessName,
                    BusinessShortName = saveAppConfigurationData.BusinessShortName,
                    BusinessAddress = saveAppConfigurationData.BusinessAddress,
                    LandLine = saveAppConfigurationData.LandLine,
                    Mobile = saveAppConfigurationData.Mobile,
                    Email = saveAppConfigurationData.Email,
                    NotificationEmail = saveAppConfigurationData.NotificationEmail,
                    SalesNotification = saveAppConfigurationData.SalesNotification ,
                    DailyStockNotification = saveAppConfigurationData.DailyStockNotification ,
                    SalesClosureNotification = saveAppConfigurationData.SalesClosureNotification ,
                    LowStockNotification = saveAppConfigurationData.LowStockNotification,
                    PaymentDays = saveAppConfigurationData.PaymentDays ,
                    FirstPaymentNotification = saveAppConfigurationData.FirstPaymentNotification,
                    FirstNotificationDaysBefore = saveAppConfigurationData.FirstNotificationDaysBefore ,
                    SecPaymentNotification = saveAppConfigurationData.SecPaymentNotification ,
                    SecNotificationDaysBefore = saveAppConfigurationData.SecNotificationDaysBefore,
                    ThirdPaymentNotification = saveAppConfigurationData.ThirdPaymentNotification,
                    ThirdNotificationDaysBefore = saveAppConfigurationData.ThirdNotificationDaysBefore,
                    NotificationEmailProfile = saveAppConfigurationData.NotificationEmailProfile,
                    DailyExpenseNotification = saveAppConfigurationData.DailyExpenseNotification,
                    SMSGateWayURL = saveAppConfigurationData.SMSGateWayURL,
                    SMSGateWayUser = saveAppConfigurationData.SMSGateWayUser,
                    SMSGateWayPwd = saveAppConfigurationData.SMSGateWayPwd,
                    SalesSMSNotification = saveAppConfigurationData.SalesSMSNotification??false,
                    SMSCountryCode       = saveAppConfigurationData.SMSCountryCode
                    
                    
                };
                context.CNF_AppConfiguration.Add(newAppConfigEntity);
            }
            else
            {
                var modifyAppConfigEntity = context.CNF_AppConfiguration.Find(saveAppConfigurationData.ID);
                if (modifyAppConfigEntity != null)
                {
                    modifyAppConfigEntity.BusinessCode = saveAppConfigurationData.BusinessCode;
                    modifyAppConfigEntity.BusinessName = saveAppConfigurationData.BusinessName;
                    modifyAppConfigEntity.BusinessShortName = saveAppConfigurationData.BusinessShortName;
                    modifyAppConfigEntity.BusinessAddress = saveAppConfigurationData.BusinessAddress;
                    modifyAppConfigEntity.LandLine = saveAppConfigurationData.LandLine;
                    modifyAppConfigEntity.Mobile = saveAppConfigurationData.Mobile;
                    modifyAppConfigEntity.Email = saveAppConfigurationData.Email;
                    modifyAppConfigEntity.NotificationEmail = saveAppConfigurationData.NotificationEmail;
                    modifyAppConfigEntity.SalesNotification = saveAppConfigurationData.SalesNotification;
                    modifyAppConfigEntity.DailyStockNotification = saveAppConfigurationData.DailyStockNotification;
                    modifyAppConfigEntity.SalesClosureNotification = saveAppConfigurationData.SalesClosureNotification;
                    modifyAppConfigEntity.LowStockNotification = saveAppConfigurationData.LowStockNotification;
                    modifyAppConfigEntity.PaymentDays = saveAppConfigurationData.PaymentDays;
                    modifyAppConfigEntity.FirstPaymentNotification = saveAppConfigurationData.FirstPaymentNotification;
                    modifyAppConfigEntity.FirstNotificationDaysBefore = saveAppConfigurationData.FirstNotificationDaysBefore;
                    modifyAppConfigEntity.SecPaymentNotification = saveAppConfigurationData.SecPaymentNotification;
                    modifyAppConfigEntity.SecNotificationDaysBefore = saveAppConfigurationData.SecNotificationDaysBefore;
                    modifyAppConfigEntity.ThirdPaymentNotification = saveAppConfigurationData.ThirdPaymentNotification;
                    modifyAppConfigEntity.ThirdNotificationDaysBefore = saveAppConfigurationData.ThirdNotificationDaysBefore;
                    modifyAppConfigEntity.NotificationEmailProfile = saveAppConfigurationData.NotificationEmailProfile;
                    modifyAppConfigEntity.DailyExpenseNotification = saveAppConfigurationData.DailyExpenseNotification;
                    modifyAppConfigEntity.SMSGateWayURL = saveAppConfigurationData.SMSGateWayURL;
                    modifyAppConfigEntity.SMSGateWayUser = saveAppConfigurationData.SMSGateWayUser;
                    modifyAppConfigEntity.SMSGateWayPwd = saveAppConfigurationData.SMSGateWayPwd;
                    modifyAppConfigEntity.SalesSMSNotification = saveAppConfigurationData.SalesSMSNotification ?? false;
                    modifyAppConfigEntity.SMSCountryCode = saveAppConfigurationData.SMSCountryCode; 
                    
                 }
                
            }

            context.SaveChanges();
            MessageBox.Show("App Configurations are saved successfully", "Confirmation");
            BindDataSource();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
