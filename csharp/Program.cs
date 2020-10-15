using System;
using static System.Console;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Factorial(15));
            // 1,307,674,368,000
        }

        private static decimal Factorial(decimal v) =>
            v == 0 ? 1 : Factorial(v - 1) * v;
    }
}
