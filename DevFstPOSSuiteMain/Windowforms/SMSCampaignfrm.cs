using DevFstPOSSuite.DAL;
using DevFstPOSSuite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevFstPOSSuite.Windowforms
{
    public partial class SMSCampaignfrm : MetroFramework.Forms.MetroForm
    {
        private CustomerSrh customerSrh = null;
        private List<CampaignRecipientModel> campaignRecipientList;
        private RetailDBEntities1 context = null;
        public SMSCampaignfrm()
        {
            InitializeComponent();
            context = new RetailDBEntities1();
        }

        private void SMSCampaign_Load(object sender, EventArgs e)
        {
            customerSrh = new CustomerSrh();
            campaignRecipientList = new List<CampaignRecipientModel>();
        }

        private void CampaignMessageTextBox_Click(object sender, EventArgs e)
        {

        }

        private void CampaignMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            lblMessLen.Text = (CampaignMessageTextBox.Text.Replace(Environment.NewLine,"@")).Length.ToString();
            double messLen = Double.Parse(lblMessLen.Text);
            lblSMSCount.Text = Math.Ceiling((messLen / 160)).ToString();
        }

        private void btnContactSearch_Click(object sender, EventArgs e)
        {
            customerSrh.addedContactsList = campaignRecipientList.Select(s => s.ContactNo).ToArray();
            customerSrh.ShowDialog();
            if (customerSrh.newlySelectedContactsList!=null && customerSrh.newlySelectedContactsList.Count > 0)
            {
                var newlyAddedContacts = customerSrh.newlySelectedContactsList.Select(s => new CampaignRecipientModel() { ContactNo = s }).ToList();
                campaignRecipientList.AddRange(newlyAddedContacts);
                BindingReceipientListDataSource();
            }
        }

        private void BindingReceipientListDataSource(){
            campaignRecipientModelBindingSource.DataSource = campaignRecipientList.ToList();
            lblRecCount.Text = campaignRecipientList.Count().ToString();
            

           
        }

        private void Send(object sender, PopupEventArgs e)
        {

        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            string campaignName = CampaignNameTextBox.Text;
            string campaignMessage = CampaignMessageTextBox.Text;
            int respCount = campaignRecipientList.Count;
            if (String.IsNullOrEmpty(campaignName) || String.IsNullOrEmpty(campaignMessage) || respCount == 0)
            {
                MessageBox.Show("Either Missing CampaignName/CampaignMessage or Recipient(s) not selected", "Missing required fields");
                return;
            }
            DialogResult dr = MessageBox.Show("Do you want to proceed with sending Campaign SMS to selected Recipient(s)(Yes/No)?", "Remove Order", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            lblSendingBar.Text = "Sending....";
            sendingProgressBar.Value = 20;
            btnSendSMS.Enabled = false;        
            SMSCampaign newCampaign = new SMSCampaign() { CampaignName = campaignName, CampaignMessage = campaignMessage, CreateBy = Global.userLogin, CreatedOn = DateTime.Now};
            try
                {
                    context.SMSCampaigns.Add(newCampaign);
                    context.SaveChanges();
                    if (newCampaign.ID > 0)
                    {
                        AppConfigurationModel SMSConfig = context.CNF_AppConfiguration.Select(s => new AppConfigurationModel()
                        {
                            Mobile = s.Mobile,
                            BusinessName = s.BusinessName,
                            BusinessShortName = s.BusinessShortName,
                            SMSGateWayURL = s.SMSGateWayURL,
                            SMSGateWayUser = s.SMSGateWayUser,
                            SMSGateWayPwd = s.SMSGateWayPwd,
                            SMSCountryCode = s.SMSCountryCode
                        }).FirstOrDefault();

                        double progressFactor = Math.Ceiling((respCount * 1.00) / 100);
                        double counter = 0.00;
                        sendingProgressBar.Value = 30;
                        foreach (var campaignRecipient in campaignRecipientList)
                        {
                            counter++;
                            
                            string smsCountryCode = (SMSConfig.SMSCountryCode == null || SMSConfig.SMSCountryCode == "") ? "92" : SMSConfig.SMSCountryCode;
                            string recipientNo = campaignRecipient.ContactNo.Substring(0, 1) == "0" ? smsCountryCode + campaignRecipient.ContactNo.Substring(1, campaignRecipient.ContactNo.Length - 1)
                                                                                     : smsCountryCode + campaignRecipient.ContactNo;

                            SMSParamModel SMSObject = new SMSParamModel()
                            {
                                SMSURI = SMSConfig.SMSGateWayURL,
                                UserName = SMSConfig.SMSGateWayUser,
                                Password = SMSConfig.SMSGateWayPwd,
                                ToNumber = recipientNo,
                                MessageText = campaignMessage,
                                Masking = SMSConfig.BusinessShortName
                            };

                        //    messageResponse= Global.SendSMS(SMSObject);
                            //Send Async SMS
                            sendCampaignSMSAsync(SMSObject, newCampaign.ID);
                            if (counter % progressFactor == 0.00 && sendingProgressBar.Value<90)
                                sendingProgressBar.Value += 1;
                        }

                        if (counter > 0 && counter <= respCount)
                        {
                            sendingProgressBar.Value = 100;
                            lblSendingBar.Text = "Completed!";
                             
                            MessageBox.Show("Sending SMS process is completed..Please see the log for detail", "Information");

                            resetCampaign();
                           

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");

                }
                finally
                {
                    btnSendSMS.Enabled = true;
                }
                                                            
        }

        private async void sendCampaignSMSAsync(SMSParamModel smsObj,int campaignID)
        {
            string messageResponse = "", sendStatus = "Error";
            Task<string> sendSMSTask = Global.SendSMS(smsObj);
            messageResponse = await sendSMSTask;
            if (messageResponse.Contains("OK"))
            {
                sendStatus = "Success";
            }

            SMSCampaignDetail newCampaignDetail = new SMSCampaignDetail()
            {
                CampaignID = campaignID,
                ContactNo = smsObj.ToNumber,
                SendResponse = messageResponse,
                SendStatus = sendStatus,
                UpdatedOn = DateTime.Now

            };

            context.SMSCampaignDetails.Add(newCampaignDetail);
            context.SaveChanges();
        }

        private void resetCampaign()
        {
            resetReceipientList();
            CampaignNameTextBox.Text = "";
            CampaignMessageTextBox.Text = "";
            lblSMSCount.Text = "0";
            lblSendingBar.Text = "Waiting to Send....";
            lblMessLen.Text = "0";
            sendingProgressBar.Value = 0;


        }

        private void resetReceipientList()
        {
            campaignRecipientList.Clear();
            BindingReceipientListDataSource();
        }
        private void receipientListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

           if(e.ColumnIndex==0){
                DataGridViewRow row = receipientListDataGridView.Rows[e.RowIndex];
               CampaignRecipientModel delRec = (CampaignRecipientModel)row.DataBoundItem;
               campaignRecipientList.Remove(delRec);
               BindingReceipientListDataSource();

           }     
               
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            resetReceipientList();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string contactNo = contactNoTextBox.Text;
            if (String.IsNullOrEmpty(contactNo))
            {
                MessageBox.Show("Please enter the contactNo to be added", "Required Field(s)");
                return;
            }

            int existingContact = campaignRecipientList.Where(w => w.ContactNo.Contains(contactNo)).Count();
            if (existingContact > 0)
            {
                MessageBox.Show("contactNo is already added", "Already Exists");
                return;
            }
            else
            {
                campaignRecipientList.Add(new CampaignRecipientModel() { ContactNo = contactNo });
                BindingReceipientListDataSource();
                contactNoTextBox.Text = null;
                contactNoTextBox.Focus();
            }
        }
    }
}
