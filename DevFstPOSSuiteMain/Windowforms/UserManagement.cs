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

namespace DevFstPOSSuite.Windowforms
{

    public partial class UserManagement : MetroForm
    {
        RetailDBEntities1 context;
        bool ibInitOrderGrid = true;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void DataSourceBinding()
        {
            /*
            userModelBindingSource.DataSource = context.AuthenticationRules.Select(x => new UserModel
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                UserType = x.UserType,
                UserName = x.UserName,
                Pass = x.Pass,
                Active = x.Active ?? false,
                Ibinventory = x.Ibinventory ?? false,
                Ibsales = x.Ibsales ?? false
                IbFinance = 


            }).ToList();
            */
            //Bind source and retrive records
            RetrieveUserRecords();
            BindingUserEditDataSource();
            RetrieveObjectRecords();
        }

        private void BindingUserEditDataSource()
        {
            userEditModelBindingSource.DataSource = new UserEditModel();
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            context = new RetailDBEntities1();
            DataSourceBinding();
        }

        private void userModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
               var option = MessageBox.Show( "Are you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
               if (option == System.Windows.Forms.DialogResult.Yes)
               {
                   try
                   {
                       DataGridViewRow row = userModelDataGridView.Rows[e.RowIndex];
                       var obj = (UserModel)row.DataBoundItem;
                       var entity = context.AuthenticationRules.Find(obj.ID);
                       context.AuthenticationRules.Remove(entity);
                       context.SaveChanges();
                       MessageBox.Show( "Record has been deleted succussfully!");
                      // userModelBindingSource.DataSource = context.AuthenticationRules.ToList();
                       DataSourceBinding();
                       RetrieveAndSetUserRights("");
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
               
                DataGridViewRow row = userModelDataGridView.Rows[e.RowIndex];
                var obj = (UserModel)row.DataBoundItem;


                userEditModelBindingSource.DataSource = new UserEditModel {ID = obj.ID, FirstName = obj.FirstName, LastName = obj.LastName,
                                                                            UserType = obj.UserType, UserName = obj.UserName, Active = obj.Active,
                                                                            Pass = obj.Pass, Ibinventory = obj.Ibinventory, IbReports = obj.IbReports, 
                                                                            Ibsales = obj.Ibsales, IbFinance = obj.IbFinance };


                comboBox_UserType.SelectedItem = obj.UserType ?? "POS";
           


            }
        }

        private void saveToolStripButton_Click1(object sender, EventArgs e)

        {
            
            
          }
      private void resetUserFields(){
          
      }

      private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {

      }

      private void btnDel_Click(object sender, EventArgs e)
      {

      }

      private void SaveBtn_Click(object sender, EventArgs e)
      {
          bool ibSave = false;

          var user = (UserEditModel)userEditModelBindingSource.DataSource;

          user.UserType = comboBox_UserType.SelectedItem == null ? null : comboBox_UserType.SelectedItem.ToString();

          if ((user.FirstName == null || user.FirstName == "") || (user.LastName == null|| user.LastName == "") ||
              (user.UserType ==null|| user.UserType == "") ||( user.Pass ==null||user.Pass == "" )|| 
              (user.UserName==null||user.UserName == ""))
          {
              MessageBox.Show("Please fill the required (*) fields", "Required Field(s)");
              return;

          }


          if (user.ID == 0)
          {

              int exitingID = context.AuthenticationRules.Where(x => x.UserName.ToLower() == user.UserName.ToLower()).Select(a => a.ID).FirstOrDefault();

              if (exitingID > 0)
              {
                  MessageBox.Show("User Login is already exist", "Duplicate User");
                  return;
              }


              AuthenticationRule newUser = new AuthenticationRule
              {
                  FirstName = user.FirstName,
                  LastName = user.LastName,
                  UserType = user.UserType,
                  UserName = user.UserName,
                  Pass = user.Pass,
                  Active = user.Active,
                  Ibinventory = user.Ibinventory,
                  Ibsales = user.Ibsales,
                  IbReports = user.IbReports,
                  IbFinance = user.IbFinance

              };



              context.AuthenticationRules.Add(newUser);
              ibSave = true;



          }

          else
          {


              AuthenticationRule editUser = context.AuthenticationRules.Find(user.ID);
              if (editUser != null)
              {
                  editUser.FirstName = user.FirstName;
                  editUser.LastName = user.LastName;
                  editUser.UserType = user.UserType;
                  editUser.UserName = user.UserName;
                  editUser.Pass = user.Pass;
                  editUser.Active = user.Active;
                  editUser.Ibinventory = user.Ibinventory;
                  editUser.Ibsales = user.Ibsales;
                  editUser.IbReports = user.IbReports;
                  editUser.IbFinance = user.IbFinance;
                  ibSave = true;
              }


          }


          if (ibSave == true)
          {
              context.SaveChanges();

              MessageBox.Show("User is saved successfully", "Confirmation");
              DataSourceBinding();



          }
      }

      private void SaveBtn_MouseHover(object sender, EventArgs e)
      {
         // SaveBtn.BackColor = System.Drawing.Color.AliceBlue;
      }

      private void filterApplyBtn_Click(object sender, EventArgs e)
      {          
         // RetrieveUserRecords();
        
      }

      private void RetrieveUserRecords()
      {
          string filterStr = filterTxtBox.Text.ToLower();
          userModelBindingSource.DataSource = context.AuthenticationRules.Select(x => new UserModel
          {
              ID = x.ID,
              FirstName = x.FirstName,
              LastName = x.LastName,
              UserType = x.UserType,
              UserName = x.UserName,
              Pass = x.Pass,
              Active = x.Active ?? false,
              Ibinventory = x.Ibinventory ?? false,
              Ibsales = x.Ibsales ?? false,
              IbReports = x.IbReports??false,
              IbFinance = x.IbFinance??false



          }).Where(f => filterStr ==""? true :  f.UserName.ToLower().Contains(filterStr) || 
                    f.FirstName.ToLower().Contains(filterStr) ||
                    f.LastName.ToLower().Contains(filterStr)
                    ).ToList();

          userModelDataGridView.ClearSelection();
      }

      private void RetrieveAndSetUserRights(String UserName)
      {
          List<UserRightsModel> userRights = context.AuthenticationRules_Rights_Detail.Where(w => w.UserName == UserName)
              .Select(s=> new UserRightsModel(){ ID = s.ID, ObjectName = s.ObjectName, UserName = s.UserName, Viewable = s.Viewable??false }).
              ToList();
          if (UserName == "")
          {
              lbl_SelectedUser.Text = "NA";
              lbl_selectedUserType.Text = "NA";
              textBoxUserID.Text = "0";
          }     
              foreach (DataGridViewRow row in userRightsModelDataGridView.Rows)
              {
                  string objectName = row.Cells[2].Value.ToString();
                  if (userRights.Count() > 0)
                  {
                      var existingRight = userRights.Where(w => w.ObjectName == objectName).FirstOrDefault();
                      if (existingRight != null)
                      {
                          row.Cells[4].Value = existingRight.Viewable;
                          row.Cells[0].Value = existingRight.ID;

                      }
                      else
                      {
                          row.Cells[4].Value = null;
                          row.Cells[0].Value = null;
                      }
                  }
                  else
                  {
                      row.Cells[4].Value = null;
                      row.Cells[0].Value = null;
                  }
               
              }
              userRightsModelDataGridView.Refresh();
              userRightsModelDataGridView.PerformLayout();
      }
      private void RetrieveObjectRecords()
      {

          userRightsModelBindingSource.DataSource = Global.objectsList;
      }

      private void filterResetBtn_Click(object sender, EventArgs e)
      {
         
      }

      private void resetRecord_Click(object sender, EventArgs e)
      {
          BindingUserEditDataSource();
      }

      private void filterTxtBox_Click(object sender, EventArgs e)
      {

      }

      private void filterTxtBox_TextChanged(object sender, EventArgs e)
      {
          RetrieveUserRecords();
      }

      private void btn_saveUserRights_Click(object sender, EventArgs e)
      {
          bool ib_save = false;

          if (textBoxUserID.Text == "0")
          {
              MessageBox.Show("Please select the user first for right(s) selection & saving", "Infromation");
              return;
          }
          foreach (DataGridViewRow row in userRightsModelDataGridView.Rows)
          {

              var obj = (UserRightsModel)row.DataBoundItem;
              AuthenticationRules_Rights_Detail UserRightsDetailEntity = null;

              if (obj != null)
              {

                  if (obj.Viewable == null)
                      continue;


                  if (obj.ID == 0)
                  {  //new detai record               
                      UserRightsDetailEntity = new AuthenticationRules_Rights_Detail()
                      {
                           ObjectName = obj.ObjectName,
                           UserName = lbl_SelectedUser.Text,
                           Viewable = obj.Viewable 

                      };
                      context.AuthenticationRules_Rights_Detail.Add(UserRightsDetailEntity);
                      ib_save = true;
                  }
                  else
                  {
                      //Edit code here
                      UserRightsDetailEntity = context.AuthenticationRules_Rights_Detail.Find(obj.ID);
                      if (UserRightsDetailEntity != null)
                      {
                          UserRightsDetailEntity.Viewable = obj.Viewable;
                          ib_save = true;
                      }
                  }
              }
          }// for each
          try
          {
              if (ib_save)
              {
                  context.SaveChanges();

                  MessageBox.Show("User Right(s) are saved Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  RetrieveAndSetUserRights(lbl_SelectedUser.Text);
                  
              }
              else
              {
                  MessageBox.Show("Error(s) while saving records. Please verify the data.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }

      }

      private void userModelDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
      {
          if (!ibInitOrderGrid)
          {

              var userRow = userModelDataGridView.Rows[e.RowIndex];

              lbl_SelectedUser.Text = userRow.Cells[3].Value.ToString();
              lbl_selectedUserType.Text = (userRow.Cells[7].Value??"NA").ToString();
              textBoxUserID.Text = userRow.Cells[2].Value.ToString();
              userRightsModelDataGridView.Enabled = (lbl_selectedUserType.Text == "Admin") ? false : true;

              RetrieveAndSetUserRights(lbl_SelectedUser.Text);
          }
      }

      private void UserManagement_Shown(object sender, EventArgs e)
      {
         ibInitOrderGrid = false;
      }

      private void metroButton1_Click(object sender, EventArgs e)
      {
          bool ibSave = false;

          var user = (UserEditModel)userEditModelBindingSource.DataSource;

          user.UserType = comboBox_UserType.SelectedItem == null ? null : comboBox_UserType.SelectedItem.ToString();

          if ((user.FirstName == null || user.FirstName == "") || (user.LastName == null || user.LastName == "") ||
              (user.UserType == null || user.UserType == "") || (user.Pass == null || user.Pass == "") ||
              (user.UserName == null || user.UserName == ""))
          {
              MessageBox.Show("Please fill the required (*) fields", "Required Field(s)");
              return;

          }


          if (user.ID == 0)
          {

              int exitingID = context.AuthenticationRules.Where(x => x.UserName.ToLower() == user.UserName.ToLower()).Select(a => a.ID).FirstOrDefault();

              if (exitingID > 0)
              {
                  MessageBox.Show("User Login is already exist", "Duplicate User");
                  return;
              }


              AuthenticationRule newUser = new AuthenticationRule
              {
                  FirstName = user.FirstName,
                  LastName = user.LastName,
                  UserType = user.UserType,
                  UserName = user.UserName,
                  Pass = user.Pass,
                  Active = user.Active,
                  Ibinventory = user.Ibinventory,
                  Ibsales = user.Ibsales,
                  IbReports = user.IbReports,
                  IbFinance = user.IbFinance

              };



              context.AuthenticationRules.Add(newUser);
              ibSave = true;



          }

          else
          {


              AuthenticationRule editUser = context.AuthenticationRules.Find(user.ID);
              if (editUser != null)
              {
                  editUser.FirstName = user.FirstName;
                  editUser.LastName = user.LastName;
                  editUser.UserType = user.UserType;
                  editUser.UserName = user.UserName;
                  editUser.Pass = user.Pass;
                  editUser.Active = user.Active;
                  editUser.Ibinventory = user.Ibinventory;
                  editUser.Ibsales = user.Ibsales;
                  editUser.IbReports = user.IbReports;
                  editUser.IbFinance = user.IbFinance;
                  ibSave = true;
              }


          }


          if (ibSave == true)
          {
              context.SaveChanges();

              MessageBox.Show("User is saved successfully", "Confirmation");
              DataSourceBinding();



          }
      }       

        
    }
}
