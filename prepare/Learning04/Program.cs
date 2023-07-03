using System;

class Program
{
    static void Main(string[] args)
    {
                Assignment assig1 = new Assignment("Pedro Puno", "Multiplication");
        Console.WriteLine(assig1.GetSummary());

        // Now create the derived class assignments
        MathAssignment assig2 = new MathAssignment("Joseph Carrick", "Divisions", "7.3", "8-19");
        Console.WriteLine(assig2.GetSummary());
        Console.WriteLine(assig2.GetHomeworkList());

        WritingAssignment assig3 = new WritingAssignment("Benson Bennet", "Italian History", "The Causes of World War V");
        Console.WriteLine(assig3.GetSummary());
        Console.WriteLine(assig3.GetWritingInformation());
        

    }
}