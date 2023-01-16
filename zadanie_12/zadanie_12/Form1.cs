namespace zadanie_12
{
    public partial class Form1 : Form
    {

        public class Dice
        {
            public int result = 0;
            public int size = 0;
            Color color;
            public Dice(int size)
            {
                this.size = size;
                Random random = new Random();
                result = random.Next(size);
            }

        }

        public Dictionary<int, Color> colors = new Dictionary<int, Color>()
        {
            {2, Color.Blue},
            {4, Color.Green},
            {6, Color.Red },
            {8, Color.Orange },
            {10, Color.Purple },
            {12, Color.Yellow },
            {20, Color.Silver },
            {100, Color.Moccasin }
        };

        public List<Dice> dices = new List<Dice>();
        public Form1()
        {
            InitializeComponent();
        }

        public void pushValuesTOList(int numberOfDices, int diceSize)
        {
            for(int i = 0; i < numberOfDices; i++)
            {
                dices.Add(new Dice(diceSize));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            pushValuesTOList((int)numericUpDown1.Value, 2);
            pushValuesTOList((int)numericUpDown2.Value, 4);
            pushValuesTOList((int)numericUpDown3.Value, 6);
            pushValuesTOList((int)numericUpDown4.Value, 8);
            pushValuesTOList((int)numericUpDown5.Value, 10);
            pushValuesTOList((int)numericUpDown6.Value, 12);
            pushValuesTOList((int)numericUpDown7.Value, 20);
            pushValuesTOList((int)numericUpDown8.Value, 100);
            for(int i = 0; i < dices.Count; i+=8)
            {
                var row = new DataGridViewRow();
                for(int j = 0; j < 8; j++)
                {
                    if(dices.Count > i + j)
                    {
                        var cell = new DataGridViewTextBoxCell();
                        cell.Value = dices[i + j].result;
                        cell.Style.BackColor = colors[dices[i+j].size];
                        row.Cells.Add(cell);
                    }
                }
                dataGridView2.Rows.Add(row);
            }
        }
    }
}