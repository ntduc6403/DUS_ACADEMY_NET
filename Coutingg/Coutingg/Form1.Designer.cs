namespace Coutingg
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
            label1 = new Label();
            label2 = new Label();
            txtStarForm = new TextBox();
            txtTo = new TextBox();
            btnCount = new Button();
            btnExit = new Button();
            label4 = new Label();
            cmbDivisibleTerm = new ComboBox();
            txtDevisibleNumbers = new TextBox();
            groupBox1 = new GroupBox();
            rdGreen = new RadioButton();
            rdBlue = new RadioButton();
            rdRed = new RadioButton();
            rdBlack = new RadioButton();
            chBold = new CheckBox();
            chItalic = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "Star Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(347, 39);
            label2.Name = "label2";
            label2.Size = new Size(34, 28);
            label2.TabIndex = 2;
            label2.Text = "To";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtStarForm
            // 
            txtStarForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStarForm.Location = new Point(165, 33);
            txtStarForm.Name = "txtStarForm";
            txtStarForm.Size = new Size(125, 34);
            txtStarForm.TabIndex = 1;
            txtStarForm.KeyPress += txtStarForm_KeyPress;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTo.Location = new Point(440, 36);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(125, 34);
            txtTo.TabIndex = 3;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCount.Location = new Point(166, 234);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(108, 39);
            btnCount.TabIndex = 8;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(323, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 39);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 131);
            label4.Name = "label4";
            label4.Size = new Size(188, 28);
            label4.TabIndex = 4;
            label4.Text = "Divisibale Number";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // cmbDivisibleTerm
            // 
            cmbDivisibleTerm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDivisibleTerm.FormattingEnabled = true;
            cmbDivisibleTerm.Location = new Point(332, 131);
            cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            cmbDivisibleTerm.Size = new Size(151, 36);
            cmbDivisibleTerm.TabIndex = 5;
            cmbDivisibleTerm.SelectedIndexChanged += cmbDivisibleTerm_SelectedIndexChanged;
            // 
            // txtDevisibleNumbers
            // 
            txtDevisibleNumbers.Dock = DockStyle.Bottom;
            txtDevisibleNumbers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDevisibleNumbers.Location = new Point(0, 293);
            txtDevisibleNumbers.Multiline = true;
            txtDevisibleNumbers.Name = "txtDevisibleNumbers";
            txtDevisibleNumbers.Size = new Size(1029, 181);
            txtDevisibleNumbers.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdGreen);
            groupBox1.Controls.Add(rdBlue);
            groupBox1.Controls.Add(rdRed);
            groupBox1.Controls.Add(rdBlack);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(627, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 200);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Colour";
            // 
            // rdGreen
            // 
            rdGreen.AutoSize = true;
            rdGreen.Location = new Point(23, 146);
            rdGreen.Name = "rdGreen";
            rdGreen.Size = new Size(78, 27);
            rdGreen.TabIndex = 3;
            rdGreen.TabStop = true;
            rdGreen.Text = "Green";
            rdGreen.UseVisualStyleBackColor = true;
            rdGreen.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rdBlue
            // 
            rdBlue.AutoSize = true;
            rdBlue.Location = new Point(23, 101);
            rdBlue.Name = "rdBlue";
            rdBlue.Size = new Size(66, 27);
            rdBlue.TabIndex = 0;
            rdBlue.TabStop = true;
            rdBlue.Text = "Blue";
            rdBlue.UseVisualStyleBackColor = true;
            rdBlue.CheckedChanged += rdBlue_CheckedChanged;
            // 
            // rdRed
            // 
            rdRed.AutoSize = true;
            rdRed.Location = new Point(23, 62);
            rdRed.Name = "rdRed";
            rdRed.Size = new Size(62, 27);
            rdRed.TabIndex = 1;
            rdRed.TabStop = true;
            rdRed.Text = "Red";
            rdRed.UseVisualStyleBackColor = true;
            rdRed.CheckedChanged += rdRed_CheckedChanged;
            // 
            // rdBlack
            // 
            rdBlack.AutoSize = true;
            rdBlack.Location = new Point(23, 29);
            rdBlack.Name = "rdBlack";
            rdBlack.Size = new Size(74, 27);
            rdBlack.TabIndex = 0;
            rdBlack.TabStop = true;
            rdBlack.Text = "Black";
            rdBlack.UseVisualStyleBackColor = true;
            rdBlack.CheckedChanged += rdBlack_CheckedChanged;
            // 
            // chBold
            // 
            chBold.AutoSize = true;
            chBold.Location = new Point(46, 177);
            chBold.Name = "chBold";
            chBold.Size = new Size(62, 24);
            chBold.TabIndex = 6;
            chBold.Text = "Bold";
            chBold.UseVisualStyleBackColor = true;
            chBold.CheckedChanged += chBold_CheckedChanged;
            // 
            // chItalic
            // 
            chItalic.AutoSize = true;
            chItalic.Location = new Point(46, 222);
            chItalic.Name = "chItalic";
            chItalic.Size = new Size(63, 24);
            chItalic.TabIndex = 7;
            chItalic.Text = "Italic";
            chItalic.UseVisualStyleBackColor = true;
            chItalic.CheckedChanged += chItalic_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 474);
            Controls.Add(chItalic);
            Controls.Add(chBold);
            Controls.Add(groupBox1);
            Controls.Add(txtDevisibleNumbers);
            Controls.Add(cmbDivisibleTerm);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(txtTo);
            Controls.Add(txtStarForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStarForm;
        private TextBox txtTo;
        private Button btnCount;
        private Button btnExit;
        private Label label4;
        private ComboBox cmbDivisibleTerm;
        private TextBox txtDevisibleNumbers;
        private GroupBox groupBox1;
        private RadioButton rdGreen;
        private RadioButton rdBlue;
        private RadioButton rdRed;
        private RadioButton rdBlack;
        private CheckBox chBold;
        private CheckBox chItalic;
    }
}
