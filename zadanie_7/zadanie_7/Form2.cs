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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Math.Abs((int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - new DateTimeOffset(1970, 1, 1, 1, 1, 1, new TimeSpan()).ToUnixTimeMilliseconds()));
            Helper.books.Add(new Book(id, this.textBox1.Text, this.textBox2.Text, "wolna"));
            form1.dataGridView1.Rows.Clear();
            for (int i = 0; i < Helper.books.Count; i++)
            {
                form1.dataGridView1.Rows.Add(Helper.books[i].id, Helper.books[i].title, Helper.books[i].author, Helper.books[i].status);
            }
            this.Close();
        }
    }
}
