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
    public partial class Productcs : MetroForm
    {
        RetailDBEntities1 context;
        BindingSource bs = new BindingSource();

        List<ProductSearchModel> productList;

        public string ProductID { get; set; }
        public Productcs()
        {
            InitializeComponent();
            context = new RetailDBEntities1();
           
        }

        private List<ProductSearchModel> getProductList()
        {
            /* old
            var productList =
           (from p in context.STK_productMaster
            join s in context.CNF_Supplier on p.SupplierID equals s.ID into ps
            from pl in ps.DefaultIfEmpty()
            select new ProductSearchModel { ProductID = p.ProductID, ProductName = p.ProductName, SupplierName = pl.ShortName == null ? "(No Supplier)" : pl.ShortName }).ToList();
            */
            var searchDate = DateTime.Parse(DateTime.Today.ToShortDateString());
            var productList = context.sp_rp_dailyStock(searchDate).Select(s => new ProductSearchModel() { ProductID = s.ProductID, ShortName = s.ProductShortName ,ProductName = s.ProductName, SupplierName = s.ShortName, StockInHand = s.StockInHand??0 }).ToList();

            return productList;
        }

        private List<ProductSearchModel> filterProductSearchRecords()
        {
            return productList.Where(x => x.ProductID.ToLower().Contains(srhTxtBox.Text.ToLower()) || (x.ShortName??"").ToLower().Contains(srhTxtBox.Text.ToLower()) || x.ProductName.ToLower().Contains(srhTxtBox.Text.ToLower()) || x.SupplierName.ToLower().Contains(srhTxtBox.Text.ToLower())).ToList();
        }
        private void Productcs_Load(object sender, EventArgs e)
        {
           // productMasterDataGridView.DataSource = context.STK_productMaster.ToList();

            productList = getProductList();
            productSearchModelBindingSource.DataSource = productList;
        }

        private void productMasterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduct_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

              //  bs.DataSource = productMasterDataGridView.DataSource;

              //  bs.Filter = string.Format("productID LIKE '%{0}%'", txtProduct.Text);

              //  var filter = context.STK_productMaster.Where(x => x.ProductID.Contains(txtProduct.Text)).ToList();

             //   productMasterDataGridView.DataSource = filter;
                
            }
            catch (Exception ex)
            {

            }

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
           // var filter = context.STK_productMaster.Where(x => x.ProductName.Contains(txtProductName .Text)).ToList();

          //  productMasterDataGridView.DataSource = filter;
        }


        private void productMasterDataGridView_DoubleClick(object sender, EventArgs e)
        {
            /*
            if (productMasterDataGridView.CurrentRow == null) return;
 
            int rowIndex = productMasterDataGridView.CurrentRow.Index;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = productMasterDataGridView.Rows[rowIndex];
                if (row.Cells[0].Value != null)
                {
                    this.ProductID = row.Cells[0].Value.ToString();
                   // txtProductName.Text = "";
                   // txtProduct.Text = "";
                    this.Visible = false;
                }

            }
      */
        }

        private void srhTxtBox_TextChanged(object sender, EventArgs e)
        {
            productSearchModelBindingSource.DataSource = filterProductSearchRecords();
        }

        private void productSearchModelDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            returnSelectedProduct();
   
        }

        
        private void Productcs_Shown(object sender, EventArgs e)
        {
            ProductID = "";
            srhTxtBox.Text = "";
            srhTxtBox.Focus();
            
        }

      
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void productSearchModelDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
               // e.SuppressKeyPress = true;
                productSearchModelDataGridView.CancelEdit();
                returnSelectedProduct();
            }

        }

        private void returnSelectedProduct()
        {
            if (productSearchModelDataGridView.CurrentRow == null) return;

            int rowIndex = productSearchModelDataGridView.CurrentRow.Index;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = productSearchModelDataGridView.Rows[rowIndex];
                if (row.Cells[0].Value != null)
                {
                    this.ProductID = row.Cells[0].Value.ToString();
                    srhTxtBox.Text = "";
                    this.Visible = false;
                }

            }

        }

        private void productSearchModelDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //if (e.KeyChar == 13)
            //{
                
            //    returnSelectedProduct();
            //}
        }

        private void productSearchModelDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;
                
        }
      
    }
}
