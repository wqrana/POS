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
using MetroFramework.Controls;
using DevFstPOSSuite.Models;
using DevFstPOSSuite.DAL;


namespace DevFstPOSSuite.Windowforms
{
    public partial class ProductDef : MetroForm
    {
        RetailDBEntities1 context = null;
        bool initBindSource = true;
        bool editProductflag = false;

        public ProductDef()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            context = new RetailDBEntities1();
            DataSourceBinding();
            initBindSource = false;
            

        }
        private void DataSourceBinding()
        {
            if (initBindSource == true)
            {
                //Supplier Dropdown list binding
                supplierModelBindingSource.DataSource = context.CNF_Supplier.Select(x => new SupplierModel { ID = x.ID, ShortName = x.ShortName }).ToList();
                // Product Type dropdown list binding
                productTypeBindingSource.DataSource = context.CNF_ProductType.Select(x => new ProductType { ID = x.ID, Name = x.Name }).ToList();
                // UOM dropdown list binding
                uOMBindingSource.DataSource = context.STK_UOM.Select(x => new UOM { Id = x.Id, UOMName = x.UOMName }).ToList();
                
            }
            // Bind and retrieve products
            RetrieveProdcutRecords();
            BindingEditProductDataSource();

        }
        private void BindingEditProductDataSource()
        {
            productEditModelBindingSource.DataSource = new ProductEditModel();
        }
        private void RetrieveProdcutRecords()
        {
            string filterStr = filterTxtBox.Text.ToLower();

            productModelBindingSource.DataSource = context.STK_productMaster.Select(x => new ProductModel
            {

                ProductID = x.ProductID,
                ShortName = x.ShortName,
                ProductName = x.ProductName,
                SupplierID = x.SupplierId,
                ProductTypeID = x.ProductTypeID,
                UOMID = x.UOMID,
                MinLevel = x.MinLevel,
                MaxLevel = x.MaxLevel,
                ReOrdQty = x.ReOrdQty,
                Rate = x.Rate,
                DisP = x.DisP,
                POSShortcutBtn = x.POSShortcutBtn??false,
                POSShortcutBtnSeq = x.POSShortcutBtnSeq,
                Active = x.Active ?? false

            }).Where(f => f.ProductID.ToLower().Contains(filterStr) || (f.ShortName ?? "").ToLower().Contains(filterStr) || f.ProductName.ToLower().Contains(filterStr) || (f.POSShortcutBtnSeq ?? 0).ToString().Contains(filterStr)).ToList();
                
                                                         
            

        }

        private void filterApplyBtn_Click(object sender, EventArgs e)
        {
            RetrieveProdcutRecords();
        }

        private void filterResetBtn_Click(object sender, EventArgs e)
        {
            filterTxtBox.Text = "";
            RetrieveProdcutRecords();
        }

        private void filterTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void filterTxtBox_TextChanged(object sender, EventArgs e)
        {
            RetrieveProdcutRecords();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete
            if (e.ColumnIndex == 0)
            {
                var option = MessageBox.Show( "Are you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (option == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        
                        DataGridViewRow row =   productDataGridView.Rows[e.RowIndex];
                        var obj = (ProductModel)row.DataBoundItem;
                        var entity = context.STK_productMaster.Find(obj.ProductID);
                        context.STK_productMaster.Remove(entity);
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
            //Edit // Copy Product
            else if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {

                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];
                var obj = (ProductModel)row.DataBoundItem;

                obj.ProductID = e.ColumnIndex == 2 ? "" : obj.ProductID;
                if (e.ColumnIndex == 1)
                {
                    editProductflag = true;
                    productIDTextBox.Enabled = false;
                }
                
              

                productEditModelBindingSource.DataSource = new ProductEditModel
                {
                    ProductID = obj.ProductID,
                    ShortName = obj.ShortName,
                    ProductName = obj.ProductName,
                    
                    SupplierID = obj.SupplierID,
                    ProductTypeID = obj.ProductTypeID,
                    UOMID = obj.UOMID,
                    MinLevel = obj.MinLevel,
                    MaxLevel = obj.MaxLevel,
                    ReOrdQty = obj.ReOrdQty,
                    Rate = obj.Rate,
                    DisP = obj.DisP,
                    POSShortcutBtn = obj.POSShortcutBtn,
                    POSShortcutBtnSeq = obj.POSShortcutBtnSeq,
                    Active = obj.Active 

                };

                comboBox_Supplier.SelectedValue     = obj.SupplierID == null ? comboBox_Supplier.SelectedValue : obj.SupplierID;
                comboBox_ProductType.SelectedValue  = obj.ProductTypeID == null ? comboBox_ProductType.SelectedValue : obj.ProductTypeID;
                comboBox_UOM.SelectedValue = obj.UOMID == null ? comboBox_UOM.SelectedValue : obj.UOMID;
            }
               // Copy Product
           


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool ibSave = false;

            var productData = (ProductEditModel)productEditModelBindingSource.DataSource;
            int supplierID = int.Parse(comboBox_Supplier.SelectedValue.ToString());
            int productTypeID = int.Parse(comboBox_ProductType.SelectedValue.ToString());
            string uomID = comboBox_UOM.SelectedValue.ToString();
            
            productData.SupplierID = supplierID;
            productData.ProductTypeID = productTypeID;
            productData.UOMID = uomID;


            if ((productData.ProductID == null || productData.ProductID == "") || (productData.ShortName == null || productData.ShortName == "") || (productData.ProductName == null || productData.ProductName == "") ||
                (productData.SupplierID == 0 || productData.SupplierID == null) || (productData.ProductTypeID == null || productTypeID == 0) || (productData.UOMID == null || productData.UOMID == ""))
                
                
            {
                MessageBox.Show("Please fill the required fields (*)", "Required Field(s)");
                return;
            }

            var saveProduct = context.STK_productMaster.Find(productData.ProductID);

            //New
            if (editProductflag == false)
            {
                string findProductStr = productIDTextBox.Text.ToUpper();

                int findCount = context.STK_productMaster.Where(x => x.ProductID.ToUpper() == findProductStr).Count();

                if (findCount > 0)
                {
                    MessageBox.Show("Entered product is already exist, Please find & Edit that product", "Already exist");
                    productIDTextBox.Text = "";
                    return;
                }
                if (productData.POSShortcutBtn == true && (productData.POSShortcutBtnSeq ?? 0) > 0)
                {
                    findCount = context.STK_productMaster.Where(x => x.POSShortcutBtnSeq == productData.POSShortcutBtnSeq).Count();
                    if (findCount > 0)
                    {
                        MessageBox.Show("Entered POS Shortcut Button seq is already exist, Please enter the available seq for use", "Already exist");
                        pOSShortcutBtnSeqTextBox.Text = "0"; 
                          
                        return;
                    }
                }
               // CNF_Supplier newSupplier = new CNF_Supplier
                 STK_productMaster newProduct = new STK_productMaster
                {
                    ProductID = productData.ProductID,
                    ShortName = productData.ShortName,
                    ProductName = productData.ProductName,
                    SupplierId = productData.SupplierID,
                    ProductTypeID = productData.ProductTypeID,
                    UOMID = productData.UOMID,
                    MinLevel = productData.MinLevel,
                    MaxLevel = productData.MaxLevel,
                    ReOrdQty = productData.ReOrdQty,
                    Rate = productData.Rate,
                    DisP = productData.DisP,
                    POSShortcutBtn = productData.POSShortcutBtn,
                    POSShortcutBtnSeq = productData.POSShortcutBtnSeq,
                    Active = productData.Active 

                };

                 context.STK_productMaster.Add(newProduct);
                ibSave = true;

            }
            else
            {
                if (productData.POSShortcutBtn == true && (productData.POSShortcutBtnSeq ?? 0) > 0)
                {
                    int findCount = context.STK_productMaster.Where(x => x.POSShortcutBtnSeq == productData.POSShortcutBtnSeq && x.ProductID != productData.ProductID).Count();
                    if (findCount > 0)
                    {
                        MessageBox.Show("Entered POS Shortcut Button seq is already exist, Please enter the available seq for use", "Already exist");
                        pOSShortcutBtnSeqTextBox.Text = "0";
                        return;
                    }
                }
               
                if (saveProduct != null)
                {

                     saveProduct.ProductName = productData.ProductName;
                     saveProduct.ShortName = productData.ShortName;
                     saveProduct.SupplierId = productData.SupplierID;
                     saveProduct.ProductTypeID = productData.ProductTypeID;
                     saveProduct.UOMID = productData.UOMID;
                     saveProduct.MinLevel = productData.MinLevel;
                     saveProduct.MaxLevel = productData.MaxLevel;
                     saveProduct.ReOrdQty = productData.ReOrdQty;
                     saveProduct.Rate = productData.Rate;
                     saveProduct.DisP = productData.DisP;
                     saveProduct.POSShortcutBtn = productData.POSShortcutBtn;
                     saveProduct.POSShortcutBtnSeq = productData.POSShortcutBtnSeq;
                     saveProduct.Active = productData.Active;

                    ibSave = true;
                }

            }
            if (ibSave == true)
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Product is saved successfully", "Confirmation");
                    DataSourceBinding();
                    productIDTextBox.Enabled = true;
                    editProductflag = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Product can't be saved due to some internal errors", "Confirmation");
            }
        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void productIDTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void resetRecord_Click(object sender, EventArgs e)
        {
            productIDTextBox.Enabled = true;
            editProductflag = false;
            BindingEditProductDataSource();
        }

        private void productNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pOSShortcutBtnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var sts = pOSShortcutBtnCheckBox.Checked;
            if (sts)
            {
                pOSShortcutBtnSeqTextBox.Enabled = true;
            }
            else
            {
                pOSShortcutBtnSeqTextBox.Enabled = false;
                productEditModelBindingSource.EndEdit();
                pOSShortcutBtnSeqTextBox.Text = "0";
                productEditModelBindingSource.EndEdit();

            }
        }
    }
}
