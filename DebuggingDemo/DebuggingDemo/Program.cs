using System;

namespace DebuggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int j=int.Parse(Console.ReadLine());
            foo (i, j) ;
            Console.WriteLine("Debugging over");
        }
        public static void foo(int x, int y)
        {
            int t = 100;
            for(int i=x;i<=y;i++)
            {
                Console.WriteLine("India");
                t = t + 34;
            }
        }
    }
}
