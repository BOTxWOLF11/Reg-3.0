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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\BOTxWOLF\source\repos\WindowsFormsApp12\WindowsFormsApp12\bin\Debug\company_data.txt";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите содержимое для сохранения.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine(textBox1.Text);
                    }

                    MessageBox.Show($"Содержимое успешно сохранено в файл {filePath}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\BOTxWOLF\source\repos\WindowsFormsApp12\WindowsFormsApp12\bin\Debug\company_data.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
            string filename = path;
            string fileText = File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт!");
        }
    }
}
