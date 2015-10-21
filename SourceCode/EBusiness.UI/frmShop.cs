using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EBusiness.BLL;
namespace EBusiness
{
    public partial class frmShop :Form
    {
        Shop shop = new Shop();
        string operation = "0";
        public frmShop()
        {
            InitializeComponent();
            txtShopName.Focus();
            try
            {
                DataTable dt = shop.SelectAllShop();
                if (dt != null && dt.Rows.Count > 0)
                {
                    operation = "1";
                    txtShopName.Text = Convert.ToString(dt.Rows[0]["ShopName"]);
                    txtShopSologon.Text = Convert.ToString(dt.Rows[0]["ShopSlogon"]);
                    txtShopRegistration.Text = Convert.ToString(dt.Rows[0]["RegistrationNumber"]);
                    txtShopAddress.Text = Convert.ToString(dt.Rows[0]["ShopAddress"]);
                    txtShopPhoneNumber.Text = Convert.ToString(dt.Rows[0]["ShopNumber"]);
                    txtProperiter.Text = Convert.ToString(dt.Rows[0]["Properiter"]);
                    txtSaleNote.Text = Convert.ToString(dt.Rows[0]["SaleNote"]);

                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Shop, "SelectAllShop", ex,"Shop Exception");
            }

        }
        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                 if (!string.IsNullOrEmpty(txtShopName.Text))
                 {
                    if (shop.InsertNewShop(operation,txtShopName.Text,txtShopSologon.Text,txtShopRegistration.Text,txtShopAddress.Text,txtShopPhoneNumber.Text,txtProperiter.Text,txtSaleNote.Text))
                    {
                        MessageBox.Show("Shop Information saved sucessfully.","Information Save Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! While saving Shop Information."+Environment.NewLine+"Enter Shop Name","Shop Information Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error! Shop Name is required.","Shop Name Required",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Shop, "InsertNewShop", ex,"Shop Exception");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Shop, "BtnClose", ex,"Shop Exception");
            }

        }
        #endregion
    }
}
