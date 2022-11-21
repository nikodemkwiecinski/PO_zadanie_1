using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public static class Book
    {
        public static string title = "";
        public static string author = "";
        public static string publisher = "";
        public static string city = "";
        public static string year = "";
        public static string status = "";
        public static int id;
        public static List<HelperBook> list = new List<HelperBook>();

        public static void clearData()
        {
            list.Append(new HelperBook(id, title, author, publisher, city, year, status));
            Book.author = "";
            Book.title = "";
            Book.id = 0;
            Book.publisher = "";
            Book.city = "";
            Book.year = "";
            Book.status = "";
        }
    }
}
