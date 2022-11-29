using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    public class Book
    {
        public int id;
        public string title;
        public string author;
        public string status;

        public Book(int id, string title, string author, string status)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.status = status;
        }
    }
}
