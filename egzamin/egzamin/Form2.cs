using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form1.currentUser == "admin" || form1.currentUser == "matematyk")
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie posiadasz uprawnień");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.currentUser == "admin" || form1.currentUser == "matematyk")
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie posiadasz uprawnień");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form1.currentUser == "filozof" || form1.currentUser == "admin")
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie posiadasz uprawnień");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (form1.currentUser == "admin")
            {
                Form6 form6 = new Form6(form1);
                form6.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie posiadasz uprawnień");
            }
        }
    }
}
