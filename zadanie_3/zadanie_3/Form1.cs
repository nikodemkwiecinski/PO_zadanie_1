using System.IO;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObject = dataGridView1.GetClipboardContent();
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\zadanie3.csv";
            File.WriteAllText(path, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add(column.HeaderText);
                }
            }
            

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTableFromDGV(dataGridView1);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test.xml");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test.xml");
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}