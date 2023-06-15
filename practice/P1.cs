using System;

namespace first_exercise_basic
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your calculator");

            int a = GetFirstNumber();
            int b = GetSecondNumber();
            int c = GetThirdNumber();

            FiguringOut(a, b, c);
        }

        static int GetFirstNumber()
        {
            Console.Write("Enter a number: ");
            return int.Parse(Console.ReadLine());
        }

        static int GetSecondNumber()
        {
            Console.Write("Enter a number: ");
            return int.Parse(Console.ReadLine());
        }

        static int GetThirdNumber()
        {
            Console.Write("Enter a number: ");
            return int.Parse(Console.ReadLine());
        }

        static void FiguringOut( int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine($"The total number is {sum}");
            Console.ReadLine();
        }
    }
}
