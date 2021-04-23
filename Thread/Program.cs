using System;
using System.Threading;
using System.IO;
namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var thread1 = new Thread(new ThreadStart(WriteFile));
            var thread2 = new Thread(new ThreadStart(WriteFile));

            thread1.Start();
            thread2.Start();
        }

        void PrintNumbers2()
        {
            for (var i = 0; i < 100; i += 2)
            {
                Console.WriteLine($"Number: {i}");
                Thread.Sleep(500);
            }
        }

        static void PrintNumbers()
        {
            for (var i = 1; i < 100; i += 2)
            {
                Console.WriteLine($"Number: {i}");
                Thread.Sleep(500);
            }
        }

        public static void WriteFile()
        {
            var path = @"H:\Web development\C sharp practice\C-sharp-features\file.txt";
            lock (path)
            {
                File.WriteAllText(path, "Hello");
            }
        }
    }
}
