using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guess = -1;
        int guessesNum = 0;

        while (guess != number)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessesNum ++;

            if (number < guess)
            {
                Console.WriteLine("Lower");
            }

            else if (number > guess)
            {
                Console.WriteLine("Highwer");
            }

            else 
            {
                Console.WriteLine($"Congratulations! You guessed it in {guessesNum} attemps");
            }

        }
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Console.Write("What is your guess? ");
        //int guess = int.Parse(Console.ReadLine());

        //if (guess < magicNumber)
        //{
        //    Console.WriteLine("Higher");
        //}
        //else if (guess > magicNumber)
        //{
        //    Console.WriteLine("Lower");
        //}
        //else
        //{
        //    Console.WriteLine("Congratulations! You guessed it!");
        //}
    }


}