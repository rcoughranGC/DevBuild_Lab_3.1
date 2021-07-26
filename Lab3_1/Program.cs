using System;

namespace Lab3_1
{
    class Program
    {
        static bool KeepGoing()
        {
            while (true) 
            {
                Console.WriteLine("\nWould you like to know about another student? (enter “yes” or “no): ");
                string response = Console.ReadLine();
                if (response.ToLower().StartsWith("y"))
                {
                    return true;
                }
                else if (response.ToLower().StartsWith("n"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }
        }
        
         
        static void Main(string[] args)
        {
            string[] names = { "Jim Jones", "Kim Smith", "John Johnson", "Roger Rogers", "Nicole Nicholson" };
            string[] favFoods = { "BBQ Ribs", "Lobster", "Lasagna", "Filet Mignon", "Tacos" };
            string[] previousTitles = { "Assistant Coach", "Bartender", "Coal Miner", "Delivery Driver", "Realtor" };

            Console.WriteLine("Welcome to our Dev.Build class. Would you like to see a list of students? (y/n); ");  //Option to see list of students
            if (Console.ReadLine().ToLower().StartsWith("y"))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {names[i]}");
                }
            }
            do
            {
                Console.WriteLine("\nWhich student would you like to learn more about?");
                Console.Write("(enter a number 1-5): ");
                int.TryParse(Console.ReadLine(), out int selection);

                //force valid selection
                while (selection <= 0 || selection > 5)  
                {
                    Console.WriteLine("That student does not exist. Please try again");
                    Console.Write("(enter a number 1-5): ");
                    int.TryParse(Console.ReadLine(), out selection);
                }

                Console.WriteLine($"\nWhat you you like to know about {names[selection - 1]}? (enter “favorite food” or “previous title”): ");
                string userChoice = Console.ReadLine();

                if (userChoice.Contains("food") || userChoice.Contains("fav")) 
                {
                    Console.WriteLine($"\n{names[selection-1]}'s favorite food is {favFoods[selection - 1]}.");
                }
                else if (userChoice.Contains("title") || userChoice.ToLower().Contains("previous"))
                {
                    Console.WriteLine($"\n{names[selection - 1]}'s previous title is {previousTitles[selection - 1]}.");
                }
            } while (KeepGoing());
        }
    }
}
