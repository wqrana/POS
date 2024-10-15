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
namespace DevFstPOSSuite
{
    public partial class ReportFilter : MetroForm
    {
        public DateTime frmDate { get; set; }
        public DateTime tDate { get; set; }
        public string visibaleFilterType { get; set; }

        public int? orderId { get; set; }

        public int? supplierId { get; set; }

        RetailDBEntities1 context;
        public Boolean isShowReport { get; set; }
        public ReportFilter()
        {
            InitializeComponent();
            isShowReport = false;
            context = new RetailDBEntities1();

            fromdatePicker.Value = DateTime.Parse(DateTime.Today.ToShortDateString());
            toDatePicker.Value = DateTime.Parse(DateTime.Today.ToShortDateString());
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (visibaleFilterType == "InvoiceSelection")
            {
                if (checkAllSup.Checked == false)
                {
                    supplierId = int.Parse(supplierList.SelectedValue.ToString());
                    if (chkAllInv.Checked == false)
                    {
                        if (POInvoiceList.SelectedValue == null)
                        {
                            MessageBox.Show("Please select the Purchase Order Invoice");
                            return;
                        }
                        orderId = int.Parse(POInvoiceList.SelectedValue.ToString());
                    }
                    else
                    {
                        orderId = null;
                    }
                }
                else
                {
                    supplierId = null;
                    orderId = null;
                }

            }
            else if (visibaleFilterType == "SupplierSelection")
            {
                if (checkAllSup.Checked == false)
                {
                    supplierId = int.Parse(supplierList.SelectedValue.ToString());
                }
                else
                {
                    supplierId = null;
                }
            }
            else if (visibaleFilterType == "PeriodSelection")
            {
                switch (periodList.SelectedItem.ToString())
                {
                    case "This Month":
                        orderId = 1;
                        break;
                    case "Last 1-Month":
                        orderId = 2;
                        break;
                    case "Last 3-Months":
                        orderId = 3;
                        break;
                    case "Last 6-Months":
                        orderId = 4;
                        break;
                    case "Last 1-Year":
                        orderId = 5;
                        break;
                    case "This Year":
                        orderId = 6;
                        break;
                }

            }

                

            frmDate = fromdatePicker.Value;
            tDate = toDatePicker.Value;
            isShowReport = true;
            this.Visible = false;
        }

        private void ReportFilter_Load(object sender, EventArgs e)
        {
            //POInvoiceList.DataSource = context.POInventoryMasters.ToList();
            supplierList.DataSource = context.CNF_Supplier.ToList();

            if (visibaleFilterType == "InvoiceSelection")
            {
                fromDateLbl.Visible = false;
                fromdatePicker.Visible = false;

                toDateLbl.Visible = false;
                toDatePicker.Visible = false;

                selInvlabel.Visible = true;
                POInvoiceList.Visible = true;
                chkAllInv.Visible = true;
                supplierLbl.Visible = true;
                supplierList.Visible = true;
                checkAllSup.Visible = true;
               

            }
            else if (visibaleFilterType == "SupplierSelection")
            {
                 fromDateLbl.Visible = false;
                fromdatePicker.Visible = false;

                toDateLbl.Visible = false;
                toDatePicker.Visible = false;

                selInvlabel.Visible = false;
                POInvoiceList.Visible = false;
                chkAllInv.Visible = false;
                supplierLbl.Visible = true;
                supplierList.Visible = true;
                checkAllSup.Visible = true;
            }
            else if (visibaleFilterType == "PeriodSelection")
            {
                fromDateLbl.Visible = false;
                fromdatePicker.Visible = false;

                toDateLbl.Visible = false;
                toDatePicker.Visible = false;

                PeriodType.Visible = true;
                periodList.Visible = true;
            }

        }

        private void chkAllInv_CheckedChanged(object sender, EventArgs e)
        {
           if ( chkAllInv.Checked == true)
           {
               POInvoiceList.Enabled = false;
           }
           else
           {
               POInvoiceList.Enabled = true;
           }
        }

        private void checkAllSup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAllSup.Checked)
            {
                supplierList.Enabled = false;
                POInvoiceList.Enabled = false;
                chkAllInv.Checked = false;
                chkAllInv.Enabled = false;
            }
            else
            {
                supplierList.Enabled = true;
                POInvoiceList.Enabled = true;
               chkAllInv.Enabled = true;
            }
        }

        private void supplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var supplierID = (int)supplierList.SelectedValue;
           // POInvoiceList.Items.Clear();
            POInvoiceList.DataSource = context.POInventoryMasters.Where(w => w.SupplierID == supplierID)
                .ToList();
            
           POInvoiceList.Text = "";
           

        }
    }
}
