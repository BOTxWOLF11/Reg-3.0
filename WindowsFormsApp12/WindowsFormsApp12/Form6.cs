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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void button1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
        }
    }
}
