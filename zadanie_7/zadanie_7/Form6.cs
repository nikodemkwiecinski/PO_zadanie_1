using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace zadanie_7
{
    public partial class Form6 : Form
    {
        Form1 form1;
        public Form6(Form1 from1)
        {
            InitializeComponent();
            this.form1 = from1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.textBox1.Text);
            var index = Helper.books.FindIndex(elem => elem.id == id);
            var item = Helper.books[index];
            if(Helper.books[index].status == "wolna")
            {
                item.status = "zajety";
            }
            else
            {
                item.status = "wolna";
            }

            Helper.books[index] = item;
            form1.dataGridView1.Rows.Clear();
            for (int i = 0; i < Helper.books.Count; i++)
            {
                form1.dataGridView1.Rows.Add(Helper.books[i].id, Helper.books[i].title, Helper.books[i].author, Helper.books[i].status);
            }
            this.Close();
        }
    }
}
