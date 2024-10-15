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
    public partial class MiscIncome : MetroFramework.Forms.MetroForm
    {
          RetailDBEntities1 context;
        public MiscIncome()
        {
            InitializeComponent();
            context =  new RetailDBEntities1();
        }

        private void MiscIncome_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            dateTimePickerTo.Value = DateTime.Parse(DateTime.Now.ToShortDateString());

            pOIncomeTypeModelBindingSource.DataSource = context.CNF_IncomeType.Select(x => new POIncomeTypeModel() { ID = x.ID, Name = x.Name }).ToList();

            DataSourceBinding();
        }
        
      private void DataSourceBinding()
      {

         BindingIncomeEditDataSource();
         BindingIncomeDetailGrid();


      }
      
        private void BindingIncomeEditDataSource()
      {
         pOIncomeEditModelBindingSource.DataSource = new POIncomeEditModel() { PostingDate =DateTime.Parse(DateTime.Now.ToShortDateString()), PostingAmount=0 };
         
      }

      private void BindingIncomeDetailGrid()
      {
         
          pOIncomeModelBindingSource.DataSource = context.POIncomes.Select( x=> new POIncomeModel()
          { ID = x.ID, PostingDate = x.PostingDate, IncomeType = x.IncomeType, PostingAmount= x.PostingAmount, AdjustedInPOS = x.AdjustedInPOS ,Reference = x.Reference 
          }).Where(w => w.PostingDate >= dateTimePickerFrom.Value && w.PostingDate <= dateTimePickerTo.Value).OrderByDescending(o=> o.ID).ToList();
       
         
      }
      
        private void resetRecord_Click(object sender, EventArgs e)
        {
            BindingIncomeEditDataSource();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

           
              bool ibSave = false;

              pOIncomeEditModelBindingSource.EndEdit();

              var incomeEditRecord = (POIncomeEditModel)pOIncomeEditModelBindingSource.DataSource;
              incomeEditRecord.IncomeType = (int?)comboBox_IncomeType.SelectedValue; 
           
            if(incomeEditRecord.PostingDate== null || incomeEditRecord.IncomeType == null ||
                incomeEditRecord.PostingAmount == 0 ) {

                    MessageBox.Show("Please fill the required fields", "Required Field(s)");
                    return;
            }
                    
            if (incomeEditRecord.ID == 0)
            {

                POIncome newIncome = new POIncome
                {
                    PostingDate = incomeEditRecord.PostingDate,
                    IncomeType = incomeEditRecord.IncomeType,
                    PostingAmount = incomeEditRecord.PostingAmount,
                    AdjustedInPOS = incomeEditRecord.AdjustedInPOS,
                    Reference = incomeEditRecord.Reference,
                    CreatedBy = Global.userLogin

                };

                context.POIncomes.Add(newIncome);
                ibSave = true;

            }
            else
            {
                var editIncome = context.POIncomes.Find(incomeEditRecord.ID);
                if (editIncome != null)
                {
                    editIncome.PostingDate = incomeEditRecord.PostingDate;
                    editIncome.PostingAmount = incomeEditRecord.PostingAmount;
                    editIncome.AdjustedInPOS = incomeEditRecord.AdjustedInPOS;
                    editIncome.IncomeType = incomeEditRecord.IncomeType;
                    editIncome.Reference = incomeEditRecord.Reference;
                    editIncome.LastUpdatedBy = Global.userLogin;
                    editIncome.LastUpdatedDate = DateTime.Now; 

                
                    ibSave = true;
                }

            }
            if (ibSave == true)
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Income is saved successfully", "Confirmation");
                    DataSourceBinding();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
            } 
          
        }

        private void pOIncomeModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             
            if (e.ColumnIndex == 0)
            {
                var option = MessageBox.Show(this, "Are you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (option == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow row = pOIncomeModelDataGridView.Rows[e.RowIndex];
                        var obj = (POIncomeModel)row.DataBoundItem;
                        var entity = context.POIncomes.Find(obj.ID);
                        context.POIncomes.Remove(entity);
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

            if (e.ColumnIndex == 1)
            {

                DataGridViewRow row = pOIncomeModelDataGridView.Rows[e.RowIndex];
                var obj = (POIncomeModel)row.DataBoundItem;
                                
                pOIncomeEditModelBindingSource.DataSource = new POIncomeEditModel
                {
                    ID = obj.ID,
                     PostingDate = obj.PostingDate,
                     IncomeType = obj.IncomeType,
                      PostingAmount = obj.PostingAmount,
                       AdjustedInPOS = obj.AdjustedInPOS,
                       Reference = obj.Reference
                   
                     
                };

                comboBox_IncomeType.SelectedValue = obj.IncomeType;

            }

            
        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            BindingIncomeDetailGrid();
        }
  

    }
}
