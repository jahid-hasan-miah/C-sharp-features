using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculation
    {
        public int Addition(int x,int y)
        {
            int result = x + y;
            Console.WriteLine("Addition:" + result);
            return result;
        }
        public int multi(int x,int y)
        {
            int result = x * y;
            Console.WriteLine("Multiplication:"+result);
            return result;
        }
        public int Substract(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Subtracttion:"+result);
            return result;
        }
        public int Division(int x, int y)
        {
            int result = x / y;
            Console.WriteLine("Division:"+result);
            return result;
        }
    }
}
