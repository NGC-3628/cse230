// For exceeding requirments. I stored 3 scriptures in the program. The user can pick one of the scripures in the menu, and the program will run with the selected scripture.
class Program
{
    static void Main(string[] args)
    {
        string MENU = " 1. Moroni 10:5 \n 2. 3 Nephi 3:11 \n 3. Moroni 10: 29-30 \n 4. Doctrine and Covenants 5:1-5 \n Please, choose a scripture to memorize: ";
        Console.WriteLine(MENU);
        Console.WriteLine("Choose one scripture to memorize");
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                string text = "And by the power of the Holy Ghost ye may know the truth of all things";
                Scripture scripture1 = new Scripture(text);
                Reference reference1 = new Reference("Moroni", 10, 5);
                UserInterface(scripture1,reference1);
                break;

            case 2:
                text = "Behold, I am Jesus Christ, whom the prophets testified shall come into the world.";
                Scripture scripture2 = new Scripture(text);
                Reference reference2 = new Reference("3 Nephi", 3, 11);

                UserInterface(scripture2,reference2);
                break;

            case 3:
                text = "And God shall show unto you, that that which I have written is true. And again I would exhort you that ye would come unto Christ, and lay hold upon every good gift, and touch not the evil gift, nor the unclean thing";
                Scripture scripture3 = new Scripture(text);
                Reference reference3 = new Reference("Moroni", 10, 29,30);

                UserInterface(scripture3,reference3);
                break;

            case 4:
                text = "Now behold, a amarvelous work is about to come forth among the children of men. Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day. Therefore, if ye have desires to serve God ye are called to the work; For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul; And afaith, hope, charity and love, with an eye single to the glory of God, qualify him for the work. Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. Ask, and ye shall receive; knock, and it shall be opened unto you. Amen..";
                Scripture scripture4 = new Scripture(text);
                Reference reference4 = new Reference("Doctrine and Covenants", 1,2,3);

                UserInterface(scripture4, reference4);
                break;
        }
    } 
    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInput = "";
        while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }  
}