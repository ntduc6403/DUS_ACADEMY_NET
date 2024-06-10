namespace PersonalTracking
{
    partial class FrmSalaryList
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
            panel4 = new Panel();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            rbEquals = new RadioButton();
            rbLess = new RadioButton();
            rbMore = new RadioButton();
            btnSearch = new Button();
            label4 = new Label();
            txtSalary = new TextBox();
            cbMonth = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtYear = new TextBox();
            pnlForAdmin = new Panel();
            cbPosition = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtSurname = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            cbDepartment = new ComboBox();
            label8 = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            btnClose = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 268);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtSalary);
            panel4.Controls.Add(cbMonth);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtYear);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(408, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(691, 268);
            panel4.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(507, 160);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 36);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEquals);
            groupBox1.Controls.Add(rbLess);
            groupBox1.Controls.Add(rbMore);
            groupBox1.Location = new Point(313, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 93);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbEquals
            // 
            rbEquals.AutoSize = true;
            rbEquals.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbEquals.Location = new Point(260, 38);
            rbEquals.Name = "rbEquals";
            rbEquals.Size = new Size(94, 32);
            rbEquals.TabIndex = 2;
            rbEquals.TabStop = true;
            rbEquals.Text = "Equals";
            rbEquals.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            rbLess.AutoSize = true;
            rbLess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbLess.Location = new Point(144, 36);
            rbLess.Name = "rbLess";
            rbLess.Size = new Size(72, 32);
            rbLess.TabIndex = 1;
            rbLess.TabStop = true;
            rbLess.Text = "Less";
            rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMore.Location = new Point(31, 36);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(83, 32);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(344, 160);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 150);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 53;
            label4.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(115, 154);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(155, 27);
            txtSalary.TabIndex = 2;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(115, 88);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(157, 28);
            cbMonth.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 24);
            label5.Name = "label5";
            label5.Size = new Size(52, 28);
            label5.TabIndex = 49;
            label5.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 84);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 51;
            label6.Text = "Month";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(115, 28);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(155, 27);
            txtYear.TabIndex = 0;
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(cbPosition);
            pnlForAdmin.Controls.Add(label1);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Controls.Add(label7);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Controls.Add(txtUser);
            pnlForAdmin.Controls.Add(cbDepartment);
            pnlForAdmin.Controls.Add(label8);
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(408, 268);
            pnlForAdmin.TabIndex = 1;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(214, 215);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(155, 28);
            cbPosition.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 41;
            label1.Text = "USERNO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 115);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 43;
            label3.Text = "SurName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 211);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 45;
            label7.Text = "Position";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(214, 115);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(155, 27);
            txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 66);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 42;
            label2.Text = "Name";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(214, 24);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(155, 27);
            txtUser.TabIndex = 0;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(214, 164);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(155, 28);
            cbDepartment.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 160);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 44;
            label8.Text = "Department";
            // 
            // txtName
            // 
            txtName.Location = new Point(216, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 27);
            txtName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 612);
            panel2.Name = "panel2";
            panel2.Size = new Size(1099, 125);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(690, 36);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 52);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(174, 36);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 52);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(516, 36);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 52);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(348, 36);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 52);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 268);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1099, 344);
            dataGridView1.TabIndex = 2;
            // 
            // FrmSalaryList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 737);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmSalaryList";
            Text = "FrmSalaryList";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel pnlForAdmin;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cbPosition;
        private Label label1;
        private Label label3;
        private Label label7;
        private TextBox txtSurname;
        private Label label2;
        private TextBox txtUser;
        private ComboBox cbDepartment;
        private Label label8;
        private TextBox txtName;
        private Label label4;
        private TextBox txtSalary;
        private ComboBox cbMonth;
        private Label label5;
        private Label label6;
        private TextBox txtYear;
        private GroupBox groupBox1;
        private RadioButton rbMore;
        private RadioButton rbEquals;
        private RadioButton rbLess;
        private Button btnClear;
        private Button btnSearch;
    }
}