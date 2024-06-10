namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetValue = new Button();
            btnSetValue = new Button();
            txtEmployeeId = new TextBox();
            textName = new TextBox();
            textAge = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // btnGetValue
            // 
            btnGetValue.Location = new Point(55, 80);
            btnGetValue.Name = "btnGetValue";
            btnGetValue.Size = new Size(191, 96);
            btnGetValue.TabIndex = 0;
            btnGetValue.Text = "Get Value";
            btnGetValue.UseVisualStyleBackColor = true;
            btnGetValue.Click += button1_Click;
            // 
            // btnSetValue
            // 
            btnSetValue.Location = new Point(297, 80);
            btnSetValue.Name = "btnSetValue";
            btnSetValue.Size = new Size(197, 96);
            btnSetValue.TabIndex = 1;
            btnSetValue.Text = "Set Value";
            btnSetValue.UseVisualStyleBackColor = true;
            btnSetValue.Click += btnSetValue_Click;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(266, 240);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(125, 27);
            txtEmployeeId.TabIndex = 2;
            // 
            // textName
            // 
            textName.Location = new Point(266, 317);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 3;
            textName.TextChanged += textName_TextChanged;
            // 
            // textAge
            // 
            textAge.Location = new Point(266, 391);
            textAge.Name = "textAge";
            textAge.Size = new Size(125, 27);
            textAge.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(545, 80);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(197, 96);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(textAge);
            Controls.Add(textName);
            Controls.Add(txtEmployeeId);
            Controls.Add(btnSetValue);
            Controls.Add(btnGetValue);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetValue;
        private Button btnSetValue;
        private TextBox txtEmployeeId;
        private TextBox textName;
        private TextBox textAge;
        private Button btnSend;
    }
}
