using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Math
    {
        public int Math1(int num1)
        {
            int results = num1 + 50;

            return results;
        }
        public decimal Math2(decimal num1)
        {
            decimal results = num1 / 5;

            return results;
        }
        public int Math3(string num1)
        {
            int results = Convert.ToInt32(num1) + 100;


            return results;
        }
    }
}
