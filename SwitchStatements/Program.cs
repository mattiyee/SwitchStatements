using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var response = Console.ReadLine();

            switch (response)
            {
                case "English":
                    Console.WriteLine("English was one of my least favorite subjects.");
                    break;
                case "Math":
                    Console.WriteLine("Math is one of my favorite subjects. Is there any particular branch you are interested in?");
                    string mathResponse = Console.ReadLine();

                    if (mathResponse == "No")
                    {
                        Console.WriteLine("I see. Fairly interesting.");
                    }
                    else
                    {
                        Console.WriteLine("What is the name of the branch?");
                        string branchName = Console.ReadLine();

                        Console.WriteLine($"I've heard of {branchName} before. Cool!");
                    }
                    break;
                case "Science":
                    Console.WriteLine("There is a large variety of science branches. Which one are you most interested in?");
                    string scienceResponse = Console.ReadLine();

                    Console.WriteLine($"Ah! {scienceResponse} is a very interesting science branch.");
                    break;
                case "History":
                    Console.WriteLine("History is a very broad area. It could range from revolutions to discoveries. What are you most interested in?");
                    string historyResponse = Console.ReadLine();

                    Console.WriteLine("Fairly interesting!");
                    break;
                case "PE":
                    Console.WriteLine("Cool. What kind of sports do you play?");
                    string peResponse = Console.ReadLine();

                    Console.WriteLine($"{peResponse} is a cool sport.");
                    break;
                default:
                    Console.WriteLine("Never heard of that subject before.");
                    break;
            }

                    

        }
    }
}
