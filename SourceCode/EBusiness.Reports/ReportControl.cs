using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EBusiness.Reports
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private void chkAllDates_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = !chkAllDates.Checked;
            label7.Visible = !chkAllDates.Checked;
            dtpStartDate.Visible = !chkAllDates.Checked;
            dtpEndDate.Visible = !chkAllDates.Checked;
        }
        
 
    }
}
