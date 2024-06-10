namespace PersonalTracking
{
    partial class FrmEmployeeList
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
            btnClear = new Button();
            btnSearch = new Button();
            cbPosition = new ComboBox();
            label5 = new Label();
            cbDepartment = new ComboBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cbPosition);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbDepartment);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 192);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(824, 112);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 62);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(824, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 62);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(561, 79);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(151, 28);
            cbPosition.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(380, 75);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 12;
            label5.Text = "Position";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(561, 30);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(151, 28);
            cbDepartment.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(380, 26);
            label4.Name = "label4";
            label4.Size = new Size(127, 28);
            label4.TabIndex = 10;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(185, 132);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(155, 27);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 132);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 9;
            label3.Text = "SURNAME";
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 7;
            label2.Text = "NAME";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(185, 26);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(155, 27);
            txtUser.TabIndex = 0;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 5;
            label1.Text = "USERNO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(992, 424);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 491);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 125);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(783, 26);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 62);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(570, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 62);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(335, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 62);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(110, 26);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(141, 62);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // FrmEmployeeList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 616);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmEmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee List";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private TextBox txtUser;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtSurname;
        private Label label3;
        private ComboBox cbDepartment;
        private Label label4;
        private Button btnClear;
        private Button btnSearch;
        private ComboBox cbPosition;
        private Label label5;
    }
}