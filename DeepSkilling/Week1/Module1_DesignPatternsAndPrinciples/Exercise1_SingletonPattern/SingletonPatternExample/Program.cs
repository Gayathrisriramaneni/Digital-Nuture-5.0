using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            if (logger1 == logger2)
            {
                Console.WriteLine("Only one instance of Logger is created.");
            }
            else
            {
                
                Console.WriteLine("Multiple instances of Logger are created.");
            }
        }
    }
}