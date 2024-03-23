namespace HumanResourceManagement
{
    partial class frmShowInfoEmployee
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
            btnBack = new Button();
            groupBox2 = new GroupBox();
            txtDepartment = new TextBox();
            label22 = new Label();
            txtSalary = new TextBox();
            txtPosition = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label13 = new Label();
            txtEmployeeID = new TextBox();
            groupBox1 = new GroupBox();
            txtGender = new TextBox();
            dtpDOB = new DateTimePicker();
            txtSkill = new TextBox();
            txtIDCart = new TextBox();
            txtPhone = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtAdress = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveBorder;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(967, 571);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(128, 48);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDepartment);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(txtSalary);
            groupBox2.Controls.Add(txtPosition);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtEmployeeID);
            groupBox2.Location = new Point(12, 341);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1106, 197);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contract Information";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartment.Location = new Point(799, 56);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(230, 39);
            txtDepartment.TabIndex = 34;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(611, 59);
            label22.Name = "label22";
            label22.Size = new Size(142, 32);
            label22.TabIndex = 32;
            label22.Text = "Department";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(761, 125);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(268, 39);
            txtSalary.TabIndex = 26;
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPosition.Location = new Point(206, 125);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(268, 39);
            txtPosition.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(616, 128);
            label16.Name = "label16";
            label16.Size = new Size(77, 32);
            label16.TabIndex = 23;
            label16.Text = "Salary";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(46, 128);
            label15.Name = "label15";
            label15.Size = new Size(98, 32);
            label15.TabIndex = 22;
            label15.Text = "Position";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(46, 55);
            label13.Name = "label13";
            label13.Size = new Size(149, 32);
            label13.TabIndex = 20;
            label13.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeID.Location = new Point(206, 52);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(268, 39);
            txtEmployeeID.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(txtSkill);
            groupBox1.Controls.Add(txtIDCart);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAdress);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1106, 308);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(717, 42);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(312, 39);
            txtGender.TabIndex = 21;
            // 
            // dtpDOB
            // 
            dtpDOB.CustomFormat = "dd/MM/yyyy";
            dtpDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(162, 113);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(312, 39);
            dtpDOB.TabIndex = 20;
            // 
            // txtSkill
            // 
            txtSkill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSkill.Location = new Point(717, 251);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(312, 39);
            txtSkill.TabIndex = 14;
            // 
            // txtIDCart
            // 
            txtIDCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDCart.Location = new Point(717, 180);
            txtIDCart.Name = "txtIDCart";
            txtIDCart.ReadOnly = true;
            txtIDCart.Size = new Size(312, 39);
            txtIDCart.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(717, 115);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(312, 39);
            txtPhone.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(611, 254);
            label8.Name = "label8";
            label8.Size = new Size(57, 32);
            label8.TabIndex = 11;
            label8.Text = "Skill";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(611, 183);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 10;
            label7.Text = "ID Cart";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(611, 115);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 9;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(611, 45);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(162, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 39);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 254);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 183);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // txtAdress
            // 
            txtAdress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdress.Location = new Point(162, 180);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(312, 39);
            txtAdress.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(162, 42);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(312, 39);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 115);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 1;
            label2.Text = "DOB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 45);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveBorder;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(699, 571);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 48);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveBorder;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(833, 571);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 48);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmShowInfoEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 628);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnBack);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmShowInfoEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowInfoEmployee";
            Load += frmShowInfoEmployee_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private GroupBox groupBox2;
        private Label label22;
        private TextBox txtSalary;
        private TextBox txtPosition;
        private Label label16;
        private Label label15;
        private Label label13;
        private TextBox txtEmployeeID;
        private GroupBox groupBox1;
        private TextBox txtSkill;
        private TextBox txtIDCart;
        private TextBox txtPhone;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private TextBox txtAdress;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDOB;
        private TextBox txtDepartment;
        private TextBox txtGender;
        private Button btnEdit;
        private Button btnDelete;
    }
}