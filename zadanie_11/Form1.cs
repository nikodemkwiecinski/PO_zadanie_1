using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace zadanie_11
{
    public class Airport
    {
        public string ICAOCode { get; set; }
        public string IATACode { get; set; }
        public string CityCode { get; set;}
        public string Percent { get; set; }
        public int NumberOfPassengers { get; set; }
        public string Voivodeship { get; set; }
        public string City { get; set; }
    }
    public partial class Form1 : Form
    {
        List<Airport> airports = new List<Airport>();

        public Form1()
        {
            InitializeComponent();
            LoadAirportData();
            DisplayAirports();
        }

        private void LoadAirportData()
        {
 
            string filePath = Path.Combine("C:\\Users\\nikok\\Desktop\\zadanie_11", "Dane-Testowe-1.csv");
            string text = File.ReadAllText(filePath);

            string[] lines = text.Split("\n");
            string[] data = lines.Skip(1).ToArray();

            foreach(string line in data)
            {
                string[] fields = line.Split(",");
                Airport airport = new Airport();
                if (fields.Length > 6)
                {
                    airport.City = fields[0];
                    airport.Voivodeship = fields[1];
                    airport.ICAOCode = fields[2];
                    airport.CityCode = fields[3];
                    airport.IATACode = fields[4];
                    airport.NumberOfPassengers = Int32.Parse(fields[5].Replace(" ", ""));
                    airport.Percent = fields[6];
                    airports.Add(airport);
                }
            }
        }

        private void DisplayAirports()
        {
            listBox1.DataSource = airports;
            listBox1.DisplayMember = "IATACode";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Airport selectedAirport = (Airport)listBox1.SelectedItem;
            if (selectedAirport == null)
            {
                MessageBox.Show("Nie wybrano ¿adnego lotniska.");
                return;
            }
            if(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
            {
                Form2 detailsForm = new Form2(selectedAirport, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Musisz zaznaczyæ minimalnie jedno pole.");
                return;
            }
            
        }
    }
}