namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            this.Hide();

            Loginloginform loginloginForm = new Loginloginform();
            loginloginForm.Show();
        }

        private void Signupforside_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            this.Hide();

            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
