using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EBusiness.BLL;

namespace EBusiness
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmCreateDB());
                
                               
                bool BackDatedRun = false;
                BackDatedRun = !SuperAdmin.VerifyLastRun();
                DateTime LastRun = SuperAdmin.LastRun;
                if (BackDatedRun && LastRun != DateTime.MinValue)
                {
                    
                    if (LastRun.AddDays(-7) > DateTime.Now)
                    {
                        MessageBox.Show(string.Format("EBusiness POS system is running in Back Dates." + Environment.NewLine
           + "Running system in back dates is not supported."), "System Running in Back Dates", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //return;
                    }
                    else
                    {
                        if (MessageBox.Show(string.Format("EBusiness POS system is running in Back Dates." + Environment.NewLine
                                   + "Are you sure you want to work in back dates ?."), "System Running in Back Dates", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            //return;
                        }
                    }
                }

                bool IsValidRegistration = false;
                IsValidRegistration = SuperAdmin.VerifyRegistration();
                if (BackDatedRun)
                    IsValidRegistration = false;
                DialogResult Result = DialogResult.OK;
                Login login = new Login(IsValidRegistration);
                login.ShowDialog();
                Result = login.CustomResult;
                if (Result != DialogResult.OK && Result != DialogResult.Ignore)
                {
                    return;
                }

                if (IsValidRegistration && Result != DialogResult.Ignore)
                {
                    int days = SuperAdmin.NoOfRegisteredDaysLeft();
                    if (days < 0)
                    {
                        MessageBox.Show(string.Format("EBusiness POS system  license is expired." + Environment.NewLine
                            + "You should renew License now to continue the software use." + Environment.NewLine
                            + "PLEASE contact vendor to resolve this issue."), "License has been expired", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else if (days <= 31)
                    {
                        MessageBox.Show(string.Format("{0} Days are left in EBusiness POS system expiry." + Environment.NewLine
                            + "Please make sure on time Renewal of your License." + Environment.NewLine
                            + "OR contact vendor to resolve this issue.", days), string.Format("{0} Days Remaining", days), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Application.Run(new WelcomeForm());
                }
                else
                {
                    if (Result == DialogResult.Ignore || !SuperAdmin.RegistrationExists())
                        Application.Run(new frmCreateDB());
                }
                if (!BackDatedRun)
                    SuperAdmin.UpdateLR();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            //Application.Run(new frmSystemLog(true));
            //Application.Run(new ReceiptViewer());
            // Application.Run(new ItemsList());
            //Application.Run(new Login());
            //Application.Run(new frmMain());
            //Application.Run(new frmCustomer());
        }
    }

}
