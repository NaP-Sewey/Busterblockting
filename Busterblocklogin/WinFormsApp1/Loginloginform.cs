using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            // Herunder er de forskellige paths som definere filplaceringen hvor dataen gemmes/skal gemmes
            string path = @"C:\Users\claus\source\repos\NaP-Sewey\Busterblockting\Busterblocklogin\WinFormsApp1\Username.txt";//Paths
            string path2 = @"C:\Users\claus\source\repos\NaP-Sewey\Busterblockting\Busterblocklogin\WinFormsApp1\Password.txt";//Paths

            // Herunder er de forskellige data hvor der bliver hentet brugerinput fra de tekstboxe som er brugt.
            string username = txtUsername.Text; // Data
            string password = txtPassword.Text;// Data

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) // Her bliver der tjekket om brugernavn og adgangskode er udfyldt
            {
                MessageBox.Show("ALL SPACES NEED TO BE FILLED");
                return;
            }

            

            string Username = File.ReadAllText(path);
            string Password = File.ReadAllText(path2);

            
            if (username == Username && password == Password)
            {
                MessageBox.Show("SUCCESS");
            }
            else
            {
                MessageBox.Show("USERNAME OR PASSWORD IS INCORRECT");
            }
            this.Hide();

            Main main = new Main();
            main.Show(); // Normalt vil den ligge under hvis den var en "succes" så man først kommer ind når det hele er rigtigt men vi skulle have en mulighed for at komme derinde siden vi ikke kan få det til at fungere
        }

}
}