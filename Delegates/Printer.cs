using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Printer
    {
        public void PrintFormat1(string text)
        {
            Console.WriteLine($"--::{text}::--");
        }

        public void PrintFormat2(string text)
        {
            Console.WriteLine($"##--{text}--##");
        }
    }
}
