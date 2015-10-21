using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EBusiness.BLL;
using System.IO;

namespace EBusiness
{
    public partial class frmCreateDB : Form
    {
        public frmCreateDB()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL Files (*.SQL) |*.sql;";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;


            }
        }

        private void btnInitializeDatabase_Click(object sender, EventArgs e)
        {
            SuperAdmin.InitializeDatabase();
            MessageBox.Show("Database has been initialized successfully.", "Database Initialized", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {

            SuperAdmin.CreateDatabase();
            MessageBox.Show("Database has been Created successfully.", "Database Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLoadSQL_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPath.Text))
            {
                FileInfo fileinfo = new FileInfo(txtPath.Text);
                string script = fileinfo.OpenText().ReadToEnd();
                txtSQLQuery.Text = script;
            }
        }

        private void btnExecuteSQL_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            lblResult.Text = string.Empty;
            if (rbSchemaQuery.Checked)
                SuperAdmin.CreateDatabaseSchema(txtSQLQuery.Text);
            else if (rbSelectDataQuery.Checked)
            {
                string query = txtSQLQuery.Text;
                if (query.ToLower().StartsWith("select") || query.ToLower().StartsWith("exe"))
                {
                    DataTable dt = SuperAdmin.ExecuteSelectQuery(query);
                    dgvResult.DataSource = dt;
                    lblResult.Text = dgvResult.Rows.Count.ToString() + " records returned.";
                }
                else
                {
                    MessageBox.Show("Specified Query is not a valid Select Query");
                }
            }
            else if (rbUpdateDataQuery.Checked)
            {
                string query = txtSQLQuery.Text;
                if (query.ToLower().StartsWith("delete") || query.ToLower().StartsWith("update") || query.ToLower().StartsWith("delete"))
                {
                    int count = SuperAdmin.ExecuteUpdateDeleteQuery(query);
                    lblResult.Text = count.ToString() + " records effected.";
                }
                else
                {
                    MessageBox.Show("Specified Query is not a valid Insert/Update/Delete Query");
                }
            }
        }

        private void btnRegisterTrial_Click(object sender, EventArgs e)
        {
            if (SuperAdmin.CreateRegistration(1))
            {
                MessageBox.Show(string.Format("Trial Version has been Installed. This Software will expired after one month on Date [{0}].", DateTime.Now.AddMonths(1).Date));
            }
        }

        private void btnRegisterFullVersion_Click(object sender, EventArgs e)
        {
            if (SuperAdmin.CreateRegistration(12))
            {
                MessageBox.Show(string.Format("Full functional Version of the EBUsiness Point Of Sale has been Installed. This Software will expired after one year on Date [{0}].", DateTime.Now.AddYears(1).Date));
            }
        }

        private void btnUnRegister_Click(object sender, EventArgs e)
        {
            if (SuperAdmin.UnRegister())
            {
                MessageBox.Show(string.Format("DONE"));
            }
        }

        private void frmCreateDB_Load(object sender, EventArgs e)
        {

        }

        private void btnDays_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("[{0}] days left on expiry.", SuperAdmin.NoOfRegisteredDaysLeft()));
        }

        private void btnValidateRegistration_Click(object sender, EventArgs e)
        {
            if (SuperAdmin.VerifyRegistration())
            {
                MessageBox.Show("Registration is Verified.");
            }
            else
            {
                MessageBox.Show("InValid Registration.");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            frmResetPassword frm = new frmResetPassword();
            frm.ShowDialog();
        }

        private void btnSetExpiryDate_Click(object sender, EventArgs e)
        {
            frmSetExpiry frm = new frmSetExpiry();
            frm.ShowDialog();
        }

        private void rbSchemaQuery_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            lblResult.Text = string.Empty;
        }
    }
}
