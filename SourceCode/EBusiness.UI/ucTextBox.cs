using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EBusiness
{
    public partial class ucTextBox : TextBox
    {
        public ucTextBox()
        {
            InitializeComponent();
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            base.OnKeyDown(e);
        }
    }
}
