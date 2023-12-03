using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 existingForm = Application.OpenForms.OfType<Form5>().FirstOrDefault();
            Form5 newForm = new Form5();
            newForm.Show();
            if (existingForm != null)
            {
                existingForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 existingForm = Application.OpenForms.OfType<Form6>().FirstOrDefault();
            Form6 newForm = new Form6();
            newForm.Show();
            if (existingForm != null)
            {
                existingForm.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 existingForm = Application.OpenForms.OfType<Form7>().FirstOrDefault();
            Form7 newForm = new Form7();
            newForm.Show();
            if (existingForm != null)
            {
                existingForm.Close();
            }
        }
    }
}
