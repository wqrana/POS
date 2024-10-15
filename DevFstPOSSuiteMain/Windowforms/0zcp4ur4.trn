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
using DevFstPOSSuite.Models;
using DevFstPOSSuite.DAL;
using System.Data.SqlClient;
namespace DevFstPOSSuite.Windowforms
{
    public partial class PurchaseOrder : MetroForm
    {
        bool ibInitOrderGrid = true;
        bool ibReCalcProductRate = false;
        Productcs pSrh = null;
        RetailDBEntities1 context = null;
        public PurchaseOrder()
        {
            InitializeComponent();
            pSrh = new Productcs();
            pSrh.Visible = false;
            context = new RetailDBEntities1();
            pOInventoryDetailModelDataGridView.Enabled = false;
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            dateTimePickerTo.Value = DateTime.Parse(DateTime.Now.ToShortDateString());



            DataSourceBinding();
        }
        private void DataSourceBinding()
        {
            supplierModelBindingSource.DataSource = context.CNF_Supplier.Select(x => new SupplierModel { ID = x.ID, ShortName = x.ShortName }).ToList();

            BindingPurchaseOrderEditDetail();
            BindingPurchaseOrderGrid();
        }
        private DateTime GetInvoiceDueDate(DateTime? InvoiceDate)
        {
            int supplierID = int.Parse(comboBox_supplier.SelectedValue == null ? "0" : comboBox_supplier.SelectedValue.ToString());    
            int paymentDays = context.CNF_Supplier.Where(w => w.ID == supplierID).Select(s => s.PaymentDays).FirstOrDefault() ?? 0;
            DateTime paymentDueDate = InvoiceDate == null ? DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(paymentDays) : InvoiceDate.Value.AddDays(paymentDays);

            return paymentDueDate;
        }
        private void BindingPurchaseOrderEditDetail()
        {

            DateTime invDueDate = GetInvoiceDueDate(null); 
            pOInventoryMasterEditModelBindingSource.DataSource = new POInventoryMasterEditModel() { OrderDate = DateTime.Parse(DateTime.Now.ToShortDateString()), InvoiceDate = DateTime.Parse(DateTime.Now.ToShortDateString()), DueDate = invDueDate, PaymentDate = DateTime.Parse(DateTime.Now.ToShortDateString()) };
            comboBox_PaymentStatus.SelectedItem = "Pending";

        }
        private void BindingPurchaseOrderGrid()
        {
            string filterStr = TextBox_filterOrder.Text.ToLower();

            pOInventoryMasterModelBindingSource.DataSource = context.POInventoryMasters.Select(x => new POInventoryMasterModel()
            {
                ID = x.ID,
                SupplierID = x.SupplierID,
                OrderNo = x.OrderNo,
                OrderDate = x.OrderDate,
                InvoiceNo = x.InvoiceNo,
                InvoiceDate = x.InvoiceDate,
                InvoiceAmount = x.InvoiceAmount,
                CatDisPct = x.CatDisPct,
                StdDisPct = x.StdDisPct,
                BreakupDisPct = x.BreakupDisPct,
                PaymentDate = x.PaymentDate,
                PaymentDisPct = x.PaymentDisPct,
                Reference = x.Reference,
                DueDate = x.DueDate,
                PaymentStatus = x.PaymentStatus


            }).Where(w => (w.OrderDate >= dateTimePickerFrom.Value && w.OrderDate <= dateTimePickerTo.Value)
             || (w.InvoiceDate >= dateTimePickerFrom.Value && w.InvoiceDate <= dateTimePickerTo.Value))
            .Where(w2 => (w2.OrderNo.ToLower().Contains(filterStr == "" ? w2.OrderNo.ToLower() : filterStr))
                || (w2.PaymentStatus.ToLower().Contains(filterStr == "" ? w2.PaymentStatus.ToLower() : filterStr))
                || (w2.InvoiceNo.ToLower().Contains(filterStr == "" ? w2.InvoiceNo.ToLower() : filterStr))

            ).OrderByDescending(o => o.ID).ToList();

            pOInventoryMasterModelDataGridView.ClearSelection();
            lbl_orderNo.Text = "";

        }
        private void PurchaseOrder_Shown(object sender, EventArgs e)
        {
            ibInitOrderGrid = false;
            textBox_selectedOderRecordID.Text = "0";
        }

        private void pOInventoryMasterModelDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!ibInitOrderGrid)
            {

                var orderRow = pOInventoryMasterModelDataGridView.Rows[e.RowIndex];

                lbl_orderNo.Text = orderRow.Cells[4].Value.ToString();
                textBox_selectedOderRecordID.Text = orderRow.Cells[3].Value.ToString();
                RetrievePurchaseOrderItemList(true);
                if (!pOInventoryDetailModelDataGridView.Enabled)
                    pOInventoryDetailModelDataGridView.Enabled = true;
                // RetrieveRateListDetailRecords();

            }
        }

        private void RetrievePurchaseOrderItemList(bool ib_calc)
        {
            int orderID = 0;
            bool ib_valid = int.TryParse(textBox_selectedOderRecordID.Text, out orderID);
            if (ib_valid)
            {
                pOInventoryDetailModelBindingSource.DataSource = context.POInventoryDetails.Select
                    (
                     x => new POInventoryDetailModel()
                     {
                         ID = x.ID,
                         OrderID = x.OrderID,
                         ProductCode = x.ProductCode,
                         RetailPrice = x.RetailPrice,
                         Qty = x.Qty,
                         ProductDiscount = x.ProductDiscount,
                         DealerPrice = x.DealerPrice,
                         IsManualRate = x.IsManualRate,
                         Remarks = x.Remarks

                     }

                    ).Where(w => w.OrderID == orderID).OrderBy(o => o.ID).ToList();
            }

            foreach (DataGridViewRow row in pOInventoryDetailModelDataGridView.Rows)
            {
                bool IsManual = ((bool?)row.Cells[8].Value) ?? false;
                switch (IsManual)
                {
                    case true:
                        // pOInventoryDetailModelDataGridView.CurrentRow.Cells[9].ReadOnly = false;
                        // pOInventoryDetailModelDataGridView.CurrentRow.Cells[7].ReadOnly = true;
                        row.Cells[9].ReadOnly = false;
                        row.Cells[7].ReadOnly = true;
                        break;
                    case false:
                        // pOInventoryDetailModelDataGridView.CurrentRow.Cells[9].ReadOnly = true;
                        // pOInventoryDetailModelDataGridView.CurrentRow.Cells[7].ReadOnly = false;
                        row.Cells[9].ReadOnly = true;
                        row.Cells[7].ReadOnly = false;
                        break;

                }
            }
            pOInventoryDetailModelDataGridView.PerformLayout();
            if (ib_calc) CalculateOrderDetail();

        }
        private void filterApplyBtn_Click(object sender, EventArgs e)
        {

            ibInitOrderGrid = true;
            ResetPurchaseOrderDetail();
            BindingPurchaseOrderGrid();
            ibInitOrderGrid = false;
        }

        private void ResetPurchaseOrderDetail()
        {
            lbl_orderNo.Text = "";
            textBox_selectedOderRecordID.Text = "";
            textBox_totalOrderItem.Text = "0";
            textBox_orderRetailAmount.Text = "0.00";
            textBox_dealerPayable.Text = "0.00";
            pOInventoryDetailModelDataGridView.Rows.Clear();
            pOInventoryDetailModelDataGridView.Refresh();

        }
        private void pOInventoryDetailModelDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = DevFstPOSSuite.Properties.Resources.delete_record;
            e.Row.Cells[4].Value = DevFstPOSSuite.Properties.Resources.Search_btn_resize;
        }

        private void pOInventoryDetailModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;


            if (e.ColumnIndex == 4)
            {
                pOInventoryMasterModelDataGridView.Enabled = false;
                pSrh.ShowDialog();
                if (pSrh.ProductID != "")
                {
                    // pOInventoryDetailModelDataGridView.Rows[e.RowIndex].Cells[3].Value = pSrh.ProductID;
                    if (!CheckExistingAddedItem(pSrh.ProductID, e.RowIndex))
                    {
                        SetSearchedProductData(pSrh.ProductID, e.RowIndex);
                    }
                    else
                    {

                        MessageBox.Show("Item is already added in the List");
                    }

                }
                pOInventoryMasterModelDataGridView.Enabled = true;
            }
            else if (e.ColumnIndex == 0)
            {
                //Delete Order detail record

                if (e.RowIndex < 0) return;


                //deletedInvoiceItemList

                if (e.ColumnIndex == 0)
                {
                    int id = (int)pOInventoryDetailModelDataGridView[1, e.RowIndex].Value;

                    DialogResult dr = MessageBox.Show("Do you want to Remove the item(Yes/No)?", "Remove Item", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.No) return;

                    try
                    {

                        if (id != 0)
                        {
                            var removeObject = context.POInventoryDetails.Find(id);
                            if (removeObject != null)
                            {
                                context.POInventoryDetails.Remove(removeObject);
                                context.SaveChanges();
                            }

                        }


                        pOInventoryDetailModelDataGridView.Rows.Remove(pOInventoryDetailModelDataGridView.CurrentRow);
                        pOInventoryDetailModelDataGridView.Refresh();
                        MessageBox.Show("Record is deleted successfully!");
                        CalculateOrderDetail();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
            else if (e.ColumnIndex == 8)
            {
                pOInventoryDetailModelDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void CalculateOrderDetail()
        {
            int totalItem = 0;
            decimal orderRetailTotal = 0;

            foreach (DataGridViewRow row in pOInventoryDetailModelDataGridView.Rows)
            {
                if (row != null)
                {

                    decimal retPrice = row.Cells[5].Value == null ? 0 : (decimal)row.Cells[5].Value;
                    int qty = row.Cells[6].Value == null ? 0 : (int)row.Cells[6].Value;
                    decimal rowRetTotal = (retPrice * qty);

                    totalItem += qty;
                    orderRetailTotal += rowRetTotal;
                }
            }
            textBox_totalOrderItem.Text = totalItem.ToString();
            textBox_orderRetailAmount.Text = orderRetailTotal.ToString();
            //  textBox_dealerPayable.Text = "0";

        }

        private bool CheckExistingAddedItem(string productCode, int excludedRow)
        {
            bool ib_find = false;
            for(int i = 0 ; i<pOInventoryDetailModelDataGridView.Rows.Count; i++)
            {
                DataGridViewRow row = pOInventoryDetailModelDataGridView.Rows[i];
                if (row != null)
                {
                    if (i == excludedRow) continue;
                    string rowvalue = row.Cells[3].Value == null ? "" : row.Cells[3].Value.ToString();
                    if (rowvalue == productCode) return true;
                }
            }
            return ib_find;
        }

        private void SetSearchedProductData(string productCode, int SelectedRowIndex)
        {
            var currDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //   var rate = context.Get_EffectiveProductRate(productCode, invoiceHeader.InvoiceDate).FirstOrDefault();
            //execute using edmx database to get result from scalar or table-value functions
            var rate = context.Database.SqlQuery<decimal>(@"select dbo.Get_EffectiveProductRate(@productCode, @CurrentDate)",
                new SqlParameter("productCode", productCode), new SqlParameter("CurrentDate", currDate)).FirstOrDefault();

            pOInventoryDetailModelDataGridView.Rows[SelectedRowIndex].Cells[3].Value = productCode;
            pOInventoryDetailModelDataGridView.Rows[SelectedRowIndex].Cells[5].Value = rate;
            pOInventoryDetailModelDataGridView.CurrentCell = pOInventoryDetailModelDataGridView.Rows[SelectedRowIndex].Cells[6];

        }

        private void pOInventoryDetailModelDataGridView_TabIndexChanged(object sender, EventArgs e)
        {
            var currRowIndex = pOInventoryDetailModelDataGridView.CurrentRow.Index;
            var currCellIndex = pOInventoryDetailModelDataGridView.CurrentCell.ColumnIndex;

        }

        private void pOInventoryDetailModelDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string ProductID = (string)pOInventoryDetailModelDataGridView.CurrentCell.Value;

                if (ProductID != "")
                {
                    // pOInventoryDetailModelDataGridView.Rows[e.RowIndex].Cells[3].Value = pSrh.ProductID;
                    int checkProduct = context.STK_productMaster.Where(x => x.ProductID == ProductID).Count();
                    if (checkProduct == 0)
                    {
                        MessageBox.Show("Entered product code is not found. Please enter the valid code");
                        pOInventoryDetailModelDataGridView.CurrentCell.Value = "";
                        pOInventoryDetailModelDataGridView.CurrentCell.Selected = true;
                    }
                    else
                    {


                        if (!CheckExistingAddedItem(ProductID, e.RowIndex))
                        {
                            SetSearchedProductData(ProductID, e.RowIndex);
                        }
                        else
                        {

                            MessageBox.Show("Product code is already added in the List");
                            pOInventoryDetailModelDataGridView.CurrentCell.Value = "";
                            pOInventoryDetailModelDataGridView.CurrentCell.Selected = true;

                        }

                    }
                }

            }
            else
            {
                CalculateOrderDetail();
            }
            
            
        }

        private void saveAndPrintBtn_Click(object sender, EventArgs e)
        {
            bool ib_save = false;
            int TotalItems = int.Parse(textBox_totalOrderItem.Text == null ? "0" : textBox_totalOrderItem.Text);
            decimal TotalorderAmount = decimal.Parse(textBox_orderRetailAmount.Text == null ? "0" : textBox_orderRetailAmount.Text);
            int orderID = int.Parse(textBox_selectedOderRecordID.Text);
            if (TotalItems == 0 && TotalorderAmount == 0)
            {
                MessageBox.Show("Please enter the order detail for save/Calculate Payable");
                return;
            }

            foreach (DataGridViewRow row in pOInventoryDetailModelDataGridView.Rows)
            {

                var obj = (POInventoryDetailModel)row.DataBoundItem;
                POInventoryDetail PODetailEntity = null;

                if (obj != null)
                {

                    if ((obj.ProductCode == null || obj.ProductCode == "") || (obj.RetailPrice == 0) || obj.Qty == 0)
                        continue;


                    if (obj.ID == 0)
                    {  //new detai record               
                        PODetailEntity = new POInventoryDetail()
                        {
                            OrderID = int.Parse(textBox_selectedOderRecordID.Text),
                            ProductCode = obj.ProductCode,
                            RetailPrice = obj.RetailPrice,
                            Qty = obj.Qty,
                            ProductDiscount = obj.ProductDiscount,
                            DealerPrice = obj.DealerPrice,
                            IsManualRate = obj.IsManualRate,
                            CreationDate = DateTime.Now,
                            UserName = Global.userLogin

                        };
                        context.POInventoryDetails.Add(PODetailEntity);
                        ib_save = true;
                    }
                    else
                    {
                        //Edit code here
                        PODetailEntity = context.POInventoryDetails.Find(obj.ID);
                        if (PODetailEntity != null)
                        {
                            PODetailEntity.ProductCode = obj.ProductCode;
                            PODetailEntity.RetailPrice = obj.RetailPrice;
                            PODetailEntity.Qty = obj.Qty;
                            PODetailEntity.ProductDiscount = obj.ProductDiscount;
                            PODetailEntity.DealerPrice = obj.DealerPrice;
                            PODetailEntity.IsManualRate = obj.IsManualRate;
                            PODetailEntity.LastModifiedDate = DateTime.Now;
                            PODetailEntity.UserName = Global.userLogin;
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

                    context.sp_calculateInventoryDealerRate(orderID);
                    var netDealerTotal = context.POInventoryDetails.Where(w => w.OrderID == orderID).Select(x => x.DealerPrice * x.Qty).Sum();
                    textBox_dealerPayable.Text = netDealerTotal.ToString();
                    MessageBox.Show("Data is saved/Payable Calculated Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RetrievePurchaseOrderItemList(false);
                    pOInventoryDetailModelDataGridView.PerformLayout();
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


        private void metroButton1_Click(object sender, EventArgs e)
        {

            bool ibSave = false;
            bool ibExecuteReCalcRate = false;
            pOInventoryMasterEditModelBindingSource.EndEdit();
            var orderData = (POInventoryMasterEditModel)pOInventoryMasterEditModelBindingSource.DataSource;
            int supplierID = int.Parse(comboBox_supplier.SelectedValue.ToString());
            POInventoryMaster orderObj = null;
            orderData.SupplierID = supplierID;
            orderData.PaymentStatus = comboBox_PaymentStatus.SelectedItem == null ? null : comboBox_PaymentStatus.SelectedItem.ToString();

            if ((orderData.OrderNo == null || orderData.OrderNo == "") || (orderData.OrderDate == null) ||
                (orderData.SupplierID == 0 || orderData.SupplierID == null))
            {
                MessageBox.Show("Please fill the required fields (*) to save the record", "Required Field(s)");
                return;
            }
            orderData.PaymentDate = (orderData.PaymentStatus == "Paid" && orderData.PaymentDate == null) ? DateTime.Parse(DateTime.Now.ToShortDateString()) : orderData.PaymentStatus == "Pending" ? null : orderData.PaymentDate;

            if (orderData.PaymentStatus == "Paid" && orderData.PaymentDate == null)
            {
                MessageBox.Show("Please enter the payment Date as payment status is paid", "Required Field(s)");
                return;
            }

            if (orderData.ID == 0)
            {
                //new record
                orderObj = new POInventoryMaster()
                {
                    SupplierID = orderData.SupplierID,
                    OrderDate = orderData.OrderDate,
                    OrderNo = orderData.OrderNo,
                    InvoiceDate = orderData.InvoiceDate,
                    InvoiceNo = orderData.InvoiceNo,
                    InvoiceAmount = orderData.InvoiceAmount,
                    StdDisPct = orderData.StdDisPct,
                    CatDisPct = orderData.CatDisPct,
                    BreakupDisPct = orderData.BreakupDisPct,
                    PaymentDate = orderData.PaymentDate,
                    PaymentDisPct = orderData.PaymentDisPct,
                    DueDate = orderData.DueDate,
                    CreationDate = DateTime.Now,
                    Reference = orderData.Reference,
                    PaymentStatus = orderData.PaymentStatus


                };
                context.POInventoryMasters.Add(orderObj);
                ibSave = true;

            }
            else
            {
                //edit record
                orderObj = context.POInventoryMasters.Find(orderData.ID);
                if (orderObj != null)
                {
                    orderObj.SupplierID = orderData.SupplierID;
                    orderObj.OrderDate = orderData.OrderDate;
                    orderObj.OrderNo = orderData.OrderNo;
                    orderObj.InvoiceDate = orderData.InvoiceDate;
                    orderObj.InvoiceNo = orderData.InvoiceNo;
                    orderObj.InvoiceAmount = orderData.InvoiceAmount;
                    orderObj.StdDisPct = orderData.StdDisPct;
                    orderObj.CatDisPct = orderData.CatDisPct;
                    orderObj.BreakupDisPct = orderData.BreakupDisPct;
                    orderObj.PaymentDate = orderData.PaymentDate;
                    orderObj.PaymentDisPct = orderData.PaymentDisPct;
                    orderObj.DueDate = orderData.DueDate;
                    orderObj.Reference = orderData.Reference;
                    orderObj.LastUpdateDate = DateTime.Now;
                    orderObj.PaymentStatus = orderData.PaymentStatus;
                    ibSave = true;
                }

                if (ibReCalcProductRate)
                {

                    var productCount = context.POInventoryDetails.Where(w => w.OrderID == orderData.ID).Count();
                    if (productCount > 0)
                    {
                        ibExecuteReCalcRate = true;
                    }
                }
            }

            if (ibSave == true)
            {
                try
                {
                    context.SaveChanges();
                    if (orderData.ID != 0 && ibExecuteReCalcRate == true)
                    {
                        context.sp_calculateInventoryDealerRate(orderData.ID);
                    }
                    MessageBox.Show("Purchase Order is saved successfully", "Confirmation");
                    ResetPurchaseOrderDetail();
                    pOInventoryMasterModelDataGridView.Enabled = true;
                    ibInitOrderGrid = true;
                    DataSourceBinding();
                    ibInitOrderGrid = false;
                    ibReCalcProductRate = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Purchase Order can't be saved due to some internal errors", "Confirmation");
            }
        }

        private void pOInventoryMasterModelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                //deleted PO 
                DataGridViewRow row = pOInventoryMasterModelDataGridView.Rows[e.RowIndex];
                var obj = (POInventoryMasterModel)row.DataBoundItem;

                var isExistOrderDetail = context.POInventoryDetails.Where(x => x.OrderID == obj.ID).Count();
                if (isExistOrderDetail > 0)
                {
                    MessageBox.Show("Purchase Order can't be deleted, Child records exist", "Information");
                    return;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to Remove the Purchase Order(Yes/No)?", "Remove Order", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.No) return;

                    try
                    {
                        var orderObj = context.POInventoryMasters.Find(obj.ID);
                        if (orderObj != null)
                        {
                            context.POInventoryMasters.Remove(orderObj);
                            context.SaveChanges();
                            ibInitOrderGrid = true;
                            pOInventoryMasterModelDataGridView.Rows.Remove(pOInventoryMasterModelDataGridView.Rows[e.RowIndex]);
                            pOInventoryMasterModelDataGridView.Refresh();
                            ibInitOrderGrid = false;
                            MessageBox.Show("Purchase Order is deleted succussfully!", "Information");
                            pOInventoryMasterModelDataGridView.ClearSelection();
                            ResetPurchaseOrderDetail();
                            comboBox_supplier.Focus();

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
                //Edit PO
                DataGridViewRow row = pOInventoryMasterModelDataGridView.Rows[e.RowIndex];
                var obj = (POInventoryMasterModel)row.DataBoundItem;
                pOInventoryMasterEditModelBindingSource.DataSource = new POInventoryMasterEditModel()
                {
                    ID = obj.ID,
                    SupplierID = obj.SupplierID,
                    OrderDate = obj.OrderDate,
                    OrderNo = obj.OrderNo,
                    InvoiceDate = obj.InvoiceDate,
                    InvoiceNo = obj.InvoiceNo,
                    InvoiceAmount = obj.InvoiceAmount,
                    StdDisPct = obj.StdDisPct,
                    CatDisPct = obj.CatDisPct,
                    BreakupDisPct = obj.BreakupDisPct,
                    PaymentDate = obj.PaymentDate,
                    PaymentDisPct = obj.PaymentDisPct,
                    DueDate = obj.DueDate,
                    Reference = obj.Reference,
                    PaymentStatus = obj.PaymentStatus


                };
                comboBox_PaymentStatus.SelectedItem = obj.PaymentStatus;
                comboBox_supplier.SelectedValue = obj.SupplierID == null ? comboBox_supplier.SelectedValue : obj.SupplierID;
                pOInventoryMasterModelDataGridView.ClearSelection();
                pOInventoryMasterModelDataGridView.Enabled = false;
                pOInventoryDetailModelDataGridView.Enabled = false;
                ResetPurchaseOrderDetail();


            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            TextBox_filterOrder.Text = "";
           // dateTimePickerFrom.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
          //  dateTimePickerTo.Value = DateTime.Parse(DateTime.Now.ToShortDateString());

            DataSourceBinding();
            // pOInventoryDetailModelDataGridView.Enabled = true;
            pOInventoryMasterModelDataGridView.Enabled = true;
            pOInventoryDetailModelDataGridView.Enabled = false;
            ResetPurchaseOrderDetail();

        }

        private void dueDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void invoiceDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime InvDate = invoiceDateDateTimePicker.Value;
            if (InvDate != null)
            {
                dueDateDateTimePicker.Value = GetInvoiceDueDate(InvDate);   //InvDate.AddDays(Global.paymentDays);
                pOInventoryMasterEditModelBindingSource.EndEdit();
            }

        }

        private void stdDisPctTextBox_TextChanged(object sender, EventArgs e)
        {
            ibReCalcProductRate = true;
        }

        private void catDisPctTextBox_TextChanged(object sender, EventArgs e)
        {
            ibReCalcProductRate = true;
        }

        private void breakupDisPctTextBox_TextChanged(object sender, EventArgs e)
        {
            ibReCalcProductRate = true;
        }

        private void paymentDisPctTextBox_TextChanged(object sender, EventArgs e)
        {
            ibReCalcProductRate = true;
        }

        private void pOInventoryDetailModelDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 8)
            {
                // bool returnSts = (bool)saleInvoiceReturnDetailModelDataGridView.CurrentRow.Cells[0].Value;

                bool isManualRate = (bool)pOInventoryDetailModelDataGridView.CurrentCell.Value;
                if (isManualRate == true)
                {
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[9].Value = null;
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[9].ReadOnly = false;
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[7].ReadOnly = true;
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[7].Value = null;
                }
                else if (isManualRate == false)
                {
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[9].Value = null;
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[9].ReadOnly = true;
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[7].ReadOnly = false;
                    pOInventoryDetailModelDataGridView.CurrentRow.Cells[7].Value = null;
                }

            }

        }

        private void pOInventoryDetailModelDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pOInventoryDetailModelDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
              DateTime InvDate = invoiceDateDateTimePicker.Value;
              if (InvDate != null)
              {
                  dueDateDateTimePicker.Value = GetInvoiceDueDate(InvDate);   //InvDate.AddDays(Global.paymentDays);
                  pOInventoryMasterEditModelBindingSource.EndEdit();
              }
        }
    }
}