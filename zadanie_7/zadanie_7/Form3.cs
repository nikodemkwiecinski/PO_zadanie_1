﻿using System;
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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.textBox1.Text);
            var item = Helper.books.Single(elem => elem.id == id);
            Helper.books.Remove(item);
            form1.dataGridView1.Rows.Clear();
            for (int i = 0; i < Helper.books.Count; i++)
            {
                form1.dataGridView1.Rows.Add(Helper.books[i].id, Helper.books[i].title, Helper.books[i].author, Helper.books[i].status);
            }
            this.Close();
        }
    }
}
