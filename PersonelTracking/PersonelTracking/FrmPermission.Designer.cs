namespace PersonalTracking
{
    partial class FrmPermission
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
            txtUser = new TextBox();
            label1 = new Label();
            dpFinish = new DateTimePicker();
            dpStart = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtDayAmout = new TextBox();
            label2 = new Label();
            txtExplanation = new TextBox();
            label3 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(193, 44);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(264, 27);
            txtUser.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 44);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 7;
            label1.Text = "UserNo";
            // 
            // dpFinish
            // 
            dpFinish.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpFinish.Location = new Point(193, 143);
            dpFinish.Name = "dpFinish";
            dpFinish.Size = new Size(264, 27);
            dpFinish.TabIndex = 20;
            // 
            // dpStart
            // 
            dpStart.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStart.Location = new Point(193, 94);
            dpStart.Name = "dpStart";
            dpStart.Size = new Size(264, 27);
            dpStart.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 143);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 22;
            label5.Text = "Finish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 94);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 21;
            label6.Text = "Start";
            // 
            // txtDayAmout
            // 
            txtDayAmout.Location = new Point(193, 214);
            txtDayAmout.Name = "txtDayAmout";
            txtDayAmout.Size = new Size(264, 27);
            txtDayAmout.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 214);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 24;
            label2.Text = "Day Amount";
            // 
            // txtExplanation
            // 
            txtExplanation.Location = new Point(193, 274);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(387, 163);
            txtExplanation.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 274);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 26;
            label3.Text = "Explanation";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(333, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 45);
            btnClose.TabIndex = 28;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(119, 466);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 45);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmPermission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 550);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtExplanation);
            Controls.Add(label3);
            Controls.Add(txtDayAmout);
            Controls.Add(label2);
            Controls.Add(dpFinish);
            Controls.Add(dpStart);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Name = "FrmPermission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label label1;
        private DateTimePicker dpFinish;
        private DateTimePicker dpStart;
        private Label label5;
        private Label label6;
        private TextBox txtDayAmout;
        private Label label2;
        private TextBox txtExplanation;
        private Label label3;
        private Button btnClose;
        private Button btnSave;
    }
}