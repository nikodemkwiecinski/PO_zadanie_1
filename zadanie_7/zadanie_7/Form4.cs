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
    public partial class Form4 : Form
    {
        Form1 form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Math.Abs((int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - new DateTimeOffset(1970, 1, 1, 1, 1, 1, new TimeSpan()).ToUnixTimeMilliseconds()));
            Helper.users.Add(new User(id, this.textBox1.Text, this.textBox2.Text));
            form1.dataGridView2.Rows.Clear();
            for (int i = 0; i < Helper.users.Count; i++)
            {
                form1.dataGridView2.Rows.Add(Helper.users[i].userId, Helper.users[i].name, Helper.users[i].suername);
            }
            this.Close();
        }
    }
}
