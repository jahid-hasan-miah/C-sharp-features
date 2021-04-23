using System;

namespace Delegates
{
    class Program
    {
        delegate void Perform(string text);
        static void Main(string[] args)
        {
            var printer = new Printer();
            var logic1 = new Perform(printer.PrintFormat1);
            var logic2 = new Perform(printer.PrintFormat2);
            var logic3 = logic1 + logic2;
            var text = "my message";
            ProcessText(text, logic3);
        }

        public static void PritingMethod(string textToPrint)
        {
            Console.WriteLine($"--::{textToPrint}::--");
        }

        public static void NewPrintingMethod(string text)
        {
            Console.WriteLine($"##--{text}--##");
        }

        static void ProcessText(string text, Perform perform)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                perform(text);
            }
        }
    }
}
