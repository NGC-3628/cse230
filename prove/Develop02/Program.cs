// using System;
// using System.Collections.Generic;
// using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Person p1 = new Person();
//         // p1._firstName = "Laura";
//         // p1._lastName = "Aguirre";
//         // p1._age = 35;

//         // Person p2 = new Person();
//         // p2._firstName = "Isaac";
//         // p2._lastName = "Iturralde";
//         // p2._age = 25;

//         // //Making the list
//         // List<Person> people = new List<Person>();
//         // people.Add(p1);
//         // people.Add(p2);

//         // //foreach(Person p in people)
//         // //{
//         // //    Console.WriteLine(p._age);
//         // //}

//         // SaveToFile(people);
//         List<Person> newPeople = ReadFromFile();
//         foreach (Person p in newPeople)
//         {
//             Console.WriteLine(p._firstName);
//         }
//     }

//     public static void SaveToFile(List<Person>people)
//     {
//         Console.WriteLine("Saving file...");
//         string filename = "people.txt";

//         using(StreamWriter outputFile = new StreamWriter(filename))
//         {
//             foreach(Person p in people)
//             {
//                 outputFile.WriteLine($"{p._firstName}, {p._lastName}, {p._age}");
//             }
//         }
//     }

//     public static List<Person>ReadFromFile()
//     {
//         Console.WriteLine("Reading from the file...");
//         List<Person> people = new List<Person>();
//         string filename = "people.txt";

//         string [] lines = System.IO.File.ReadAllLines(filename);

//         foreach(string line in lines)
//         {
//             string[] parts = line.Split("**");

//             Person newPerson = new Person();
//             newPerson._firstName = parts[0];
//             newPerson._lastName = parts[1];
//             newPerson._age = int.Parse(parts[2]);

//             people.Add(newPerson);
//         }

//         return people; 
//     }
// }


using System;
using System.Collections.Generic;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

class Journal
{
    private List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public void AddEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        // Code to save the journal to the file
        // Implement this based on your preferred file handling method (e.g., StreamWriter, File.WriteAllText, etc.)
    }

    public void LoadFromFile()
    {
        Console.Write("Enter a filename to load the journal: ");
        string filename = Console.ReadLine();

        // Code to load the journal from the file
        // Implement this based on your preferred file handling method (e.g., StreamReader, File.ReadAllText, etc.)

        // Replace the current entries with the loaded entries
        entries = new List<JournalEntry>();
        // Add the loaded entries to the list
        // Example: entries.AddRange(loadedEntries);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.SaveToFile();
                    break;
                case 4:
                    journal.LoadFromFile();
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}


