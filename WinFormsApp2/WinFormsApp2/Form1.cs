namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Employee personelDetail = new Employee();

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            personelDetail.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            personelDetail.Name = Convert.ToString(textName.Text);
            personelDetail.Age = Convert.ToInt32(textAge.Text);
            MessageBox.Show("All Data Received");
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            personelDetail.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            personelDetail.Name = Convert.ToString(textName.Text);
            personelDetail.Age = Convert.ToInt32(textAge.Text);
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
