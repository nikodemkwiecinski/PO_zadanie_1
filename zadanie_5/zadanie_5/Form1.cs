namespace zadanie_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sequence = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filePath = ofd.OpenFile;
                var fileStream = ofd.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    sequence = reader.ReadToEnd();
                    textBox2.Text = sequence;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sequence == "")
            {
                sequence = this.textBox2.Text;
            }
            Dictionary<string, int> result = new Dictionary<string, int>();
            for(int i = 0; i <= sequence.Length-4; i++)
            {
                string currSeq = sequence.Substring(i, 4);
                if (result.ContainsKey(currSeq))
                {
                    result[currSeq]++;
                }
                else
                {
                    result.Add(currSeq, 1);
                }
            }
            listView1.Items.Clear();
            foreach (KeyValuePair<string, int> elem in result)
            {
                listView1.Items.Add(string.Concat(elem.Key, ": ", elem.Value));
            }
            sequence = "";
        }
    }
}