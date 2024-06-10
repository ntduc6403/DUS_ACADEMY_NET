namespace PersonalTracking
{
    partial class FrmDepartment
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
            txtDepartment = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 59);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 0;
            label1.Text = "Department";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(270, 59);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(159, 27);
            txtDepartment.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(97, 133);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 51);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(287, 133);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 51);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 259);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtDepartment);
            Controls.Add(label1);
            Name = "FrmDepartment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Department";
            Load += FrmDepartment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDepartment;
        private Button btnSave;
        private Button btnClose;
    }
}