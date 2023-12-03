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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string login = textBox1.Text;
                string password = textBox2.Text;
                string confirmPassword = textBox3.Text;

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }
            string userData = login + ";" + password; 
            using (StreamWriter sw = new StreamWriter("userData.txt", true))
            {
                sw.WriteLine(userData);
            }
            if (login == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin registration successful");
            }
            else
            {
                MessageBox.Show("User registration successful");
            }
            this.Close();
        }
    }
}
