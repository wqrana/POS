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
    public partial class ProductActivity : MetroForm
    {
        RetailDBEntities1 context;
        Productcs p;

        public ProductActivity()
        {
            InitializeComponent();

            context = new RetailDBEntities1();

          //  this.WindowState = FormWindowState.Maximized;

            p = new Productcs();
            p.Visible = false;
        }

        private void ProductActivity_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            dateTimePickerTo.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            BindActivityDataSource();
        }

        private void BindActivityDataSource()
        {
            BindActivityEditSource();
            BindActivityGridDataSource();

        }
        private void BindActivityEditSource()

        {

            pOActivitEdityModelBindingSource.DataSource = new POActivitEdityModel() { ActivityDate = DateTime.Parse(DateTime.Now.ToShortDateString()), ActivityType = "Exchange", CompletionDate = DateTime.Parse(DateTime.Now.ToShortDateString()) };
            targetSrh_btn.Enabled = true;
            targetProductQtyTextBox.ReadOnly = false;
            comboBox_activityType.SelectedItem = "Exchange";
            comboBox_ActivityStatus.SelectedItem = "Pending";
        }
        private void BindActivityGridDataSource()
        {
            

            string filterStr = TextBox_filter.Text;

            pOActivityModelBindingSource.DataSource = context.POActivityDetails.Select(s => new POActivityModel()
            {
                ActivityID = s.ActivityID,
                ActivityDate = s.ActivityDate,
                ActivityType = s.ActivityType,
                Status = s.Status,
                SourceProductCode = s.SourceProductCode,
                SourceProductQty = s.SourceProductQty,
                TargetProductCode = s.TargetProductCode,
                TargetProductQty = s.TargetProductQty,
                TargetLocation = s.TargetLocation,
                ActivityDetailDesc = s.ActivityDetailDesc,
                CompletionDate = s.CompletionDate,
                NetDealerPrice = s.NetDealerPrice,
                LastUpdatedOn = s.LastUpdatedOn,
                 UserID = s.UserID
            }).
            Where(w => w.ActivityDate >= dateTimePickerFrom.Value && w.ActivityDate <= dateTimePickerTo.Value).
            Where(w2 => filterStr == "" ? w2.SourceProductCode.ToLower().Contains(w2.SourceProductCode.ToLower()) : w2.SourceProductCode.ToLower().Contains(filterStr.ToLower()) ||
                 w2.TargetProductCode.ToLower().Contains(filterStr.ToLower()) ||w2.ActivityType.ToLower().Contains(filterStr.ToLower())).OrderByDescending(o => o.ActivityDate).
            ToList();                 
                                                                                                                      

        }
        private void comboBox_activityType_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string activityType = comboBox_activityType.SelectedItem.ToString();

            switch (activityType)
            {
                case "Exchange":
                    targetProductQtyTextBox.ReadOnly = false;
                    targetSrh_btn.Enabled = true;
                    break;
                case "Returned":
                case "TransferTo":
                case "TransferFrom":
                    targetProductQtyTextBox.ReadOnly = true;
                    targetSrh_btn.Enabled = false;
                    targetProductCodeTextBox.Text = "";
                    targetProductQtyTextBox.Text = "0";
                    pOActivitEdityModelBindingSource.EndEdit();
                    break;
                                    
            }

           
        }

        private void sourceSrhBtn_Click(object sender, EventArgs e)
        {
              p.ShowDialog();
              if (p.ProductID != "")
              {
                  sourceProductCodeTextBox.Text = p.ProductID;
                  sourceProductQtyTextBox.Focus();
                  var netRate = context.POInventoryDetails.Where(w => w.ProductCode == p.ProductID).Max(m => m.NetDealerPrice)??0;
                  netDealerPriceTextBox.Text = netRate.ToString();
                  pOActivitEdityModelBindingSource.EndEdit();

              }
        }

        private void targetSrh_btn_Click(object sender, EventArgs e)
        {
            p.ShowDialog();
            if (p.ProductID != "")
            {
                targetProductCodeTextBox.Text = p.ProductID;
                targetProductQtyTextBox.Focus();
                pOActivitEdityModelBindingSource.EndEdit();

            }
        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            BindActivityGridDataSource();
        }

        private void pOActivityModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void resetRecord_Click(object sender, EventArgs e)
        {
            BindActivityEditSource();
        }

        private void pOActivityModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
               DataGridViewRow row = pOActivityModelDataGridView.Rows[e.RowIndex];
               var obj = (POActivityModel)row.DataBoundItem;      
               DialogResult dr = MessageBox.Show("Do you want to Delete the Activity(Yes/No)?", "Delete Activity", MessageBoxButtons.YesNo);
               if (dr == DialogResult.No) return;
                  try
                    {
                        var activityObj = context.POActivityDetails.Find(obj.ActivityID);
                        if (activityObj != null)
                        {
                            context.POActivityDetails.Remove(activityObj);
                            context.SaveChanges();
                           
                            pOActivityModelDataGridView.Rows.Remove(pOActivityModelDataGridView.Rows[e.RowIndex]);
                            pOActivityModelDataGridView.Refresh();
                            BindActivityEditSource();
                            MessageBox.Show("Activity is deleted succussfully!", "Information");
                          
                        }
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

              }
                          
            else if (e.ColumnIndex == 1)
            {
                //Edit PO Activity
                DataGridViewRow row = pOActivityModelDataGridView.Rows[e.RowIndex];
                var obj = (POActivityModel)row.DataBoundItem;
                pOActivitEdityModelBindingSource.DataSource = new POActivitEdityModel()
                {
                   ActivityID = obj.ActivityID,
                   ActivityDate = obj.ActivityDate,
                   ActivityType = obj.ActivityType,
                   Status = obj.Status,
                   SourceProductCode = obj.SourceProductCode,
                   SourceProductQty = obj.SourceProductQty,
                   TargetProductCode = obj.TargetProductCode,
                   TargetProductQty = obj.TargetProductQty,
                   CompletionDate = obj.CompletionDate,
                   TargetLocation = obj.TargetLocation,
                   NetDealerPrice = obj.NetDealerPrice,
                   ActivityDetailDesc = obj.ActivityDetailDesc
                   
                };
                comboBox_ActivityStatus.SelectedItem = obj.Status;
                comboBox_activityType.SelectedItem = obj.ActivityType;

            }
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            bool ibSave = false;
            bool ibMissingfield = false;
            pOActivitEdityModelBindingSource.EndEdit();
            var activityData = (POActivitEdityModel)pOActivitEdityModelBindingSource.DataSource;
            string activityType = comboBox_activityType.SelectedItem.ToString();
            string activityStatus = comboBox_ActivityStatus.SelectedItem==null ?"" :comboBox_ActivityStatus.SelectedItem.ToString(); 
            
            POActivityDetail activityObj = null;
            activityData.ActivityType = activityType;
            activityData.Status = activityStatus;

            activityData.CompletionDate = activityStatus == "Pending" ? null : activityData.CompletionDate == null ? DateTime.Parse(DateTime.Now.ToShortDateString()) : activityData.CompletionDate;

            if ((activityData.ActivityType == null || activityData.ActivityType=="")||(activityData.Status==null ||activityData.Status=="" )||(activityData.SourceProductCode==null ||activityData.SourceProductCode=="")||
                (activityData.SourceProductQty==null || activityData.SourceProductQty == 0) || (activityData.NetDealerPrice == 0))
            {
                ibMissingfield = true;
              
            }
            else if (activityData.ActivityType == "Exchange" && ( (activityData.TargetProductCode == null || activityData.TargetProductCode == "") || (activityData.TargetProductQty ==null|| activityData.TargetProductQty == 0)))
            {
                ibMissingfield = true;
            }

            if (ibMissingfield)
            {
                MessageBox.Show("Please fill the required fields (*) to save the record", "Required Field(s)");
                return;

            }
            if (activityData.ActivityID == 0)
            {
                //new record
                activityObj = new POActivityDetail()
                {
                    ActivityDate = activityData.ActivityDate,
                    ActivityType = activityData.ActivityType,
                    Status = activityData.Status,
                    SourceProductCode = activityData.SourceProductCode,
                    SourceProductQty = activityData.SourceProductQty,
                    TargetProductCode = activityData.TargetProductCode,
                    TargetProductQty =  activityData.TargetProductQty,
                    CompletionDate = activityData.CompletionDate,
                    TargetLocation = activityData.TargetLocation,
                    NetDealerPrice = activityData.NetDealerPrice,
                    ActivityDetailDesc = activityData.ActivityDetailDesc,
                    CreatedOn = DateTime.Now,
                    UserID = Global.userLogin
                                       

                };
                context.POActivityDetails.Add(activityObj);
                ibSave = true;

            }
            else
            {
                //edit record
                activityObj = context.POActivityDetails.Find(activityData.ActivityID);
                if (activityObj != null)
                {
                    activityObj.ActivityDate = activityData.ActivityDate;
                    activityObj.ActivityType = activityData.ActivityType;
                    activityObj.Status = activityData.Status;
                    activityObj.SourceProductCode = activityData.SourceProductCode;
                    activityObj.SourceProductQty = activityData.SourceProductQty;
                    activityObj.TargetProductCode = activityData.TargetProductCode;
                    activityObj.TargetProductQty =  activityData.TargetProductQty;
                    activityObj.CompletionDate = activityData.CompletionDate;
                    activityObj.TargetLocation = activityData.TargetLocation;
                    activityObj.NetDealerPrice = activityData.NetDealerPrice;
                    activityObj.ActivityDetailDesc = activityData.ActivityDetailDesc;
                    activityObj.LastUpdatedOn = DateTime.Now;
                    activityObj.UserID = Global.userLogin;

                    ibSave = true;
                }
            }

            if (ibSave == true)
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Activity is saved successfully", "Confirmation");
                    BindActivityDataSource();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Activity can't be saved due to some internal errors", "Confirmation");
            }



        }

        private void comboBox_ActivityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       
       
    }
}
