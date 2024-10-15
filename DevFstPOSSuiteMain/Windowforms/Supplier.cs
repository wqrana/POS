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

    public partial class Supplier : MetroForm
    {
        RetailDBEntities1 context;    
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            context = new RetailDBEntities1();
            DataSourceBinding();
        }

        private void DataSourceBinding()
        {
           
            bankBindingSource.DataSource = context.CNF_Bank.Select(x => new Bank { ID = x.ID, ShortName = x.ShortName }).ToList();
            comBox_DefaultBankID.SelectedValue = 1;

            BindingSupplierGridDataSource();
            BindingSupplierEditDataSource();
           
           
        }

        private void BindingSupplierGridDataSource()
        {
            string filterStr = filterTxtBox.Text;
            supplierModelBindingSource.DataSource = context.CNF_Supplier.Select(x => new SupplierModel
            {

                ID = x.ID,
                BusinessName = x.BusinessName,
                ShortName = x.ShortName,
                BusinessType = x.BusinessType,
                ContactPerson = x.ContactPerson,
                LandLine = x.LandLine,
                Mobile = x.Mobile,
                Email = x.Email,
                Address = x.Address,
                DefaultBankID = x.DefaultBankID,
                AccountNo = x.AccountNo,
                PaymentDays = x.PaymentDays,
                Active = x.Active ?? false



            }).Where(w => filterStr=="" ? w.BusinessName.ToLower().Contains(w.BusinessName.ToLower()) : w.BusinessName.ToLower().Contains(filterStr) || w.ShortName.ToLower().Contains(filterStr)) 
            .ToList();
        }

        private void BindingSupplierEditDataSource()
        {
            supplierEditModelBindingSource.DataSource = new SupplierEditModel();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool ibSave = false;

            var supplierData = (SupplierEditModel)supplierEditModelBindingSource.DataSource;

            if ((supplierData.BusinessName == null || supplierData.BusinessName == "") || (supplierData.ShortName == null || supplierData.BusinessName == ""))
            {
                MessageBox.Show("Please fill the required fields", "Required Field(s)");
                return;
            }
            //New
            if (supplierData.ID == 0)
            {

               
                CNF_Supplier newSupplier = new CNF_Supplier
                {
                    BusinessName = supplierData.BusinessName,
                    ShortName = supplierData.ShortName,
                    BusinessType = supplierData.BusinessType,
                    ContactPerson = supplierData.ContactPerson,
                    LandLine = supplierData.LandLine,
                    Mobile = supplierData.Mobile,
                    Email = supplierData.Email,
                    Address = supplierData.Address,
                   // DefaultBankID = supplierData.DefaultBankID,
                   DefaultBankID = comBox_DefaultBankID.SelectedValue == null? null : (int?)(comBox_DefaultBankID.SelectedValue),
                   AccountNo = supplierData.AccountNo,
                   PaymentDays = supplierData.PaymentDays,
                    Active = supplierData.Active 
                    
                };

                context.CNF_Supplier.Add(newSupplier);
                ibSave = true;

            }
            else
            {
                var editSupplier = context.CNF_Supplier.Find(supplierData.ID);
                if (editSupplier != null)
                {
                   
                    editSupplier.BusinessName = supplierData.BusinessName;
                    editSupplier.ShortName = supplierData.ShortName;
                    editSupplier.BusinessType = supplierData.BusinessType;
                    editSupplier.ContactPerson = supplierData.ContactPerson;
                    editSupplier.LandLine = supplierData.LandLine;
                    editSupplier.Mobile = supplierData.Mobile;
                    editSupplier.Email = supplierData.Email;
                    editSupplier.Address = supplierData.Address;
                    editSupplier.DefaultBankID = comBox_DefaultBankID.SelectedValue == null ? null : (int?)(comBox_DefaultBankID.SelectedValue);
                    editSupplier.AccountNo = supplierData.AccountNo;
                    editSupplier.PaymentDays = supplierData.PaymentDays;
                    editSupplier.Active = supplierData.Active;
                    ibSave = true;
                }

            }
            if (ibSave == true)
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Supplier is saved successfully", "Confirmation");
                    DataSourceBinding();

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
            }

        }

        private void suppliersListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var option = MessageBox.Show(this, "Are you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (option == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow row = suppliersListGrid.Rows[e.RowIndex];
                        var obj = (SupplierModel)row.DataBoundItem;
                        var entity = context.CNF_Supplier.Find(obj.ID);
                        context.CNF_Supplier.Remove(entity);
                        context.SaveChanges();
                        MessageBox.Show("Record has been deleted succussfully!");
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

                DataGridViewRow row = suppliersListGrid.Rows[e.RowIndex];
                var obj = (SupplierModel)row.DataBoundItem;


                supplierEditModelBindingSource.DataSource = new SupplierEditModel
                {
                    ID          = obj.ID,
                    BusinessName = obj.BusinessName,
                    ShortName = obj.ShortName,
                    BusinessType = obj.BusinessType,
                    ContactPerson = obj.ContactPerson,
                    LandLine = obj.LandLine,
                    Mobile = obj.Mobile,
                    Email = obj.Email,
                    Address = obj.Address,
                    DefaultBankID = obj.DefaultBankID,
                    AccountNo = obj.AccountNo,
                    PaymentDays = obj.PaymentDays,
                    Active = obj.Active

                };
                

            }
        }

        private void accountNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            BindingSupplierGridDataSource();
        }

        private void filterResetBtn_Click(object sender, EventArgs e)
        {

        }

        private void filterTxtBox_Click(object sender, EventArgs e)
        {
           
        }

        private void resetRecord_Click(object sender, EventArgs e)
        {
            BindingSupplierEditDataSource();
        }
    }
}
