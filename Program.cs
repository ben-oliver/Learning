using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string command = "";

            while (command != "exit")
            {
                command = Console.ReadLine();
            }
        }
    }
}