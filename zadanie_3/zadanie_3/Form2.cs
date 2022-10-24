﻿using System;
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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book.title = title;
            Book.author = author;
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
    }
}
