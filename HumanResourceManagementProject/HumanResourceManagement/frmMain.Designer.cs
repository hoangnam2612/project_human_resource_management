namespace HumanResourceManagement
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            tsmiAccount = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            tsmiEmployee = new ToolStripMenuItem();
            tsmiDepartment = new ToolStripMenuItem();
            msStatistic = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            rdOther = new RadioButton();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label5 = new Label();
            dgvEmployeeData = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeData).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, managementToolStripMenuItem, msStatistic, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1196, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAccount, logOutToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(85, 29);
            systemToolStripMenuItem.Text = "System";
            // 
            // tsmiAccount
            // 
            tsmiAccount.Name = "tsmiAccount";
            tsmiAccount.Size = new Size(248, 34);
            tsmiAccount.Text = "Manage Account";
            tsmiAccount.Click += tsmiAccount_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(248, 34);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiEmployee, tsmiDepartment });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(133, 29);
            managementToolStripMenuItem.Text = "Management";
            // 
            // tsmiEmployee
            // 
            tsmiEmployee.Name = "tsmiEmployee";
            tsmiEmployee.Size = new Size(209, 34);
            tsmiEmployee.Text = "Employee";
            tsmiEmployee.Click += tsmiEmployee_Click;
            // 
            // tsmiDepartment
            // 
            tsmiDepartment.Name = "tsmiDepartment";
            tsmiDepartment.Size = new Size(209, 34);
            tsmiDepartment.Text = "Department";
            tsmiDepartment.Click += tsmiDepartment_Click;
            // 
            // msStatistic
            // 
            msStatistic.Name = "msStatistic";
            msStatistic.Size = new Size(96, 29);
            msStatistic.Text = "Statistics";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(rdOther);
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1171, 184);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Information";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveBorder;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(521, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 49);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // rdOther
            // 
            rdOther.AutoSize = true;
            rdOther.Location = new Point(1086, 41);
            rdOther.Name = "rdOther";
            rdOther.Size = new Size(82, 29);
            rdOther.TabIndex = 9;
            rdOther.TabStop = true;
            rdOther.Text = "Other";
            rdOther.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(980, 41);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(93, 29);
            rdFemale.TabIndex = 8;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(890, 41);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(75, 29);
            rdMale.TabIndex = 7;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(792, 37);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(402, 41);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 4;
            label3.Text = "EmployeeID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(569, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(204, 39);
            txtID.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(107, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 39);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(503, 249);
            label5.Name = "label5";
            label5.Size = new Size(171, 32);
            label5.TabIndex = 11;
            label5.Text = "Employee List";
            // 
            // dgvEmployeeData
            // 
            dgvEmployeeData.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmployeeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeData.Location = new Point(25, 295);
            dgvEmployeeData.Name = "dgvEmployeeData";
            dgvEmployeeData.RowHeadersWidth = 62;
            dgvEmployeeData.RowTemplate.Height = 33;
            dgvEmployeeData.Size = new Size(1148, 391);
            dgvEmployeeData.TabIndex = 12;
            dgvEmployeeData.CellClick += dgvEmployeeData_CellClick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 710);
            Controls.Add(dgvEmployeeData);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            FormClosing += frmMain_FormClosing;
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem tsmiAccount;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem tsmiEmployee;
        private ToolStripMenuItem tsmiDepartment;
        private ToolStripMenuItem msStatistic;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox txtID;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private Button btnSearch;
        private RadioButton rdOther;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label label4;
        private Label label5;
        private DataGridView dgvEmployeeData;
    }
}