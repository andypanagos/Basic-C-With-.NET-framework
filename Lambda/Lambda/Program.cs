using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List <Employee>();
            {
                EmployeeList.Add(new Employee() { FirstName = "Joe", LastName = "Coffee", ID = 1 });
                EmployeeList.Add(new Employee() { FirstName = "Mac", LastName = "Jones", ID = 2 });
                EmployeeList.Add(new Employee() { FirstName = "Lebron", LastName = "James", ID = 3 });
                EmployeeList.Add(new Employee() { FirstName = "Floyd", LastName = "Mayweather", ID = 4 });
                EmployeeList.Add(new Employee() { FirstName = "Elon", LastName = "Musk", ID = 5 });
                EmployeeList.Add(new Employee() { FirstName = "Joe", LastName = "Rogan", ID = 6 });
                EmployeeList.Add(new Employee() { FirstName = "Alex", LastName = "Smith", ID = 7 });
                EmployeeList.Add(new Employee() { FirstName = "Pat", LastName = "Johnson", ID = 8 });
                EmployeeList.Add(new Employee() { FirstName = "Mike", LastName = "Williams", ID = 9 });
                EmployeeList.Add(new Employee() { FirstName = "Ben", LastName = "Simmonds", ID = 10 });

                Console.WriteLine("Employees named Joe: ");
                Console.ReadLine();

                Console.WriteLine("\n");

                foreach(Employee employee in EmployeeList)
                {
                    if ( employee.FirstName == "Joe")
                    {
                        Console.WriteLine(employee.FirstName + " " + employee.LastName);
                    }
                }
                Console.ReadLine();

                List<Employee> joeList = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

                List<Employee> idList = EmployeeList.Where(x => x.ID > 5).ToList();

                Console.WriteLine("Employees with ID greater than 5");
                Console.ReadLine();

                List<Employee> EmployeeList3 = EmployeeList.Where(x => x.ID > 5).ToList();
                foreach (Employee employee in EmployeeList3)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
                }
                Console.ReadLine();
            }
        }
    }
}
