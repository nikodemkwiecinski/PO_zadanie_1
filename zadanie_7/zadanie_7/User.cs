using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    public class User
    {
        public int userId;
        public string name;
        public string suername;

        public User(int userId, string name, string suername)
        {
            this.userId = userId;
            this.name = name;
            this.suername = suername;
        }
    }
}
