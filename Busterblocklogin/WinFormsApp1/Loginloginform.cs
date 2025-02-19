using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Loginloginform : Form
    {
        public Loginloginform()
        {
            InitializeComponent();
        }

        private void _1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginloginform1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginloginform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginLoginside_Click(object sender, EventArgs e)
        {
            string filepath = "Username.txt";
            if (!File.Exists(filepath)) {
                MessageBox.Show("File does not exits!, jeg kan godt lide kage.");
                return;
            }
        }
}
}