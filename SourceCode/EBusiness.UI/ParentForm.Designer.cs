namespace EBusiness
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpNew = new System.Windows.Forms.TabPage();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tpView = new System.Windows.Forms.TabPage();
            this.gbGrid = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSearchByName = new System.Windows.Forms.RadioButton();
            this.rbSearchByCode = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpNew.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCommands.SuspendLayout();
            this.tpView.SuspendLayout();
            this.gbGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpNew);
            this.tcMain.Controls.Add(this.tpView);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(739, 539);
            this.tcMain.TabIndex = 0;
            // 
            // tpNew
            // 
            this.tpNew.Controls.Add(this.gbMain);
            this.tpNew.Controls.Add(this.panel1);
            this.tpNew.Controls.Add(this.gbCommands);
            this.tpNew.Location = new System.Drawing.Point(4, 22);
            this.tpNew.Name = "tpNew";
            this.tpNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpNew.Size = new System.Drawing.Size(731, 513);
            this.tpNew.TabIndex = 0;
            this.tpNew.Text = "New / Update";
            this.tpNew.UseVisualStyleBackColor = true;
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.Color.Transparent;
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(3, 60);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(725, 374);
            this.gbMain.TabIndex = 7;
            this.gbMain.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 57);
            this.panel1.TabIndex = 5;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(725, 57);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Header";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCommands
            // 
            this.gbCommands.Controls.Add(this.btnSave);
            this.gbCommands.Controls.Add(this.btnCancel);
            this.gbCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCommands.Location = new System.Drawing.Point(3, 434);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(725, 76);
            this.gbCommands.TabIndex = 4;
            this.gbCommands.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(491, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(608, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 51);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tpView
            // 
            this.tpView.Controls.Add(this.gbGrid);
            this.tpView.Controls.Add(this.gbSearch);
            this.tpView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpView.Location = new System.Drawing.Point(4, 22);
            this.tpView.Name = "tpView";
            this.tpView.Padding = new System.Windows.Forms.Padding(3);
            this.tpView.Size = new System.Drawing.Size(731, 513);
            this.tpView.TabIndex = 1;
            this.tpView.Text = "Search / View";
            this.tpView.UseVisualStyleBackColor = true;
            // 
            // gbGrid
            // 
            this.gbGrid.Controls.Add(this.dgvData);
            this.gbGrid.Controls.Add(this.panel2);
            this.gbGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGrid.Location = new System.Drawing.Point(3, 84);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(725, 426);
            this.gbGrid.TabIndex = 6;
            this.gbGrid.TabStop = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.Size = new System.Drawing.Size(719, 376);
            this.dgvData.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.txtBalance);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 31);
            this.panel2.TabIndex = 0;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtBalance.Location = new System.Drawing.Point(522, 3);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(188, 24);
            this.txtBalance.TabIndex = 17;
            this.txtBalance.Text = "0.00";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBalance.Location = new System.Drawing.Point(418, 4);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 18);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "Balance : ";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbAll);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.rbSearchByName);
            this.gbSearch.Controls.Add(this.rbSearchByCode);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Location = new System.Drawing.Point(3, 3);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(725, 81);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbAll.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbAll.Location = new System.Drawing.Point(432, 14);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(70, 17);
            this.rbAll.TabIndex = 5;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "View All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Vani", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search for";
            // 
            // rbSearchByName
            // 
            this.rbSearchByName.AutoSize = true;
            this.rbSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbSearchByName.ForeColor = System.Drawing.Color.DeepPink;
            this.rbSearchByName.Location = new System.Drawing.Point(293, 14);
            this.rbSearchByName.Name = "rbSearchByName";
            this.rbSearchByName.Size = new System.Drawing.Size(118, 17);
            this.rbSearchByName.TabIndex = 3;
            this.rbSearchByName.TabStop = true;
            this.rbSearchByName.Text = "Search by Name";
            this.rbSearchByName.UseVisualStyleBackColor = true;
            // 
            // rbSearchByCode
            // 
            this.rbSearchByCode.AutoSize = true;
            this.rbSearchByCode.Checked = true;
            this.rbSearchByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchByCode.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbSearchByCode.Location = new System.Drawing.Point(161, 14);
            this.rbSearchByCode.Name = "rbSearchByCode";
            this.rbSearchByCode.Size = new System.Drawing.Size(115, 17);
            this.rbSearchByCode.TabIndex = 2;
            this.rbSearchByCode.TabStop = true;
            this.rbSearchByCode.Text = "Search by Code";
            this.rbSearchByCode.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = true;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(161, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(341, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Blue;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(601, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(118, 49);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 539);
            this.ControlBox = false;
            this.Controls.Add(this.tcMain);
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tcMain.ResumeLayout(false);
            this.tpNew.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbCommands.ResumeLayout(false);
            this.tpView.ResumeLayout(false);
            this.gbGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCommands;
        protected System.Windows.Forms.Button btnFind;
        protected System.Windows.Forms.TabControl tcMain;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbGrid;
        protected System.Windows.Forms.RadioButton rbSearchByCode;
        protected System.Windows.Forms.RadioButton rbSearchByName;
        protected System.Windows.Forms.RadioButton rbAll;
        protected System.Windows.Forms.TabPage tpView;
        protected System.Windows.Forms.TabPage tpNew;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label lblHeader;
        protected System.Windows.Forms.GroupBox gbMain;
        protected System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.TextBox txtBalance;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbSearch;

    }
}