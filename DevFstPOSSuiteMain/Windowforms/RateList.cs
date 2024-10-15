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
using MetroFramework.Forms;
using MetroFramework.Controls;
using DevFstPOSSuite.Windowforms;

namespace DevFstPOSSuite.Windowforms
{
    public partial class RateList : MetroForm
    {
        RetailDBEntities1 context = null;
        bool ibEditRateRecord = false;
        bool ibEditRateDetailRecord = false;
        bool ibInitForm = true;
        Productcs pSrh = null;

        public RateList()
        {
            InitializeComponent();
            pSrh = new Productcs();
            pSrh.Visible = false;
        }

        private void RateList_Load(object sender, EventArgs e)

        {
            context = new RetailDBEntities1();
 
            effectiveDatePicker.Format = DateTimePickerFormat.Short;

            DataBindingSource();

          
        }

        private void rateListIdTextBox_Enter(object sender, EventArgs e)
        {
            bool resetRateDetail = selectedRateListID.Text == "" ? false : true;

            resetListGridviewSelection();

            if (resetRateDetail)
            {
                RetrieveRateListDetailRecords();
            }

        }

        private void resetListGridviewSelection()
        {
            rateListDataGridView.ClearSelection();
          
            textBox_SelectedRateList.Text= "";
            selectedRateListID.Text = "";
            rateListIdTextBox.Focus();
        }
        private void DataBindingSource()
        {
            
            RetrieveRateListRecords();
            BindingRateListEditDataSource();

          

        }

        private void BindingRateListEditDataSource()
        {
            rateListEditModelBindingSource.DataSource = new RateListEditModel { StartDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()) };
        }
        private void RetrieveRateListRecords()
        {
            rateListModelBindingSource.DataSource = context.SAL_RateList.OrderByDescending(o=>o.dtStamp).Where(x => x.RateListId.Contains(filterRateListTxtBox.Text) || x.Name.ToLower().Contains(filterRateListTxtBox.Text.ToLower())).Select(y => new RateListModel { RateListId = y.RateListId, Name = y.Name, StartDate = y.StartDate }).ToList();


        }
        private void RetrieveRateListDetailRecords()
        {

            BindingRateListDetailEditDataSource();

            rateListDetailModelBindingSource.DataSource = context.SAL_RateListDetail.Where(l => l.RateListId == selectedRateListID.Text).Where(x => x.ProductCode.ToLower().Contains(filterRateListDetailTxtBox.Text)).Select(

                d => new RateListDetailModel { RateListId = d.RateListId, ProductCode = d.ProductCode, Rate = d.Rate }).ToList();
                

        }

        private void BindingRateListDetailEditDataSource()
        {
            rateListDetailEditModelBindingSource.DataSource = new RateListDetailEditModel { RateListId = selectedRateListID.Text };
        }

        private void RateSaveBtn_Click(object sender, EventArgs e)

        {
            Boolean ibSave = false;
            var rateListRecord = (RateListEditModel)rateListEditModelBindingSource.DataSource;

            if((rateListRecord.RateListId == null || rateListRecord.RateListId == "") || (rateListRecord.Name == null || rateListRecord.Name == "")
                || rateListRecord.StartDate == null)
            {
                MessageBox.Show("Missing required field(s)");
                return;
            }
            var findEffectiveDate = context.SAL_RateList.Where(x => x.StartDate == rateListRecord.StartDate && x.RateListId != rateListRecord.RateListId).Count();
            if (findEffectiveDate > 0)
            {
                MessageBox.Show("Effective of Date of Rate List can't be same, Please check the list");
                return;

            }

            if (!ibEditRateRecord)
            {
                // new rate list
                var findRec = context.SAL_RateList.Where(x => x.RateListId == rateListRecord.RateListId).Count();
                if (findRec > 0)
                {
                    MessageBox.Show("Record is already exist");
                    return;

                }
               

                var newRateRecord = new SAL_RateList
                {
                    RateListId = rateListRecord.RateListId,
                    Name = rateListRecord.Name,
                    StartDate = rateListRecord.StartDate,
                    username = Global.userLogin,
                    dtStamp = DateTime.Now
                };

                context.SAL_RateList.Add(newRateRecord);
                ibSave = true;
                
            }
            else
            {
                //edit record
                var editRateRecord = context.SAL_RateList.Find(rateListRecord.RateListId);
                if (editRateRecord != null)
                {

                    editRateRecord.Name = rateListRecord.Name;
                    editRateRecord.StartDate = rateListRecord.StartDate;
                    editRateRecord.username = Global.userLogin;
                    editRateRecord.dtStamp = DateTime.Now;
                    
                    ibEditRateRecord = false;
                    rateListIdTextBox.ReadOnly = false;
                    ibSave = true;
                }

                
            }

            if (ibSave == true)
            {
                context.SaveChanges();
               // MessageBox.Show("Rate List record is saved successfully!");
                DataBindingSource();
                resetListGridviewSelection();
                RetrieveRateListDetailRecords();
              
            } 
        }

        private void RateList_Shown(object sender, EventArgs e)
        {
            resetListGridviewSelection();

            ibInitForm = false;
        }

        private void rateListDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!ibInitForm) {

                var rateRow = rateListDataGridView.Rows[e.RowIndex];

                textBox_SelectedRateList.Text = rateRow.Cells[2].Value.ToString() + " - " + rateRow.Cells[3].Value.ToString();
                selectedRateListID.Text = rateRow.Cells[2].Value.ToString();

                RetrieveRateListDetailRecords();
                
            }
            
        }

        private void rateListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void rateDetailSaveBtn_Click(object sender, EventArgs e)
          {
              bool ibSave = false;
            if (selectedRateListID.Text == "")
            {
                MessageBox.Show("Please first select the Rate List from Rate List Grid");
                return;
            }

            var rateListDetailRecord = (RateListDetailEditModel) rateListDetailEditModelBindingSource.DataSource;

            if ((rateListDetailRecord.ProductCode == null || rateListDetailRecord.ProductCode == "") || (rateListDetailRecord.Rate == null|| rateListDetailRecord.Rate == 0.00))
            {
                MessageBox.Show("Missing required fields");
                return;
            }
            
            if (!ibEditRateDetailRecord)
            {
                var findExistingRec = context.SAL_RateListDetail.Where(x => x.RateListId == rateListDetailRecord.RateListId && x.ProductCode == rateListDetailRecord.ProductCode).Count();
                if (findExistingRec > 0)
                {
                    MessageBox.Show("Product Rate is already added, Please Search and check");
                    return;
                }

                var newRateListDetailRecord = new SAL_RateListDetail
                {
                    RateListId = rateListDetailRecord.RateListId,
                    ProductCode = rateListDetailRecord.ProductCode,
                    Rate = rateListDetailRecord.Rate,
                    username = Global.userLogin,
                    dtStamp = DateTime.Now

                };
                context.SAL_RateListDetail.Add(newRateListDetailRecord);
                ibSave = true;
            }
            else
            {
                //Edit Record

                var editRateListDetailRecord = context.SAL_RateListDetail.Where(x => x.RateListId == rateListDetailRecord.RateListId && x.ProductCode == rateListDetailRecord.ProductCode).FirstOrDefault();

                if (editRateListDetailRecord != null)
                {
                    editRateListDetailRecord.Rate = rateListDetailRecord.Rate;

                    ibEditRateDetailRecord = false;
                    //productCodeTextBox.ReadOnly = false;
                    srhPrdBtn.Enabled = true;
                    ibSave = true;
                }

               
            }

            if (ibSave)
            {
                context.SaveChanges();
                RetrieveRateListDetailRecords();
                productCodeTextBox.Focus();

            }
        }

        private void srhPrdBtn_Click(object sender, EventArgs e)
        {
            if (selectedRateListID.Text == "")
            {
                MessageBox.Show("Please first select the Rate List from Rate List Grid");
                return;
            }

            pSrh.ShowDialog();

            if (pSrh.ProductID != "")
            {
                productCodeTextBox.Text = pSrh.ProductID;
                productCodeTextBox.Focus();
                rateTextBox.Focus();
                //pSrh.ProductID = "";
            }
        }

        private void rateListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                var editRecord = (RateListModel)rateListDataGridView.Rows[e.RowIndex].DataBoundItem;

                var detailRows = rateListDetailDataGridView.RowCount;
                if (detailRows > 0)
                {
                    MessageBox.Show("Please delete the Rate List Detail records first");
                    return;
                }
                 var option = MessageBox.Show(this, "Do you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (option == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        var removeObj = context.SAL_RateList.Find(editRecord.RateListId);
                        if (removeObj != null)
                        {

                            context.SAL_RateList.Remove(removeObj);
                            context.SaveChanges();
                            MessageBox.Show(this, "Record has been deleted succussfully!");
                            ibInitForm = true;
                            RetrieveRateListRecords();
                            resetListGridviewSelection();
                            ibInitForm = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }



            }
            else if (e.ColumnIndex == 1)
            {
                var editRecord = (RateListModel) rateListDataGridView.Rows[e.RowIndex].DataBoundItem;

                rateListEditModelBindingSource.DataSource = new RateListEditModel
                {
                    RateListId = editRecord.RateListId,
                    Name = editRecord.Name,
                    StartDate = editRecord.StartDate

                };
                rateListIdTextBox.ReadOnly = true;
                rateListIdTextBox.Focus();
                ibEditRateRecord = true;
            }
        }

        private void rateListDetailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)

            {
                var editDetailRecord = (RateListDetailModel)rateListDetailDataGridView.Rows[e.RowIndex].DataBoundItem;
                var option = MessageBox.Show(this, "Do you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (option == System.Windows.Forms.DialogResult.Yes)
                {

                    try
                    {
                        var removeObj = context.SAL_RateListDetail.Where(w => w.RateListId == editDetailRecord.RateListId && w.ProductCode == editDetailRecord.ProductCode).FirstOrDefault();
                        if (removeObj != null)
                        {

                            context.SAL_RateListDetail.Remove(removeObj);
                            context.SaveChanges();
                            MessageBox.Show(this, "Record has been deleted succussfully!");
                           RetrieveRateListDetailRecords();
        
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

            }
            
            else if (e.ColumnIndex == 1)
            {
                var editDetailRecord = (RateListDetailModel)rateListDetailDataGridView.Rows[e.RowIndex].DataBoundItem;

                rateListDetailEditModelBindingSource.DataSource = new RateListDetailEditModel
                {

                    RateListId = editDetailRecord.RateListId,
                    ProductCode = editDetailRecord.ProductCode,
                    Rate = editDetailRecord.Rate
                };

                ibEditRateDetailRecord = true;
                productCodeTextBox.ReadOnly = true;
                srhPrdBtn.Enabled = false;

            }

        }

        private void filterRateListTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void filterRateListTxtBox_TextChanged(object sender, EventArgs e)
        {
            RetrieveRateListRecords();
        }

        private void filterRateListDetailTxtBox_TextChanged(object sender, EventArgs e)
        {
            RetrieveRateListDetailRecords();
        }

        private void resetRateList_Click(object sender, EventArgs e)
        {
            BindingRateListEditDataSource();
            rateListIdTextBox.ReadOnly = false;
            ibEditRateRecord = false;
           
        }

        private void resetRateListDetail_Click(object sender, EventArgs e)
        {
            BindingRateListDetailEditDataSource();
          
        }
    }
}
