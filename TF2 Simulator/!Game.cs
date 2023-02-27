// TF2 Text Based Fighting Sim
using System.ComponentModel.Design;
using System.Data;

namespace TF2_Simulator
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick your class! or type '!Help' to view the class choices and other important info!");

            Console.Write("Class or Command:");
            string UserInput = Console.ReadLine();
            if (UserInput == "!Help") 
            {
                Console.Clear();
                Console.WriteLine("====Help Topics====");
                Console.WriteLine("Select Using Numbers");
                Console.WriteLine("1. Classes");
                Console.WriteLine("2. Weapons");
                Console.WriteLine("3. About the Game");
                Console.WriteLine();
                Console.Write("Input: ");
                string HelpInput = Console.ReadLine();
                
                if (HelpInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("====Classes====");
                    Console.WriteLine("1. Scout");
                    Console.WriteLine("2. Soldier");
                    Console.WriteLine("3. Pyro");
                    Console.WriteLine("4. Demoman");
                    Console.WriteLine("5. Heavy");
                    Console.WriteLine("6. Engineer");
                    Console.WriteLine("7. Sniper");
                    Console.WriteLine("8. Medic");
                    Console.WriteLine("9. Spy");
                    Console.WriteLine();
                    string HelpClasses = Console.ReadLine();
                    if (HelpClasses == "1") 
                    {
                        Console.Clear();
                        Console.WriteLine("====The Scout====");
                        Console.WriteLine("Scout Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Soldier====");
                        Console.WriteLine("Soldier Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Pyro====");
                        Console.WriteLine("Pyro Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Demoman====");
                        Console.WriteLine("Demoman Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "5")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Heavy====");
                        Console.WriteLine("Heavy Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "6")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Engineer====");
                        Console.WriteLine("Engineer Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "7")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Medic====");
                        Console.WriteLine("Medic Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "8")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Sniper====");
                        Console.WriteLine("Sniper Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else if (HelpClasses == "9")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Spy====");
                        Console.WriteLine("Spy Help Selected");
                        Console.WriteLine("Implement Stats and Info Later");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Command Entered");
                    }
                }
                if (HelpInput == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Weapons Help Selected");
                    Console.WriteLine("Implement or Scrap Later");
                }
                if (HelpInput == "3")
                {
                    Console.Clear();
                    Console.WriteLine("====About the Game====");
                    Thread.Sleep(2500);
                    Console.WriteLine("This is a Console based TF2 Turn-Based fighter.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Weapon Stats may be edited to make the game last longer. Otherwise they are accurate to the TF2 Offical Wiki.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Critical Hits are not available in this game to make it last longer.");
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    Console.WriteLine("Implement more info later...");
                }
                else 
                {
                    Console.WriteLine("Invalid Command"); 
                }
            }
        }
    }
}





