namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void HideRadButtons()
        {
            groupBox1.Visible = false;
        }
        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }
        public void FillTextBox(string text)
        {
            textBox2.Text = text;
        }
        public void SetNumber(int age)
        {
            label1.Text = "You are" + age.ToString() + "Year old";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FillTextBox(textBox1.Text);
            SetNumber(35);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
