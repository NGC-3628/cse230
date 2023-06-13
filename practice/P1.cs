using System; 

namespace first_excersice_basic
{
    class Program
    {
        static void Main (string[] args)
        {
            int a = FirstNumber;
            int b = SecondNumber;
            int c = ThirdNumber;
        }

        static void WelcomeCalculator ()
        {
            Console.WriteLine("Welcome to your calculator");
        }

        static int FirstNumber()
        {
            Console.Write("Enter a number");
            return int.Parse(Console.ReadLine());
        }

        static int SecondNumber()
        {
            Console.Write("Enter a number");
            return int.Parse(Console.ReadLine());
        }

        static int ThirdNumber()
        {
            Console.Write("Enter a number");
            return int.Parse(Console.ReadLine());
        }
        
        static void FiguringOut()
        {
                 int sum = a + b + c;

            Console.WriteLine ($"The total number is {sum}");
            Console.ReadLine ();
        }

    }
}
