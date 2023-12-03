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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string companyName = textBox1.Text;
            string companyAddress = textBox4.Text;
            string Date = dateTimePicker1.Text;
            string companySUMM = textBox2.Text;



            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyAddress) || string.IsNullOrEmpty(companySUMM))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }


            string companyData = $"Название проекта: {companyName}\r\nАдрес создания проекта: {companyAddress}\r\nДата Создания: {Date}\r\nСумма проекта: {companySUMM}$\r\n ";

            try
            {
                string filePath = "company_data.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(companyData);
                }

                MessageBox.Show("Компания успешно зарегистрирована.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации проекта: {ex.Message}");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
