namespace PersonalTracking
{
    partial class FrmSalary
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            cbPosition = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            cbDepartment = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtUser = new TextBox();
            txtSurname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSalary = new TextBox();
            label5 = new Label();
            txtYear = new TextBox();
            cbMonth = new ComboBox();
            label6 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(463, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 640);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(302, 414);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbPosition);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cbDepartment);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 226);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(11, 125);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(201, 28);
            cbPosition.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 9);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 42;
            label8.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 83);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 43;
            label7.Text = "Position";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(11, 52);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(201, 28);
            cbDepartment.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 37;
            label1.Text = "USERNO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 77);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 38;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(215, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 27);
            txtName.TabIndex = 35;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(215, 35);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(155, 27);
            txtUser.TabIndex = 34;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(215, 126);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(155, 27);
            txtSurname.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 126);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 39;
            label3.Text = "SurName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 184);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 41;
            label4.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(215, 185);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(155, 27);
            txtSalary.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 252);
            label5.Name = "label5";
            label5.Size = new Size(52, 28);
            label5.TabIndex = 43;
            label5.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(215, 253);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(155, 27);
            txtYear.TabIndex = 42;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(215, 316);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(157, 28);
            cbMonth.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 312);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 45;
            label6.Text = "Month";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(251, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 45);
            btnClose.TabIndex = 45;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(37, 406);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 45);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 640);
            Controls.Add(btnClose);
            Controls.Add(cbMonth);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtSalary);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(txtSurname);
            Name = "FrmSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtUser;
        private TextBox txtSurname;
        private Label label3;
        private ComboBox cbPosition;
        private Label label8;
        private Label label7;
        private ComboBox cbDepartment;
        private Label label4;
        private TextBox txtSalary;
        private Label label5;
        private TextBox txtYear;
        private ComboBox cbMonth;
        private Label label6;
        private Button btnClose;
        private Button btnSave;
    }
}