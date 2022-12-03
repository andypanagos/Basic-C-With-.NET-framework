using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person
    {
        //inherits sayname method from abstract person class
        public virtual void SayName()
        {
            base.SayName();
        }
    }
}
