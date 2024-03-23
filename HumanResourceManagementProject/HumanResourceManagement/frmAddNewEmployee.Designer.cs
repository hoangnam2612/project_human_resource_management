namespace HumanResourceManagement
{
    partial class frmAddNewEmployee
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbSkill = new ComboBox();
            dtpDOB = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            cbGender = new ComboBox();
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
            groupBox2 = new GroupBox();
            cbPosition = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            cbDepartment = new ComboBox();
            label18 = new Label();
            txtSalary = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label25 = new Label();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSkill);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbGender);
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
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1106, 308);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // cbSkill
            // 
            cbSkill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSkill.FormattingEnabled = true;
            cbSkill.Location = new Point(717, 251);
            cbSkill.Name = "cbSkill";
            cbSkill.Size = new Size(312, 40);
            cbSkill.TabIndex = 34;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDOB.CustomFormat = "dd/MM/yyyy";
            dtpDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(162, 110);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(312, 39);
            dtpDOB.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(953, 42);
            label12.Name = "label12";
            label12.Size = new Size(38, 32);
            label12.TabIndex = 19;
            label12.Text = "(*)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(480, 180);
            label11.Name = "label11";
            label11.Size = new Size(38, 32);
            label11.TabIndex = 18;
            label11.Text = "(*)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(480, 112);
            label10.Name = "label10";
            label10.Size = new Size(38, 32);
            label10.TabIndex = 17;
            label10.Text = "(*)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(480, 42);
            label9.Name = "label9";
            label9.Size = new Size(38, 32);
            label9.TabIndex = 16;
            label9.Text = "(*)";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbGender.Location = new Point(717, 42);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(230, 40);
            cbGender.TabIndex = 15;
            // 
            // txtIDCart
            // 
            txtIDCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDCart.Location = new Point(717, 180);
            txtIDCart.Name = "txtIDCart";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(cbPosition);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(cbDepartment);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(txtSalary);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Location = new Point(12, 342);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1106, 194);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contract Information";
            // 
            // cbPosition
            // 
            cbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(162, 90);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(312, 40);
            cbPosition.TabIndex = 33;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(1035, 59);
            label23.Name = "label23";
            label23.Size = new Size(38, 32);
            label23.TabIndex = 21;
            label23.Text = "(*)";
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
            // cbDepartment
            // 
            cbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(799, 56);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(230, 40);
            cbDepartment.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(1035, 124);
            label18.Name = "label18";
            label18.Size = new Size(38, 32);
            label18.TabIndex = 27;
            label18.Text = "(*)";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(799, 121);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(230, 39);
            txtSalary.TabIndex = 26;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(480, 93);
            label17.Name = "label17";
            label17.Size = new Size(38, 32);
            label17.TabIndex = 25;
            label17.Text = "(*)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(639, 124);
            label16.Name = "label16";
            label16.Size = new Size(77, 32);
            label16.TabIndex = 23;
            label16.Text = "Salary";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(46, 93);
            label15.Name = "label15";
            label15.Size = new Size(98, 32);
            label15.TabIndex = 22;
            label15.Text = "Position";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(697, 562);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 48);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(831, 562);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.Red;
            label25.Location = new Point(58, 570);
            label25.Name = "label25";
            label25.Size = new Size(255, 32);
            label25.TabIndex = 35;
            label25.Text = "(*): Các mục phải nhập";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveBorder;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(965, 562);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(128, 48);
            btnBack.TabIndex = 36;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmAddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 633);
            Controls.Add(btnBack);
            Controls.Add(label25);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmAddNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewEmployee";
            FormClosed += frmAddNewEmployee_FormClosed;
            Load += frmAddNewEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private TextBox txtAdress;
        private TextBox txtName;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cbGender;
        private TextBox txtIDCart;
        private TextBox txtPhone;
        private Label label8;
        private GroupBox groupBox2;
        private Label label16;
        private Label label15;
        private Label label23;
        private Label label22;
        private ComboBox cbDepartment;
        private Label label18;
        private TextBox txtSalary;
        private Label label17;
        private Button btnSave;
        private Button btnCancel;
        private Label label25;
        private ComboBox cbPosition;
        private DateTimePicker dtpDOB;
        private ComboBox cbSkill;
        private Button btnBack;
    }
}