using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int sum = 0;
        int prevCheck = 0;
        int prevComboBox = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                sum -= prevCheck;
                this.sum += 20;
                this.prevCheck = 20;
            }
            this.label1.Text = sum.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                sum -= prevCheck;
                this.sum += 100;
                this.prevCheck = 100;
            }
            this.label1.Text = sum.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.prevComboBox != this.comboBox1.SelectedIndex + 1)
            {
                this.sum = this.sum - (this.prevComboBox * 2 * 50) + ((this.comboBox1.SelectedIndex + 1) * 2 * 50);
                this.prevComboBox = this.comboBox1.SelectedIndex + 1;
                this.label1.Text = sum.ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                sum -= prevCheck;
                this.sum += 300;
                this.prevCheck = 300;
            }
            this.label1.Text = sum.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.sum += 50;
            }
            else
            {
                this.sum -= 50;
            }
            this.label1.Text = this.sum.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.sum += 100;
            }
            else
            {
                this.sum -= 100;
            }
            this.label1.Text = this.sum.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.sum += 80;
            }
            else
            {
                this.sum -= 80;
            }
            this.label1.Text = this.sum.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                this.sum += 150;
            }
            else
            {
                this.sum -= 150;
            }
            this.label1.Text = this.sum.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                this.sum += 350;
            }
            else
            {
                this.sum -= 350;
            }
            this.label1.Text = this.sum.ToString();
        }

        private void Form2_Closed(object sender, EventArgs e)
        {
            GlobalSum.form2Flag = true;
            GlobalSum.globalSum2 = this.sum;
        }
    }
}
