using System;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time(23, 42, 15);
            t.AddSeconds(4450);
            Console.WriteLine(t);
        }
    }
}
