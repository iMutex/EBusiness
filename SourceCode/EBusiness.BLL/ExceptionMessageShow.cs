using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.MessageBox;
using System.Windows.Forms;

namespace EBusiness.BLL
{
    public class ExceptionMessageShow : Form
    {
        private string title;
        private string ExceptionMessage;
        #region Constructor
        public ExceptionMessageShow()
        {
        }
        public ExceptionMessageShow(string title, string ExceptionMessage)
        {
            this.title = title;
            this.ExceptionMessage = ExceptionMessage;
        }
        #endregion Constructor




        #region ShowExceptionMessage
        public void ShowExceptionMessage()
        {
            try
            {
                // Do something that you don't expect to generate an exception.
                throw new ApplicationException(ExceptionMessage);
            }
            catch (ApplicationException ex)
            {
                // Define a new top-level error message.
                string str = "An Error has ocurred in while logging the Exception Information on System. " + Environment.NewLine
                             + "Please contact support";

                // Add the new top-level message to the handled exception.                
                ApplicationException exTop = new ApplicationException(str, ex);
                ExceptionMessageBox box = new ExceptionMessageBox(exTop);
                box.Buttons = ExceptionMessageBoxButtons.OK;
                box.Caption = title;
                box.ShowCheckBox = false;
                box.ShowToolBar = true;
                box.Symbol = ExceptionMessageBoxSymbol.Stop;
                box.Show(this);
                this.Close();
            }
        }
        #endregion ShowExceptionMessage

    }
}
