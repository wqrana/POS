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
using MetroFramework.Forms;
using DevFstPOSSuite.Models;
namespace DevFstPOSSuite
{
    public partial class DailySale : MetroForm
    {
        RetailDBEntities1 context;
       
        public DailySale()
        {
            InitializeComponent();
            context = new RetailDBEntities1();
            //  oDateTimePicker = new DateTimePicker();
           
        }

      
        private void DailySale_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            dateTimePickerTo.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            DataSourceBinding(); 
               


        }
        private void DataSourceBinding()
        {
            BindingDaySaleClosureEditDetail();
            BindingDaySaleClosureGrid();
                       

        }

        private void BindingDaySaleClosureEditDetail()
        {

            daySaleClosureEditModelBindingSource.DataSource = new DaySaleClosureEditModel() 
            { SaleDate = DateTime.Parse(DateTime.Now.ToShortDateString()), CashInHand = 0, TotalSale = 0, 
              AdjustedIncomeLoss=0,  AdjustedExpense = 0, TotalCashInHand = 0, WithdrawCash = 0, POCashAdjustment=0, SaleClosure = 0 , IsClosed=false};
        }
        private void BindingDaySaleClosureGrid()
        {

            daySaleClosureModelBindingSource.DataSource = context.POSaleDetails.Select(x => new DaySaleClosureModel()
            {
                ID = x.ID,
                SaleDate = x.SaleDate,
                CashInHand = x.CashInHand,
                TotalSale = x.TotalSale,
                AdjustedExpense = x.AdjustedExpense,
                AdjustedIncomeLoss = x.AdjustedIncomeLoss,
                WithdrawCash = x.WithdrawCash,
                WithdrawBy = x.WithdrawBy,
                POCashAdjustment = x.POCashAdjustment,
                SaleClosure = x.SaleClosure,
                ClosureBy = x.ClosureBy,
                IsClosed = x.IsClosed,
                Remarks = x.Remarks,
                LastModifiedOn = x.LastModifiedOn
            }).Where(y => y.SaleDate >= dateTimePickerFrom.Value && y.SaleDate <= dateTimePickerTo.Value).OrderByDescending(o => o.SaleDate).ToList();

            daySaleClosureModelDataGridView.PerformLayout();           
         
          }

       

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            BindingDaySaleClosureGrid();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool ibSave = false;
           // daySaleClosureEditModelBindingSource
            daySaleClosureEditModelBindingSource.EndEdit();
            var DayClosureEditRecord = (DaySaleClosureEditModel)daySaleClosureEditModelBindingSource.DataSource;
           
            if (DayClosureEditRecord.SaleDate == null) 
            {
                MessageBox.Show("Please fill the required fields", "Required Field(s)");
                return;
            }
            else 
            {
                var recordCount = context.POSaleDetails.Where(x => (x.SaleDate == DayClosureEditRecord.SaleDate) && (x.ID != DayClosureEditRecord.ID)).Count();
                if (recordCount > 0)
                {
                    MessageBox.Show(string.Format("Sale Closure record is already exist for Sales Date ({0}), Please select from List and Edit it.",DayClosureEditRecord.SaleDate.Value.ToShortDateString()), "Already Exist Record");
                    return;
                }

                if (DayClosureEditRecord.SaleClosure < 0)
                {
                    MessageBox.Show(string.Format("Sales Closing Cash is in Negative ({0}), Please correct the Closing Detail.", DayClosureEditRecord.SaleClosure.ToString()), "Negative Closure Amount");
                    return;
                }
            }

            if (DayClosureEditRecord.ID == 0)
            {

                POSaleDetail newSaleClosure = new POSaleDetail()
                {
                    SaleDate = DayClosureEditRecord.SaleDate,
                    CashInHand = DayClosureEditRecord.CashInHand,
                    AdjustedExpense = DayClosureEditRecord.AdjustedExpense,
                     AdjustedIncomeLoss = DayClosureEditRecord.AdjustedIncomeLoss,
                    TotalSale = DayClosureEditRecord.TotalSale,
                    WithdrawCash = DayClosureEditRecord.WithdrawCash,
                    WithdrawBy = DayClosureEditRecord.WithdrawBy,
                     POCashAdjustment = DayClosureEditRecord.POCashAdjustment,
                    SaleClosure = DayClosureEditRecord.SaleClosure,
                    ClosureBy = DayClosureEditRecord.ClosureBy,
                    IsClosed = DayClosureEditRecord.IsClosed,
                    Remarks = DayClosureEditRecord.Remarks,
                    LastModifiedOn = DateTime.Now
                     
                };

                context.POSaleDetails.Add(newSaleClosure);
                ibSave = true;

            }
            else
            {
                var editSaleClosure = context.POSaleDetails.Find(DayClosureEditRecord.ID);
                if (editSaleClosure != null)
                {
                   editSaleClosure.SaleDate = DayClosureEditRecord.SaleDate;
                   editSaleClosure.CashInHand = DayClosureEditRecord.CashInHand;
                   editSaleClosure.AdjustedExpense = DayClosureEditRecord.AdjustedExpense;
                   editSaleClosure.AdjustedIncomeLoss = DayClosureEditRecord.AdjustedIncomeLoss;
                   editSaleClosure.TotalSale = DayClosureEditRecord.TotalSale;
                   editSaleClosure.WithdrawCash = DayClosureEditRecord.WithdrawCash;
                   editSaleClosure.WithdrawBy = DayClosureEditRecord.WithdrawBy;
                   editSaleClosure.POCashAdjustment = DayClosureEditRecord.POCashAdjustment;
                   editSaleClosure.SaleClosure = DayClosureEditRecord.SaleClosure;
                   editSaleClosure.ClosureBy = DayClosureEditRecord.ClosureBy;
                   editSaleClosure.IsClosed = DayClosureEditRecord.IsClosed;
                   editSaleClosure.Remarks = DayClosureEditRecord.Remarks;
                   editSaleClosure.LastModifiedOn = DateTime.Now;
                   ibSave = true;
                }

            }
            if (ibSave == true)
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Record is saved successfully", "Confirmation");
                    DataSourceBinding();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
            }
        }

        private void daySaleClosureModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 1)
            {
                var option = MessageBox.Show(this, "Are you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (option == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow row = daySaleClosureModelDataGridView.Rows[e.RowIndex];
                        var obj = (DaySaleClosureModel)row.DataBoundItem;
                        var entity = context.POSaleDetails.Find(obj.ID);
                        context.POSaleDetails.Remove(entity);
                        context.SaveChanges();
                        MessageBox.Show(this, "Record has been deleted succussfully!");
                        // userModelBindingSource.DataSource = context.AuthenticationRules.ToList();
                        DataSourceBinding();
                        // resetUserFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }

            }

            if (e.ColumnIndex == 2)
            {

                DataGridViewRow row = daySaleClosureModelDataGridView.Rows[e.RowIndex];
                var obj = (DaySaleClosureModel)row.DataBoundItem;


                daySaleClosureEditModelBindingSource.DataSource = new DaySaleClosureEditModel
                {
                   SaleDate= obj.SaleDate,
                   CashInHand = obj.CashInHand??0,
                   AdjustedExpense = obj.AdjustedExpense??0,
                   AdjustedIncomeLoss = obj.AdjustedIncomeLoss??0,
                   TotalSale = obj.TotalSale??0,
                   TotalCashInHand = (obj.CashInHand??0 + obj.TotalSale??0 + obj.AdjustedIncomeLoss??0 - obj.AdjustedExpense??0),
                   WithdrawCash = obj.WithdrawCash??0,
                   WithdrawBy = obj.WithdrawBy,
                   CashForClosing = (obj.CashInHand??0 + obj.TotalSale??0 + obj.AdjustedIncomeLoss??0 - obj.AdjustedExpense??0) -  obj.WithdrawCash??0,
                   POCashAdjustment = obj.POCashAdjustment,
                   SaleClosure = obj.SaleClosure??0,
                   ClosureBy = obj.ClosureBy,
                   IsClosed = obj.IsClosed,
                   Remarks = obj.Remarks,
                   ID = obj.ID
                 };

               
            }
        }

        private void resetRecord_Click(object sender, EventArgs e)
        {
            BindingDaySaleClosureEditDetail();
        }

        private void withdrawCashTextBox_TextChanged(object sender, EventArgs e)
        {
           // CalculateClosingCash(isClosedCheckBox.Checked);
            CalculateClosingValues("Withdraw");
        }

        private void isClosedLabel_Click(object sender, EventArgs e)
        {

        }

        private void isClosedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
          //  CalculateClosingCash(isClosedCheckBox.Checked);

            closureByTextBox.Text = isClosedCheckBox.Checked ? Global.userLogin : null;
            daySaleClosureEditModelBindingSource.EndEdit();
            
        }

        private void CalculateTotalCash()
        {
            
            var initalValue = "0";
             daySaleClosureEditModelBindingSource.EndEdit();
              var rec = (DaySaleClosureEditModel)daySaleClosureEditModelBindingSource.DataSource;
               decimal OpeningCashAmount = 0;
            
                    var result = Decimal.TryParse(cashInHandTextBox.Text, out OpeningCashAmount);
                    if (result == true)
                    {
                        initalValue = (rec.CashInHand + rec.TotalSale + rec.AdjustedIncomeLoss - rec.AdjustedExpense).ToString();
                    }

                 totalCashInHandTextBox.Text = initalValue;
                daySaleClosureEditModelBindingSource.EndEdit();
        }

        private void CalculateClosingCash(bool isClosed)
        {
            try
            {
                var initalValue = "0";
                if (isClosed) 
                { 
                    daySaleClosureEditModelBindingSource.EndEdit();
                    var rec = (DaySaleClosureEditModel)daySaleClosureEditModelBindingSource.DataSource;
                    decimal withdrawAmount = 0;
                    var result = Decimal.TryParse(withdrawCashTextBox.Text, out withdrawAmount);
                    if (result == true)
                    {
                        initalValue = (rec.CashInHand + rec.TotalSale + rec.AdjustedIncomeLoss - rec.AdjustedExpense - withdrawAmount).ToString();
                    }
                }

                saleClosureTextBox.Text = initalValue;
                daySaleClosureEditModelBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");

            }

        }

        private void CalculateClosingValues(string ChangedFieldName)
        {
            daySaleClosureEditModelBindingSource.EndEdit();
            var closingRec = (DaySaleClosureEditModel)daySaleClosureEditModelBindingSource.DataSource;
            decimal CashinHand = closingRec.CashInHand??0, Withdraw = closingRec.WithdrawCash??0, Adjustment = closingRec.POCashAdjustment??0;
            decimal TotalCash = 0, CashForClosing = 0, FinalClosingCash = 0;

            try
            {

                switch (ChangedFieldName)
                {
                    case "CashInHand":
                        Decimal.TryParse(cashInHandTextBox.Text, out CashinHand);
                        break;
                    case "WithDraw":
                        Decimal.TryParse(withdrawCashTextBox.Text, out Withdraw);
                        break;
                    case "Adjustment":
                        Decimal.TryParse(POAdjustmentTextBox.Text, out Adjustment);
                        break;
                }

                TotalCash = CashinHand + (closingRec.TotalSale ?? 0) + (closingRec.AdjustedIncomeLoss ?? 0) - (closingRec.AdjustedExpense ?? 0);
                CashForClosing   = TotalCash - Withdraw;
                FinalClosingCash = CashForClosing + Adjustment;

                totalCashInHandTextBox.Text = TotalCash.ToString();
                CashForClosingTextBox.Text = CashForClosing.ToString();
                saleClosureTextBox.Text = FinalClosingCash.ToString();
                daySaleClosureEditModelBindingSource.EndEdit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");

            }


        }

        private void cashInHandTextBox_TextChanged(object sender, EventArgs e)
        {
            //CalculateTotalCash();
            //CalculateClosingCash(isClosedCheckBox.Checked);
            CalculateClosingValues("CashInHand");
        }

        private void applyReturn_Click(object sender, EventArgs e)
        {
            try 
            { 
             daySaleClosureEditModelBindingSource.EndEdit();
             var rec = (DaySaleClosureEditModel)daySaleClosureEditModelBindingSource.DataSource;
             var recordSet = context.sp_rp_dailySaleStat(rec.SaleDate, rec.SaleDate).FirstOrDefault();
             if (recordSet == null)
             {
                 MessageBox.Show("Please first save the Sale Closure record with minimum information then Re-calculate the sales/Expense", "Information");
                 return;

             }
             adjustedExpenseTextBox.Text = recordSet.TotalAdjustedExpense == null ? "0" : recordSet.TotalAdjustedExpense.Value.ToString();
             totalSaleTextBox.Text = recordSet.TotalSale == null ? "0" : recordSet.TotalSale.Value.ToString();
             AdjustedIncomeLossTextBox.Text = recordSet.AdjustedPOSIncomeLoss == null ? "0" : recordSet.AdjustedPOSIncomeLoss.ToString();  
            // CalculateTotalCash();
            // CalculateClosingCash(isClosedCheckBox.Checked);
             CalculateClosingValues("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
             
        }

        private void POAdjustmentTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateClosingValues("Adjustment");
        }

        private void daySaleClosureModelDataGridView_MouseMove(object sender, MouseEventArgs e)
        {
         }        
        

        



        
    }
}