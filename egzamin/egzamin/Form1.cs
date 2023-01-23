namespace egzamin
{
    public partial class Form1 : Form
    {

        string LOGIN = "admin";
        string MATH_LOGIN = "matematyk";
        string PHYLO_LOGIN = "filozof";
        string PASSWORD = "admin";
        public string wrongLoging = "";
        public string currentUser = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((this.textBox1.Text == LOGIN || this.textBox1.Text == MATH_LOGIN || this.textBox1.Text == PHYLO_LOGIN) && this.textBox2.Text == PASSWORD)
            {
                currentUser = this.textBox1.Text;
                Form2 form2 = new Form2(this);
                form2.ShowDialog();
            }
            else
            {
                string msg = "";
                if(this.textBox1.Text != LOGIN || this.textBox1.Text != MATH_LOGIN || this.label1.Text != PHYLO_LOGIN)
                {
                    msg += "Podano b³êdny login \n";
                }
                if(this.textBox2.Text != PASSWORD)
                {
                    msg += "Podano b³êdne has³o";
                }
                wrongLoging = DateTime.Now.ToString();
                MessageBox.Show(msg);
            }

        }
    }
}