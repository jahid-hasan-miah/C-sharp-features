using System;

namespace FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "my message";
            ProcessText(text, NewPrintingMethod);
        }

        public static void NewPrintingMethod(string text)
        {
            Console.WriteLine($"##--{text}--##");
        }

        static void ProcessText(string text, Action<string> perform)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                perform(text);
            }
        }
    }
}
