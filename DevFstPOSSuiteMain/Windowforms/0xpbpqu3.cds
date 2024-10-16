﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevFstPOSSuite.Models;
using DevFstPOSSuite.Windowforms;
using MetroFramework.Forms;
namespace DevFstPOSSuite
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

       

     
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripUserText.Text = "Welcome! "+ Global.userLogin;

            inventoryToolStripMenuItem.Visible = Global.userModel.Ibinventory;
            SalesToolStripMenuItem.Visible = Global.userModel.Ibsales;
            financeToolStripMenuItem.Visible = Global.userModel.IbFinance;
            reportToolStripMenuItem.Visible = Global.userModel.IbReports;
            setupToolStripMenuItem.Visible = Global.userModel.UserType == "Admin" ? true : false;
            cRMToolStripMenuItem.Visible = Global.userModel.UserType == "Admin" ? true : false;
           // otherIncomesToolStripMenuItem.Visible = Global.userModel.UserType == "Admin" ? true : false;

            //ToolStripMenuItem item = menuStrip1.Items
            //.OfType<ToolStripMenuItem>()
            //.SelectMany(it => it.DropDownItems.OfType<ToolStripMenuItem>()).FirstOrDefault(m => m.Text == "Sales Closure");

            //List<ToolStripMenuItem> itemList = menuStrip1.Items
            //.OfType<ToolStripMenuItem>()
            //.SelectMany(it => it.DropDownItems.OfType<ToolStripMenuItem>()).ToList();
            //foreach (ToolStripMenuItem item in itemList)
            //{
            //    Console.WriteLine(item.Text);
               
            //}

            ToolStripItem item = menuStrip1.Items.Find("Sales_salesInvoice", true).FirstOrDefault();
            Console.WriteLine(item.Name);
            item.Visible = false;
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

      
     
    
      

         

               

        public static bool checkIsAlreadyOpenForm(string formName)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == formName)
                {
                    return true;
                }

            }
            return false;
        }

          
        private void ReportOrderDetail_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Purchase Order Detail"))
            {
                Report r = new Report("Purchase Order Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void ReportStockDetail_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Stock Detail"))
            {
                Report r = new Report("Stock Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void ReportstockValueDetail_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Low Stock Detail"))
            {
                Report r = new Report("Low Stock Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void ReportsalesRegister_Click(object sender, EventArgs e)
        {
            //Sales Register
            if (!checkIsAlreadyOpenForm("Sales Register"))
            {
                Report r = new Report("Sales Register");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void ReportDailySales_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Daily Sales Overview"))
            {
                Report r = new Report("Daily Sales Overview");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void ReportMonthlySales_click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Monthly/Yearly Sales Overview"))
            {
                Report r = new Report("Monthly/Yearly Sales Overview");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void ReportSellingItems_click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Selling Items Overview"))
            {
                Report r = new Report("Selling Items Overview");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void ReportCustomerList_Click(object sender, EventArgs e)
        {
           
        }

        private void SetupConfiguration_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserMangement_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetailDefination_Click(object sender, EventArgs e)
        {

        }

        private void ProductRateList_Click(object sender, EventArgs e)
        {

        }

        private void InventoryPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Purchase Order"))
            {
                PurchaseOrder i = new PurchaseOrder();
                i.MdiParent = this;
                i.Show();
            }
        }

        private void InventoryProdcutActivity_click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Product Activity"))
            {
                            
                ProductActivity pa = new ProductActivity();
                pa.MdiParent = this;
                pa.Show();
            }
        }

        private void Sales_salesInvoice_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Sale Invoice "))
            {

                SaleInvoice si = new SaleInvoice();
                si.MdiParent = this;
                si.Show();
            }
        }

        private void Sales_salesReturn_Click(object sender, EventArgs e)
        {

        }

        private void Sales_salesClosure_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Sales Closure"))
            {

                DailySale s = new DailySale();
                s.MdiParent = this;
                s.Show();
            }
        }

        private void Management_expenses_Click(object sender, EventArgs e)
        {

          
        }

        private void ReportDailyExpense_Click(object sender, EventArgs e)
        {
           
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersManagementMenuItem_Click(object sender, EventArgs e)
        {

            if (!checkIsAlreadyOpenForm("User Management"))
            {
               // Expense exp = new Expense();
                UserManagement um = new UserManagement();
                um.MdiParent = this;
                um.Show();

            }
        }

        private void logoffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         

        }

        private void mainConfigurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("App Configurations"))
            {
                // Expense exp = new Expense();
               // UserManagement um = new UserManagement();
                AppConfigurations app = new AppConfigurations();
                app.MdiParent = this;
                app.Show();

            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Supplier"))
            {
                // Expense exp = new Expense();
                // UserManagement um = new UserManagement();
                  Supplier sup = new Supplier();
                sup.MdiParent = this;
                sup.Show();

            }
        }

        private void productDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Product"))
            {
                // Expense exp = new Expense();
                // UserManagement um = new UserManagement();
                ProductDef sup = new ProductDef();
                sup.MdiParent = this;
                sup.Show();

            }

        }

        private void rateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Rate List"))
            {
                // Expense exp = new Expense();
                // UserManagement um = new UserManagement();
                  RateList rt = new RateList();
                rt.MdiParent = this;
                rt.Show();

            }
        }

        private void dueOrderPaymentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Purchase Order Due Payment(s)"))
            {
                Report r = new Report("Purchase Order Due Payment(s)");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void printingProductsBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("About"))
            {
                // Expense exp = new Expense();
                // UserManagement um = new UserManagement();
                About ab = new About();
                ab.MdiParent = this;
                ab.Show();

            }
        }

        private void purchaseOrderPaymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Due Payment(s) Detail"))
            {
                Report r = new Report("Due Payment(s) Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Expense Detail"))
            {
                Expense exp = new Expense();
                exp.MdiParent = this;
                exp.Show();


            }
        }

        private void expenseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (!checkIsAlreadyOpenForm("Expense Detail"))
            {
                Report r = new Report("Expense Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void barcodePrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Products Barcode"))
            {
                Report r = new Report("Products Barcode");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void customerDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Customers Detail"))
            {
                Report r = new Report("Customers Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void otherIncomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Income/Loss"))
            {
                //Expense exp = new Expense();
                //exp.MdiParent = this;
                //exp.Show();
                MiscIncome mi = new MiscIncome();
                mi.MdiParent = this;
                mi.Show();


            }
        }

        private void miscIncomeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Income/Loss Detail"))
            {
                Report r = new Report("Income/Loss Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void poductEffectiveRateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Effective Product Rate(s)"))
            {
                Report r = new Report("Effective Product Rate(s)");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("PO Payment"))
            {
                //Expense exp = new Expense();
                //exp.MdiParent = this;
                //exp.Show();
                POPayment pmt = new POPayment();
                pmt.MdiParent = this;
                pmt.Show();


            }
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Payments History Detail"))
            {
                Report r = new Report("Payments History Detail");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void monthlyYealyPurchaseOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!checkIsAlreadyOpenForm("Purchase Order Overview"))
            {
                Report r = new Report("Purchase Order Overview");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void dailtSalesClosureHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Daily Sales Closure History"))
            {
                Report r = new Report("Daily Sales Closure History");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void periodicFinancialOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkIsAlreadyOpenForm("Periodic Financial Overview"))
            {
                Report r = new Report("Periodic Financial Overview");
                r.MdiParent = this;
                r.Show();
            }
        }

        private void stockInHandValueDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report("Stock In-Hand Value Detail");
            r.MdiParent = this;
            r.Show();
        }

        private void productActivityDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report("Product Activity Detail");
            r.MdiParent = this;
            r.Show();
        }
    }
}
