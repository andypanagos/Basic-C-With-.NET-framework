using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static bool operator ==(Employee empOne, Employee empTwo)
        {
            if (empOne.ID == empTwo.ID) 
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee empOne, Employee empTwo)
        {
            return !(empOne.ID == empTwo.ID);
        }
        
    }
}
