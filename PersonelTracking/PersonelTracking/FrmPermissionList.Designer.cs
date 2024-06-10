namespace PersonalTracking
{
    partial class FrmPermissionList
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
            panel3 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            label9 = new Label();
            txtDayAmout = new TextBox();
            groupBox1 = new GroupBox();
            rdDeliveryDate = new RadioButton();
            rdStartDate = new RadioButton();
            dpFinish = new DateTimePicker();
            dpStart = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pnlForAdmin = new Panel();
            cbPosition = new ComboBox();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            cbDepartment = new ComboBox();
            txtName = new TextBox();
            label8 = new Label();
            txtUser = new TextBox();
            txtSurname = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            btnDisApprove = new Button();
            btnApprove = new Button();
            btnClose = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 260);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtDayAmout);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dpFinish);
            panel3.Controls.Add(dpStart);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(443, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 260);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(601, 204);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 36);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(438, 204);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 187);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 37;
            label9.Text = "Day Amout";
            // 
            // txtDayAmout
            // 
            txtDayAmout.Location = new Point(146, 187);
            txtDayAmout.Name = "txtDayAmout";
            txtDayAmout.Size = new Size(261, 27);
            txtDayAmout.TabIndex = 2;
            txtDayAmout.KeyPress += txtDayAmout_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdDeliveryDate);
            groupBox1.Controls.Add(rdStartDate);
            groupBox1.Location = new Point(477, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 126);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // rdDeliveryDate
            // 
            rdDeliveryDate.AutoSize = true;
            rdDeliveryDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdDeliveryDate.Location = new Point(23, 68);
            rdDeliveryDate.Name = "rdDeliveryDate";
            rdDeliveryDate.Size = new Size(149, 29);
            rdDeliveryDate.TabIndex = 1;
            rdDeliveryDate.TabStop = true;
            rdDeliveryDate.Text = "Delivery Date";
            rdDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rdStartDate
            // 
            rdStartDate.AutoSize = true;
            rdStartDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdStartDate.Location = new Point(23, 26);
            rdStartDate.Name = "rdStartDate";
            rdStartDate.Size = new Size(120, 29);
            rdStartDate.TabIndex = 0;
            rdStartDate.TabStop = true;
            rdStartDate.Text = "Start Date";
            rdStartDate.UseVisualStyleBackColor = true;
            // 
            // dpFinish
            // 
            dpFinish.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpFinish.Location = new Point(146, 136);
            dpFinish.Name = "dpFinish";
            dpFinish.Size = new Size(264, 27);
            dpFinish.TabIndex = 1;
            // 
            // dpStart
            // 
            dpStart.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStart.Location = new Point(146, 86);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(264, 27);
            dpStart.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 44);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 24;
            label4.Text = "Permission Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 135);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 26;
            label5.Text = "Finish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 86);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 25;
            label6.Text = "Start";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(cbPosition);
            pnlForAdmin.Controls.Add(label1);
            pnlForAdmin.Controls.Add(label7);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Controls.Add(cbDepartment);
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Controls.Add(label8);
            pnlForAdmin.Controls.Add(txtUser);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(443, 260);
            pnlForAdmin.TabIndex = 0;
            pnlForAdmin.Paint += pnlForAdmin_Paint;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(230, 216);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(155, 28);
            cbPosition.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 25);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 31;
            label1.Text = "USERNO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 212);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 35;
            label7.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 67);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 32;
            label2.Text = "Name";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(230, 165);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(155, 28);
            cbDepartment.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(232, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 27);
            txtName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 161);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 34;
            label8.Text = "Department";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(230, 25);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(155, 27);
            txtUser.TabIndex = 0;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(230, 116);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(155, 27);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 116);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 33;
            label3.Text = "SurName";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDisApprove);
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 552);
            panel2.Name = "panel2";
            panel2.Size = new Size(1201, 125);
            panel2.TabIndex = 1;
            // 
            // btnDisApprove
            // 
            btnDisApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisApprove.Location = new Point(76, 75);
            btnDisApprove.Name = "btnDisApprove";
            btnDisApprove.Size = new Size(143, 38);
            btnDisApprove.TabIndex = 1;
            btnDisApprove.Text = "Disapprove";
            btnDisApprove.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(76, 16);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(143, 38);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(789, 40);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 52);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(273, 40);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 52);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(615, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 52);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(447, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 52);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1201, 292);
            dataGridView1.TabIndex = 2;
            // 
            // FrmPermissionList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 677);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPermissionList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission List";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnDisApprove;
        private Button btnApprove;
        private Button btnClose;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel3;
        private Panel pnlForAdmin;
        private ComboBox cbPosition;
        private Label label1;
        private Label label7;
        private Label label2;
        private ComboBox cbDepartment;
        private TextBox txtName;
        private Label label8;
        private TextBox txtUser;
        private TextBox txtSurname;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rdDeliveryDate;
        private RadioButton rdStartDate;
        private DateTimePicker dpFinish;
        private DateTimePicker dpStart;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox txtDayAmout;
        private Button btnClear;
        private Button btnSearch;
    }
}