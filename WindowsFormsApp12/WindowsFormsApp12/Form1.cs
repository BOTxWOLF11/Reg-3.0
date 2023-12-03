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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string[] lines = File.ReadAllLines("userData.txt");
            

            bool loggedIn = false;

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string fileUsername = parts[0];
                string filePassword = parts[1];

                if (fileUsername == username && filePassword == password)
                {
                    loggedIn = true;
                    if (username == "admin" && password == "admin123")
                    {
                        MessageBox.Show("Admin registration successful");
                        Form4 existingForm = Application.OpenForms.OfType<Form4>().FirstOrDefault();
                        Form4 newForm = new Form4();
                        newForm.Show();
                        if (existingForm != null)
                        {
                            existingForm.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User login successful");
                        Form3 existingForm = Application.OpenForms.OfType<Form3>().FirstOrDefault();
                        Form3 newForm = new Form3();
                        newForm.Show();
                        if (existingForm != null)
                        {
                            existingForm.Close();
                        }
                    }
                    break;
                }
            }

            if (!loggedIn)
            {
                MessageBox.Show("Invalid username or password");
            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
                Form2 existingForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
                Form2 newForm = new Form2();
                newForm.Show();
                if (existingForm != null)
                {
                    existingForm.Close();
                }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
