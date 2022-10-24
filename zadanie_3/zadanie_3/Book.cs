using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public static class Book
    {
        public static string title;
        public static string author;
        public static int id;

        public static void clearData()
        {
            Book.author = "";
            Book.title = "";
            Book.id = 0;
        }
    }
}
