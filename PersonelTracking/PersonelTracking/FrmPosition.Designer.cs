namespace PersonalTracking
{
    partial class FrmPosition
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
            txtPosition = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            cbDepartment = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 85);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "Position";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(295, 89);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(151, 27);
            txtPosition.TabIndex = 1;
            txtPosition.TextChanged += txtPosition_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 150);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 2;
            label2.Text = "Department";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(114, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 42);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(315, 230);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 42);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(295, 154);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(151, 28);
            cbDepartment.TabIndex = 6;
            // 
            // FrmPosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 359);
            Controls.Add(cbDepartment);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtPosition);
            Controls.Add(label1);
            Name = "FrmPosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Position";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosition;
        private Label label2;
        private Button btnSave;
        private Button btnClose;
        private ComboBox cbDepartment;
    }
}