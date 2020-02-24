using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = "Hello Extension Methods";
            Console.WriteLine("Word Count: " + s.WordCount());
            Console.WriteLine("Char Count:" + s.CharCount());
        }
    }
}
