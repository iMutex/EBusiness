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
    public partial class frmSystemLog : Form
    {
        DataTable DtexceptionLog = null;
        bool IsUserLog = false;
        public frmSystemLog()
        {
            Initiaze(false);
            
        }
        public frmSystemLog(bool isUserLog)
        {
            Initiaze(isUserLog);

        }
        void Initiaze(bool isUserLog)
        {
            IsUserLog = isUserLog;
            InitializeComponent();
            if (IsUserLog)
            {
                lblTitle.Text = "User";
                Common.BindUserCombo(ref cbSearch, false);
            }
            else
            {
                lblTitle.Text = "Module";
                cbSearch.DataSource = Enum.GetNames(typeof(Modules));
            }

            
        }

        void BindExceptionLog(string startDate, string endDate, string module)
        {

            try
            {
                DtexceptionLog = ExceptionLog.ViewExceptionLog(startDate, endDate, module);
                dgvData.DataSource = DtexceptionLog;
                dgvData.Columns["Id"].Visible = false;

            }
            catch (Exception exe)
            {

                ExceptionLog.LogException(Modules.SystemLog, "Bind Exception Log ", exe, "System Log Exception ");
            }
        }

        void BindUserLog(string startDate, string endDate, string UserId)
        {

            try
            {
                DtexceptionLog = UserLog.Select(UserId, startDate, endDate);
                dgvData.DataSource = DtexceptionLog;
                //dgvData.Columns["Ticks"].Visible = false;

            }
            catch (Exception exe)
            {

                ExceptionLog.LogException(Modules.SystemLog, "Bind Exception Log ", exe, "System Log Exception ");
            }
        }

        private void frmSystemLog_Load(object sender, EventArgs e)
        {
            try
            {

                if (IsUserLog)
                {
                    BindUserLog(Common.FormateDateForDB(dtpStartDate.Value), Common.FormateDateForDB(dtpEndDate.Value.AddDays(1)), null);
                }
                else
                {
                    BindExceptionLog(Common.FormateDateForDB(dtpStartDate.Value), Common.FormateDateForDB(dtpEndDate.Value.AddDays(1)), null);
                }
            
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.SystemLog, "Bind Exception Log ", ex, "System Log Exception ");
               
            }
        }

        private void btnFindReceipts_Click(object sender, EventArgs e)
        {
            try
            {

                string startDate =Convert.ToString( dtpStartDate.Value.Date.AddSeconds(-1));
                string endDate = Convert.ToString(dtpEndDate.Value.Date.AddDays(1).Date);
                string module = cbSearch.SelectedItem.ToString();
                if (cbSearch.SelectedIndex == 0)
                {
                    if (IsUserLog)
                        BindUserLog(startDate, endDate, null);
                    else
                    BindExceptionLog(startDate, endDate, null);
                }
                else
                {
                    if (IsUserLog)
                        BindUserLog(startDate, endDate, module);
                    else
                        BindExceptionLog(startDate, endDate, module);
                    //BindExceptionLog(startDate, endDate, module);
                }
            }
            catch (Exception exe)
            {

                ExceptionLog.LogException(Modules.SystemLog, "Bind Exception Log ", exe, "System Log Exception ");
            }
        }
    }
}
