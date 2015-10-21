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
    public partial class frmResetPassword : Form
    {
        SystemUser user = null;
        bool IsValidUserName = false;
        public frmResetPassword()
        {
            InitializeComponent();
            user = new SystemUser();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            try
            {


                IsValidUserName = false;
                if (user == null)
                    user = new SystemUser();
                if (!string.IsNullOrEmpty(txtUserName.Text))
                {
                    DataTable dt = SystemUser.SelectUser(null, txtUserName.Text, null);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        IsValidUserName = true;
                        lblFullName.Text = Convert.ToString(dt.Rows[0]["Name"]);
                    }
                }
            }
            catch (Exception ex)
            {

                ExceptionLog.LogException(Modules.SystemUsers, "Reset Password", ex, "Reset Password Exception");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUserName.Text))
                {

                    if (!string.IsNullOrEmpty(txtNewPassword.Text))
                    {
                        if (txtNewPassword.Text == txtReEnterPassword.Text)
                        {
                            if (SystemUser.ResetPassword(txtUserName.Text, txtNewPassword.Text))
                            {
                                MessageBox.Show("Password of " + "  " + "[" + txtUserName.Text + "]" + " is sucessfully Reseted", "Password Reset Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error !Password is not Reseted." + Environment.NewLine + "Try Again", "Passowrd Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error! Password is not matched" + Environment.NewLine + "Try Again", "Password Matching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! New Password is not valid" + Environment.NewLine + "Try Again", "Password Matching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Error! User Name is not Valid" + Environment.NewLine + "Try Again", "User Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.SystemUsers, "Reset Password", ex, "Reset Password Exception");

            }
        }
    }
}
