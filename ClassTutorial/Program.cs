using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var tqlmath = new TqlMath();

            tqlmath.A = 21;
            tqlmath.B = 30;

            var sum = tqlmath.Sum();
            Console.WriteLine($"The sum of {tqlmath.A} and {tqlmath.B} is {sum}!");
        }
    }
}
