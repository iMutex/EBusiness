namespace EBusiness
{
    partial class frmCreateDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSetExpiryDate = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnValidateRegistration = new System.Windows.Forms.Button();
            this.btnDays = new System.Windows.Forms.Button();
            this.btnInitializeDatabase = new System.Windows.Forms.Button();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.btnUnRegister = new System.Windows.Forms.Button();
            this.btnRegisterFullVersion = new System.Windows.Forms.Button();
            this.btnRegisterTrial = new System.Windows.Forms.Button();
            this.txtSQLQuery = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadSQL = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbSchemaQuery = new System.Windows.Forms.RadioButton();
            this.rbSelectDataQuery = new System.Windows.Forms.RadioButton();
            this.rbUpdateDataQuery = new System.Windows.Forms.RadioButton();
            this.btnExecuteSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSetExpiryDate);
            this.splitContainer1.Panel1.Controls.Add(this.btnResetPassword);
            this.splitContainer1.Panel1.Controls.Add(this.btnValidateRegistration);
            this.splitContainer1.Panel1.Controls.Add(this.btnDays);
            this.splitContainer1.Panel1.Controls.Add(this.btnInitializeDatabase);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateDatabase);
            this.splitContainer1.Panel1.Controls.Add(this.btnUnRegister);
            this.splitContainer1.Panel1.Controls.Add(this.btnRegisterFullVersion);
            this.splitContainer1.Panel1.Controls.Add(this.btnRegisterTrial);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblResult);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.txtSQLQuery);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(925, 597);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSetExpiryDate
            // 
            this.btnSetExpiryDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetExpiryDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetExpiryDate.Location = new System.Drawing.Point(0, 240);
            this.btnSetExpiryDate.Name = "btnSetExpiryDate";
            this.btnSetExpiryDate.Size = new System.Drawing.Size(295, 30);
            this.btnSetExpiryDate.TabIndex = 8;
            this.btnSetExpiryDate.Text = "Set Expiry Date";
            this.btnSetExpiryDate.UseVisualStyleBackColor = true;
            this.btnSetExpiryDate.Click += new System.EventHandler(this.btnSetExpiryDate_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetPassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(0, 210);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(295, 30);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "Reset User Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnValidateRegistration
            // 
            this.btnValidateRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnValidateRegistration.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateRegistration.Location = new System.Drawing.Point(0, 180);
            this.btnValidateRegistration.Name = "btnValidateRegistration";
            this.btnValidateRegistration.Size = new System.Drawing.Size(295, 30);
            this.btnValidateRegistration.TabIndex = 6;
            this.btnValidateRegistration.Text = "Validate Registration";
            this.btnValidateRegistration.UseVisualStyleBackColor = true;
            this.btnValidateRegistration.Click += new System.EventHandler(this.btnValidateRegistration_Click);
            // 
            // btnDays
            // 
            this.btnDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDays.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDays.Location = new System.Drawing.Point(0, 150);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(295, 30);
            this.btnDays.TabIndex = 5;
            this.btnDays.Text = "No Of Days Left";
            this.btnDays.UseVisualStyleBackColor = true;
            this.btnDays.Click += new System.EventHandler(this.btnDays_Click);
            // 
            // btnInitializeDatabase
            // 
            this.btnInitializeDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInitializeDatabase.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializeDatabase.Location = new System.Drawing.Point(0, 120);
            this.btnInitializeDatabase.Name = "btnInitializeDatabase";
            this.btnInitializeDatabase.Size = new System.Drawing.Size(295, 30);
            this.btnInitializeDatabase.TabIndex = 4;
            this.btnInitializeDatabase.Text = "Intialize Database";
            this.btnInitializeDatabase.UseVisualStyleBackColor = true;
            this.btnInitializeDatabase.Click += new System.EventHandler(this.btnInitializeDatabase_Click);
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateDatabase.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDatabase.Location = new System.Drawing.Point(0, 90);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(295, 30);
            this.btnCreateDatabase.TabIndex = 3;
            this.btnCreateDatabase.Text = "Create Database";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // btnUnRegister
            // 
            this.btnUnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnRegister.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnRegister.Location = new System.Drawing.Point(0, 60);
            this.btnUnRegister.Name = "btnUnRegister";
            this.btnUnRegister.Size = new System.Drawing.Size(295, 30);
            this.btnUnRegister.TabIndex = 2;
            this.btnUnRegister.Text = "UnRegister";
            this.btnUnRegister.UseVisualStyleBackColor = true;
            this.btnUnRegister.Click += new System.EventHandler(this.btnUnRegister_Click);
            // 
            // btnRegisterFullVersion
            // 
            this.btnRegisterFullVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterFullVersion.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterFullVersion.Location = new System.Drawing.Point(0, 30);
            this.btnRegisterFullVersion.Name = "btnRegisterFullVersion";
            this.btnRegisterFullVersion.Size = new System.Drawing.Size(295, 30);
            this.btnRegisterFullVersion.TabIndex = 1;
            this.btnRegisterFullVersion.Text = "Register Full Version";
            this.btnRegisterFullVersion.UseVisualStyleBackColor = true;
            this.btnRegisterFullVersion.Click += new System.EventHandler(this.btnRegisterFullVersion_Click);
            // 
            // btnRegisterTrial
            // 
            this.btnRegisterTrial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterTrial.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterTrial.Location = new System.Drawing.Point(0, 0);
            this.btnRegisterTrial.Name = "btnRegisterTrial";
            this.btnRegisterTrial.Size = new System.Drawing.Size(295, 30);
            this.btnRegisterTrial.TabIndex = 0;
            this.btnRegisterTrial.Text = "Register Trial";
            this.btnRegisterTrial.UseVisualStyleBackColor = true;
            this.btnRegisterTrial.Click += new System.EventHandler(this.btnRegisterTrial_Click);
            // 
            // txtSQLQuery
            // 
            this.txtSQLQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSQLQuery.Location = new System.Drawing.Point(0, 116);
            this.txtSQLQuery.Name = "txtSQLQuery";
            this.txtSQLQuery.Size = new System.Drawing.Size(626, 206);
            this.txtSQLQuery.TabIndex = 7;
            this.txtSQLQuery.Text = "";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loaded SQL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExecuteSQL);
            this.groupBox1.Controls.Add(this.rbUpdateDataQuery);
            this.groupBox1.Controls.Add(this.rbSelectDataQuery);
            this.groupBox1.Controls.Add(this.rbSchemaQuery);
            this.groupBox1.Controls.Add(this.btnLoadSQL);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnLoadSQL
            // 
            this.btnLoadSQL.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSQL.Location = new System.Drawing.Point(529, 16);
            this.btnLoadSQL.Name = "btnLoadSQL";
            this.btnLoadSQL.Size = new System.Drawing.Size(91, 23);
            this.btnLoadSQL.TabIndex = 7;
            this.btnLoadSQL.Text = "Load SQL";
            this.btnLoadSQL.UseVisualStyleBackColor = true;
            this.btnLoadSQL.Click += new System.EventHandler(this.btnLoadSQL_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(441, 20);
            this.txtPath.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(453, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 217);
            this.panel1.TabIndex = 9;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(626, 217);
            this.dgvResult.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Location = new System.Drawing.Point(0, 539);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(626, 56);
            this.lblResult.TabIndex = 10;
            // 
            // rbSchemaQuery
            // 
            this.rbSchemaQuery.AutoSize = true;
            this.rbSchemaQuery.Checked = true;
            this.rbSchemaQuery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSchemaQuery.ForeColor = System.Drawing.Color.Red;
            this.rbSchemaQuery.Location = new System.Drawing.Point(20, 56);
            this.rbSchemaQuery.Name = "rbSchemaQuery";
            this.rbSchemaQuery.Size = new System.Drawing.Size(119, 17);
            this.rbSchemaQuery.TabIndex = 8;
            this.rbSchemaQuery.TabStop = true;
            this.rbSchemaQuery.Text = "Schema Query";
            this.rbSchemaQuery.UseVisualStyleBackColor = true;
            this.rbSchemaQuery.Click += new System.EventHandler(this.rbSchemaQuery_Click);
            // 
            // rbSelectDataQuery
            // 
            this.rbSelectDataQuery.AutoSize = true;
            this.rbSelectDataQuery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSelectDataQuery.ForeColor = System.Drawing.Color.Green;
            this.rbSelectDataQuery.Location = new System.Drawing.Point(299, 56);
            this.rbSelectDataQuery.Name = "rbSelectDataQuery";
            this.rbSelectDataQuery.Size = new System.Drawing.Size(142, 17);
            this.rbSelectDataQuery.TabIndex = 9;
            this.rbSelectDataQuery.Text = "Select Data Query";
            this.rbSelectDataQuery.UseVisualStyleBackColor = true;
            this.rbSelectDataQuery.Click += new System.EventHandler(this.rbSchemaQuery_Click);
            // 
            // rbUpdateDataQuery
            // 
            this.rbUpdateDataQuery.AutoSize = true;
            this.rbUpdateDataQuery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdateDataQuery.ForeColor = System.Drawing.Color.Yellow;
            this.rbUpdateDataQuery.Location = new System.Drawing.Point(145, 56);
            this.rbUpdateDataQuery.Name = "rbUpdateDataQuery";
            this.rbUpdateDataQuery.Size = new System.Drawing.Size(148, 17);
            this.rbUpdateDataQuery.TabIndex = 10;
            this.rbUpdateDataQuery.Text = "Update Data Query";
            this.rbUpdateDataQuery.UseVisualStyleBackColor = true;
            this.rbUpdateDataQuery.Click += new System.EventHandler(this.rbSchemaQuery_Click);
            // 
            // btnExecuteSQL
            // 
            this.btnExecuteSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuteSQL.ForeColor = System.Drawing.Color.Blue;
            this.btnExecuteSQL.Location = new System.Drawing.Point(453, 47);
            this.btnExecuteSQL.Name = "btnExecuteSQL";
            this.btnExecuteSQL.Size = new System.Drawing.Size(167, 34);
            this.btnExecuteSQL.TabIndex = 11;
            this.btnExecuteSQL.Text = "Execute SQL";
            this.btnExecuteSQL.UseVisualStyleBackColor = true;
            this.btnExecuteSQL.Click += new System.EventHandler(this.btnExecuteSQL_Click);
            // 
            // frmCreateDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 597);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateDB";
            this.Text = "Super Administration";
            this.Load += new System.EventHandler(this.frmCreateDB_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Button btnUnRegister;
        private System.Windows.Forms.Button btnRegisterFullVersion;
        private System.Windows.Forms.Button btnRegisterTrial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadSQL;
        private System.Windows.Forms.RichTextBox txtSQLQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnInitializeDatabase;
        private System.Windows.Forms.Button btnValidateRegistration;
        private System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnSetExpiryDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rbUpdateDataQuery;
        private System.Windows.Forms.RadioButton rbSelectDataQuery;
        private System.Windows.Forms.RadioButton rbSchemaQuery;
        private System.Windows.Forms.Button btnExecuteSQL;
    }
}