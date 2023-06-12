using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}


namespace SpaceForNumbers
{
class Program1
{
    static void Main(int[] args)
    {
        Console.WriteLine("Give me a number! ");
        int FirstNum = Console.ReadLine();

        Console.WriteLine("Give me another numver! ");
        int SecondNum = Console.ReadLine();

        Console.WriteLine($"The numbers are{FirstNum} and {SecondNum}");
    }
}

}