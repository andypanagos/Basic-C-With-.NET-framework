using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Math
    {
        public int addition(int num1)
        {
            int results = num1 + 50;

            return results;
        }
        public decimal addition(decimal num1)
        {
            decimal results = num1 / 5;

            return results;
        }
        public int addition(string num1)
        {
            int results = Convert.ToInt32(num1) + 100;


            return results;
        }
    }
}
