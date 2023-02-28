// TF2 Text Based Fighting Sim
using System.ComponentModel.Design;
using System.Data;
using System.Xml.Schema;

namespace TF2_Simulator
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick your class! or type '!Help' to view the class choices and other important info!");
            Console.WriteLine();
            Console.WriteLine("====Available Classes====");
            Console.WriteLine("1. Scout");
            Console.WriteLine("2. Soldier");
            Console.WriteLine("3. Pyro");
            Console.WriteLine("4. Demoman");
            Console.WriteLine("5. Heavy");
            Console.WriteLine("6. Engineer");
            Console.WriteLine("7. Medic");
            Console.WriteLine("8. Sniper");
            Console.WriteLine("9. Spy");
            Console.WriteLine();
            Console.Write("Choose a Class, or type a Command: ");
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
                        Console.WriteLine("Class Name: Scout [ID: 1] \r\n        HP: 125\r\n        --Weapons Used:\r\n        -Primary: Scattergun\r\n         Damage: 4-10 [x10]\r\n         Ammo: 6/32\r\n         Reload: 1-6 Shells per Turn\r\n         Rate of Fire: 1 Shell per Turn\r\n        ---Secondary: Pistol\r\n         Damage: 8-12\r\n         Ammo: 12/36\r\n         Reload: Full Mag [12] in 1 Turn\r\n         Rate of Fire: 3-6 bullets.\r\n        ---Melee: Bat\r\n         Damage: 20-35\r\n         Rate of Fire: 1 with a 20% chance for a second hit per Turn.\r\n        --Passive Stats:\r\n          - 2% Chance to get a Second Turn...?");
                    }
                    else if (HelpClasses == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("====The Soldier====");
                        Console.WriteLine("Class Name: Soldier [ID:2]  \r\n        HP: 200\r\n        --Weapons Used: \r\n        -Primary: Rocket Launcher\r\n         Damage: 36-50 [20% Chance to Deal 10-35 Self-Damage]\r\n         Ammo: 4/20\r\n         Reload: 1-4 Per Turn \r\n         Rate of Fire: 1 Per Turn\r\n        -Secondary: Shotgun\r\n         Damage: 4-6 [x10]\r\n         Ammo: 6/32\r\n         Rate of Fire: 1 Shot per Turn. may hit 1-10 pellets [4-60 HP]\r\n         Reload: 1-3 Shells per Turn\r\n        -Melee: Market Gardener\r\n         Damage: 30-65\r\n         Rate of Fire: 1 Hit Per Turn \r\n         Special: Deal 25-30 Self Damage, and recieve a 10% Chance to deal 195 Damage to the Enemy with a Market Garden\r\n        --Passive Stats:\r\n          - None");
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
            }
            if (UserInput == "1")
            {
                Console.Clear();
                Console.WriteLine("Scout Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "2")
            {
                Console.Clear();
                Console.WriteLine("Soldier Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "3")
            {
                Console.Clear();
                Console.WriteLine("Pyro Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "4")
            {
                Console.Clear();
                Console.WriteLine("Demoman Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "5")
            {
                Console.Clear();
                Console.WriteLine("Heavy Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "6")
            {
                Console.Clear();
                Console.WriteLine("Engineer Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "7")
            {
                Console.Clear();
                Console.WriteLine("Medic Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "8")
            {
                Console.Clear();
                Console.WriteLine("Sniper Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "9")
            {
                Console.Clear();
                Console.WriteLine("Spy Selected");
                Console.WriteLine("Implement Later");
            }
            if (UserInput == "Cheats") 
            {
                Console.Clear();
                Console.WriteLine("====Cheats & Secrets====");
                Console.WriteLine("Take a Screenshot or Take Notes of this Screen");
                Console.WriteLine("-- Damage");
                Console.WriteLine("-- CheckHP");
                Console.WriteLine("-- EndTest");
                Console.WriteLine("-- HeavyBattleTest");
                Console.WriteLine("-- Weapon Switch Test");
                Console.WriteLine("-- SpecialTest");
            }
            if (UserInput == "no")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Why not?");
                Thread.Sleep(10000);
            }
            if (UserInput == "Damage")
            {
                var randomdamage = new Random();

                int BaseDamage = randomdamage.Next(6, 13); // creates a number between 6 & 12
                int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implement random damage per bullet later.)
                Console.WriteLine($"{BaseDamage} Base Damage Dealt");
                Console.WriteLine($"{BulletsFired} Damage Muliplier (Bullets Fired/Hit) ");
                Console.WriteLine($"{BaseDamage * BulletsFired} Total Damage");
            }
            if (UserInput == "CheckHP")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Heavy's HP is: {Heavy.HeavyHealth()}");
                Console.ResetColor();
                Console.Write("Type 'Next' to Continue & Roll 1 Attack ");
                string userconfirm = Console.ReadLine();
                if (userconfirm == "Next")
                {
                    var randomdamage = new Random();

                    int TotalDamage;
                    int BaseDamage = randomdamage.Next(6, 13); // creates a number between 6 & 12
                    int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implement random damage per bullet later.)
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Debug: {BaseDamage} Base Damage Dealt");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Debug: {BulletsFired} Damage Muliplier (Bullets Fired/Hit) ");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Debug: {TotalDamage = BaseDamage * BulletsFired} Total Damage");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Taken {TotalDamage} Damage from Enemy!");
                    Console.ResetColor();
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Heavy's Health: {Heavy.HeavyHealth() - TotalDamage}");
                    Console.ResetColor();
                    //Console Color helped by Scott
                }
            }
            if (UserInput == "EndTest")
            {
                Console.Write("Set Player HP: ");
                string PlayerHP = Console.ReadLine();
                Console.Write("Set Enemy HP: ");
                string EnemyHP = Console.ReadLine();
                if (int.TryParse(PlayerHP, out int PlayerHPint))
                {
                    if (int.TryParse(EnemyHP, out int EnemyHPint))
                    {

                        Console.Clear();
                        while (PlayerHPint >= 0 && EnemyHPint >= 0)
                        {
                            EnemyHPint--;
                            if (EnemyHPint == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("The Enemy's HP Reached 0! You Won!");
                                Console.ResetColor();
                                break;
                            }
                            PlayerHPint--;
                            if (PlayerHPint == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your HP Reached 0! You Lost the Battle!");
                                Console.ResetColor();
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Enemy took 1 damage! Their HP is now {EnemyHPint}");
                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"You took 1 damage! Your HP is now {PlayerHPint}");
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            if (UserInput == "HeavyBattleTest")
            {
                Console.Write("Type 'Start' to Start!: ");
                string StartConfirm = Console.ReadLine();
                int PlayerHP = 300;
                int EnemyHP = 300;
                if (StartConfirm == "Start")
                {
                    Console.Clear();
                    while (PlayerHP >= 0 && EnemyHP >= 0)
                    {
                        var randomdamage = new Random();
                        int TotalDamage;
                        int BaseDamage = randomdamage.Next(6, 13); // creates a number between 6 & 12
                        int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implement random damage per bullet later.)
                      //Console.WriteLine($"{BaseDamage} Base Damage Dealt");
                      //Console.WriteLine($"{BulletsFired} Damage Muliplier (Bullets Fired/Hit) ");
                      //Console.WriteLine($"{TotalDamage = BaseDamage * BulletsFired} Total Damage");
                        TotalDamage = BaseDamage * BulletsFired;
                      //Console.WriteLine(TotalDamage);
                      //Console.WriteLine(EnemyHP = EnemyHP - TotalDamage);
                        EnemyHP = EnemyHP - TotalDamage;
                        Console.WriteLine();
                        if (EnemyHP == 0)
                        {
                          //Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The Enemy's HP Reached 0! You Won!");
                          //Console.ResetColor();
                            break;
                        }
                        if (PlayerHP == 0)
                        {
                            //Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your HP Reached 0! You Lost the Battle!");
                            //Console.ResetColor();
                            break;
                        }
                        //Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Enemy took {TotalDamage} damage! Their HP is now {EnemyHP}");
                        Thread.Sleep(1000);

                        BaseDamage = randomdamage.Next(6, 13); // creates a number between 6 & 12
                        BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implement random damage per bullet later.)
                      //Console.WriteLine($"{BaseDamage} Base Damage Dealt");
                      //Console.WriteLine($"{BulletsFired} Damage Muliplier (Bullets Fired/Hit) ");
                      //Console.WriteLine($"{TotalDamage = BaseDamage * BulletsFired} Total Damage");
                        TotalDamage = BaseDamage * BulletsFired;
                      //Console.WriteLine(TotalDamage);
                      //Console.WriteLine(PlayerHP = PlayerHP - TotalDamage);
                        PlayerHP = PlayerHP - TotalDamage;
                        Console.WriteLine();
                      //Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You took {TotalDamage} damage! Your HP is now {PlayerHP}");
                        Thread.Sleep(1000);

                    }
                    // Implement an easier way to Select Classes
                    // Console.WriteLine($"{classSelected} Selected")' 
                }
            }
            if (UserInput == "Weapon Switch Test")
            {
                Console.Clear();
                Console.WriteLine("====Weapon Switch Test====");
                Console.WriteLine("What Weapon do you want to use?");
                Console.WriteLine("1. Minigun");
                Console.WriteLine("2. Shotgun");
                Console.WriteLine("3. Fists");
                Console.Write("Action: ");
                int Health = Heavy.HeavyHealth();
                int Totaldamage = 0;
                string WeaponChoice = Console.ReadLine();
                if (WeaponChoice == "1")
                {
                    Heavy.HeavyPrimaryDamage();
                    Health = Health - Totaldamage;
                    Console.WriteLine($"Enemy Heavy took Damage! [Weapon: Minigun]");
                    Console.WriteLine($"Damage Taken: {Totaldamage}, Current HP: {Health}");
                }
                else if (WeaponChoice == "2")
                {
                    Heavy.HeavySecondaryDamage();
                    Health = Health - Totaldamage;
                    Console.WriteLine($"Enemy Heavy took Damage! [Weapon: Shotgun]");
                    Console.WriteLine($"Damage Taken: {Totaldamage}, Current HP: {Health}");
                }
                else if (WeaponChoice == "3")
                {
                    Heavy.HeavyMeleeDamage();
                    Health = Health - Totaldamage;
                    Console.WriteLine($"Enemy Heavy took Damage! [Weapon: Fists]");
                    Console.WriteLine($"Damage Taken: {Totaldamage}, Current HP: {Health}");
                }
                else { Console.WriteLine("Error, Listed Actions not selected."); }
            }
            if (UserInput == "SpecialTest")
            {
                var randomdamage = new Random();

                int BaseDamage = randomdamage.Next(20, 36); // creates a number between 20 & 36
                int Special = randomdamage.Next(0, 101); // creates a number between 0 & 100, if the number is 2 or lower, Special Bonus will be activated.
                int SpecialBonus = 1;
                Console.WriteLine($"Special Roll: {Special}");
                if (Special <= 2)
                {
                    SpecialBonus = 2;
                    Console.WriteLine("Special Activated!: Swing 2 Times [x2 Damage]");
                }
                int Totaldamage = BaseDamage * SpecialBonus;
                Console.WriteLine($"Total Damage: {Totaldamage}");
            }
            if (UserInput == "Take a Screenshot or Take Notes of this Screen")
            {
                Console.Clear();
                Console.WriteLine("=========================");
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("B");
                Thread.Sleep(1000);
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("R");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("U");
                Thread.Sleep(1000);
                Console.ForegroundColor= ConsoleColor.DarkGreen;
                Console.WriteLine("H");
                Console.ResetColor();
                Console.WriteLine("=========================");


            }
           
        }
    }
}