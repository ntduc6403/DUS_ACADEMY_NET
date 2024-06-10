namespace WinFormsApp1
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //string Messagetext = "Simple messsga text";
            //string messagetitle = "Title";
            ////MessageBox.Show(Messagetext);
            //MessageBox.Show(Messagetext, messagetitle);
            //checkBox1.Checked = true;
            //bool control = checkBox1.Checked;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string surName = txtSurname.Text;
            string NameSurname = Name + surName;
            frmShowData frmShow = new frmShowData();
            frmShow.labelSurname.Text = NameSurname;
            frmShow.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ivalue = "";
            for (int i = 0;i < 10; i++)
            {
                
                for(int k = 0; k< 8; k++)
                {
                    richTextBox1.Text += "i=  " + i + " k= " + k + Environment.NewLine;
                }
            }
            MessageBox.Show(ivalue);



        }
    }
}
