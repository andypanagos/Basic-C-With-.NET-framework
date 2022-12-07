using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class user
    {
        string FirstName;
        string LastName;

        public user() : this("jayson", "tatum") { }
        //chaining two constructs
        public user(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

        public void SayName()
        {
            Console.WriteLine("MVP: " + FirstName + " " + LastName);
        }
    }
}
