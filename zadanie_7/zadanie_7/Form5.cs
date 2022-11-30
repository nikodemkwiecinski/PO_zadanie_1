using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_7
{
    public partial class Form5 : Form
    {
        Form1 form1;
        public Form5(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.textBox1.Text);
            var item = Helper.users.Single(elem => elem.userId == id);
            Helper.users.Remove(item);
            form1.dataGridView2.Rows.Clear();
            for (int i = 0; i < Helper.users.Count; i++)
            {
                form1.dataGridView2.Rows.Add(Helper.users[i].userId, Helper.users[i].name, Helper.users[i].suername);
            }
            this.Close();
        }
    }
}
