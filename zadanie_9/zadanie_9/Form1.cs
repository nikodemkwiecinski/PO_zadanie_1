using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace zadanie_9
{

    [XmlRoot("form")]
    public class FormData
    {
        [XmlElement("Kierunek")]
        public string kierunek { get; set; }

        [XmlElement("Studia_W_Zakresie")]
        public string studiaWZakresie { get; set; }

        [XmlElement("Profil_Studiow")]
        public string profilStudiow { get; set; }

        [XmlElement("Forma_Studiow")]
        public string formaStudiow { get; set; }

        [XmlElement("Poziom_Studiow")]
        public string poziomStudiow { get; set; }

        [XmlElement("Student_1_Imie")]
        public string student1Name { get; set; }

        [XmlElement("Student_1_Index")]
        public string student1Index { get; set; }

        [XmlElement("Student_1_Data")]
        public string student1Data { get; set; }
        [XmlElement("Student_2_Imie")]
        public string student2Name { get; set; }

        [XmlElement("Student_2_Index")]
        public string student2Index { get; set; }

        [XmlElement("Student_2_Data")]
        public string student2Data { get; set; }
        [XmlElement("Student_3_Imie")]
        public string student3Name { get; set; }

        [XmlElement("Student_3_Index")]
        public string student3Index { get; set; }

        [XmlElement("Student_3_Data")]
        public string student3Data { get; set; }
        
        [XmlElement("Tytul")]
        public string title { get; set; }

        [XmlElement("Tytul_Eng")]
        public string titleEng { get; set; }

        [XmlElement("Dane_wejsciowe")]
        public string daneWejsciowe { get; set; }
        [XmlElement("Zakres_Pracy")]
        public string zakresPracy { get; set; }

        [XmlElement("Termin_oddania")]
        public string terminOddania { get; set; }

        [XmlElement("Promotor")]
        public string promotor { get; set; }

        [XmlElement("Jednostka_Organizacyjna")]
        public string jednostka { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isError = false;
            List<string> errorMsg = new List<string>();
            string onlyLetters = @"^[a-zA-z]+$";
            string onlyLettersError = "Pole mo¿e zawieraæ tylko litery, musi mieæ co najmniej 5 i maksymalnie 255 znaków";
            string onlyLettersAndDash = @"^[a-zA-z- ]+$";
            string onlyLettersAndDashError = "Pole mo¿e zawieraæ tylko litery lub znak '-', musi mieæ co najmniej 5 znaków i maksymalnie 255 znaków";
            string onlyNumbers = @"^[0-9]+$";
            string indexError = "Pole musi zawieraæ dok³adnie 6 znaków i sk³adaæ siê tylko z cyfr";
            string date = @"^\d{2}/\d{2}/\d{4}$";
            string dateError = "Pole musi byæ w formacie DD/MM/YYYY";
            if (this.comboBox1.Text.Length < 1)
            {
                isError = true;
                errorMsg.Add("Musisz wybraæ kierunek" + " Select 1");
            }
            if (this.textBox3.Text.Length < 5 || this.textBox3.Text.Length > 255 || !Regex.IsMatch(this.textBox3.Text, onlyLetters))
            {
                isError = true;
                errorMsg.Add(onlyLettersError + " Input3");
            }
            if (this.textBox4.Text.Length < 5 || this.textBox4.Text.Length > 255 || !Regex.IsMatch(this.textBox4.Text, onlyLetters))
            {
                isError = true;
                errorMsg.Add(onlyLettersError + " Input 4");
            }
            if (this.comboBox2.Text.Length < 1)
            {
                isError = true;
                errorMsg.Add("Musisz wybraæ forme studiów" + " Select 2");
            }
            if (this.comboBox3.Text.Length < 1)
            {
                isError = true;
                errorMsg.Add("Musisz poziom studiów" + " Select 3");
            }
            if (this.textBox7.Text.Length < 5 || this.textBox7.Text.Length > 255 || !Regex.IsMatch(this.textBox7.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 7");
            }
            if (this.textBox8.Text.Length != 6 && !Regex.IsMatch(this.textBox8.Text, onlyNumbers))
            {
                isError = true;
                errorMsg.Add(indexError + " Input 8");
            }
            if(!Regex.IsMatch(this.textBox9.Text, date))
            {
                isError = true;
                errorMsg.Add(dateError + " Input 9");
            }
            if (this.textBox10.Text.Length < 5 || this.textBox10.Text.Length > 255 || !Regex.IsMatch(this.textBox10.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 10");
            }
            if (this.textBox11.Text.Length != 6 && !Regex.IsMatch(this.textBox11.Text, onlyNumbers))
            {
                isError = true;
                errorMsg.Add(indexError + " Input 11");
            }
            if (!Regex.IsMatch(this.textBox12.Text, date))
            {
                isError = true;
                errorMsg.Add(dateError + " Input 12");
            }
            if (this.textBox13.Text.Length < 5 || this.textBox13.Text.Length > 255 || !Regex.IsMatch(this.textBox13.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 13");
            }
            if (this.textBox14.Text.Length != 6 && !Regex.IsMatch(this.textBox14.Text, onlyNumbers))
            {
                isError = true;
                errorMsg.Add(indexError + " Input 14");
            }
            if (!Regex.IsMatch(this.textBox15.Text, date))
            {
                isError = true;
                errorMsg.Add(dateError + " Input 15");
            }
            if (this.textBox16.Text.Length < 5 || this.textBox16.Text.Length > 255 || !Regex.IsMatch(this.textBox16.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 16");
            }
            if (this.textBox17.Text.Length < 5 || this.textBox17.Text.Length > 255 || !Regex.IsMatch(this.textBox17.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 17");
            }
            if (this.textBox18.Text.Length < 5 || this.textBox18.Text.Length > 255 || !Regex.IsMatch(this.textBox18.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 18");
            }
            if (this.textBox19.Text.Length < 5 || this.textBox19.Text.Length > 255 || !Regex.IsMatch(this.textBox19.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 19");
            }
            if (!Regex.IsMatch(this.textBox20.Text, date))
            {
                isError = true;
                errorMsg.Add(dateError + " Input 20");
            }
            if (this.textBox21.Text.Length < 5 || this.textBox21.Text.Length > 255 || !Regex.IsMatch(this.textBox21.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 21");
            }
            if (this.textBox22.Text.Length < 5 || this.textBox22.Text.Length > 255 || !Regex.IsMatch(this.textBox22.Text, onlyLettersAndDash))
            {
                isError = true;
                errorMsg.Add(onlyLettersAndDashError + " Input 22");
            }

            if (isError)
            {
                string temp = string.Join(Environment.NewLine, errorMsg.ToArray());
                errorMsg.Clear();
                MessageBox.Show(temp);
            }
            else
            {
                FormData formData = new FormData
                {
                    kierunek = this.comboBox1.Text,
                    studiaWZakresie = this.textBox3.Text,
                    profilStudiow = this.textBox4.Text,
                    formaStudiow = this.comboBox2.Text,
                    poziomStudiow = this.comboBox3.Text,
                    student1Name = this.textBox7.Text,
                    student1Index = this.textBox8.Text,
                    student1Data = this.textBox9.Text,
                    student2Name = this.textBox10.Text,
                    student2Index = this.textBox11.Text,
                    student2Data = this.textBox12.Text,
                    student3Name = this.textBox13.Text,
                    student3Index = this.textBox14.Text,
                    student3Data = this.textBox15.Text,
                    title = this.textBox16.Text,
                    titleEng = this.textBox17.Text,
                    daneWejsciowe = this.textBox18.Text,
                    zakresPracy = this.textBox19.Text,
                    terminOddania = this.textBox20.Text,
                    promotor = this.textBox21.Text,
                    jednostka = this.textBox22.Text
                };

                XmlSerializer serializer = new XmlSerializer(typeof(FormData));
                using (TextWriter writer = new StreamWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\formularz.xml"))
                {
                    serializer.Serialize(writer, formData);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(FormData));
            using (FileStream fs = new FileStream(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\formularz.xml", FileMode.Open))
            {
                FormData formData = (FormData)xmlSerializer.Deserialize(fs);
                this.comboBox1.Text = formData.kierunek;
                this.textBox3.Text = formData.studiaWZakresie;
                this.textBox4.Text = formData.profilStudiow;
                this.comboBox2.Text = formData.formaStudiow;
                this.comboBox3.Text = formData.poziomStudiow;
                this.textBox7.Text = formData.student1Name;
                this.textBox8.Text = formData.student1Index;
                this.textBox9.Text = formData.student1Data;
                this.textBox10.Text = formData.student2Name;
                this.textBox11.Text = formData.student2Index;
                this.textBox12.Text = formData.student2Data;
                this.textBox13.Text = formData.student3Name;
                this.textBox14.Text = formData.student3Index;
                this.textBox15.Text = formData.student3Data;
                this.textBox16.Text = formData.title;
                this.textBox17.Text = formData.titleEng;
                this.textBox18.Text = formData.daneWejsciowe;
                this.textBox19.Text = formData.zakresPracy;
                this.textBox20.Text = formData.terminOddania;
                this.textBox21.Text = formData.promotor;
                this.textBox22.Text = formData.jednostka;
            }
        }
    }
}