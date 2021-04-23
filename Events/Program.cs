using System;

namespace Events
{
    class Program
    {
        public delegate void Notify(string address, string message);
        public event Notify Notification;

        static void Main(string[] args)
        {
            var instance = new Program();
            instance.Notification += EmailNotification;
            instance.Notification += SMSNotification;
            instance.Notification += SMSNotification;

            instance.Notification("info@devskill.com", "Hello World");

            //instance.Notification -= EmailNotification;

            instance.Notification("info@devskill.com", "Hello World");
        }

        private static void EmailNotification(string address, string message)
        {
            // sending email 
            Console.WriteLine($"Sending Email to {address} with message: {message}");
        }

        public static void SMSNotification(string mobileNumber, string message)
        {
            Console.WriteLine($"Sending SMS to {mobileNumber} with message: {message}");
        }
    }
}
