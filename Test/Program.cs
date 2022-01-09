using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool CheckNumber(int x)
        {
            if (x > 10)
                return true;
            else
                return false;
        }
    }
}