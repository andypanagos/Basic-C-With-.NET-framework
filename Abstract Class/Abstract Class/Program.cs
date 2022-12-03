using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating employee class with first and last name objects inherited from person class.
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.Read();
        }
    }
}
