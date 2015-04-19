using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class User
    {
        private int age;
        private string fname, lname, login;
        readonly DateTime date = DateTime.Now; //Probably i shouldn't use this "readonly" field if i already using get only;
        public User(int age, string fname, string lname, string login)
        {
            this.age = age;
            this.fname = fname;
            this.lname = lname;
            this.login = login;
            Console.WriteLine("Your fname is {0}, last name is {1}, login = {2}, age {3},\n date of registration {4}", fname, lname, login, age, date);
        }
        public DateTime getDate
        {
            get
            {
                return date;
            }
        }

    }

}
