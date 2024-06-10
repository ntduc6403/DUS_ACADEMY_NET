namespace WinFormsApp1
{
    partial class frmShowData
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
            labelSurname = new Label();
            SuspendLayout();
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(263, 104);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(50, 20);
            labelSurname.TabIndex = 0;
            labelSurname.Text = "label1";
            // 
            // frmShowData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSurname);
            Name = "frmShowData";
            Text = "frmShowData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelSurname;
    }
}