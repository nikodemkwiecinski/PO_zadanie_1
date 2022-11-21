using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public class HelperBook
    {
        public string title = "";
        public string author = "";
        public string publisher = "";
        public string city = "";
        public string year = "";
        public string status = "";
        public int id;

        public HelperBook(int id, string title, string author, string publisher, string city, string year, string status)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.city = city;
            this.year = year;
            this.status = status;
        }

        public HelperBook() { }
    }
}
