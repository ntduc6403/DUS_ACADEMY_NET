namespace PersonalTracking
{
    partial class FrmTaskList
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
            cbTaskSate = new ComboBox();
            label9 = new Label();
            btnSearch = new Button();
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
            label7 = new Label();
            cbDepartment = new ComboBox();
            label8 = new Label();
            txtSurname = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnApprove = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btbAdd = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 258);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(cbTaskSate);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dpFinish);
            panel3.Controls.Add(dpStart);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(469, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(718, 258);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(565, 198);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 36);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // cbTaskSate
            // 
            cbTaskSate.FormattingEnabled = true;
            cbTaskSate.Location = new Point(205, 176);
            cbTaskSate.Name = "cbTaskSate";
            cbTaskSate.Size = new Size(155, 28);
            cbTaskSate.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 172);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 27;
            label9.Text = "Task Sate";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(402, 198);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdDeliveryDate);
            groupBox1.Controls.Add(rdStartDate);
            groupBox1.Location = new Point(436, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 145);
            groupBox1.TabIndex = 21;
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
            dpFinish.Location = new Point(120, 110);
            dpFinish.Name = "dpFinish";
            dpFinish.Size = new Size(264, 27);
            dpFinish.TabIndex = 1;
            // 
            // dpStart
            // 
            dpStart.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStart.Location = new Point(120, 61);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(264, 27);
            dpStart.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 19);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 16;
            label4.Text = "Task Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 110);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 18;
            label5.Text = "Finish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 61);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 17;
            label6.Text = "Start";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(cbPosition);
            pnlForAdmin.Controls.Add(label7);
            pnlForAdmin.Controls.Add(cbDepartment);
            pnlForAdmin.Controls.Add(label8);
            pnlForAdmin.Controls.Add(txtSurname);
            pnlForAdmin.Controls.Add(label1);
            pnlForAdmin.Controls.Add(label3);
            pnlForAdmin.Controls.Add(txtUser);
            pnlForAdmin.Controls.Add(txtName);
            pnlForAdmin.Controls.Add(label2);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(469, 258);
            pnlForAdmin.TabIndex = 0;
            pnlForAdmin.Paint += pnlForAdmin_Paint;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(214, 210);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(155, 28);
            cbPosition.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 206);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 25;
            label7.Text = "Position";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(214, 159);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(155, 28);
            cbDepartment.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 155);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 24;
            label8.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(214, 110);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(155, 27);
            txtSurname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 13;
            label1.Text = "USERNO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 110);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 15;
            label3.Text = "SURNAME";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(214, 19);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(155, 27);
            txtUser.TabIndex = 0;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(216, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 61);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1187, 382);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btbAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 523);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 117);
            panel2.TabIndex = 2;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(119, 35);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(121, 52);
            btnApprove.TabIndex = 8;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(891, 35);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 52);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(674, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 52);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(501, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 52);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btbAdd
            // 
            btbAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbAdd.Location = new Point(301, 35);
            btbAdd.Name = "btbAdd";
            btbAdd.Size = new Size(121, 52);
            btbAdd.TabIndex = 4;
            btbAdd.Text = "Add";
            btbAdd.UseVisualStyleBackColor = true;
            btbAdd.Click += btbAdd_Click;
            // 
            // FrmTaskList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 640);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmTaskList";
            Text = "FrmTaskList";
            Load += FrmTaskList_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnApprove;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btbAdd;
        private Panel panel3;
        private Panel pnlForAdmin;
        private TextBox txtSurname;
        private Label label1;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtName;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbPosition;
        private Label label7;
        private ComboBox cbDepartment;
        private Label label8;
        private DateTimePicker dpFinish;
        private DateTimePicker dpStart;
        private ComboBox cbTaskSate;
        private Label label9;
        private GroupBox groupBox1;
        private RadioButton rdDeliveryDate;
        private RadioButton rdStartDate;
        private Button btnClear;
        private Button btnSearch;
    }
}