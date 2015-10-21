using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EBusiness.BLL;

namespace EBusiness
{
    public partial class frmStock : Form
    {
        Item item = new Item();
        Company company = new Company();
        ItemType itemtype = new ItemType();
        private Int16 Status_Supplier;
        private Int16 Status_Item;
        private Int16 Status_ItemType;

        DataTable stock = null;
        public frmStock()
        {
            InitializeComponent();
            Status_Supplier = 0;
            Status_Item = 0;
            Status_ItemType = 0;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            try
            {
                Common.BindCompanyComboOnlyActive(ref cbCompanies, true);
                Common.BindItemComboOnlyActive(ref cbItems, true);
                Common.BindItemTypeCombo(ref cboItemTypes, true);
                BindStock();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Stock, "Stock", ex, "Stock Exception");

            }
        }

        void BindStock()
        {
            stock = item.Stock();
            dgvStock.AutoGenerateColumns = false;
            dgvStock.Columns["colCode"].DataPropertyName = "Code";
            dgvStock.Columns["colName"].DataPropertyName = "Name";
            dgvStock.Columns["colPacking"].DataPropertyName = "Packing";
            dgvStock.Columns["colType"].DataPropertyName = "Type";
            dgvStock.Columns["colCompany"].DataPropertyName = "Company";
            dgvStock.Columns["colPurchasePrice"].DataPropertyName = "PurchasePrice";
            dgvStock.Columns["colSalePrice"].DataPropertyName = "SalePrice";
            dgvStock.Columns["colTotalPurchase"].DataPropertyName = "TotalPurchase";
            dgvStock.Columns["colTotalSale"].DataPropertyName = "TotalSale";
            dgvStock.Columns["colStock"].DataPropertyName = "Stock";
            dgvStock.Columns["colStockValue"].DataPropertyName = "StockValue";
            dgvStock.Columns["colPurchasedValue"].DataPropertyName = "PurchasedValue";
            dgvStock.Columns["colSoldValue"].DataPropertyName = "SoldValue";
            dgvStock.Columns["colOnOrder"].DataPropertyName = "OnOrder";
            dgvStock.DataSource = stock;
            Common.FormatCurrencyColumn(dgvStock, "colStockValue");
            CalculateTotals();
        }


        void CalculateTotals()
        {
            double StockValue = 0.0;
            double TotalPurchase = 0.0;
            double TotalSale = 0.0;
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                StockValue += Convert.ToDouble(row.Cells["colStockValue"].Value);
                TotalPurchase += Convert.ToDouble(row.Cells["colTotalPurchase"].Value);
                TotalSale += Convert.ToDouble(row.Cells["colTotalSale"].Value);
            }
            lblStockValue.Text = StockValue.ToString("#0.00");
            lblTotalPurchase.Text = TotalPurchase.ToString("#0.00");
            lblTotalSale.Text = TotalSale.ToString("#0.00");
        }

        string GetFilter(bool IsPrint)
        {
            string filterExpression = "1=1";
            string strCompany = cbCompanies.Text;
            string strItem = cbItems.Text;
            string strType = cboItemTypes.Text;
            if (!string.IsNullOrEmpty(strCompany) && strCompany != "--ALL--" && !strCompany.Contains("DataRowView"))
            {
                cbItems.SelectedIndex = 0;
                cboItemTypes.SelectedIndex = 0;
                if (IsPrint)
                {
                    filterExpression += " AND Company.CompanyCode='" + strCompany + "'";
                }
                else
                {
                    filterExpression += " AND CompanyCode='" + strCompany + "'";
                }
            }
            else if (!string.IsNullOrEmpty(strItem) && strItem != "--ALL--" && !strItem.Contains("DataRowView"))
            {
                cbCompanies.SelectedIndex = 0;
                cboItemTypes.SelectedIndex = 0;
                if (IsPrint)
                {
                    if (Common.UseItemNames)
                    {
                        filterExpression += " AND Item.ItemName='" + strItem + "'";
                    }
                    else
                    {
                        filterExpression += " AND Item.ItemCode='" + strItem + "'";
                    }
                    
                }
                else
                {
                    //filterExpression += " AND Code='" + strItem + "'";
                    if (Common.UseItemNames)
                    {
                        filterExpression += " AND Name='" + strItem + "'";
                    }
                    else
                    {
                        filterExpression += " AND Code='" + strItem + "'";
                    }
                }
            }
            else if (!string.IsNullOrEmpty(strType) && strType != "--ALL--" && !strType.Contains("DataRowView"))
            {
                cbCompanies.SelectedIndex = 0;
                cbItems.SelectedIndex = 0;
                if (IsPrint)
                {
                    filterExpression += " AND ItemTypeName='" + strType + "'";
                }
                else
                {
                    filterExpression += " AND Type='" + strType + "'";
                }
            }
            if (chkHideZero.Checked)
            {
                if (IsPrint)
                {
                    filterExpression += " AND ItemInStock <> 0";
                }
                else
                {
                    filterExpression += " AND Stock <> 0";      //FILTER STOCK NOT EQUAL 0
                }
            }
            return filterExpression;
        }

        void ApplyFilter()
        {
            if (stock != null && stock.Rows.Count > 0)
            {
                string filterExpression = GetFilter(false); ;
                stock.DefaultView.RowFilter = filterExpression;
                CalculateTotals();
            }

        }
        #region Events
        private void chkHideZero_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ApplyFilter();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Stock, "ApplyFilter", ex, "Stock Exception");
            }
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.ComboBox cbo = (System.Windows.Forms.ComboBox)sender;
                if (cbo.Text != "--ALL--" && cbo.Text != "System.Data.DataRowView")
                {
                    if (cbo.Name == "cbCompanies")
                    {
                        cbItems.SelectedIndex = 0;
                        cboItemTypes.SelectedIndex = 0;
                    }
                    else if (cbo.Name == "cbItems")
                    {
                        cbCompanies.SelectedIndex = 0;
                        cboItemTypes.SelectedIndex = 0;
                    }
                    else if (cbo.Name == "cboItemTypes")
                    {
                        cbItems.SelectedIndex = 0;
                        cbCompanies.SelectedIndex = 0;
                    }
                }
                ApplyFilter();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Stock, "ApplyFilter", ex, "Stock Exception");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvStock.Rows.Count > 0)
            {
                ReportInfo info = new ReportInfo();
                info.Report = Report.Stock;
                info.Options = GetFilter(true);
                ReceiptViewer print = new ReceiptViewer(info);
                print.ShowDialog();
            }
            else if (dgvStock.Rows.Count <= 0)
            {
                MessageBox.Show("No Record Found" + Environment.NewLine + "Please make sure that Stock is not empty", "Stock Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void cbCompanies_Leave(object sender, EventArgs e)
        //{
        //    if(!Common.IsCodeExists(cbCompanies.Text,Modules.Company))
        //    {
        //         Status_Supplier = 1;
        //        MessageBox.Show("Error ! Invalid Supplier Code" + Environment.NewLine + "Please Select a Valid Supplier Code", "Supplier Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        cbCompanies.Focus();
        //    }
        //    else
        //    {
        //        Status_Supplier=0;
        //    }

        //}

        //private void cboItemTypes_Leave(object sender, EventArgs e)
        //{
        //    if (!Common.IsCodeExists(cboItemTypes.Text, Modules.ItemType))
        //    {
        //        Status_ItemType = 1;
        //        MessageBox.Show("Error ! Invalid Item Type" + Environment.NewLine + "Please Select a Valid Item Type", "Item Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        cboItemTypes.Focus();
        //    }
        //    else
        //    {
        //        Status_ItemType = 0;
        //    }

        //}

        //private void cbItems_Leave(object sender, EventArgs e)
        //{
        //    if (!Common.IsCodeExists(cbItems.Text, Modules.Item))
        //    {
        //        Status_Item = 1;
        //        MessageBox.Show("Error ! Invalid Item Code" + Environment.NewLine + "Please Select a Valid Item Code", "Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        cbItems.Focus();

        //    }
        //    else
        //    {
        //        Status_Item = 0;
        //    }
        //}
        #endregion



    }
}
