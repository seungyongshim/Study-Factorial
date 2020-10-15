using System;
using System.Linq;
using static System.Console;


namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Factorial(15));
            WriteLine(Factorial_Tail(15));
            WriteLine(Factorial_Linq(15));
            // 1,307,674,368,000
        }

        private static decimal Factorial(decimal v) =>
            v == 0 ? 1 : v * Factorial(v - 1);

        static decimal Factorial_Tail(decimal v, decimal sum = 1) =>
            v == 0 ? sum : Factorial_Tail(v - 1, sum * v);

        static decimal Factorial_Linq(int v) =>
            Enumerable.Range(1, v).Aggregate(1m, (a, x) => a * x);
    }
}
