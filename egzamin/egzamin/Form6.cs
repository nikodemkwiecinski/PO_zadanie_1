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
    public partial class Form6 : Form
    {
        Form1 form1;
        public Form6(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            if (form1.wrongLoging != "")
            {
                this.label4.Text = form1.wrongLoging;
            }else
            {
                this.label4.Text = "Brak danych";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.numericUpDown1.Value > 0 && this.numericUpDown2.Value > 0)
            {
                form1.Height = (int)this.numericUpDown1.Value;
                form1.Width = (int)this.numericUpDown2.Value;
            }
        }
    }
}
