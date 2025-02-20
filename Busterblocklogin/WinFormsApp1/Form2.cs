using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Herunder er de forskellige paths som definere filplaceringen hvor dataen gemmes/skal gemmes
            string path = @"C:\Users\Bruger\Desktop\Database\Username.txt";//Paths
            string path2 = @"C:\Users\Bruger\Desktop\Database\Password.txt";//Paths
            string path3 = @"C:\Users\Bruger\Desktop\Database\Mail.txt";//Paths
            string path4 = @"C:\Users\Bruger\Desktop\Database\Phonenumber.txt";//Paths


            // Herunder er de forskellige data hvor der bliver hentet brugerinput fra de tekstboxe som er brugt.
            string username = txtUsername.Text; // Data
            string password = txtUsername.Text;// Data
            string mail = txtMail.Text; // Data
            string phonenumber = txtPhonenumber.Text; // Data
            string confirmPassword = txtConfirmPassword.Text;

            if (!File.Exists(username)) using (StreamWriter sw = File.CreateText(username))

                {

                    sw.WriteLine("Username existere ikke!");


                    sw.Close();

                }

            if (!File.Exists(password)) using (StreamWriter sw = File.CreateText(password))

                {

                    sw.WriteLine("Password existere ikke!");


                    sw.Close();

                }
;
            if (!File.Exists(mail)) using (StreamWriter sw = File.CreateText(mail))

                {

                    sw.WriteLine("Mail existere ikke!");


                    sw.Close();

                }
;
            if (!File.Exists(phonenumber)) using (StreamWriter sw = File.CreateText(phonenumber))

                {

                    sw.WriteLine("Phonenumber existere ikke!");


                    sw.Close();

                }
;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(phonenumber))// Her bliver der tjekket om brugernavn og adgangskode er udfyldt
            {
                MessageBox.Show("ALL SPACES NEED TO BE FILLED");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("PASSWORDS DOES NOT MATCH");
                return;
            }

            using (StreamReader sr = File.OpenText(path))
            {
                using (StreamWriter sw = File.CreateText(path2))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] substring = line.Split(',');

                        string[] existingUsers = File.ReadAllLines(path);
                        if (Array.Exists(existingUsers, user => user == username))
                        {
                            MessageBox.Show("Username is USED");
                            return;
                        }
                    }

                    sw.Close();

                }

              
                
            }

            CreateFile(path);
            CreateFile(path2);
            CreateFile(path3);
            CreateFile(path4);

            // Putter username ind i username.txt, Password ind i Password.txt, mail ind i mail.txt og Phonenumber ind i phonenumber.txt
            File.AppendAllText(path, username + Environment.NewLine);
            File.AppendAllText(path2, password + Environment.NewLine);
            File.AppendAllText(path3, mail + Environment.NewLine);
            File.AppendAllText(path4, phonenumber + Environment.NewLine);

            MessageBox.Show("YOUR NOW REGISTERED", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
          
            

        }
        private void CreateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { } // Opretter filen og lukker den med det samme
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
