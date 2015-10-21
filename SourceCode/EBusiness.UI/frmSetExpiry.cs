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
    public partial class frmSetExpiry : Form
    {
        public frmSetExpiry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime expDate = dtpExpiryDate.Value;
            if (expDate > DateTime.Now.AddDays(1))
            {
                if (SuperAdmin.CreateRegistration(expDate))
                {
                    MessageBox.Show(string.Format("Full functional Version of the EBUsiness Point Of Sale has been Installed. This Software will expired on Date [{0}].", expDate));
                }
                else
                {
                    MessageBox.Show(string.Format("Registration Failed"));
                }
                this.Close();
            }
        }
    }
}
