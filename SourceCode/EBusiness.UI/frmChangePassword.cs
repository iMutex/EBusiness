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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUser.Text))
                {
                    if (!string.IsNullOrEmpty(txtOldPassword.Text))
                    {
                        if (!string.IsNullOrEmpty(txtNewPassword.Text))
                        {
                            if (txtNewPassword.Text == txtReEnterPassword.Text)
                            {
                                if (SystemUser.ChangePassword(txtUser.Text, txtOldPassword.Text, txtNewPassword.Text, 1))
                                {
                                    MessageBox.Show("Password " + "  " +"["+ txtUser.Text +"]"+ " is sucessfully updated","Password Change Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error !Password is not updated."+Environment.NewLine+"Try Again","Passowrd Updated Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error! Password is not matched"+Environment.NewLine+"Try Again","Password Matching Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error! New Password is not valid"+Environment.NewLine+"Try Again","Password Matching Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! Old Password is not Valid"+Environment.NewLine+"Try Again","Old Password Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error! User Name is not Valid"+Environment.NewLine+"Try Again","User Name Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.SystemUsers, "Change Password", ex, "Change Password Exception");
               
            }
        }

        private void EmptyField()
        {
            txtReEnterPassword.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtOldPassword.Text = string.Empty;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtUser.Text = Common.CURRENT_USER.UserName.ToString();
        }

        
    }
}
