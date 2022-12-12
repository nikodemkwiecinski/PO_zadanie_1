using System.Text.RegularExpressions;

namespace zadanie_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string errorMsg = "";
            string onlyLetters = @"^[a-zA-z]+$";
            string onlyLettersError = "Pole mo¿e zawieraæ tylko litery i mieæ co najmniej 5 znaków";
            string onlyLettersAndNumbers = @"^[a-zA-z0-9]+$";
            string onlyLettersNumbersAndDash = @"^[a-zA-z0-9-]+$";
            string onlyLettersAndDash = @"^[a-zA-z-]+$";
            string onlyLettersAndDashError = "Pole mo¿e zawieraæ tylko litery lub znak '-' i mieæ co najmniej 5 znaków";
            string onlyNumbers = @"^[0-9]+$";
            string indexError = "Pole musi zawieraæ dok³adnie 6 znaków i sk³adaæ siê tylko z cyfr";
            string date = @"^\d{2}/\d{2}/\d{4}$";
            string dateError = "Pole musi byæ w formacie DD/MM/YYYY";
            if (this.comboBox1.Text.Length < 1)
            {
                isError = true;
                errorMsg = "Musisz wybraæ kierunek";
            }
            else if (this.textBox3.Text.Length > 5 && Regex.IsMatch(this.textBox3.Text, onlyLetters))
            {
                isError = true;
                errorMsg = onlyLettersError;
            }
            else if (this.textBox4.Text.Length > 5 && Regex.IsMatch(this.textBox4.Text, onlyLetters))
            {
                isError = true;
                errorMsg = onlyLettersError;
            }
            else if (this.comboBox2.Text.Length < 1)
            {
                isError = true;
                errorMsg = "Musisz wybraæ forme studiów";
            }
            else if (this.comboBox3.Text.Length < 1)
            {
                isError = true;
                errorMsg = "Musisz poziom studiów";
            }
            else if (this.textBox7.Text.Length > 5 && Regex.IsMatch(this.textBox7.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg = onlyLettersAndDashError;
            }
            else if (this.textBox8.Text.Length != 6 && Regex.IsMatch(this.textBox8.Text, onlyNumbers))
            {
                isError = true;
                errorMsg = indexError;
            }
            else if(Regex.IsMatch(this.textBox9.Text, date))
            {
                isError = true;
                errorMsg = dateError;
            }
            else if (this.textBox10.Text.Length > 5 && Regex.IsMatch(this.textBox10.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg = onlyLettersAndDashError;
            }
            else if (this.textBox11.Text.Length != 6 && Regex.IsMatch(this.textBox11.Text, onlyNumbers))
            {
                isError = true;
                errorMsg = indexError;
            }
            else if (Regex.IsMatch(this.textBox12.Text, date))
            {
                isError = true;
                errorMsg = dateError;
            }
            else if (this.textBox13.Text.Length > 5 && Regex.IsMatch(this.textBox13.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg = onlyLettersAndDashError;
            }
            else if (this.textBox14.Text.Length != 6 && Regex.IsMatch(this.textBox14.Text, onlyNumbers))
            {
                isError = true;
                errorMsg = indexError;
            }
            else if (Regex.IsMatch(this.textBox15.Text, date))
            {
                isError = true;
                errorMsg = dateError;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}