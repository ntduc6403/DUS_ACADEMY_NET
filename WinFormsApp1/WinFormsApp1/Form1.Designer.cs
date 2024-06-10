namespace WinFormsApp1
{
    partial class frmGetData
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
            button1 = new Button();
            txtName = new TextBox();
            txtSurname = new TextBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 271);
            button1.Name = "button1";
            button1.Size = new Size(285, 108);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(129, 196);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 2;
            txtSurname.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(499, 55);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(629, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(159, 310);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // frmGetData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "frmGetData";
            Text = "frmGetData";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private TextBox txtSurname;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}
