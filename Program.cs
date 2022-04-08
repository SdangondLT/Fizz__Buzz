using System;

namespace testOfFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsMultipleOfThreeAndFive();
        }

        public static void IsMultipleOfThreeAndFive()
        {
            int numberMain = 100;
            Console.WriteLine("Estos son los numeros: ");

            for (int i = 1; i <= numberMain; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("fizzbuzz");
                else if (i % 5 == 0)
                    Console.WriteLine("buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("fizz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
