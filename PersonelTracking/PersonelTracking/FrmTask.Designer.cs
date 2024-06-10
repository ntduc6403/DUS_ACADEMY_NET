namespace PersonalTracking
{
    partial class FrmTask
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
            label7 = new Label();
            cbDepartment = new ComboBox();
            label8 = new Label();
            txtSurname = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            cbTaskSate = new ComboBox();
            label4 = new Label();
            txtTitle = new TextBox();
            label5 = new Label();
            txtContent = new TextBox();
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
            panel1.Location = new Point(648, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 585);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(265, 420);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(cbPosition);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cbDepartment);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 165);
            panel2.TabIndex = 0;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(24, 121);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(155, 28);
            cbPosition.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 80);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 29;
            label7.Text = "Position";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(24, 49);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(155, 28);
            cbDepartment.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 18);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 28;
            label8.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(206, 124);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(155, 27);
            txtSurname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 19;
            label1.Text = "USERNO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 124);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 21;
            label3.Text = "SurName";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(205, 33);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(156, 27);
            txtUser.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(205, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 27);
            txtName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // cbTaskSate
            // 
            cbTaskSate.FormattingEnabled = true;
            cbTaskSate.Location = new Point(205, 196);
            cbTaskSate.Name = "cbTaskSate";
            cbTaskSate.Size = new Size(155, 28);
            cbTaskSate.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 192);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 31;
            label4.Text = "Task State";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(206, 261);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(155, 27);
            txtTitle.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 261);
            label5.Name = "label5";
            label5.Size = new Size(55, 28);
            label5.TabIndex = 33;
            label5.Text = "Title";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(205, 323);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(386, 158);
            txtContent.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 323);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 35;
            label6.Text = "Content";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(350, 511);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(189, 62);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(136, 511);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 62);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 585);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtContent);
            Controls.Add(label6);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(cbTaskSate);
            Controls.Add(txtSurname);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(txtName);
            Name = "FrmTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task";
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
        private ComboBox cbPosition;
        private Label label7;
        private ComboBox cbDepartment;
        private Label label8;
        private TextBox txtSurname;
        private Label label1;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtName;
        private Label label2;
        private ComboBox cbTaskSate;
        private Label label4;
        private TextBox txtTitle;
        private Label label5;
        private TextBox txtContent;
        private Label label6;
        private Button btnClose;
        private Button btnSave;
    }
}