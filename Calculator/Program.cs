using System;

namespace Calculator
{
    class Program
    {
        public delegate int clac(int a, int b);
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            clac cal1 = cal.Addition;
            clac cal2 = cal.Division;
            clac cal3 = cal.multi;
            clac cal4 = cal.Substract;
            clac calculate = cal1 + cal2 + cal3 + cal4;

            runcalculation(calculate);
            
        }

        private static int runcalculation(clac Clac)
        {
            int r = Clac.Invoke(40, 5);
            return r;
        }
    }
}
