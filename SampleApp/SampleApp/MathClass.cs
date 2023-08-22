using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class MathClass
    {
        //Addition Operation
        public int Add(int a, int b)
        {
            return a + b;
        }

        //Subtraction Operation
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        //Multiplication operation
        public int Multiple(int a, int b)
        {
            return a * b;
        }

        //Division Operation
        public int Division(int a, int b)
        {
            if (b == 0)
            {
                return -1;
            }
            return a / b;
        }
    }
}
