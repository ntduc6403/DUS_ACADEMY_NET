namespace PersonalTracking
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnEmployee = new Button();
            btnTask = new Button();
            btnSalary = new Button();
            btnDepartment = new Button();
            btnPermission = new Button();
            btnPosition = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(255, 128, 0);
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.Location = new Point(43, 21);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(159, 144);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.TextAlign = ContentAlignment.BottomCenter;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnTask
            // 
            btnTask.BackColor = Color.FromArgb(128, 255, 255);
            btnTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTask.Image = (Image)resources.GetObject("btnTask.Image");
            btnTask.Location = new Point(296, 21);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(159, 144);
            btnTask.TabIndex = 1;
            btnTask.Text = "Task";
            btnTask.TextAlign = ContentAlignment.BottomCenter;
            btnTask.UseVisualStyleBackColor = false;
            btnTask.Click += btnTask_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(0, 192, 0);
            btnSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalary.Image = (Image)resources.GetObject("btnSalary.Image");
            btnSalary.Location = new Point(538, 21);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(159, 144);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary";
            btnSalary.TextAlign = ContentAlignment.BottomCenter;
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(255, 224, 192);
            btnDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepartment.Image = (Image)resources.GetObject("btnDepartment.Image");
            btnDepartment.Location = new Point(296, 205);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(159, 144);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = "Department";
            btnDepartment.TextAlign = ContentAlignment.BottomCenter;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnPermission
            // 
            btnPermission.BackColor = Color.LightGreen;
            btnPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPermission.Image = (Image)resources.GetObject("btnPermission.Image");
            btnPermission.Location = new Point(43, 205);
            btnPermission.Name = "btnPermission";
            btnPermission.Size = new Size(159, 144);
            btnPermission.TabIndex = 4;
            btnPermission.Text = "Permission";
            btnPermission.TextAlign = ContentAlignment.BottomCenter;
            btnPermission.UseVisualStyleBackColor = false;
            btnPermission.Click += btnPermission_Click;
            // 
            // btnPosition
            // 
            btnPosition.BackColor = Color.FromArgb(128, 128, 255);
            btnPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPosition.Image = (Image)resources.GetObject("btnPosition.Image");
            btnPosition.Location = new Point(538, 205);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(159, 144);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Position";
            btnPosition.TextAlign = ContentAlignment.BottomCenter;
            btnPosition.UseVisualStyleBackColor = false;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Yellow;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(162, 375);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(159, 144);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LogOut";
            btnLogout.TextAlign = ContentAlignment.BottomCenter;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(404, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(159, 144);
            btnExit.TabIndex = 7;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 542);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnPosition);
            Controls.Add(btnPermission);
            Controls.Add(btnDepartment);
            Controls.Add(btnSalary);
            Controls.Add(btnTask);
            Controls.Add(btnEmployee);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Employee Tracking";
            FormClosed += FrmMain_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnTask;
        private Button btnSalary;
        private Button btnDepartment;
        private Button btnPermission;
        private Button btnPosition;
        private Button btnLogout;
        private Button btnExit;
    }
}