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
        public int Math2(decimal num2)
        {
            int results = Convert.ToInt32(num2);
            int answer2 = results / 5;
            return answer2;

            
        }
        public int Math3(string num1)
        {
            int results = Convert.ToInt32(num1);
            int answer2 = results + 100;
            return answer2;


            return results;
        }
    }
}
