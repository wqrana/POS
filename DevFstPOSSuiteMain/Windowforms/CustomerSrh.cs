using DevFstPOSSuite.DAL;
using DevFstPOSSuite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevFstPOSSuite.Windowforms
{
    public partial class CustomerSrh : MetroFramework.Forms.MetroForm
    {
        public string[] addedContactsList { get; set; }
        public List<string> newlySelectedContactsList { get; set; }

        RetailDBEntities1 context;
        List<CustomerSearchModel> customerList;
        

        public CustomerSrh()
        {
            InitializeComponent();
            context = new RetailDBEntities1();
           
        }

        private List<CustomerSearchModel> getCustomerList()
        {
           List<CustomerSearchModel> dataSet= context.sp_POSCustomerSrhList().Select(s => new CustomerSearchModel() { ContactNo = s.ContactNo, 
                                                                                        CustomerName = s.CustomerName, 
                                                                                        ShoppingWorth = s.totalBuyingWorth }).ToList();
           return dataSet;
        }
        private void CustomerSrh_Load(object sender, EventArgs e)
        {
            if (customerList != null) customerList.Clear();
            customerList = getCustomerList();
            if (addedContactsList != null && addedContactsList.Length > 0)
            {
                customerList = customerList.Where(w => addedContactsList.Contains(w.ContactNo) == false).ToList();
            }
          //  customerSearchModelDataGridView.DataSource = customerList;
            BindingCustomerListDataSource();
            newlySelectedContactsList = null;
            selectAllCheckBox.Checked = false;
            
        }

        private void BindingCustomerListDataSource()
        {
            string filterStr = srhTxtBox.Text;
            customerSearchModelBindingSource.DataSource = customerList.Where(w => filterStr == "" ? true : w.ContactNo.Contains(filterStr) || (w.CustomerName??"").ToLower().Contains(filterStr.ToLower())).ToList();
            selectAllCheckBox.Checked = false;
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void selectDeSelectAll(bool selectAll)
        {
            foreach (DataGridViewRow row in customerSearchModelDataGridView.Rows)
            {
                row.Cells[0].Value = selectAll;
                
            }
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectDeSelectAll(selectAllCheckBox.Checked);
        }

        private void btnContactSearch_Click(object sender, EventArgs e)
        {   newlySelectedContactsList = new List<string>();
            foreach (DataGridViewRow row in customerSearchModelDataGridView.Rows)
            {
              
                    bool ibSelected = bool.Parse((row.Cells[0].Value ?? false).ToString());
                    if (ibSelected)
                    {
                        newlySelectedContactsList.Add(row.Cells[1].Value.ToString());
                    }
            }
            
            this.Visible = false;
        }

        private void srhTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void srhTxtBox_TextChanged(object sender, EventArgs e)
        {
            BindingCustomerListDataSource();
          //  filterSearchedRecords();
        }

        private void filterSearchedRecords()
        {
            string filterStr = srhTxtBox.Text;
            foreach (DataGridViewRow row in customerSearchModelDataGridView.Rows)
            {
                string contractNo = row.Cells[1].Value.ToString();
                string customerName = (row.Cells[2].Value??"").ToString();

                if (contractNo.Contains(filterStr) || customerName.ToLower().Contains(filterStr.ToLower()) || filterStr == "")
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
       
    }
}
