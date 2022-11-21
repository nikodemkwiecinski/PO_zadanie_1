using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_3
{
    public partial class Form2 : Form
    {
        private string title;
        private string author;
        private string publisher;
        private string city;
        private string year;
        private string status;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book.title = title;
            Book.author = author;
            Book.publisher = publisher;
            Book.city = city;
            Book.year = year;
            Book.status = status;
            Book.id = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - new DateTimeOffset(1970,1,1,1,1,1,new TimeSpan()).ToUnixTimeMilliseconds());
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            author = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            title = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            publisher = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            city = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            year = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            status = textBox6.Text;
        }
    }
}
