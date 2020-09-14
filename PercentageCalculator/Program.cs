using System;

namespace PercentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int UserScore;
            double Result;

            Console.WriteLine("What's the maximum score?");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What's your score?");
            UserScore = Int32.Parse(Console.ReadLine());
            Result = (UserScore * 100) / Maximum;

            //Console.WriteLine($"You scored {Result}%.");

            if (Result >= 90)
            {
                Console.WriteLine($"You scored {Result}%. Your grade is 5.");
            }
            else if (Result >= 80)
            {
                Console.WriteLine($"You scored {Result}%. Your grade is 4.");
            }else if (Result >= 61)
            {
                Console.WriteLine($"You scored {Result}%. Your grade is 3.");
            }else
            {
                Console.WriteLine($"You scored {Result}%. Your grade is 2.");
            }
        }
    }
}
