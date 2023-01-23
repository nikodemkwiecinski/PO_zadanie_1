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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label4.Text = Math.Sqrt((double)this.numericUpDown1.Value).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label4.Text = Math.Pow((double)this.numericUpDown1.Value, 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value != null)
            {
                this.label4.Text = Math.Pow((double)this.numericUpDown1.Value, (double)this.numericUpDown3.Value).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.numericUpDown1.Value >= -1 && this.numericUpDown1.Value <= 1)
            {
                this.label4.Text = Math.Sin((double)this.numericUpDown1.Value).ToString();
            }
            else
            {
                MessageBox.Show("Podana liczba nie jest zakresu <-1;1>");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.numericUpDown1.Value >= -1 && this.numericUpDown1.Value <= 1)
            {
                this.label4.Text = Math.Cos((double)this.numericUpDown1.Value).ToString();
            }else
            {
                MessageBox.Show("Podana liczba nie jest z zakresu <-1:1>");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label4.Text = Math.Tan((double)this.numericUpDown1.Value).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label4.Text = Math.Tan(1/(double)this.numericUpDown1.Value).ToString();
        }
    }
}
