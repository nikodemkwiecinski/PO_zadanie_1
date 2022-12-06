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
        int index2 = 0;
        bool displayed = false;
        List<Button> buttons = new List<Button> ();
        private System.Windows.Forms.Timer tmr;

        public Form2(string type, string size)
        {
            this.type = type;
            this.size = int.Parse(size.Substring(0,1));
            Random rnd = new Random();
            index = rnd.Next(0, this.size * this.size);
            index2 = rnd.Next(0, this.size * this.size);
            while(index == index2)
            {
                index2 = rnd.Next(0, this.size * this.size) - 1;
            }
            InitializeComponent();
            this.Shown += createBoard;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                if (!this.displayed)
                {
                    Form3 form3 = new Form3("Przegrales");
                    form3.Show();
                    this.Close();
                    tmr.Stop();
                }
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
            tmr.Start();
        }

        private void click(object sender, EventArgs e)
        {
            var currBtn = sender as Button;
            if (currBtn != null && currBtn.Text != "Puste" && currBtn.Text != "Krokodyl") {
                if (int.Parse(currBtn.Text.Substring(17)) == index)
                {
                    currBtn.Text = type;
                    Form3 form3 = new Form3("Wygrales");
                    form3.Show();
                    displayed = true;
                    this.Close();
                }
                else if(int.Parse(currBtn.Text.Substring(17)) == index2)
                {
                    currBtn.Text = "Krokodyl";
                    Random rnd = new Random();
                    int chance = rnd.Next(0, 2);
                    if(chance == 0)
                    {
                        Form3 form3 = new Form3("Przegrales");
                        form3.Show();
                        displayed = true;
                        this.Close();
                    }
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
                    newBtn.Text = "Kliknij przycisk " + ((i*size) + j);
                    newBtn.Location = new Point(i * 100, j * 100);
                    newBtn.Size = new Size(100, 100);
                    newBtn.Click += click;
                    buttons.Add(newBtn);
                }
            }
            this.ClientSize = new System.Drawing.Size(size*100, size * 100);
        }
    }
}
