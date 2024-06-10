namespace PersonalTracking
{
    partial class FrmEmployee
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
            panel1 = new Panel();
            chIsAdmin = new CheckBox();
            btnCheck = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            txtImagePath = new TextBox();
            label6 = new Label();
            cbPosition = new ComboBox();
            label7 = new Label();
            cbDepartment = new ComboBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            textBox2 = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chIsAdmin);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 144);
            panel1.TabIndex = 0;
            // 
            // chIsAdmin
            // 
            chIsAdmin.AutoSize = true;
            chIsAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chIsAdmin.Location = new Point(876, 21);
            chIsAdmin.Name = "chIsAdmin";
            chIsAdmin.Size = new Size(132, 32);
            chIsAdmin.TabIndex = 2;
            chIsAdmin.Text = "Is Admin ?";
            chIsAdmin.UseVisualStyleBackColor = true;
            chIsAdmin.CheckedChanged += chIsAdmin_CheckedChanged;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(377, 21);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(111, 30);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(683, 23);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(186, 21);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(155, 27);
            txtUser.TabIndex = 0;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(539, 23);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "USERNO";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(219, 260);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(178, 27);
            txtSurname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 260);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 13;
            label3.Text = "SURNAME";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 199);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 27);
            txtName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 199);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 12;
            label4.Text = "NAME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 392);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 388);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 17;
            label5.Text = "Salary";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(219, 322);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(178, 27);
            txtImagePath.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 322);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 16;
            label6.Text = "Image Path";
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(219, 513);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(178, 28);
            cbPosition.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 509);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 21;
            label7.Text = "Position";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(219, 451);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(178, 28);
            cbDepartment.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(42, 447);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 20;
            label8.Text = "Department";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(640, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 223);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(428, 323);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(111, 30);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(42, 576);
            label9.Name = "label9";
            label9.Size = new Size(97, 28);
            label9.TabIndex = 23;
            label9.Text = "BirthDay";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 581);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2024, 3, 29, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(42, 657);
            label10.Name = "label10";
            label10.Size = new Size(97, 28);
            label10.TabIndex = 25;
            label10.Text = "BirthDay";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 661);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(619, 152);
            textBox2.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(505, 876);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(189, 62);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(291, 876);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 62);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 997);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox1);
            Controls.Add(cbPosition);
            Controls.Add(label7);
            Controls.Add(cbDepartment);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(txtImagePath);
            Controls.Add(label6);
            Controls.Add(txtSurname);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label4);
            Name = "FrmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUser;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private CheckBox chIsAdmin;
        private Button btnCheck;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox txtImagePath;
        private Label label6;
        private ComboBox cbPosition;
        private Label label7;
        private ComboBox cbDepartment;
        private Label label8;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox textBox2;
        private Button btnClose;
        private Button btnSave;
    }
}