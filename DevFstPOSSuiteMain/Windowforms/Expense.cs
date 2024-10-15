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
    public partial class Expense : MetroForm
    {
        RetailDBEntities1 context;
       
        public Expense()
        {
            InitializeComponent();
            context = new RetailDBEntities1();

           // this.WindowState = FormWindowState.Maximized;

          //  oDateTimePicker = new DateTimePicker();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            dateTimePickerTo.Value =  DateTime.Parse(DateTime.Now.ToShortDateString());

            DataSourceBinding();
         
            

        }
        private void DataSourceBinding()
        {

            BindingExpenseEditDataSource();
            BindingExpenseDetailGrid();

            
        }
        private void BindingExpenseEditDataSource()
        {
            expenseEditModelBindingSource.DataSource = new ExpenseEditModel() { ExpenseDate = DateTime.Parse(DateTime.Now.ToShortDateString()), ExpenseAmount = 0 };
            comboBoxExpenseType.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
        }

        private void BindingExpenseDetailGrid()
        {
            expenseModelBindingSource.DataSource = context.POExpenseDetails.Select(x => new ExpenseModel()
            {
                ID = x.ID,
                ExpenseDate = x.ExpenseDate,
                ExpenseType = x.ExpenseType,
                ExpenseDesc = x.ExpenseDesc,
                ExpenseAmount = x.ExpenseAmount,
                Remarks = x.Remarks,
                Status = x.Status,
                AdjustedDate = x.AdjustedDate
            }).Where(y => (y.ExpenseDate >= dateTimePickerFrom.Value && y.ExpenseDate <= dateTimePickerTo.Value)
                    || (y.AdjustedDate >= dateTimePickerFrom.Value && y.AdjustedDate <= dateTimePickerTo.Value) 
                ).OrderBy(o=>o.ExpenseDate).ThenBy(b=> b.ID).ToList();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            BindingExpenseDetailGrid();
        }

        private void expenseAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            double amount=0.00;
            bool sts = Double.TryParse(expenseAmountTextBox.Text, out amount);
            if (sts == false) expenseAmountTextBox.Text = "0.00";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool ibSave = false;

            expenseEditModelBindingSource.EndEdit();
            var expenseEditRecord = (ExpenseEditModel)expenseEditModelBindingSource.DataSource;
            expenseEditRecord.ExpenseType = comboBoxExpenseType.SelectedItem.ToString();
            expenseEditRecord.Status = comboBoxStatus.SelectedItem.ToString();
            if (expenseEditRecord.AdjustedDate == null && expenseEditRecord.Status == "Adjusted")
                expenseEditRecord.AdjustedDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            if(expenseEditRecord.ExpenseDate== null || (expenseEditRecord.ExpenseType == null || expenseEditRecord.ExpenseType == "") ||
                (expenseEditRecord.ExpenseAmount.Value <= 0 ) || (expenseEditRecord.Status == null ||expenseEditRecord.Status=="" )){

                    MessageBox.Show("Please fill the required fields", "Required Field(s)");
                    return;
            }
            if (expenseEditRecord.Status == "Adjusted" && expenseEditRecord.AdjustedDate == null)
            {
                MessageBox.Show("Please Select the Adjusted Date from Calender.", "Adjusted Date)");
                return;
            }
            else if (expenseEditRecord.Status != "Adjusted")
            {
                expenseEditRecord.AdjustedDate = null;
            }

            expenseEditRecord.ExpenseDate = DateTime.Parse(expenseEditRecord.ExpenseDate.Value.ToShortDateString());
            expenseEditRecord.AdjustedDate = expenseEditRecord.AdjustedDate == null ? expenseEditRecord.AdjustedDate : DateTime.Parse(expenseEditRecord.AdjustedDate.Value.ToShortDateString());

            if (expenseEditRecord.ID == 0)
            {

                POExpenseDetail newExpense = new POExpenseDetail
                {
                    ExpenseDate = expenseEditRecord.ExpenseDate,
                    ExpenseType = expenseEditRecord.ExpenseType,
                    ExpenseDesc = expenseEditRecord.ExpenseDesc,
                    ExpenseAmount = expenseEditRecord.ExpenseAmount,
                    Remarks = expenseEditRecord.Remarks,
                    Status = expenseEditRecord.Status,
                    AdjustedDate = expenseEditRecord.AdjustedDate

                };

                context.POExpenseDetails.Add(newExpense);
                ibSave = true;

            }
            else
            {
                var editExpense = context.POExpenseDetails.Find(expenseEditRecord.ID);
                if (editExpense != null)
                {
                    editExpense.ExpenseDate = expenseEditRecord.ExpenseDate;
                    editExpense.ExpenseType = expenseEditRecord.ExpenseType;
                    editExpense.ExpenseDesc = expenseEditRecord.ExpenseDesc;
                    editExpense.ExpenseAmount = expenseEditRecord.ExpenseAmount;
                    editExpense.Remarks = expenseEditRecord.Remarks;
                    editExpense.Status = expenseEditRecord.Status;
                    editExpense.AdjustedDate = expenseEditRecord.AdjustedDate;
                
                    ibSave = true;
                }

            }
            if (ibSave == true)
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Expense is saved successfully", "Confirmation");
                    DataSourceBinding();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
            }


        }

        private void expenseModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                var option = MessageBox.Show("Are you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (option == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow row = expenseModelDataGridView.Rows[e.RowIndex];
                        var obj = (ExpenseModel)row.DataBoundItem;
                        var entity = context.POExpenseDetails.Find(obj.ID);
                        context.POExpenseDetails.Remove(entity);
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

                DataGridViewRow row = expenseModelDataGridView.Rows[e.RowIndex];
                var obj = (ExpenseModel)row.DataBoundItem;


                expenseEditModelBindingSource.DataSource = new ExpenseEditModel
                {
                    ID = obj.ID,
                    ExpenseDate = obj.ExpenseDate,
                    ExpenseType = obj.ExpenseType,
                    ExpenseAmount = obj.ExpenseAmount,
                    ExpenseDesc = obj.ExpenseDesc,
                    Remarks = obj.Remarks,
                    Status = obj.Status,
                     AdjustedDate = obj.AdjustedDate
                     
                };

                comboBoxExpenseType.SelectedItem = obj.ExpenseType;
                comboBoxStatus.SelectedItem = obj.Status;

            }
        }

        private void resetRecord_Click(object sender, EventArgs e)
        {
            BindingExpenseEditDataSource();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adjustedDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        
     
       
    }
}
