using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_11
{
    public partial class Form2 : Form
    {
        public Form2(Airport airport, bool checked1, bool checked2, bool checked3, bool checked4, bool checked5)
        {
            InitializeComponent();
            string temp = "";
            if (checked1)
            {
                temp += "Kod ICAO: " + airport.ICAOCode + " \n";
            }
            if (checked2)
            {
                temp += "Kod IATA: " + airport.IATACode + " \n";

            }
            if (checked3)
            {
                temp += "Liczba pasażerów: " + airport.NumberOfPassengers + " \n";
            }
            if(checked4)
            {
                temp += "Województwo: " + airport.Voivodeship + " \n";
            }
            if(checked5)
            {
                temp += "Miasto: " + airport.City + " \n";
            }
            label1.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
