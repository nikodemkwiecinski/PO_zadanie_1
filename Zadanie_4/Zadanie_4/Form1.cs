namespace Zadanie_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap currentBitmap;

        private void changeColor(string colorName)
        {
            Bitmap blackBitmap = new Bitmap(currentBitmap.Width, currentBitmap.Height);
            Color currColor;
            Color newColor;
            if(colorName == "Black")
            {
                newColor = Color.Black;
            }
            else
            {
                newColor = Color.Green;
            }
            Color newSecondColor = Color.White;
            for(int i = 0; i < currentBitmap.Width; i++)
            {
                for(int j=0; j < currentBitmap.Height; j++)
                {
                    currColor = currentBitmap.GetPixel(i,j);
                    if (colorName == "Black")
                    {
                        if (currColor.R == 0 && currColor.G == 0 && currColor.B == 0)
                        {
                            blackBitmap.SetPixel(i, j, newColor);
                        }
                        else
                        {
                            blackBitmap.SetPixel(i, j, newSecondColor);
                        }
                    }
                    else
                    {
                        if (currColor.R < 50 && currColor.G > 50 && currColor.B < 50)
                        {
                            blackBitmap.SetPixel(i, j, newColor);
                        }
                        else
                        {
                            blackBitmap.SetPixel(i, j, newSecondColor);
                        }
                    }
                }
            }
            this.currentBitmap = blackBitmap;
            this.pictureBox1.Image = this.currentBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Otworz zdjecie";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.currentBitmap = new Bitmap(ofd.FileName);
                this.pictureBox1.Image = this.currentBitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeColor("Black");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeColor("Green");
        }
    }
}