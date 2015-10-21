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
    public partial class ItemsList : Form
    {
        public long ItemId = 0;
        public string ItemCode = string.Empty;
        public string ItemName = string.Empty;
        int CompanyId = 0;
        Item item = new Item();
        DataTable itemTable = null;
        public ItemsList()
        {
            Initialize();
        }
        public ItemsList(int companyId)
        {
            Initialize();
            CompanyId = companyId;
        }

        void Initialize()
        {
            InitializeComponent();
            dgvItems.StandardTab = true;
        }

        private void ItemsList_Load(object sender, EventArgs e)
        {
            if (CompanyId > 0)
            {
                itemTable = item.SelectItemByCompany(CompanyId.ToString());
            }
            else
            {
                itemTable = item.SelectAllItem();
            }
            BindGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(txtSearch.Text);
        }
        void ApplyFilter(string itemName)
        {
            string filter = string.Empty;
            if (!string.IsNullOrEmpty(itemName))
            {
                if (Common.UseItemNames)
                    filter = "ItemName like '%" + filter + "%'";
                else
                    filter = "ItemCode like '%" + filter + "%'";
                //filter = "ItemName like '%" + itemName + "%'";
                itemTable.DefaultView.RowFilter = filter;
            }
            else
            {
                itemTable.DefaultView.RowFilter = string.Empty;
            }
        }
        void BindGrid()
        {
            dgvItems.AutoGenerateColumns = false;
            dgvItems.DataSource = itemTable;
            dgvItems.Columns["colItemId"].DataPropertyName = "ItemId";
            dgvItems.Columns["colItemCode"].DataPropertyName = "ItemCode";
            dgvItems.Columns["colItemName"].DataPropertyName = "ItemName";
            dgvItems.Columns["colCompany"].DataPropertyName = "CompanyName";
            dgvItems.Columns["colStock"].DataPropertyName = "ItemInStock";
            dgvItems.Columns["colPrice"].DataPropertyName = "SalePrice";
            dgvItems.Columns["colPurchasePrice"].DataPropertyName = "PurchasePrice";
            
        }

        

        private void dgvItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ItemId = Convert.ToInt32(dgvItems.CurrentRow.Cells["colItemId"].Value);
                ItemName = Convert.ToString(dgvItems.CurrentRow.Cells["colItemName"].Value);
                ItemCode = Convert.ToString(dgvItems.CurrentRow.Cells["colItemCode"].Value);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
                e.Handled = true;
            }
        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                e.Handled = true;
        }
    }
}
