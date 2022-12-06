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
            int answer = num1 + 50;

            return answer;
        }
        public int Math1(double num1)
        {
            int results = Convert.ToInt32(num1);
            int answer = results / 5;
            return answer;

            
        }
        public int Math1(string num1)
        {
            int results = Convert.ToInt32(num1);
            int answer = results + 100;
            return answer;


            
        }
    }
}
