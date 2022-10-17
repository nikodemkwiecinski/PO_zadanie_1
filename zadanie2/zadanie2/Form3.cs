using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int prevCombo1Index = 0;
        int prevCombo2Index = 0;
        int sum = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.prevCombo1Index != this.comboBox1.SelectedIndex + 1)
            {
                this.sum = this.sum - (this.prevCombo1Index * 2 * 50) + ((this.comboBox1.SelectedIndex + 1) * 2 * 50);
                this.prevCombo1Index = this.comboBox1.SelectedIndex + 1;
                this.label1.Text = sum.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.prevCombo2Index != this.comboBox2.SelectedIndex + 1)
            {
                this.sum = this.sum - (this.prevCombo2Index * 2 * 75) + ((this.comboBox2.SelectedIndex + 1) * 2 * 75);
                this.prevCombo2Index = this.comboBox2.SelectedIndex + 1;
                this.label1.Text = sum.ToString();
            }
        }

        private void Form3_Closed(object sender, EventArgs e)
        {
            GlobalSum.form3Flag = true;
            GlobalSum.globalSum3 = this.sum; 
        }
    }
}
