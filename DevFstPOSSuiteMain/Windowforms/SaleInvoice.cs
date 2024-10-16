﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevFstPOSSuite.DAL;
using DevFstPOSSuite.Models;
using DevFstPOSSuite.Windowforms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace DevFstPOSSuite.Windowforms
{
    public partial class SaleInvoice : MetroForm
    {
        RetailDBEntities1 context = null;
        IList<SaleInvoiceDetailListModel> SIItemList = null;
        IList<int> deletedInvoiceItemList = null;
        string InvoiceMode = "N";
        Productcs pSearchfrm = null;
        POSNumPad numPadDialog = null;
        public SaleInvoice()
        {
            InitializeComponent();

            context = new RetailDBEntities1();

            SIItemList = new List<SaleInvoiceDetailListModel>();

            deletedInvoiceItemList = new List<int>();

            InitilizeSaleInvoice();

            pSearchfrm = new Productcs();
            pSearchfrm.Visible = false;

            numPadDialog = new POSNumPad();
            numPadDialog.Visible = false;

        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {

        }
        private void InitilizeSalePOSShortcutbuttons()
        {
            List<ProductModel> productListForShortcut = context.STK_productMaster.Where(w => w.POSShortcutBtn == true && w.POSShortcutBtnSeq > 0).Select(s => new ProductModel() { ProductID = s.ProductID, ShortName = s.ShortName, POSShortcutBtnSeq = s.POSShortcutBtnSeq }).OrderBy(o => o.POSShortcutBtnSeq).ToList();
            if (productListForShortcut.Count > 0)
            {
                foreach (var prod in productListForShortcut)
                {
                    var btnName = "btn_" + prod.POSShortcutBtnSeq.ToString();
                   Button btnControl = this.Controls.Find(btnName, true).FirstOrDefault() as Button;
                   if (btnControl != null)
                   {
                       btnControl.Text = (prod.ShortName == null || prod.ShortName == "") ? prod.ProductID : prod.ShortName;
                       btnControl.Enabled = true;
                   }
                }
            }
                                                        
        }
        private void InitilizeSaleInvoice()
        {
            try
            {
                //  string newInvoiceNo = GetNewInvoiceNo();
                SIItemList.Clear();
                deletedInvoiceItemList.Clear();
                string newInvoiceNo = context.Database.SqlQuery<string>("select dbo.Generate_NewSaleInvoiceNo()").Single().ToString();
            
                saleInvoiceModelBindingSource.DataSource = new SaleInvoiceModel { InvoiceNo = newInvoiceNo, InvoiceDate = DateTime.Parse(DateTime.Now.ToShortDateString()), InvoiceModeType = "N" };
                            
                saleInvoiceDetailEditModelBindingSource.DataSource = new SaleInvoiceDetailEditModel { Qty = 1 };

                saleInvoiceDetailListModelDataGridView.Rows.Clear();
                saleInvoiceDetailListModelDataGridView.Refresh();

                saleInvoiceListModelDataGridView.Rows.Clear();
                saleInvoiceListModelDataGridView.Refresh();

                saleInvoiceReturnDetailModelDataGridView.Rows.Clear();
                saleInvoiceReturnDetailModelDataGridView.Refresh();

                saleInvoiceDetailListModelBindingSource.DataSource = SIItemList;
                               
                saleInvoiceBillDetailBindingSource.DataSource = new SaleInvoiceBillDetail() { UserName = Global.userLogin };

                invoiceModeTypeModelBindingSource.DataSource = new List<InvoiceModeTypeModel>{

                    new InvoiceModeTypeModel{val="N", display="New Invoice"},
                    new InvoiceModeTypeModel{val="E", display="Edit/Add Invoice"},
                    new InvoiceModeTypeModel{val="R", display="Return/Add Invoice"}
                
                };

                //InvoiceModeTypeComboBox.SelectedIndex = 0;
                InvoiceModeTypeComboBox.SelectedValue = "N";
                paymentModeComboBox.SelectedItem = "Cash";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }


        private void SearchInvoiceBtn_Click(object sender, EventArgs e)
        {

            
            saleInvoiceListModelBindingSource.DataSource = context.SAL_InvoiceMaster.Where(x => x.InvoiceNo.ToLower().Contains(SearchText.Text.ToLower()) ||
                                                                                               x.SSName.ToLower().Contains(SearchText.Text.ToLower()) ||
                                                                                               x.Phone.Contains(SearchText.Text)).
                                                                                               Select(s => new SaleInvoiceListModel
                                                                                               {
                                                                                                   InvoiceNo = s.InvoiceNo,
                                                                                                   InvoiceDate = s.InvoiceDate,
                                                                                                   SSName = s.SSName,
                                                                                                   Phone = s.Phone

                                                                                               }).OrderByDescending(o=> o.InvoiceDate).ToList();




            




        }

        private void saleInvoiceListModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string invoiceNo = saleInvoiceListModelDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            DateTime invoiceDate = DateTime.Parse(saleInvoiceListModelDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            DateTime CurrentDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {                
                DialogResult dr= MessageBox.Show(string.Format("Do you want to proceed for Return/Edit on Sale Invoice ({0})", invoiceNo), "Edit/Return the Invoice", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                   
                    if (e.ColumnIndex == 1)
                    {
                        if (invoiceDate < CurrentDate)
                        {
                            MessageBox.Show("Past Date, Sales Invoice, can't be edited");
                            return;
                        }
                        saleInvoiceReturnDetailModelDataGridView.Rows.Clear();
                        saleInvoiceReturnDetailModelDataGridView.Refresh();
                    }

                    saleInvoiceDetailListModelDataGridView.Rows.Clear();
                    saleInvoiceDetailListModelDataGridView.Refresh();
                    RetreiveSaleInvoice(invoiceNo, e.ColumnIndex == 0 ? "R" : "E");
                }
             }
            else if (e.ColumnIndex == 2)
            {
                DialogResult dr = MessageBox.Show(string.Format("Do you want to Re-print the Sale Invoice ({0})", invoiceNo), "Re-print Sales Invoice", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DateTime invDate = (DateTime)saleInvoiceListModelDataGridView.Rows[e.RowIndex].Cells[4].Value;
                    printSaleInvoice(invoiceNo, invDate);
                }
            } 
        }

        private void RetreiveSaleInvoice(string InvoiceNo, String Action)
        {
            RetreiveSaleInvoiceHeader(InvoiceNo, Action);
            RetreiveSaleInvoiceDetail(InvoiceNo, Action);
            deletedInvoiceItemList.Clear();
            CalculateInvoiceBill();


        }

        private void RetreiveSaleInvoiceHeader(string InvoiceNo, string Action)
        {

            var saleInvoiceObj = context.SAL_InvoiceMaster.Where(x => x.InvoiceNo == InvoiceNo).FirstOrDefault();
         
            string invoiceNo = saleInvoiceObj.InvoiceNo;
            DateTime InvoiceDate = saleInvoiceObj.InvoiceDate ?? DateTime.Parse(DateTime.Now.ToShortDateString());

            if (Action == "R")
            {
                invoiceNo = context.Database.SqlQuery<string>("select dbo.Generate_NewSaleInvoiceNo()").Single().ToString();
                InvoiceDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            }                

            saleInvoiceModelBindingSource.DataSource = new SaleInvoiceModel
            {
                InvoiceNo = invoiceNo,
                InvoiceDate = InvoiceDate,
                SSName = saleInvoiceObj.SSName,
                Phone = saleInvoiceObj.Phone
            };
         

        }

        private void RetreiveSaleInvoiceDetail(string InvoiceNo, String Action)
        {

            switch (Action)
            {
                case "R":
                    saleInvoiceReturnDetailModelBindingSource.DataSource = context.sp_saleInvoice_itemDetailForReturn(InvoiceNo).Select(x => new SaleInvoiceReturnDetailModel { AutoID = x.AutoID, InvoiceNo = x.InvoiceNo, ProductCode = x.ProductCode, Qty = x.Qty, PrevReturnedQty = x.PrevReturnedQty ?? 0, AvailableQty = x.AvailableQty ?? 0 }).
                         ToList();
                    InvoiceModeTypeComboBox.SelectedValue = "R";
                    SIItemList.Clear();
                   
                    break;

                case "E":
                    SIItemList = context.SAL_InvoiceDetail.Where(x => x.InvoiceNo == InvoiceNo).Select(s => new SaleInvoiceDetailListModel
                    {
                        InvoiceNo = s.InvoiceNo,
                        ProductCode = s.ProductCode,
                        AutoID = s.AutoID,
                        Rate = s.Rate,
                        DisP = s.DisP,
                        DisAmt = s.DisAmt,
                        NetRate = s.NetRate,
                        Qty = s.Qty,
                        Status = (s.Status == "NEW" || s.Status == null) ? "EDIT" : s.Status,
                        ReferenceID = s.ReferenceID,
                        TotalAmount = (s.NetRate ?? 0) * (s.Qty ?? 0)
                    }).ToList();

                   InvoiceModeTypeComboBox.SelectedValue = "E";
                    break;
            }

            saleInvoiceDetailListModelBindingSource.DataSource = SIItemList;
            
        }

        private void searchProductBtn_Click(object sender, EventArgs e)
        {
            pSearchfrm.ShowDialog();

            if (pSearchfrm.ProductID != "")
            {
                // productCodeTextBox.Text = pSearchfrm.ProductID;

                SetSearchedProductDetail(pSearchfrm.ProductID);
                addProductBtn.Focus();
            }


        }

        private void SetSearchedProductDetail(string productCode)
        {
            var invoiceHeader = (SaleInvoiceModel)saleInvoiceModelBindingSource.DataSource;
         //   var rate = context.Get_EffectiveProductRate(productCode, invoiceHeader.InvoiceDate).FirstOrDefault();
            //execute using edmx database to get result from scalar or table-value functions
            var rate = context.Database.SqlQuery<decimal>(@"select dbo.Get_EffectiveProductRate(@productCode, @invoiceDate)",
                new SqlParameter("productCode", productCode), new SqlParameter("invoiceDate", invoiceHeader.InvoiceDate)).FirstOrDefault();
         
             

            saleInvoiceDetailEditModelBindingSource.DataSource = new SaleInvoiceDetailEditModel
            {

                InvoiceNo = invoiceHeader.InvoiceNo,
                ProductCode = productCode,
                Rate = rate,
                DisP = 0,
                NetRate = (double)rate,
                Qty = 1,
                TotalAmount = (double)rate,
                Status = "NEW"
            };


        }

        private void RecalcuateProductDetailOnChanged(string fieldName)
        {
            saleInvoiceDetailEditModelBindingSource.EndEdit();
            var invoiceDetail = (SaleInvoiceDetailEditModel)saleInvoiceDetailEditModelBindingSource.DataSource;
            // 
            decimal retPrice = invoiceDetail.Rate ?? 0;  //decimal.Parse(rateTextBox.Text == "" ? "0" : rateTextBox.Text);
            decimal netPrice = (decimal)(invoiceDetail.NetRate??0); //decimal.Parse(netRateTextBox.Text == "" ? "0" : netRateTextBox.Text);
            decimal discP = (decimal)(invoiceDetail.DisP??0);  //decimal.Parse(disPTextBox.Text == "" ? "0" : disPTextBox.Text);
            int qty = invoiceDetail.Qty ?? 0; //int.Parse(qtyTextBox.Text == "" ? "0" : qtyTextBox.Text);
            decimal totalAmount = 0;
            switch (fieldName)
            {
                case "RetailPrice":
                case "DiscP":

                    netPrice = Math.Round(retPrice * (1 - (discP / 100)), 2);
                    netRateTextBox.Text = netPrice.ToString();
                    //       netRateTextBox.Focus();
                    netPrice = Math.Round(retPrice * (decimal)(1 - ((invoiceDetail.DisP??0) / 100)), 2);
                    invoiceDetail.NetRate = (double)netPrice;

                    //invoiceDetail.NetRate = (double)netPrice;
                    invoiceDetail.DisAmt = (double)(retPrice - netPrice);

                    break;

                case "DiscPrice":

                    //netPrice = (decimal)invoiceDetail.NetRate;
                    if (retPrice > 0)
                    {
                        discP = Math.Round(100 - (netPrice / retPrice) * 100, 2);
                        disPTextBox.Text = discP.ToString();
                        invoiceDetail.DisP = (double)discP;
                        invoiceDetail.DisAmt = (double)(retPrice - netPrice);
                        // disPTextBox.Focus();
                    }
                    break;

            }
            totalAmount = Math.Round((netPrice * qty), 2);
            totalAmountTextBox.Text = totalAmount.ToString();
            invoiceDetail.TotalAmount = (double)totalAmount;
            saleInvoiceDetailEditModelBindingSource.DataSource = invoiceDetail;
            saleInvoiceDetailEditModelBindingSource.EndEdit();


            //invoiceDetail.TotalAmount= (double)Math.Round((decimal)((invoiceDetail.NetRate??0) * (invoiceDetail.Qty)), 2);

            //  saleInvoiceDetailEditModelBindingSource.DataSource = invoiceDetail;
        }







        private void addProductBtn_Click(object sender, EventArgs e)
        {
            bool ib_new = true;
            saleInvoiceDetailEditModelBindingSource.EndEdit();
            var invoiceDetail = (SaleInvoiceDetailEditModel)saleInvoiceDetailEditModelBindingSource.DataSource;

            if ((invoiceDetail.ProductCode == null || invoiceDetail.ProductCode == "") || (invoiceDetail.NetRate == null || invoiceDetail.NetRate <= 0.00) || (invoiceDetail.Qty == null || invoiceDetail.Qty <= 0))
            {
                MessageBox.Show("Missing/Invalid value in Required field(s)");
                return;
            }
            else
            {
                var validProduct = context.STK_productMaster.Where(x => x.ProductID == invoiceDetail.ProductCode).Count();
                var alreadyAdded = SIItemList.Where(x => x.ProductCode == invoiceDetail.ProductCode).Count();

                if (validProduct == 0 || alreadyAdded > 0)
                {
                    //MessageBox.Show("Either Invalid Product Code or Already Added in Invoice Detail");
                    //return;
                    var updateProductQty = SIItemList.Where(x => x.ProductCode == invoiceDetail.ProductCode).FirstOrDefault();
                    updateProductQty.Qty += 1;
                    updateProductQty.TotalAmount += updateProductQty.NetRate??0; 
                    ib_new = false;
                }


            }
            if (ib_new == true)
            {
                SaleInvoiceDetailListModel newItemRecord = new SaleInvoiceDetailListModel
                {
                    InvoiceNo = invoiceDetail.InvoiceNo,
                    ProductCode = invoiceDetail.ProductCode,
                    Rate = invoiceDetail.Rate,
                    DisP = invoiceDetail.DisP,
                    NetRate = invoiceDetail.NetRate,
                    Qty = invoiceDetail.Qty,
                    TotalAmount = invoiceDetail.TotalAmount,
                    Status = invoiceDetail.Status,
                    DisAmt = invoiceDetail.DisAmt

                };

                SIItemList.Add(newItemRecord);
            }
            //saleInvoiceDetailListModelBindingSource.EndEdit();
            saleInvoiceDetailListModelBindingSource.DataSource = SIItemList.ToList();
            saleInvoiceDetailEditModelBindingSource.DataSource = new SaleInvoiceDetailEditModel { Qty = 1 };
            CalculateInvoiceBill();
            setFocusOnAddedRow(invoiceDetail.ProductCode);
            productCodeTextBox.Focus();
            

        }

        private void setFocusOnAddedRow(string productCode)
        {
           
            DataGridViewRow row = saleInvoiceDetailListModelDataGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[3].Value.ToString().Equals(productCode))
                .First();
            if (row != null)
            {
                saleInvoiceDetailListModelDataGridView.Rows[row.Index].Cells[3].Selected = true;
                saleInvoiceDetailListModelDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
            }
          
        }
        private void rateTextBox_Validated(object sender, EventArgs e)
        {
            RecalcuateProductDetailOnChanged("RetailPrice");
        }

        private void disPTextBox_Validated(object sender, EventArgs e)
        {
            RecalcuateProductDetailOnChanged("DiscP");
        }

        private void netRateTextBox_Validated(object sender, EventArgs e)
        {
            RecalcuateProductDetailOnChanged("DiscPrice");
        }

        private void qtyTextBox_Validated(object sender, EventArgs e)
        {
            RecalcuateProductDetailOnChanged("Qty");
        }

        private void saleInvoiceDetailListModelDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            decimal retPrice = (decimal)saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[4].Value;
            decimal netPrice = decimal.Parse(saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[6].Value.ToString());
            decimal discP = decimal.Parse(saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[5].Value.ToString());
            int qty = (int)saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[7].Value;
         

            //deletedInvoiceItemList

            switch (e.ColumnIndex)
            {
                case 4:
                case 5:  //RetailPrice & DiscP
                    netPrice = Math.Round(retPrice * (1 - (discP / 100)), 2);
                    saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[6].Value = (double)netPrice;
                    saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[8].Value = (double)(retPrice - netPrice);
                    break;

                case 6:  // Net Rate 
                    if (retPrice > 0)
                    {
                        discP = Math.Round(100 - (netPrice / retPrice) * 100, 2);
                        saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[5].Value = (double)discP;
                        saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[8].Value = (double)(retPrice - netPrice);
                    }
                    break;


            }
            saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[10].Value = netPrice * qty;

            CalculateInvoiceBill();





        }

        private void CalculateInvoiceBill()
        {
            int totalItem = 0;
            decimal grandTotal = 0;
            decimal totalDisc = 0;
            decimal NetTotal = 0;
            decimal cashReceived = 0;           
            foreach (DataGridViewRow row in saleInvoiceDetailListModelDataGridView.Rows)
            {
                
                decimal retPrice = row.Cells[4].Value == null ? 0 : (decimal)row.Cells[4].Value;
                int      qty     = row.Cells[7].Value == null?0:(int)row.Cells[7].Value;
                decimal rowRetTotal = (retPrice * qty);
                decimal rowNetTotal = decimal.Parse(row.Cells[10].Value.ToString());
                decimal rowDisc = rowRetTotal - rowNetTotal;
                
                totalItem += (qty<0?0:qty); 
               grandTotal += rowRetTotal;
               totalDisc += rowDisc;
               NetTotal += rowNetTotal;
                
            }
            saleInvoiceBillDetailBindingSource.EndEdit();
            decimal.TryParse(cashReceivedTextBox.Text, out cashReceived);
            totalItemTextBox.Text = totalItem.ToString();
            grandTotalTextBox.Text = grandTotal.ToString();
            totalDiscountTextBox.Text = totalDisc.ToString();
            netTotalTextBox.Text = NetTotal.ToString();
            balanceTextBox.Text = (NetTotal - cashReceived).ToString();
            saleInvoiceBillDetailBindingSource.EndEdit();

            
        }

        private void cashReceivedTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateInvoiceBill();
        }

        private  void saveAndPrintBtn_Click(object sender, EventArgs e)
        {
            saleInvoiceBillDetailBindingSource.EndEdit();
            SaleInvoiceBillDetail invoiceBill = (SaleInvoiceBillDetail)saleInvoiceBillDetailBindingSource.DataSource ;
            saleInvoiceModelBindingSource.EndEdit();
            SaleInvoiceModel invoiceHeader = (SaleInvoiceModel)saleInvoiceModelBindingSource.DataSource;
            saleInvoiceDetailListModelBindingSource.EndEdit();
            IList<SaleInvoiceDetailListModel> invoiceItemsList = (List<SaleInvoiceDetailListModel>)saleInvoiceDetailListModelBindingSource.DataSource;
           
            if (invoiceBill.NetTotal>0 && invoiceBill.CashReceived == 0)
            {
              MessageBox.Show("Please enter the received payment in 'Cash Received' field");

               return;
            }
            if (invoiceHeader.InvoiceDate < DateTime.Parse(DateTime.Now.ToShortDateString()))
            {
                MessageBox.Show("Invoice Date should not be in Past Date");
                return;
            }

            if (invoiceItemsList.Count < 1)
            {
                MessageBox.Show("Invoice should have at least one item");
                return;
            }

           bool saveSts= saveInvoiceData(InvoiceModeTypeComboBox.SelectedValue.ToString());
           if (saveSts)
           {
               printSaleInvoice(invoiceHeader.InvoiceNo, invoiceHeader.InvoiceDate.Value);
               InitilizeSaleInvoice();
               //Reset invoice after saving successful
               if (sendSMSCheckBox.Checked == true)
               {
                 // SMSSaleInvoiceAsync(invoiceBill, invoiceHeader);
                   //Sending by using Async Programming with seperate Thread
                   Thread sendSMSTask = new Thread(()=>SMSSaleInvoiceAsync(invoiceBill, invoiceHeader));
                   sendSMSTask.Start();
                  
               }
              
              
           }
           else
           {
               MessageBox.Show("Sales Invoice can't be saved & print", "Invoice Saving", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
            
            //Invocie Header data source
            //saleInvoiceModelBindingSource
            //Invoice Detail data source
            
        }
        private async void SMSSaleInvoiceAsync(SaleInvoiceBillDetail InvoiceBill, SaleInvoiceModel InvoiceHeader)
        {
            AppConfigurationModel SMSConfig = context.CNF_AppConfiguration.Select(s => new AppConfigurationModel() { Mobile = s.Mobile,
                                                                                                                        BusinessName       = s.BusinessName,           
                                                                                                                        BusinessShortName = s.BusinessShortName, 
                                                                                                                        SMSGateWayURL = s.SMSGateWayURL, 
                                                                                                                        SMSGateWayUser = s.SMSGateWayUser, 
                                                                                                                        SMSGateWayPwd = s.SMSGateWayPwd, 
                                                                                                                        SalesSMSNotification = s.SalesSMSNotification, SMSCountryCode = s.SMSCountryCode }).FirstOrDefault();
            if (SMSConfig.SalesSMSNotification == true)
            {
                if ((InvoiceHeader.Phone != null || InvoiceHeader.Phone == ""))
                   {
                       string smsCountryCode = (SMSConfig.SMSCountryCode == null || SMSConfig.SMSCountryCode == "") ? "92" : SMSConfig.SMSCountryCode;
                       string toNumber = InvoiceHeader.Phone.Substring(0, 1) == "0" ? smsCountryCode + InvoiceHeader.Phone.Substring(1, InvoiceHeader.Phone.Length - 1)
                                                                                : smsCountryCode + InvoiceHeader.Phone;

                    string smsMessageTemplate = Global.GetSalesSMSTemplate();

                    string smsMessage = smsMessageTemplate.Replace("[Customer]", (InvoiceHeader.SSName == null || InvoiceHeader.SSName == "") ? "Customer" : InvoiceHeader.SSName)
                                       .Replace("[InvoiceNo]", InvoiceHeader.InvoiceNo)
                                       .Replace("[InvoiceDate]", InvoiceHeader.InvoiceDate.Value.ToShortDateString())
                                       .Replace("[BillAmount]", InvoiceBill.NetTotal.ToString())
                                       .Replace("[PaidAmount]", InvoiceBill.CashReceived.ToString())
                                       .Replace("[Balance]", InvoiceBill.CashReceived.ToString())
                                       .Replace("[BusinessName]", SMSConfig.BusinessShortName)
                                       .Replace("[PhoneNo]", SMSConfig.Mobile);

                   SMSParamModel SMSObject = new SMSParamModel()
                   {
                       SMSURI = SMSConfig.SMSGateWayURL,
                       UserName = SMSConfig.SMSGateWayUser,
                       Password = SMSConfig.SMSGateWayPwd,
                       ToNumber = toNumber,
                       MessageText = smsMessage,
                       Masking = SMSConfig.BusinessShortName
                   };
                  Task<string> sendSMSTask = Global.SendSMS(SMSObject);
                  string messageResponse = await sendSMSTask;
                  LOG_NotificationSendingData smsLog = new LOG_NotificationSendingData()
                  {
                      NotificationMessage = SMSObject.MessageText,
                      NotificationResponse = messageResponse,
                      CreatedBy = Global.userLogin,
                      CreatedOn = DateTime.Now,
                      NotificationStatus = messageResponse.Contains("OK") ? "Success" : "Failure",
                      NotificationType = "SMS"

                  };
                  context.LOG_NotificationSendingData.Add(smsLog);
                  context.SaveChanges();
                 
                  
                }
            }

           
        }
        private void printSaleInvoice(string invoiceNo, DateTime invoiceDate)
        {
          //  if (! Main.checkIsAlreadyOpenForm("Print Sale Invoice"))
           // {
                Report r = new Report("Print Sale Invoice");
                r.rfObj.FromDate = invoiceDate;
                r.rfObj.ToDate = invoiceDate;
                r.rfObj.InvoiceNo = invoiceNo;
                r.rfObj.ib_directPrint = directPrintCheckBox.Checked;
                r.MdiParent = this.MdiParent;
                r.Show();
            //}
        }
        private bool    saveInvoiceData(string InvoiceType)
        {
            bool ib_regen_SINV = false;
            bool ib_save = false;
            saleInvoiceBillDetailBindingSource.EndEdit();
            SaleInvoiceBillDetail invoiceBill = (SaleInvoiceBillDetail)saleInvoiceBillDetailBindingSource.DataSource;
            SaleInvoiceModel invoiceHeader = (SaleInvoiceModel)saleInvoiceModelBindingSource.DataSource;
            IList<SaleInvoiceDetailListModel> invoiceItemsList = (List<SaleInvoiceDetailListModel>)saleInvoiceDetailListModelBindingSource.DataSource;
            SAL_InvoiceMaster InvoiceMasterObj = null;
            invoiceBill.PaymentMode = paymentModeComboBox.SelectedItem.ToString();

            try
            {
                
                if (InvoiceType == "E")
                {
                    InvoiceMasterObj = context.SAL_InvoiceMaster.Where(x => x.InvoiceNo == invoiceHeader.InvoiceNo).FirstOrDefault();
                    if (InvoiceMasterObj != null)
                    {
                        InvoiceMasterObj.LastModifiedDate = DateTime.Now;

                    }
                }
                else if (InvoiceType == "N" || InvoiceType == "R")
                {
                    InvoiceMasterObj = new SAL_InvoiceMaster();
                    InvoiceMasterObj.CreationDate = DateTime.Now;
                    InvoiceMasterObj.CreatedBy = Global.userLogin;
                    context.SAL_InvoiceMaster.Add(InvoiceMasterObj);
                    var checkInv = context.SAL_InvoiceMaster.Where(w => w.InvoiceNo == invoiceHeader.InvoiceNo).Count();
                    if (checkInv > 0)
                    {
                      string newInvoiceNo = context.Database.SqlQuery<string>("select dbo.Generate_NewSaleInvoiceNo()").Single().ToString();
                      invoiceHeader.InvoiceNo = newInvoiceNo;
                      invoiceNoTextBox.Text = newInvoiceNo;
                      ib_regen_SINV = true;
                    }
                }

                if (InvoiceMasterObj != null)
                {
                    InvoiceMasterObj.InvoiceNo = invoiceHeader.InvoiceNo;
                    InvoiceMasterObj.InvoiceDate = invoiceHeader.InvoiceDate;
                    InvoiceMasterObj.Phone = invoiceHeader.Phone;
                    InvoiceMasterObj.SSName = invoiceHeader.SSName;
                    InvoiceMasterObj.Status = InvoiceType == "N" ? "NEW" : InvoiceType == "E"? "EDIT" : "RETURN";
                    InvoiceMasterObj.dtStamp = DateTime.Now;
                    InvoiceMasterObj.InvoiceType = invoiceBill.PaymentMode;
                    InvoiceMasterObj.ReferenceNo = invoiceBill.paymentRef;
                    InvoiceMasterObj.Invoiceof = "Customer";
                    InvoiceMasterObj.UserName = Global.userLogin;
                    InvoiceMasterObj.LastModifiedDate = DateTime.Now;
                    InvoiceMasterObj.LastModifiedBy = Global.userLogin;
                    InvoiceMasterObj.ReceivedAmount =(decimal)invoiceBill.CashReceived;
                    InvoiceMasterObj.BalanceAmount = (decimal)invoiceBill.Balance;
                   
                }

                SAL_InvoiceDetail invoiceDetailObj = null;
                IList<SAL_InvoiceDetail> updateableItemList = new List<SAL_InvoiceDetail>();
                foreach (var invoiceItem in invoiceItemsList)
                {
                    invoiceDetailObj = null;
                    if (invoiceItem.AutoID == 0 && (invoiceItem.Status == "NEW" || invoiceItem.Status == "RETURN"))
                    {
                        invoiceDetailObj = new SAL_InvoiceDetail();
                        context.SAL_InvoiceDetail.Add(invoiceDetailObj);

                    }
                    else if (invoiceItem.AutoID != 0 && invoiceItem.Status == "EDIT")
                    {
                        invoiceDetailObj = context.SAL_InvoiceDetail.Where(x => x.InvoiceNo == invoiceItem.InvoiceNo && x.AutoID == invoiceItem.AutoID).FirstOrDefault();
                        updateableItemList.Add(invoiceDetailObj);
                    }

                    if (invoiceDetailObj != null)
                    {
                        invoiceDetailObj.InvoiceNo = ib_regen_SINV == false ? invoiceItem.InvoiceNo : invoiceHeader.InvoiceNo;
                        invoiceDetailObj.ProductCode = invoiceItem.ProductCode;
                        invoiceDetailObj.Qty = invoiceItem.Qty;
                        invoiceDetailObj.Rate = invoiceItem.Rate;
                        invoiceDetailObj.DisP = invoiceItem.DisP;
                        invoiceDetailObj.NetRate = invoiceItem.NetRate;
                        invoiceDetailObj.DisAmt = invoiceItem.DisAmt;
                        invoiceDetailObj.Status = invoiceItem.Status;
                        invoiceDetailObj.ReferenceID = invoiceItem.ReferenceID;
                        
                        
                    }

                }
                //delete removed items
                if (deletedInvoiceItemList.Count > 0)
                {
                    foreach (var deleteItem in deletedInvoiceItemList)
                    {
                        var deleteInvoiceItem = context.SAL_InvoiceDetail.Where(s => s.AutoID == deleteItem).FirstOrDefault();
                        if (deleteInvoiceItem != null)
                        {
                            context.SAL_InvoiceDetail.Remove(deleteInvoiceItem);
                        }
                    }
                }
                context.SaveChanges();
                ib_save = true;
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invoice Saving Error");
                ib_save = false;

            }

            return ib_save;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void resetInvoice_Click(object sender, EventArgs e)
        {
            InitilizeSaleInvoice();
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
          
         }

        private void phoneTextBox_TabIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            saleInvoiceModelBindingSource.EndEdit();
            var customerName = context.SAL_InvoiceMaster.Where(y => y.Phone == phoneTextBox.Text).Select(x => x.SSName).FirstOrDefault();
            sSNameTextBox.Text = customerName == null ? "" : customerName;
            saleInvoiceModelBindingSource.EndEdit();
        }

        private void saleInvoiceDetailListModelDataGridView_Click(object sender, EventArgs e)
        {
            

        }

        private void saleInvoiceDetailListModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            int autoID = (int)saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[2].Value;
            string productCode = (string)saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[3].Value;
            string status = (string)saleInvoiceDetailListModelDataGridView.CurrentRow.Cells[11].Value;

            //deletedInvoiceItemList
           
            if (e.ColumnIndex == 0)
            {
                if (status == "RETURN")
                {
                    MessageBox.Show("In Return, item can't be removed?", "Remove Item");
                    return;
                }
                
                DialogResult dr = MessageBox.Show("Do you want to Remove the item(Yes/No)?", "Remove Item", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No) return;

                saleInvoiceDetailListModelDataGridView.Rows.Remove(saleInvoiceDetailListModelDataGridView.CurrentRow);
                saleInvoiceDetailListModelDataGridView.Refresh();
                if (status == "EDIT")
                {
                    deletedInvoiceItemList.Add(autoID);
                }
                else if (status == "NEW")
                {

                    SIItemList.Remove(SIItemList.FirstOrDefault(s => s.ProductCode == productCode));
                }
                CalculateInvoiceBill();

            }
        }

        private void saleInvoiceReturnDetailModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
               // bool returnSts = (bool)saleInvoiceReturnDetailModelDataGridView.CurrentRow.Cells[0].Value;
                saleInvoiceReturnDetailModelDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                              
            }

        }
              
      
        private void saleInvoiceReturnDetailModelDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                // bool returnSts = (bool)saleInvoiceReturnDetailModelDataGridView.CurrentRow.Cells[0].Value;
                
                bool returnSts = (bool)saleInvoiceReturnDetailModelDataGridView.CurrentCell.Value;
                int availableQty =(int) saleInvoiceReturnDetailModelDataGridView.CurrentRow.Cells[5].Value;
                string productCode = (string)saleInvoiceReturnDetailModelDataGridView.CurrentRow.Cells[3].Value;
               if(returnSts == true)
               {
                if (availableQty < 1 )
                {
                    MessageBox.Show("No Available Qty. Can't be selected for return");
                    saleInvoiceReturnDetailModelDataGridView.CurrentCell.Value = false;
                    saleInvoiceReturnDetailModelDataGridView.CancelEdit();
                    return;
                }
                var findProdCount = SIItemList.Where(x => x.ProductCode == productCode).Count();
                if (findProdCount > 0)
                {
                    MessageBox.Show("Selected return item is already added in Product(s) Detail Section");
                    saleInvoiceReturnDetailModelDataGridView.CurrentCell.Value = false;
                    saleInvoiceReturnDetailModelDataGridView.CancelEdit();
                    return;
                }
                   //Add return item in invoice
                addReturnProductRow(saleInvoiceReturnDetailModelDataGridView.CurrentRow, returnSts);
               }
               else
               {
                   //remove added return item from invoice
                   addReturnProductRow(saleInvoiceReturnDetailModelDataGridView.CurrentRow, returnSts);
               }
            }

        }

        private void applyReturn_Click(object sender, EventArgs e)
        {

            if (saleInvoiceReturnDetailModelDataGridView.RowCount < 1)
            {
                MessageBox.Show("Invoice Item(s) for return records are not available. Please first fetch the detail.");
                return;
            }
            SaleInvoiceModel invoiceHeader = (SaleInvoiceModel)saleInvoiceModelBindingSource.DataSource;

            bool ib_returnItemAdd = false;
            foreach (DataGridViewRow row in saleInvoiceReturnDetailModelDataGridView.Rows)
            {
                
               bool returnSts = row.Cells[0].Value== null? false :(bool)row.Cells[0].Value;
               if (returnSts == true)
               {
                   ib_returnItemAdd = addReturnProductRow(row, returnSts);

                   //string invoiceNo= (string)row.Cells[1].Value;
                   //string productCode = (string)row.Cells[3].Value;
                   //int autoID = (int)row.Cells[2].Value;
                   //int availableQty = (int)row.Cells[5].Value;
                   //Math.Round(122.22, 2);
                   //var invoiceItemRecord = context.SAL_InvoiceDetail.Where(x => x.InvoiceNo == invoiceNo && x.ProductCode == productCode && x.AutoID == autoID).Select(s => new { Rate = s.Rate, DisP = s.DisP, NetRate = s.NetRate }).FirstOrDefault();
                   //if (invoiceItemRecord != null)
                   //{
                   //    SaleInvoiceDetailListModel newItemRecord = new SaleInvoiceDetailListModel
                   //    {
                   //        InvoiceNo = invoiceHeader.InvoiceNo,
                   //        ProductCode = productCode,
                   //        Rate = invoiceItemRecord.Rate,
                   //        DisP = invoiceItemRecord.DisP,
                   //        NetRate = invoiceItemRecord.NetRate,
                   //        Qty = (availableQty * -1),
                   //        TotalAmount = Math.Round( (double) (invoiceItemRecord.NetRate * (availableQty * -1)), 2),
                   //        Status = "RETURN",
                   //        ReferenceID = autoID

                   //    };

                   //    SIItemList.Add(newItemRecord);
                   //    ib_returnItemAdd = true;
                   //    //saleInvoiceDetailListModelBindingSource.EndEdit();
                   //  //  saleInvoiceDetailListModelBindingSource.DataSource = SIItemList.ToList();

                   //}


               }

            }

            if (ib_returnItemAdd)
            {
                //saleInvoiceDetailListModelBindingSource.DataSource = SIItemList.ToList();
                //CalculateInvoiceBill();
            }
            else
            {
                MessageBox.Show("Either Return item is not selected/There is error in adding item");
            }
        }

        private bool addReturnProductRow(DataGridViewRow row, bool returnSts)
        {
            SaleInvoiceModel invoiceHeader = (SaleInvoiceModel)saleInvoiceModelBindingSource.DataSource;
            bool ib_returnItemAddRemove = false;

            if (returnSts == true)
            {
                string invoiceNo = (string)row.Cells[1].Value;
                string productCode = (string)row.Cells[3].Value;
                int autoID = (int)row.Cells[2].Value;
                int availableQty = (int)row.Cells[5].Value;
                Math.Round(122.22, 2);
                var invoiceItemRecord = context.SAL_InvoiceDetail.Where(x => x.InvoiceNo == invoiceNo && x.ProductCode == productCode && x.AutoID == autoID).Select(s => new { Rate = s.Rate, DisP = s.DisP, NetRate = s.NetRate }).FirstOrDefault();
                if (invoiceItemRecord != null)
                {
                    SaleInvoiceDetailListModel newItemRecord = new SaleInvoiceDetailListModel
                    {
                        InvoiceNo = invoiceHeader.InvoiceNo,
                        ProductCode = productCode,
                        Rate = invoiceItemRecord.Rate,
                        DisP = invoiceItemRecord.DisP,
                        NetRate = invoiceItemRecord.NetRate,
                        Qty = (availableQty * -1),
                        TotalAmount = Math.Round((double)(invoiceItemRecord.NetRate * (availableQty * -1)), 2),
                        Status = "RETURN",
                        ReferenceID = autoID

                    };

                    SIItemList.Add(newItemRecord);
                    ib_returnItemAddRemove = true;
                }
            }
            else
            {
                string productCode = (string)row.Cells[3].Value;
                int autoID = (int)row.Cells[2].Value;
                var removeItemObj = SIItemList.Where(w => w.ReferenceID == autoID && w.ProductCode == productCode).FirstOrDefault();
                if (removeItemObj != null)
                {
                    SIItemList.Remove(removeItemObj);
                    ib_returnItemAddRemove = true;
                }

            }

            if (ib_returnItemAddRemove)
            {
                saleInvoiceDetailListModelBindingSource.DataSource = SIItemList.ToList();
                CalculateInvoiceBill();
            }
            return ib_returnItemAddRemove;
        }
        private void productCodeTextBox_TabIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void productCodeTextBox_Leave(object sender, EventArgs e)
        {
            string productCode = productCodeTextBox.Text;
            if (productCode != "") 
            { 
                int checkProduct = context.STK_productMaster.Where(x => x.ProductID == productCode).Count();

                if (checkProduct == 0)
                {
                    MessageBox.Show("Entered product code is not found. Please enter the defined code");
                    saleInvoiceDetailEditModelBindingSource.DataSource = new SaleInvoiceDetailEditModel { Qty = 1 };
                    return;
                }

                SetSearchedProductDetail(productCode);
                addProductBtn.Focus();
           }
        }

        private void directPrintCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void productCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string productCode = productCodeTextBox.Text;
                if (productCode != "")
                {
                    int checkProduct = context.STK_productMaster.Where(x => x.ProductID == productCode).Count();

                    if (checkProduct == 0)
                    {
                        MessageBox.Show("Entered product code is not found. Please enter the defined code");
                        saleInvoiceDetailEditModelBindingSource.DataSource = new SaleInvoiceDetailEditModel { Qty = 1 };
                        return;
                    }

                    SetSearchedProductDetail(productCode);
                    addProductBtn.PerformClick();
                }
            }
        }
        private void POSShortcutBtnClickEventHandling(string sourceBtnSuffix){
           
                int shortcutSeq = int.Parse(sourceBtnSuffix);
                if (shortcutSeq > 0)
                {
                    var productID = context.STK_productMaster.Where(w=> w.POSShortcutBtnSeq == shortcutSeq).Select(s => s.ProductID).FirstOrDefault();
                    if (productID != null)
                    {
                        SetSearchedProductDetail(productID);
                        addProductBtn.PerformClick();
                    }
                }
            
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void contactNoNumPadBtn_Click(object sender, EventArgs e)
        {
            numPadDialog.ShowDialog();
            if(numPadDialog.EnteredNumber!=""){
                saleInvoiceModelBindingSource.EndEdit();
                phoneTextBox.Text = numPadDialog.EnteredNumber;
                saleInvoiceModelBindingSource.EndEdit();
                phoneTextBox.Focus();
            }

                

        }

        private void amtpaidNumPadbtn_Click(object sender, EventArgs e)
        {
            numPadDialog.ShowDialog();
            if (numPadDialog.EnteredNumber != "")
            {               
                cashReceivedTextBox.Text = numPadDialog.EnteredNumber;
                cashReceivedTextBox.Focus();
                CalculateInvoiceBill();
            }

        }

        private void SaleInvoice_Shown(object sender, EventArgs e)
        {
            InitilizeSalePOSShortcutbuttons();
            productCodeTextBox.Focus();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("9");
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("10");
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("11");
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("12");
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("13");
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("14");
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("15");
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("16");
        }

        private void btn_17_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("17");
        }

        private void btn_18_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("18");
        }

        private void btn_19_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("19");
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("20");
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("21");
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("22");
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("23");
        }

        private void btn_24_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("24");
        }

        private void btn_25_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("25");
        }

        private void btn_26_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("26");
        }

        private void btn_27_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("27");
        }

        private void btn_28_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("28");
        }

        private void btn_29_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("29");
        }

        private void btn_30_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("30");
        }

        private void btn_31_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("31");
        }

        private void btn_32_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("32");
        }

        private void btn_33_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("33");
        }

        private void btn_34_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("34");
        }

        private void btn_35_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("35");
        }

        private void btn_36_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("36");
        }

        private void btn_37_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("37");
        }

        private void btn_38_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("38");
        }

        private void btn_39_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("39");
        }

        private void btn_40_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("40");
        }

        private void btn_41_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("41");
        }

        private void btn_42_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("42");
        }

        private void btn_43_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("43");
        }

        private void btn_44_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("44");
        }
               

        private void btn_45_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("45");
        }

        private void btn_46_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("46");
        }

        private void btn_47_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("47");
        }

        private void btn_48_Click(object sender, EventArgs e)
        {
            POSShortcutBtnClickEventHandling("48");
        }

              
        }
   }
