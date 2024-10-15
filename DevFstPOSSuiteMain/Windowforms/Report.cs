using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CrystalDecisions.ReportAppServer.ClientDoc;
using CrystalDecisions.ReportAppServer.Controllers;
using CrRas = CrystalDecisions.ReportAppServer.DataDefModel;
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;
using DevFstPOSSuite.DAL;
using MetroFramework.Forms;
namespace DevFstPOSSuite
{
    public partial class Report : MetroForm
    {
        private string reportName { get; set; }

        private ReportFilter rf;
        public ReportFilterObj rfObj {get;set;}
        public Report(string _report)
        {
            InitializeComponent();
            reportName = _report;
            this.Text = _report;
            rfObj = new ReportFilterObj();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
           

            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            
        }

        public void showReportDocument()
        {
            DataSet ReportDataSet;
            DataTable rptDataTable;
            dynamic resultSet = null;
            string strRptPath = string.Empty;
            string dataTableName = string.Empty;
            ReportDataSet = new DataSet();
            RetailDBEntities1 context = new RetailDBEntities1();

            switch (reportName)
            {
                case "Daily Sales Overview":
                // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//DailySaleDetail.rpt"));
                    
                 strRptPath = Path.Combine(Application.StartupPath, "Reports", "DailySaleDetail.rpt");
                 resultSet = context.sp_rp_dailySaleStat(rfObj.FromDate, rfObj.ToDate).ToList();
                 dataTableName = "DS_DailySaleStat"; 
                    break;

                case "Daily Sales Closure History":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "DailySaleClosureHistoryReport.rpt");
                    resultSet = context.sp_dailySaleClosureHistoryDetail(rfObj.FromDate, rfObj.ToDate).ToList();
                    dataTableName = "DS_DailySaleClosure";
                    break;
                case "Stock Detail":

                // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//StockReport.rpt"));
                //    strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//StockReport.rpt"));
                 strRptPath = Path.Combine(Application.StartupPath, "Reports", "StockReport.rpt");
                 string supplierShortName = "";
                 if(rfObj.supplierId.HasValue){
                       supplierShortName=context.CNF_Supplier.Where(s=>s.ID ==rfObj.supplierId).Select(w=> w.ShortName).FirstOrDefault();
                    }
                 resultSet = context.sp_rp_dailyStock(DateTime.Now).Where(s => supplierShortName == "" ? true : s.ShortName.Contains(supplierShortName)).ToList();
                 dataTableName = "DS_DailyStock"; 

                  break;
                case "Low Stock Detail":
                 string supShortName = "";
                 if(rfObj.supplierId.HasValue){
                     supShortName = context.CNF_Supplier.Where(s => s.ID == rfObj.supplierId).Select(w => w.ShortName).FirstOrDefault();
                    }
                  // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//StockReport.rpt"));
                  //    strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//StockReport.rpt"));
                  strRptPath = Path.Combine(Application.StartupPath, "Reports", "LowStockReport.rpt");
                  resultSet = context.sp_rp_dailyStock(DateTime.Now).Where(w => w.StockInHand < w.MinLevel && (supShortName == "" ? true : w.ShortName.Contains(supShortName))).OrderBy(o => o.StockInHand)
                      .ToList();
                  dataTableName = "DS_DailyStock";

                  break;

                case "Stock In-Hand Value Detail":
                  string suppShortName = "";
                  if (rfObj.supplierId.HasValue)
                  {
                      suppShortName = context.CNF_Supplier.Where(s => s.ID == rfObj.supplierId).Select(w => w.ShortName).FirstOrDefault();
                  }
                 
                  strRptPath = Path.Combine(Application.StartupPath, "Reports", "StockInHandValueDetail.rpt");
                  resultSet = context.sp_rpt_StockInHandValueDetail().Where(s => suppShortName == "" ? true : s.SupShortName.Contains(suppShortName)).ToList();
                  dataTableName = "DS_StockInHandValue";
                   break;
                
                case "Expense Detail":
                 // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//DailyExpenseDetail.rpt"));
                  //strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//DailyExpenseDetail.rpt"));
                  strRptPath = Path.Combine(Application.StartupPath, "Reports", "DailyExpenseDetail.rpt");     
                  resultSet = context.sp_rp_dailExpenseDetail(rfObj.FromDate, rfObj.ToDate).ToList();
                  dataTableName = "DS_dailExpenseDetail";
                    break;

                case "Customers Detail":
                     //strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//CustomerList.rpt"));
                    //strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//CustomerList.rpt"));
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "CustomerList.rpt");     
                     resultSet = context.sp_rp_POSCustomerList().ToList();
                     dataTableName = "DS_POSCustomerList";

                    break;
                case "Purchase Order Detail":
                   // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//OrderDetail.rpt"));
                    //strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//OrderDetail.rpt"));
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "PurchaseOrderDetail.rpt"); 
                    resultSet = context.sp_rp_orderInvoiceDetailReport(rfObj.orderId, rfObj.supplierId).ToList();
                    dataTableName = "DS_orderInvoiceDetail";

                    break;
                case "Payments History Detail":
                    // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//OrderDetail.rpt"));
                    //strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//OrderDetail.rpt"));
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "PaymentHistoryReport.rpt");
                    //resultSet = context.sp_rp_orderInvoiceDetailReport(null, null).Where(w => w.PaymentStatus=="Paid").ToList();
                    resultSet = context.sp_rp_POPaymentHistoryDetailReport(rfObj.supplierId).ToList();
                    dataTableName = "DS_PaymentHistoryDetail";

                    break;


                case "Due Payment(s) Detail":
                   // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//OrderDetail.rpt"));
                    //strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//OrderDetail.rpt"));
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "PurchaseOrderDuePaymentReport.rpt");
                    resultSet = context.sp_rp_orderInvoiceDetailReport(null, rfObj.supplierId).Where(w => w.PaymentStatus == "Pending" || w.PaymentStatus == "Partial Paid").ToList();
                    dataTableName = "DS_orderInvoiceDetail";

                    break;
                case "Purchase Order Overview":
                    // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//OrderDetail.rpt"));
                    //strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Reports//OrderDetail.rpt"));
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "PurchaseOrderOverviewReport.rpt");
                    resultSet = context.sp_rp_orderInvoiceDetailReport(null, null).Where(s => s.InvoiceDate >= rfObj.FromDate && s.InvoiceDate<= rfObj.ToDate).ToList();
                    dataTableName = "DS_orderInvoiceDetail";

                    break;

                case "Selling Items Overview":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "TopSellingStatsReport.rpt"); 
                    resultSet = context.sp_TopSellingItemOverviewReport(rfObj.orderId).ToList();
                    dataTableName = "DS_TopSellingItemOverview";

                    break;

                case "Monthly/Yearly Sales Overview":
                    // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//DailySaleDetail.rpt"));

                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "MonthlySaleStatsReport.rpt");
                    resultSet = context.sp_rp_dailySaleStat(rfObj.FromDate, rfObj.ToDate).ToList();
                    dataTableName = "DS_DailySaleStat";
                    break;
                 case "Periodic Financial Overview":
                    // strRptPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Reports//DailySaleDetail.rpt"));

                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "PeriodicFinancialStatsReport.rpt");
                    resultSet = context.sp_rp_dailySaleStat(rfObj.FromDate, rfObj.ToDate).ToList();
                    dataTableName = "DS_DailySaleStat";
                    break;
                
                case "Print Sale Invoice":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "SaleInvoiceDetail.rpt");
                    resultSet =context.sp_rp_RegisterSaleInvoiceDetail(rfObj.FromDate,rfObj.ToDate, rfObj.InvoiceNo).ToList();
                    dataTableName = "DS_RegisterSaleInvoiceDetail";
                    break;
                    

                case "Sales Register":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "RegisterSaleInvoiceList.rpt");
                    resultSet = context.sp_rp_RegisterSaleInvoiceDetail(rfObj.FromDate, rfObj.ToDate, null).ToList();
                    dataTableName = "DS_RegisterSaleInvoiceDetail";
                    break;
                case "Products Barcode":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "ProductBarCode.rpt");
                    resultSet = context.sp_rp_productBarcode(rfObj.supplierId).ToList();
                    dataTableName = "DS_ProductBarcode";
                    break;
                
                case "Product Activity Detail":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "ProductActivityDetail.rpt");
                    resultSet = context.sp_rpt_ProductActivityDetail(rfObj.FromDate, rfObj.ToDate).ToList();
                    dataTableName = "DS_ProductActivity";
                    break;
                //Effective Product Rate(s)
              
                case "Effective Product Rate(s)":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "EffectProductRateDetail.rpt");
                    resultSet = context.sp_rp_productBarcode(rfObj.supplierId).ToList();
                    dataTableName = "DS_ProductBarcode";
                    break;

                case "Income/Loss Detail":
                    strRptPath = Path.Combine(Application.StartupPath, "Reports", "IncomeDetailReport.rpt");
                    resultSet = context.sp_rp_MiscIncomeDetail(rfObj.FromDate, rfObj.ToDate).ToList();
                    dataTableName = "DS_Income";
                    break;
            }

          //  MessageBox.Show(strRptPath);
            //rpt proc calling
            //strRptPath = Environment.CurrentDirectory + "Reports//" + "StockReport.rpt";

          //  strRptPath = AppDomain.CurrentDomain.BaseDirectory + "Reports//" + "StockReport.rpt"; 
                         
            

            //"DS_DailyStock"

            rptDataTable = new DataTable(dataTableName);
            rptDataTable = ToDataTable(resultSet, dataTableName);
            ReportDataSet.Tables.Add(rptDataTable);
            ReportDocument rptDocument = new ReportDocument();
            rptDocument.Load(strRptPath);                 
            rptDocument.SetDataSource(ReportDataSet);
            if (reportName == "Selling Items Overview")
            {
                rptDocument.SetParameterValue("PeriodType", rfObj.orderId);
            }
            
            crystalReportViewer.ReportSource = rptDocument;
            crystalReportViewer.Refresh();

            if (reportName == "Print Sale Invoice" && rfObj.ib_directPrint == true)
            {
                //crystalReportViewer.PrintReport();
                
                rptDocument.PrintToPrinter(1, false, 0, 0);
                
            }
            // Set Report 
        }

        private DataTable ToDataTable<T>(List<T> l_oItems, string dataTableName)
        {
            try
            {
                DataTable oReturn = new DataTable(dataTableName);
                object[] a_oValues;
                int i;
                PropertyInfo[] a_oProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo oProperty in a_oProperties)
                {
                    oReturn.Columns.Add(oProperty.Name, BaseType(oProperty.PropertyType));
                }

                foreach (T oItem in l_oItems)
                {
                    a_oValues = new object[a_oProperties.Length];

                    for (i = 0; i < a_oProperties.Length; i++)
                    {
                        a_oValues[i] = a_oProperties[i].GetValue(oItem, null);
                       

                    }

                    oReturn.Rows.Add(a_oValues);
                }

                return oReturn;
            }
            catch (Exception ex)
            {
                //Error logging in cloud tables 
              
                return null;
            }
        }
       private Type BaseType(Type oType)
        {
            if (oType != null && oType.IsValueType &&
                oType.IsGenericType && oType.GetGenericTypeDefinition() == typeof(Nullable<>)
            )
            {
                return Nullable.GetUnderlyingType(oType);
            }
            else
            {
                return oType;
            }
        }

       private void Report_Shown(object sender, EventArgs e)
       {
           rf = new ReportFilter();


           if (reportName == "Expense Detail" || reportName == "Daily Sales Overview" || reportName == "Purchase Order Detail" || reportName == "Selling Items Overview" || reportName == "Monthly/Yearly Sales Overview"
               || reportName == "Sales Register" || reportName == "Products Barcode" || reportName == "Income/Loss Detail" || reportName == "Effective Product Rate(s)" || reportName == "Payments History Detail" || reportName == "Due Payment(s) Detail"
               || reportName == "Purchase Order Overview" || reportName == "Stock Detail" || reportName == "Low Stock Detail" || reportName == "Daily Sales Closure History" || reportName == "Periodic Financial Overview" || reportName == "Stock In-Hand Value Detail" || reportName == "Product Activity Detail")
           {
               if (reportName == "Purchase Order Detail")
               {
                   rf.visibaleFilterType = "InvoiceSelection";
               }
               else if (reportName == "Selling Items Overview" )
               {

                   rf.visibaleFilterType = "PeriodSelection";
               }
               else if (reportName == "Products Barcode" || reportName == "Effective Product Rate(s)" || reportName == "Payments History Detail" || reportName == "Due Payment(s) Detail" || reportName == "Stock Detail" || reportName == "Low Stock Detail" || reportName == "Stock In-Hand Value Detail")
               {
                   rf.visibaleFilterType = "SupplierSelection";
               }
               else
               {
                   rf.visibaleFilterType = "dateRange";
               }

               rf.ShowDialog();

               if (rf.isShowReport == false)
               {
                   this.Close();
                   return;
               }

               rfObj.FromDate = rf.frmDate;
               rfObj.ToDate = rf.tDate;
               rfObj.orderId = rf.orderId;
               rfObj.supplierId = rf.supplierId;
           }


           //MessageBox.Show( rf.frmDate.ToString(), rf.tDate.ToString());

           showReportDocument();


       }


    }
}
