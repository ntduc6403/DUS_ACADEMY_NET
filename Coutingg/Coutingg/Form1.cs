namespace Coutingg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int firtNumber = 0, lastNumber = 0;
        int divisibleTerm = 1;
        string divisibleNumber = "";
        int controlNumber = 0;
        private void btnCount_Click(object sender, EventArgs e)
        {


            if (txtStarForm.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the neccessary fields");
            }
            else if (cmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("please select dibvible term");
            }
            else
            {
                firtNumber = Convert.ToInt32(txtStarForm.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);
                for (int i = firtNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                        {
                            divisibleNumber += Environment.NewLine; //xuống dòng
                            controlNumber++;
                        }
                    }
                }
                txtDevisibleNumbers.Text = divisibleNumber;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("9");
            cmbDivisibleTerm.Items.Add("10");



        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }

        private void txtStarForm_KeyPress(object sender, KeyPressEventArgs e) //chỉ được viết số
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGreen.Checked)
            {
                rdRed.Checked = false;
                rdBlue.Checked = false;
                rdBlack.Checked = false;
                txtDevisibleNumbers.ForeColor = Color.Green;

            }
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlack.Checked)
            {
                rdRed.Checked = false;
                rdBlue.Checked = false;
                rdGreen.Checked = false;
                txtDevisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRed.Checked)
            {
                rdBlack.Checked = false;
                rdBlue.Checked = false;
                rdGreen.Checked = false;
                txtDevisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlue.Checked)
            {
                rdRed.Checked = false;
                rdBlack.Checked = false;
                rdGreen.Checked = false;
                txtDevisibleNumbers.ForeColor = Color.Blue;

            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                txtDevisibleNumbers.Font = new Font(txtDevisibleNumbers.Font.FontFamily, txtDevisibleNumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtDevisibleNumbers.Font = new Font(txtDevisibleNumbers.Font.FontFamily, txtDevisibleNumbers.Font.Size, FontStyle.Regular);

            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDevisibleNumbers.Font = new Font(txtDevisibleNumbers.Font.FontFamily, txtDevisibleNumbers.Font.Size, FontStyle.Italic);
            }
            else
            {
                txtDevisibleNumbers.Font = new Font(txtDevisibleNumbers.Font.FontFamily, txtDevisibleNumbers.Font.Size, FontStyle.Regular);

            }
        }
    }
}
