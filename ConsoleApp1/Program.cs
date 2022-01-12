using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetAlien();
            
            Console.ReadKey();
        }

        static void MeetAlien()
        {
            Random numberGen = new Random();

            string name = "X" + numberGen.Next(30, 150);
            int age = numberGen.Next(2000, 5000);

            Console.WriteLine("Hi, I'm " + name+".");
            Console.WriteLine("I'm " + age + " years old!");
        }

    }
}
