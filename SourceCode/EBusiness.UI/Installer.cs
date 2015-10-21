using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace EBusiness
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();

            //MessageBox.Show("Hello Intialiize");

        }
        protected override void OnBeforeInstall(IDictionary savedState)
        {
            //MessageBox.Show("TARGET DIR" + Context.Parameters["dp_targetdir"]);
            base.OnBeforeInstall(savedState);
        }

        
        public override void Install(IDictionary stateSaver)
        {
           
            
            
            
            
            
            base.Install(stateSaver);

            
        }
        protected override void OnAfterInstall(IDictionary savedState)
        {
            base.OnAfterInstall(savedState);
            //string dir = Context.Parameters["dp_targetdir"];
            //string installerDir = dir + @"\Installers\ReportViewer2010.exe";
            //ProcessStartInfo pInfo = new ProcessStartInfo(installerDir);
            //pInfo.UseShellExecute = true;

            //Process p = new Process();
            //p.StartInfo = pInfo;
            //p.Start();
            //p.WaitForExit();
            //MessageBox.Show("Installing report Viewer Completed.");
            
        }
        
    }
}
