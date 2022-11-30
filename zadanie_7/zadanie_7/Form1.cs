using System.Data;

namespace zadanie_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTableFromDGV(dataGridView2);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test.xml");
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTableFromDGV(dataGridView1);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test2.xml");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test2.xml");
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
        }
    }
}