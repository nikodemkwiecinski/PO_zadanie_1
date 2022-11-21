using System.CodeDom.Compiler;
using System.Data;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

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

        private void button4_Click(object sender, EventArgs e)
        {
           using(var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(typeof(HelperBook[]));
                string result = "";
                serializer.Serialize(stringwriter, Book.list);
                result = stringwriter.ToString();
                string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\test.xml";
                File.WriteAllText(path, result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}