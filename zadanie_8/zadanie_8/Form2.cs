using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_8
{
    public partial class Form2 : Form
    {
        int size = 0;
        string type = "";
        int index = 0;
        List<Button> buttons = new List<Button> ();

        public Form2(string type, string size)
        {
            this.type = type;
            this.size = int.Parse(size.Substring(0,1));
            Random rnd = new Random();
            index = rnd.Next(0, this.size * this.size);
            InitializeComponent();
            this.Shown += createBoard;
        }

        private void click(object sender, EventArgs e)
        {
            var currBtn = sender as Button;
            if (currBtn != null) {
                if (int.Parse(currBtn.Text.Substring(17) == index))
                {
                    currBtn.Text = type;
                }
                else
                {
                    currBtn.Text = "Puste";
                }
            }
        }

        private void createBoard(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button newBtn = new Button();
                    this.Controls.Add(newBtn);
                    newBtn.Text = "Kliknij przycisk " + i + j;
                    newBtn.Location = new Point(i * 60, j * 50);
                    newBtn.Size = new Size(50, 50);
                    newBtn.Click += click;
                    buttons.Add(newBtn);
                }
            }
        }
    }
}
