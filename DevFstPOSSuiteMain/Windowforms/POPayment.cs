using System;
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

namespace DevFstPOSSuite.Windowforms
{
    public partial class POPayment : MetroFramework.Forms.MetroForm
    {
        RetailDBEntities1 context;
        public POPayment()
        {
            InitializeComponent();
            context = new RetailDBEntities1();
        }

        private void POPayment_Load(object sender, EventArgs e)
        {
            supplierModelBindingSource.DataSource = context.CNF_Supplier.Select(s => new SupplierModel() { ID = s.ID, ShortName = s.ShortName }).ToList();
            bankBindingSource.DataSource = context.CNF_Bank.Select(s => new Bank() { ID = s.ID, ShortName = s.ShortName }).ToList();

            BindingPaymentMainSource();


        }

        private void BindingPaymentMainSource()
        {
            pOPaymentModelBindingSource.DataSource = new POPaymentModel() { PaymentDate = DateTime.Parse(DateTime.Now.ToShortDateString()) };
            comboBox_PaymentMode.SelectedItem = "Cash";
            pOPaymentModelBindingSource.EndEdit();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void PendingPmtSrhBtn_Click(object sender, EventArgs e)
        {
            var SupplierID = ComboBox_PendingPmtsupplier.SelectedValue == null ? null : (int?)ComboBox_PendingPmtsupplier.SelectedValue;
            comboBox_paymentSupplier.SelectedValue = SupplierID;
            setSupplierDefaultBank("");         
            RetrieveAndBindPendingpayments();
        }

        private void RetrieveAndBindPendingpayments()
        {
            var supplierID = ComboBox_PendingPmtsupplier.SelectedValue == null ? null : (int?)ComboBox_PendingPmtsupplier.SelectedValue; 
            var srhText = TextBox_filterPendingPmt.Text;

            var pendingPaymentList = context.POInventoryMasters.Where(x=> x.InvoiceAmount>0 && x.PaymentStatus!="Paid").Select(s => new POPaymentDetailModel() { ID = s.ID, SupplierID = s.SupplierID, InvoiceNo = s.InvoiceNo, InvoiceAmount = s.InvoiceAmount, DueDate = s.DueDate, PaidPaymentAmount = s.PaymentAmount })
                .Where(w=> (w.SupplierID == supplierID) && (srhText==""? w.InvoiceNo.Contains(w.InvoiceNo): w.InvoiceNo.Contains(srhText)))
                .OrderBy(o => o.DueDate).ToList();
            pOPaymentDetailModelBindingSource.DataSource = pendingPaymentList;
        }

        private void ComboBox_PendingPmtsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CalculateTotalPayment()
        {
            
            decimal TotalPayment = 0;
            decimal TotalAdjustment = 0;
            
            foreach (DataGridViewRow row in pOPaymentDetailModelDataGridView.Rows)
            {
                string InvNo = row.Cells[4].Value.ToString() ;
                bool ibSelected = row.Cells[1].Value == null ? false : (bool)row.Cells[1].Value;
                decimal InvAmount = row.Cells[6].Value == null ? 0 : (decimal)row.Cells[6].Value;
                decimal paidAmount = row.Cells[8].Value == null ? 0 : (decimal)row.Cells[8].Value;

                decimal newPayment = row.Cells[9].Value == null ? 0 : (decimal)row.Cells[9].Value;
                decimal adjustment = row.Cells[10].Value == null ? 0 : (decimal)row.Cells[10].Value;
                
                if (ibSelected) {

                    if ((InvAmount - paidAmount) < (newPayment + adjustment))
                    {
                        MessageBox.Show(string.Format("Invoice({0}), Entered payment is greater than balance amount({1}), difference({2})", InvNo, (InvAmount - paidAmount), (InvAmount - paidAmount) - (newPayment + adjustment)));
                        //row.Cells[1].Value = false;
                        newPayment = (InvAmount - paidAmount);
                        adjustment = 0;
                        row.Cells[9].Value = newPayment;
                        row.Cells[10].Value = adjustment;
                        row.Cells[11].Value = 0;
                      
                    }
                    else
                    {
                        row.Cells[11].Value = (InvAmount - paidAmount) - (newPayment + adjustment);

                    }

                    TotalPayment += newPayment;
                    TotalAdjustment += adjustment;
                }
            }

            pOPaymentModelBindingSource.EndEdit();
            paymentAmountTextBox.Text = TotalPayment.ToString();
            adjustmentAmountTextBox.Text = TotalAdjustment.ToString();
            pOPaymentModelBindingSource.EndEdit();


        }

        private void pOPaymentDetailModelDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            //{
            //    bool ib_pay = (bool)pOPaymentDetailModelDataGridView[e.ColumnIndex, e.RowIndex].Value;
            //    var row = pOPaymentDetailModelDataGridView.Rows[e.RowIndex];
            //    if (ib_pay == true)
            //    {
            //        decimal InvAmount = row.Cells[6].Value == null ? 0 : (decimal)row.Cells[6].Value;
            //        decimal paidAmount = row.Cells[8].Value == null ? 0 : (decimal)row.Cells[8].Value;
            //        row.Cells[9].Value = InvAmount - paidAmount;     
            //    }
            //}

            CalculateTotalPayment();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            pOPaymentModelBindingSource.EndEdit();

            List<POInventoryMaster> updateOrderList = new List<POInventoryMaster>();
            var PaymentMainDetail = (POPaymentModel)pOPaymentModelBindingSource.DataSource;
            PaymentMainDetail.SupplierID = comboBox_paymentSupplier.SelectedValue == null ? null : (int?)comboBox_paymentSupplier.SelectedValue;
            PaymentMainDetail.PaymentBankID = comBox_PaymentBankID.SelectedValue == null ? null : (int?)comBox_PaymentBankID.SelectedValue;
            PaymentMainDetail.PaymentMode = comboBox_PaymentMode.SelectedItem == null ? null : comboBox_PaymentMode.SelectedItem.ToString();

            DialogResult dr = MessageBox.Show("Do you want to save the payment (Yes/No)?", "Payment", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No) return;

            var checkPayment = (PaymentMainDetail.PaymentAmount??0) + (PaymentMainDetail.AdjustmentAmount??0);

            if (checkPayment == 0 || PaymentMainDetail.SupplierID==null)
            {
                MessageBox.Show("Missing Payment Detail, Please verify before further proceed");
                return;
            }
            try
            {
                POPaymentDisbursement newPaymentRecord = new POPaymentDisbursement()
                {
                    SupplierID = PaymentMainDetail.SupplierID,
                    PaymentDate = PaymentMainDetail.PaymentDate,
                    PaymentMode = PaymentMainDetail.PaymentMode,
                    PaymentBankID = PaymentMainDetail.PaymentBankID,
                    PaymentAccount = PaymentMainDetail.PaymentAccount,
                    PaymentAmount = PaymentMainDetail.PaymentAmount,
                    PaymentReference = PaymentMainDetail.PaymentReference,
                    AdjustmentAmount = PaymentMainDetail.AdjustmentAmount,
                    Remarks = PaymentMainDetail.Remarks,
                    CreatedBy = Global.userLogin,
                    CreationDate = DateTime.Now

                };

                context.POPaymentDisbursements.Add(newPaymentRecord);
                context.SaveChanges();
                if (newPaymentRecord.ID != null)
                {
                    foreach (DataGridViewRow row in pOPaymentDetailModelDataGridView.Rows)
                    {
                        bool ibSelected = row.Cells[1].Value == null ? false : (bool)row.Cells[1].Value;

                        if (ibSelected)
                        {

                            POPaymentDetailModel newDetailRecord = (POPaymentDetailModel)row.DataBoundItem;
                            if (newDetailRecord.ID != 0)
                            {

                                POPaymentDisbursementDetail newDetailDBObj = new POPaymentDisbursementDetail()
                                {
                                    DisbursementID = newPaymentRecord.ID,
                                    OrderID = newDetailRecord.ID,
                                    PaidPayment = newDetailRecord.PaymentAmount,
                                    AdjustedPayment = newDetailRecord.AdjustedAmount,
                                    CreatedBy = Global.userLogin,
                                    CreationDate = DateTime.Now
                                };

                                context.POPaymentDisbursementDetails.Add(newDetailDBObj);

                                var POInvMasterDBObj = context.POInventoryMasters.Find(newDetailRecord.ID);
                                if (POInvMasterDBObj != null)
                                {

                                    POInvMasterDBObj.PaymentAmount = (POInvMasterDBObj.PaymentAmount ?? 0) + (newDetailDBObj.PaidPayment ?? 0) + (newDetailDBObj.AdjustedPayment ?? 0);
                                    POInvMasterDBObj.PaymentDate = newPaymentRecord.PaymentDate;
                                    POInvMasterDBObj.LastUpdateDate = newPaymentRecord.CreationDate;
                                    POInvMasterDBObj.Reference = newPaymentRecord.PaymentReference;
                                    if ((POInvMasterDBObj.InvoiceAmount ?? 0) > (POInvMasterDBObj.PaymentAmount ?? 0))
                                    {
                                        POInvMasterDBObj.PaymentStatus = "Partial Paid";
                                    }
                                    else
                                    {
                                        POInvMasterDBObj.PaymentStatus = "Paid";
                                    }

                                    updateOrderList.Add(POInvMasterDBObj);

                                }


                            }

                        }

                     
                    }

                    context.SaveChanges();
                    MessageBox.Show("Payment is saved Successfully!");
                    BindingPaymentMainSource();
                    RetrieveAndBindPendingpayments();

                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void pOPaymentDetailModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
               
                pOPaymentDetailModelDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                bool ib_pay = (bool)pOPaymentDetailModelDataGridView[e.ColumnIndex, e.RowIndex].Value;
                var row = pOPaymentDetailModelDataGridView.Rows[e.RowIndex];
                if (ib_pay == true)
                {
                    decimal InvAmount = row.Cells[6].Value == null ? 0 : (decimal)row.Cells[6].Value;
                    decimal paidAmount = row.Cells[8].Value == null ? 0 : (decimal)row.Cells[8].Value;
                    decimal adjustmentAmt = row.Cells[10].Value == null ? 0 : (decimal)row.Cells[10].Value;
                    decimal balanceAmt= 0;
                    row.Cells[9].Value = InvAmount - paidAmount;
                    row.Cells[9].ReadOnly = false;
                    row.Cells[10].ReadOnly = false;
                    row.Cells[11].Value = balanceAmt;
                }
                else
                {
                    row.Cells[9].Value = null;
                    row.Cells[10].Value = null;
                    row.Cells[11].Value = null;
                    row.Cells[9].ReadOnly = true;
                    row.Cells[10].ReadOnly = true;

                }

                pOPaymentDetailModelDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                CalculateTotalPayment();      
            }
        }

        private void pOPaymentDetailModelDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          /*

            if (e.ColumnIndex == 1 && e.RowIndex>=0)
            {
                bool ib_pay = (bool)pOPaymentDetailModelDataGridView[e.ColumnIndex, e.RowIndex].Value;
                if (ib_pay == true)
                {

                }
            }
           */
            

        }

        private void comboBox_paymentSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_paymentSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (comboBox_paymentSupplier.SelectedValue == null) return;
            
            //setSupplierDefaultBank("");
        }

        private void setSupplierDefaultBank(string fieldType)
        {
            var supID = (int)comboBox_paymentSupplier.SelectedValue;
            var supplierDetail = context.CNF_Supplier.Select(s => new { ID = s.ID, BankID = s.DefaultBankID, AccNo = s.AccountNo }).Where(w => w.ID == supID).FirstOrDefault();
            if (supplierDetail.BankID != 1)
            {
                comboBox_PaymentMode.SelectedItem = "Bank Deposit";
                comBox_PaymentBankID.SelectedValue = supplierDetail.BankID;
                paymentAccountTextBox.Text = supplierDetail.AccNo;
            }
            else
            {
                paymentAccountTextBox.Text = "";
                comboBox_PaymentMode.SelectedItem = "Cash";
                comBox_PaymentBankID.SelectedValue = supplierDetail.BankID;
            }
            pOPaymentModelBindingSource.EndEdit();

        }
    }
}
