// TF2 Text Based Fighting Sim
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Xml.Schema;

namespace TF2_Simulator
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Console.Write("What is your Name: ");
            string PlayerName = Console.ReadLine();
            if (PlayerName == "")
            {
                PlayerName = "someone who apparently doesn't have a name";
            }
            if (PlayerName == "bucket" || (PlayerName == "Bucket"))
            {
                Thread.Sleep(1000);
                Console.WriteLine("[Spy]: This is a Bucket.");
                Thread.Sleep(1500);
                Console.WriteLine("[Soldier]: Dear God,");
                Thread.Sleep(1500);
                Console.WriteLine("[Spy]: There's More.");
                Thread.Sleep(1500);
                Console.WriteLine("[Soldier]: No!");
                Thread.Sleep(1000);
            }
            string Header = "┌────────────────────────┬────────────────────────┐";
            string Footer = "└────────────────────────┴────────────────────────┘";
            int PlayerHP;
            string PlayerMaxHP; //Add to Classes
            string PlayerClass; //Add to Classes
            int PlayerPrimaryDamage;
            int PlayerSecondaryDamage;
            int PlayerMeleeDamage;
            int PlayerSpecial = 0;
            int PlayerWeaponFeature = 0; //Add to Classes
            string PlayerPrimaryName;
            string PlayerSecondaryName;
            string PlayerMeleeName;
            string PlayerSpecialName;
            bool PlayerSetClass = false;
            int EnemyHP;
            string EnemyMaxHP; //Add to Classes
            string EnemyClass; //Add to Classes
            int EnemyPrimaryDamage;
            int EnemySecondaryDamage;
            int EnemyMeleeDamage;
            int EnemySpecial;
            string EnemyPrimaryName;
            string EnemySecondaryName;
            string EnemyMeleeName;
            string EnemySpecialName;
            int EnemyWeaponFeature = 0; //Add to Classes
            bool InputOK=false;
            bool InputEnemy = false;
            while (InputOK == false)
            {
                InputOK = true;
                Console.WriteLine();
                Console.WriteLine($"Welcome {PlayerName}!");
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
                Console.WriteLine("=========================");
                Console.WriteLine();
                Console.Write("Choose a Class, or type a Command: ");
                string UserInput = Console.ReadLine();
                if ((UserInput.ToLower() == "!help") || (UserInput.ToLower() == "help"))
                {
                    bool InputOKHelp = false;
                    while (InputOKHelp == false)
                    {
                        InputOKHelp = true;
                        Console.Clear();
                        Console.WriteLine("====Help Topics====");
                        Console.WriteLine("Select Using Numbers");
                        Console.WriteLine("1. Classes");
                        Console.WriteLine("2. About the Game");
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
                        else if (HelpInput == "2")
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
                            Thread.Sleep(5000);
                            InputOKHelp = false;
                        }
                        else
                        {
                            InputOKHelp = false;
                            Console.Clear();
                        }
                    }
                }
                else if (UserInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Scout Selected");
                    PlayerHP = 125;
                    PlayerClass = Scout.ScoutName();
                    PlayerMaxHP = Scout.ScoutMaxHP();
                    PlayerPrimaryDamage = Scout.ScoutPrimaryDamage();
                    PlayerSecondaryDamage = Scout.ScoutSecondaryDamage();
                    PlayerMeleeDamage = Scout.ScoutMeleeDamage();
                    PlayerSpecial = Scout.ScoutPrimaryDamage();
                    PlayerPrimaryName = Scout.ScoutPrimaryName();
                    PlayerSecondaryName = Scout.ScoutSecondaryName();
                    PlayerMeleeName = Scout.ScoutMeleeName();
                    PlayerSpecialName = "No Special - Replaced By Primary";
                    Thread.Sleep(1000);
                    Console.WriteLine("...Scout Settings Applied");
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    PlayerSetClass = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (UserInput == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Soldier Selected");
                    PlayerHP = 200;
                    PlayerClass = Soldier.SoldierName();
                    PlayerMaxHP = Soldier.SoldierMaxHP();
                    PlayerPrimaryDamage = Soldier.SoldierPrimaryDamage();
                    PlayerSecondaryDamage = Soldier.SoldierSecondaryDamage();
                    PlayerMeleeDamage = Soldier.SoldierMeleeDamage();
                    PlayerSpecial = Soldier.SoldierSpecial();
                    PlayerPrimaryName = Soldier.SoldierPrimaryName();
                    PlayerSecondaryName = Soldier.SoldierSecondaryName();
                    PlayerMeleeName = Soldier.SoldierMeleeName();
                    PlayerSpecialName = Soldier.SoldierSpecialName();
                    Thread.Sleep(1000);
                    Console.WriteLine("...Soldier Settings Applied");
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    Thread.Sleep(2000);
                    PlayerSetClass = true;
                    break;
                }
                else if (UserInput == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Pyro Selected");
                    PlayerHP = 175;
                    PlayerClass = Pyro.PyroName();
                    PlayerMaxHP = Pyro.PyroMaxHP();
                    PlayerPrimaryDamage = Pyro.PyroPrimaryDamage();
                    PlayerSecondaryDamage = Pyro.PyroSecondaryDamage();
                    PlayerMeleeDamage = Pyro.PyroMeleeDamage();
                    PlayerSpecial = Pyro.PyroPrimaryDamage();
                    PlayerPrimaryName = Pyro.PyroPrimaryName();
                    PlayerSecondaryName = Pyro.PyroSecondaryName();
                    PlayerMeleeName = Pyro.PyroMeleeName();
                    PlayerSpecialName = "No Special - Replaced By Primary";
                    Thread.Sleep(1000);
                    Console.WriteLine("...Pyro Settings Applied");
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    Thread.Sleep(2000);
                    PlayerSetClass = true;
                    break;
                }
                else if (UserInput == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Demoman Selected");
                    PlayerHP = 175;
                    PlayerClass = Demoman.DemomanName();
                    PlayerMaxHP = Demoman.DemomanMaxHP(); 
                    PlayerPrimaryDamage = Demoman.DemomanPrimaryDamage();
                    PlayerSecondaryDamage = Demoman.DemomanSecondaryDamage(PlayerWeaponFeature++); //PlayerWeaponFeature is reserved for Sticky Placement for this class. [++ = +1 Sticky Placed [Damage Multiplier]
                    PlayerWeaponFeature--;
                    PlayerMeleeDamage = Demoman.DemomanMeleeDamage();
                    PlayerSpecial = Demoman.DemomanSpecial(PlayerWeaponFeature); //Detonate Stickies. Uses PlayerWeaponFeature as a Damage Multiplier.
                    PlayerPrimaryName = Demoman.DemomanPrimaryName();
                    PlayerSecondaryName = Demoman.DemomanSecondaryName();
                    PlayerMeleeName = Demoman.DemomanMeleeName();
                    PlayerSpecialName = Demoman.DemomanSpecialName();
                    Thread.Sleep(1000);
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Stickies Placed - Secondary: {PlayerWeaponFeature}");
                    Console.WriteLine($"Sticky Detonate Damage - {PlayerSpecial}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Secondary Weapon Move Name: {PlayerSpecialName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    PlayerSetClass = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (UserInput == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Heavy Selected");
                    PlayerHP = 300;
                    PlayerClass = Heavy.HeavyName();
                    PlayerMaxHP = Heavy.HeavyMaxHP();
                    PlayerPrimaryDamage = Heavy.HeavyPrimaryDamage();
                    PlayerSecondaryDamage = Heavy.HeavySecondaryDamage();
                    PlayerMeleeDamage = Heavy.HeavyMeleeDamage();
                    PlayerSpecial = Heavy.HeavyPrimaryDamage();
                    PlayerPrimaryName = Heavy.HeavyPrimaryName();
                    PlayerSecondaryName = Heavy.HeavySecondaryName();
                    PlayerMeleeName = Heavy.HeavyMeleeName();
                    PlayerSpecialName = "No Special - Replaced By Primary";
                    Thread.Sleep(1000);
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    PlayerSetClass = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (UserInput == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Engineer Selected");
                    PlayerHP = 125;
                    PlayerClass = Engineer.EngineerName();
                    PlayerMaxHP = Engineer.EngineerMaxHP();
                    PlayerPrimaryDamage = Engineer.EngineerPrimaryDamage();
                    PlayerSecondaryDamage = Engineer.EngineerSecondaryDamage();
                    PlayerMeleeDamage = Engineer.EngineerMeleeDamage();
                    PlayerSpecial = Engineer.EngineerPrimaryDamage();
                    PlayerPrimaryName = Engineer.EngineerPrimaryName();
                    PlayerSecondaryName = Engineer.EngineerSecondaryName();
                    PlayerMeleeName = Engineer.EngineerMeleeName();
                    PlayerSpecialName = "No Special - Replaced By Primary";
                    Thread.Sleep(1000);
                    Console.WriteLine("...Engineer Settings Applied");
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    PlayerSetClass = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (UserInput == "7")
                {
                    Console.Clear();
                    Console.WriteLine("Medic Selected");
                    PlayerHP = 150;
                    PlayerClass = Medic.MedicName();
                    PlayerMaxHP = Medic.MedicMaxHP();
                    PlayerPrimaryDamage = Medic.MedicPrimaryDamage();
                    PlayerSecondaryDamage = Medic.MedicSecondaryDamage();
                    PlayerMeleeDamage = Medic.MedicMeleeDamage();
                    PlayerSpecial = Medic.MedicPrimaryDamage();
                    PlayerPrimaryName = Medic.MedicPrimaryName();
                    PlayerSecondaryName = Medic.MedicSecondaryName();
                    PlayerMeleeName = Medic.MedicMeleeName();
                    PlayerSpecialName = "No Special - Replaced By Primary";
                    Thread.Sleep(1000);
                    Console.WriteLine("...Medic Settings Applied");
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Heal - Secondary: {PlayerHP + PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    PlayerSetClass = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (UserInput == "8")
                {
                    Console.Clear();
                    Console.WriteLine("Sniper Selected");
                    PlayerHP = 125;
                    PlayerClass = Sniper.SniperName();
                    PlayerMaxHP = Sniper.SniperMaxHP();
                    PlayerPrimaryDamage = Sniper.SniperPrimaryDamage(PlayerWeaponFeature++); //PlayerWeaponFeature is reserved for Weapon Charge for this class. [++ = +1 Charge Level [Damage Multiplier]
                    PlayerSecondaryDamage = Sniper.SniperSecondaryDamage();
                    PlayerMeleeDamage = Sniper.SniperMeleeDamage();
                    PlayerSpecial = Sniper.SniperSpecial(PlayerWeaponFeature); //Detonate Stickies. Uses PlayerWeaponFeature as a Damage Multiplier.
                    PlayerPrimaryName = Sniper.SniperPrimaryName();
                    PlayerSecondaryName = Sniper.SniperSecondaryName();
                    PlayerMeleeName = Sniper.SniperMeleeName();
                    PlayerSpecialName = Sniper.SniperSpecialName();
                    Thread.Sleep(1000);
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerSpecial}");
                    Console.WriteLine($"Charge - Primary: {PlayerWeaponFeature}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Primary Weapon Move Name: {PlayerSpecialName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine(".....");
                    PlayerSetClass = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (UserInput == "9")
                {
                    Console.Clear();
                    Console.WriteLine("Spy Selected");
                    PlayerHP = 125;
                    PlayerClass = Spy.SpyName();
                    PlayerMaxHP = Spy.SpyMaxHP();
                    PlayerPrimaryDamage = Spy.SpySecondaryDamage();
                    PlayerSecondaryDamage = Spy.SpySecondaryDamage();
                    PlayerMeleeDamage = Spy.SpyMeleeDamage();
                    PlayerSpecial = Spy.SpySecondaryDamage();
                    PlayerPrimaryName = "No Primary - Replaced by Secondary";
                    PlayerSecondaryName = Spy.SpySecondaryName();
                    PlayerMeleeName = Spy.SpyMeleeName();
                    PlayerSpecialName = "No Special - Replaced By Secondary";
                    Thread.Sleep(1000);
                    Console.WriteLine("...Spy Settings Applied");
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary [Secondary]: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll [Secondary] - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....");
                    PlayerSetClass = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (UserInput.ToLower() == "cheats")
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
                    Console.WriteLine("-- Stickybomb Test");
                    Console.WriteLine("-- Sniper Test");
                    Console.WriteLine("-- Design //Sniper Test, *but cooler*");
                    Console.WriteLine("-- Close //Easily the greatest cheat / secret of all");
                }
                else if (UserInput.ToLower() == "no")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Why not?");
                    Thread.Sleep(10000);
                }
                else if (UserInput.ToLower() == "damage")
                {
                    var randomdamage = new Random();

                    int BaseDamage = randomdamage.Next(6, 13); // creates a number between 6 & 12
                    int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implement random damage per bullet later.)
                    Console.WriteLine($"{BaseDamage} Base Damage Dealt");
                    Console.WriteLine($"{BulletsFired} Damage Muliplier (Bullets Fired/Hit) ");
                    Console.WriteLine($"{BaseDamage * BulletsFired} Total Damage");
                }
                else if (UserInput.ToLower() == "check hp")
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
                else if (UserInput.ToLower() == "end test")
                {
                    Console.Write("Set Player HP: ");
                    string PlayerHP_EndTest = Console.ReadLine();
                    Console.Write("Set Enemy HP: ");
                    string EnemyHP_EndTest = Console.ReadLine();
                    if (int.TryParse(PlayerHP_EndTest, out int PlayerHPint))
                    {
                        if (int.TryParse(EnemyHP_EndTest, out int EnemyHPint))
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
                else if (UserInput.ToLower() == "heavy battle test")
                {
                    Console.Write("Type 'Start' to Start!: ");
                    string StartConfirm = Console.ReadLine();
                    int PlayerHP_BattleTest = 300;
                    int EnemyHP_BattleTest = 300;
                    if (StartConfirm == "Start")
                    {
                        Console.Clear();
                        while (PlayerHP_BattleTest >= 0 && EnemyHP_BattleTest >= 0)
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
                            EnemyHP_BattleTest = EnemyHP_BattleTest - TotalDamage;
                            Console.WriteLine();
                            if (EnemyHP_BattleTest <= 0)
                            {
                                //Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("The Enemy's HP Reached 0! You Won!");
                                //Console.ResetColor();
                                break;
                            }
                            if (PlayerHP_BattleTest <= 0)
                            {
                                //Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your HP Reached 0! You Lost the Battle!");
                                //Console.ResetColor();
                                break;
                            }
                            //Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Enemy took {TotalDamage} damage! Their HP is now {EnemyHP_BattleTest}");
                            Thread.Sleep(1000);

                            BaseDamage = randomdamage.Next(6, 13); // creates a number between 6 & 12
                            BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implement random damage per bullet later.)
                            //Console.WriteLine($"{BaseDamage} Base Damage Dealt");
                            //Console.WriteLine($"{BulletsFired} Damage Muliplier (Bullets Fired/Hit) ");
                            //Console.WriteLine($"{TotalDamage = BaseDamage * BulletsFired} Total Damage");
                            TotalDamage = BaseDamage * BulletsFired;
                            //Console.WriteLine(TotalDamage);
                            //Console.WriteLine(PlayerHP = PlayerHP - TotalDamage);
                            PlayerHP_BattleTest = PlayerHP_BattleTest - TotalDamage;
                            Console.WriteLine();
                            //Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"You took {TotalDamage} damage! Your HP is now {PlayerHP_BattleTest}");
                            Thread.Sleep(1000);

                        }
                        // Implement an easier way to Select Classes
                        // Console.WriteLine($"{classSelected} Selected")' 
                    }
                }
                else if (UserInput.ToLower() == "weapon switch test")
                {
                    Console.Clear();
                    Console.WriteLine("====Weapon Switch Test====");
                    Console.WriteLine("What Weapon do you want to use?");
                    Console.WriteLine($"1. {Heavy.HeavyPrimaryName()}");
                    Console.WriteLine($"2. {Heavy.HeavySecondaryName()}");
                    Console.WriteLine($"3. {Heavy.HeavyMeleeName()}");
                    Console.Write("Action: ");
                    int Health = Heavy.HeavyHealth();
                    int Totaldamage = 0;
                    string WeaponChoice = Console.ReadLine();
                    if (WeaponChoice == "1")
                    {
                        Heavy.HeavyPrimaryDamage();
                        Totaldamage = Heavy.HeavyPrimaryDamage();
                        Health = Health - Totaldamage;
                        Console.WriteLine($"Enemy Heavy took Damage! [Weapon: Minigun]");
                        Console.WriteLine($"Damage Taken: {Totaldamage}, Current HP: {Health}");
                    }
                    else if (WeaponChoice == "2")
                    {
                        Heavy.HeavySecondaryDamage();
                        Totaldamage = Heavy.HeavySecondaryDamage();
                        Health = Health - Totaldamage;
                        Console.WriteLine($"Enemy Heavy took Damage! [Weapon: Shotgun]");
                        Console.WriteLine($"Damage Taken: {Totaldamage}, Current HP: {Health}");
                    }
                    else if (WeaponChoice == "3")
                    {
                        Heavy.HeavyMeleeDamage();
                        Totaldamage = Heavy.HeavyMeleeDamage();
                        Health = Health - Totaldamage;
                        Console.WriteLine($"Enemy Heavy took Damage! [Weapon: Fists]");
                        Console.WriteLine($"Damage Taken: {Totaldamage}, Current HP: {Health}");
                    }
                    else { Console.WriteLine("Error, Listed Actions not selected."); }
                }
                else if (UserInput.ToLower() == "special test")
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
                else if (UserInput == "Take a Screenshot or Take Notes of this Screen")
                {
                    Console.Clear();
                    Console.WriteLine("=========================");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("B");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("R");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("U");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("H");
                    Console.ResetColor();
                    Console.WriteLine("=========================");


                }
                else if (UserInput.ToLower() == "stickybomb test")
                {
                    for (int i = 0; i < 10;)
                    {
                        Console.Clear();
                        Console.WriteLine("=====Sticky Bomb Add Test=====");
                        Console.WriteLine($"Sticky Bombs Placed: {PlayerWeaponFeature}");
                        Console.WriteLine("Type 'Place' to Place another Sticky, or 'Detonate' to Detonate the Stickies");
                        string DemoInput = Console.ReadLine();
                        if (DemoInput == "Place")
                        {
                            Console.WriteLine("Sticky Bomb Placed");
                            Demoman.DemomanSecondaryDamage(PlayerWeaponFeature++);
                            Console.WriteLine(PlayerWeaponFeature);
                        }
                        else if (DemoInput == "Detonate")
                        {
                            Console.WriteLine("Sticky Bomb(s) Detonated");
                            PlayerSpecial = Demoman.DemomanSpecial(PlayerWeaponFeature);
                            Console.WriteLine($"Total Damage {PlayerSpecial}");
                            Console.WriteLine($"Sticky Bombs Detonated: {PlayerWeaponFeature}");
                            PlayerWeaponFeature = 0;
                            Console.WriteLine($"Sticky Bombs Currently Placed: {PlayerWeaponFeature}");
                            Thread.Sleep(20000);
                        }
                    }

                }
                else if (UserInput.ToLower() == "sniper test")
                {
                    for (int i = 0; i < 10;)
                    {
                        Console.Clear();
                        Console.WriteLine("=====Sniper Charge Test=====");
                        Console.WriteLine("Warning: Charge Level will start at 0. When the Sniper is loaded normally, the charge will be one.");
                        Console.WriteLine($"Sniper Charge: {PlayerWeaponFeature}");
                        Console.WriteLine("Type 'Charge' to Charge your Damage, or 'Fire' to Fire your Weapon");
                        string SniperInput = Console.ReadLine();
                        if (SniperInput == "Charge")
                        {
                            Console.WriteLine("Spent Turn Charging Sniper");
                            Sniper.SniperPrimaryDamage(PlayerWeaponFeature++);
                            Console.WriteLine(PlayerWeaponFeature);
                        }
                        else if (SniperInput == "Fire")
                        {
                            Console.WriteLine("Sniper Shot Fired");
                            PlayerSpecial = Sniper.SniperSpecial(PlayerWeaponFeature);
                            Console.WriteLine($"Total Damage {PlayerSpecial}");
                            Console.WriteLine($"Charge Level When Shot: {PlayerWeaponFeature}");
                            PlayerWeaponFeature = 1;
                            Console.WriteLine($"Current Charge Level: {PlayerWeaponFeature}");
                            Thread.Sleep(20000);
                        }
                    }


                }
                else if (UserInput.ToLower() == "design")
                {
                    for (int i = 0; i < 10;)
                    {
                        Console.Clear();
                        Console.WriteLine("=====Sniper Charge Test=====");
                        Console.WriteLine(Header);
                        Console.WriteLine($"Sniper Charge: {PlayerWeaponFeature}");
                        Console.WriteLine(Footer);
                        Console.WriteLine("1. Fire");
                        Console.WriteLine("2. Charge");
                        Console.Write("├ Action: ");
                        string SniperInput = Console.ReadLine();
                        if (SniperInput == "2")
                        {
                            Console.WriteLine(Header);
                            Console.WriteLine("├ Spent Turn Charging Sniper");
                            Sniper.SniperPrimaryDamage(PlayerWeaponFeature++);
                            Console.WriteLine($"├ Charge Level: {PlayerWeaponFeature}");
                            Console.WriteLine(Footer);
                            Thread.Sleep(2000);
                        }
                        else if (SniperInput == "1")
                        {
                            Console.WriteLine(Header);
                            Console.WriteLine("Sniper Shot Fired");
                            PlayerSpecial = Sniper.SniperSpecial(PlayerWeaponFeature);
                            Console.WriteLine($"Total Damage {PlayerSpecial}");
                            Console.WriteLine($"Charge Level When Shot: {PlayerWeaponFeature}");
                            PlayerWeaponFeature = 1;
                            Console.WriteLine($"Current Charge Level: {PlayerWeaponFeature}");
                            Console.WriteLine(Footer);
                            Thread.Sleep(2000);
                        }
                    }

                }
                else if (UserInput.ToLower() == "close")
                {
                    Console.WriteLine(Header);
                    Console.WriteLine("Player Requested to Close the Game.");
                    Console.WriteLine(Footer);
                }
                else if (UserInput.ToLower() == "soldier market garden")
                {
                    bool SoldierTest = false;
                    Console.WriteLine(Header);
                    Console.WriteLine("Testing: The Soldier's Market Garden.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Selected Classes:");
                    Thread.Sleep(1000);
                    Console.WriteLine("Player: Soldier");
                    Thread.Sleep(1000);
                    Console.WriteLine("Enemy: Heavy");
                    Thread.Sleep(1000);
                    Console.WriteLine(".....Loading Classes");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine(Header);
                    Console.WriteLine("Soldier Selected");
                    PlayerHP = 200;
                    PlayerClass = Soldier.SoldierName();
                    PlayerMaxHP = Soldier.SoldierMaxHP();
                    PlayerPrimaryDamage = Soldier.SoldierPrimaryDamage();
                    PlayerSecondaryDamage = Soldier.SoldierSecondaryDamage();
                    PlayerMeleeDamage = Soldier.SoldierMeleeDamage();
                    PlayerSpecial = Soldier.SoldierSpecial();
                    PlayerPrimaryName = Soldier.SoldierPrimaryName();
                    PlayerSecondaryName = Soldier.SoldierSecondaryName();
                    PlayerMeleeName = Soldier.SoldierMeleeName();
                    PlayerSpecialName = Soldier.SoldierSpecialName();
                    Thread.Sleep(1000);
                    Console.WriteLine("...Soldier Settings Applied");
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {PlayerPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {PlayerSecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {PlayerMeleeDamage}");
                    Console.WriteLine($"Special Roll - {PlayerSpecial}");
                    Console.WriteLine($"Primary Weapon Name: {PlayerPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {PlayerSecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {PlayerMeleeName}");
                    Console.WriteLine($"Special Move Name: {PlayerSpecialName}");
                    Console.WriteLine(".....Loading Enemy Class");
                    Thread.Sleep(2000);
                    Console.WriteLine(Footer);
                    Console.WriteLine();
                    Console.WriteLine(Header);
                    Console.WriteLine("Enemy Heavy Selected");
                    EnemyHP = 300;
                    EnemyClass = Heavy.HeavyName();
                    EnemyMaxHP = Heavy.HeavyMaxHP();
                    EnemyPrimaryDamage = Heavy.HeavyPrimaryDamage();
                    EnemySecondaryDamage = Heavy.HeavySecondaryDamage();
                    EnemyMeleeDamage = Heavy.HeavyMeleeDamage();
                    EnemySpecial = Heavy.HeavyPrimaryDamage();
                    EnemyPrimaryName = Heavy.HeavyPrimaryName();
                    EnemySecondaryName = Heavy.HeavySecondaryName();
                    EnemyMeleeName = Heavy.HeavyMeleeName();
                    EnemySpecialName = "No Special - Replaced By Primary";
                    Thread.Sleep(1000);
                    Console.WriteLine("=====Debug=====");
                    Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                    Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                    Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                    Console.WriteLine($"Special Roll - {EnemySpecial}");
                    Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                    Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                    Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                    Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                    Console.WriteLine(".....");
                    Console.WriteLine(Footer);
                    Console.WriteLine();
                    Console.WriteLine(Header);
                    Console.WriteLine("Classes Selected...");
                    while (SoldierTest = false)
                    {

                    }
                }
                else
                {
                    InputOK = false;
                    Console.Clear();
                    Console.Write("Invalid Command Entered."); Thread.Sleep(1000); Console.Write(" Try Again");
                    Console.WriteLine();
                }
            }
            if (PlayerSetClass == true) 
            {
                while (InputEnemy == false)
                {
                    InputEnemy = true;
                    Console.Clear();
                    Console.WriteLine("Pick The Enemy's class!");
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
                    Console.WriteLine("=========================");
                    Console.WriteLine();
                    Console.Write("Choose a Class: ");
                    string UserInput = Console.ReadLine();
                    if (UserInput == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Scout Selected");
                        EnemyHP = 125;
                        EnemyPrimaryDamage = Scout.ScoutPrimaryDamage();
                        EnemySecondaryDamage = Scout.ScoutSecondaryDamage();
                        EnemyMeleeDamage = Scout.ScoutMeleeDamage();
                        EnemySpecial = Scout.ScoutPrimaryDamage();
                        EnemyPrimaryName = Scout.ScoutPrimaryName();
                        EnemySecondaryName = Scout.ScoutSecondaryName();
                        EnemyMeleeName = Scout.ScoutMeleeName();
                        EnemySpecialName = "No Special - Replaced By Primary";
                        Console.WriteLine("...Scout Settings Applied");
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Special Roll - {EnemySpecial}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                    }
                    else if (UserInput == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Soldier Selected");
                        EnemyHP = 200;
                        EnemyClass = Soldier.SoldierName();
                        EnemyMaxHP = Soldier.SoldierMaxHP();
                        EnemyPrimaryDamage = Soldier.SoldierPrimaryDamage();
                        EnemySecondaryDamage = Soldier.SoldierSecondaryDamage();
                        EnemyMeleeDamage = Soldier.SoldierMeleeDamage();
                        EnemySpecial = Soldier.SoldierSpecial();
                        EnemyPrimaryName = Soldier.SoldierPrimaryName();
                        EnemySecondaryName = Soldier.SoldierSecondaryName();
                        EnemyMeleeName = Soldier.SoldierMeleeName();
                        EnemySpecialName = Soldier.SoldierSpecialName();
                        Thread.Sleep(1000);
                        Console.WriteLine("...Soldier Settings Applied");
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Special Roll - {EnemySpecial}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                        Console.WriteLine(".....");
                        Thread.Sleep(2000);
                    }
                    else if (UserInput == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Pyro Selected");
                        EnemyHP = 175;
                        EnemyClass = Pyro.PyroName();
                        EnemyMaxHP = Pyro.PyroMaxHP();
                        EnemyPrimaryDamage = Pyro.PyroPrimaryDamage();
                        EnemySecondaryDamage = Pyro.PyroSecondaryDamage();
                        EnemyMeleeDamage = Pyro.PyroMeleeDamage();
                        EnemySpecial = Pyro.PyroPrimaryDamage();
                        EnemyPrimaryName = Pyro.PyroPrimaryName();
                        EnemySecondaryName = Pyro.PyroSecondaryName();
                        EnemyMeleeName = Pyro.PyroMeleeName();
                        EnemySpecialName = "No Special - Replaced By Primary";
                        Thread.Sleep(1000);
                        Console.WriteLine("...Pyro Settings Applied");
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Special Roll - {EnemySpecial}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                        Console.WriteLine(".....");
                        Thread.Sleep(2000);
                    }
                    else if (UserInput == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Demoman Selected");
                        EnemyHP = 175;
                        EnemyClass = Demoman.DemomanName();
                        EnemyMaxHP = Demoman.DemomanMaxHP();
                        EnemyPrimaryDamage = Demoman.DemomanPrimaryDamage();
                        EnemySecondaryDamage = Demoman.DemomanSecondaryDamage(EnemyWeaponFeature++); //EnemyWeaponFeature is reserved for Sticky Placement for this class. [++ = +1 Sticky Placed [Damage Multiplier]
                        EnemyWeaponFeature--;
                        EnemyMeleeDamage = Demoman.DemomanMeleeDamage();
                        EnemySpecial = Demoman.DemomanSpecial(EnemyWeaponFeature); //Detonate Stickies. Uses EnemyWeaponFeature as a Damage Multiplier.
                        EnemyPrimaryName = Demoman.DemomanPrimaryName();
                        EnemySecondaryName = Demoman.DemomanSecondaryName();
                        EnemyMeleeName = Demoman.DemomanMeleeName();
                        EnemySpecialName = Demoman.DemomanSpecialName();
                        Thread.Sleep(1000);
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Stickies Placed - Secondary: {EnemyWeaponFeature}");
                        Console.WriteLine($"Sticky Detonate Damage - {EnemySpecial}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Secondary Weapon Move Name: {EnemySpecialName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                        Console.WriteLine(".....");
                    }
                    else if (UserInput == "5")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Heavy Selected");
                        EnemyHP = 300;
                        EnemyClass = Heavy.HeavyName();
                        EnemyMaxHP = Heavy.HeavyMaxHP();
                        EnemyPrimaryDamage = Heavy.HeavyPrimaryDamage();
                        EnemySecondaryDamage = Heavy.HeavySecondaryDamage();
                        EnemyMeleeDamage = Heavy.HeavyMeleeDamage();
                        EnemySpecial = Heavy.HeavyPrimaryDamage();
                        EnemyPrimaryName = Heavy.HeavyPrimaryName();
                        EnemySecondaryName = Heavy.HeavySecondaryName();
                        EnemyMeleeName = Heavy.HeavyMeleeName();
                        EnemySpecialName = "No Special - Replaced By Primary";
                        Thread.Sleep(1000);
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Special Roll - {EnemySpecial}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                        Console.WriteLine(".....");
                    }
                    else if (UserInput == "6")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Engineer Selected");
                        EnemyHP = 125;
                        EnemyClass = Engineer.EngineerName();
                        EnemyMaxHP = Engineer.EngineerMaxHP();
                        EnemyPrimaryDamage = Engineer.EngineerPrimaryDamage();
                        EnemySecondaryDamage = Engineer.EngineerSecondaryDamage();
                        EnemyMeleeDamage = Engineer.EngineerMeleeDamage();
                        EnemySpecial = Engineer.EngineerPrimaryDamage();
                        EnemyPrimaryName = Engineer.EngineerPrimaryName();
                        EnemySecondaryName = Engineer.EngineerSecondaryName();
                        EnemyMeleeName = Engineer.EngineerMeleeName();
                        EnemySpecialName = "No Special - Replaced By Primary";
                        Thread.Sleep(1000);
                        Console.WriteLine("...Engineer Settings Applied");
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Special Roll - {EnemySpecial}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                        Console.WriteLine(".....");
                    }
                    else if (UserInput == "7")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Medic Selected");
                        EnemyHP = 150;
                        EnemyClass = Medic.MedicName();
                        EnemyMaxHP = Medic.MedicMaxHP();
                        EnemyPrimaryDamage = Medic.MedicPrimaryDamage();
                        EnemySecondaryDamage = Medic.MedicSecondaryDamage();
                        EnemyMeleeDamage = Medic.MedicMeleeDamage();
                        EnemySpecial = Medic.MedicPrimaryDamage();
                        EnemyPrimaryName = Medic.MedicPrimaryName();
                        EnemySecondaryName = Medic.MedicSecondaryName();
                        EnemyMeleeName = Medic.MedicMeleeName();
                        EnemySpecialName = "No Special - Replaced By Primary";
                        Thread.Sleep(1000);
                        Console.WriteLine("...Medic Settings Applied");
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Heal - Secondary: {EnemyHP + EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Special Roll - {EnemySpecial}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                        Console.WriteLine(".....");
                    }
                    else if (UserInput == "8")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Sniper Selected");
                        EnemyHP = 125;
                        EnemyClass = Sniper.SniperName();
                        EnemyMaxHP = Sniper.SniperMaxHP();
                        EnemyPrimaryDamage = Sniper.SniperPrimaryDamage(EnemyWeaponFeature++); //EnemyWeaponFeature is reserved for Weapon Charge for this class. [++ = +1 Charge Level [Damage Multiplier]
                        EnemySecondaryDamage = Sniper.SniperSecondaryDamage();
                        EnemyMeleeDamage = Sniper.SniperMeleeDamage();
                        EnemySpecial = Sniper.SniperSpecial(EnemyWeaponFeature); //Detonate Stickies. Uses EnemyWeaponFeature as a Damage Multiplier.
                        EnemyPrimaryName = Sniper.SniperPrimaryName();
                        EnemySecondaryName = Sniper.SniperSecondaryName();
                        EnemyMeleeName = Sniper.SniperMeleeName();
                        EnemySpecialName = Sniper.SniperSpecialName();
                        Thread.Sleep(1000);
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary: {EnemySpecial}");
                        Console.WriteLine($"Charge - Primary: {EnemyWeaponFeature}");
                        Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Primary Weapon Move Name: {EnemySpecialName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine(".....");
                    }
                    else if (UserInput == "9")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Spy Selected");
                        EnemyHP = 125;
                        EnemyClass = Spy.SpyName();
                        EnemyMaxHP = Spy.SpyMaxHP();
                        EnemyPrimaryDamage = Spy.SpySecondaryDamage();
                        EnemySecondaryDamage = Spy.SpySecondaryDamage();
                        EnemyMeleeDamage = Spy.SpyMeleeDamage();
                        EnemySpecial = Spy.SpySecondaryDamage();
                        EnemyPrimaryName = "No Primary - Replaced by Secondary";
                        EnemySecondaryName = Spy.SpySecondaryName();
                        EnemyMeleeName = Spy.SpyMeleeName();
                        EnemySpecialName = "No Special - Replaced By Secondary";
                        Thread.Sleep(1000);
                        Console.WriteLine("...Spy Settings Applied");
                        Console.WriteLine("=====Debug=====");
                        Console.WriteLine($"Attack - Primary [Secondary]: {EnemyPrimaryDamage}");
                        Console.WriteLine($"Attack - Secondary: {EnemySecondaryDamage}");
                        Console.WriteLine($"Attack - Melee: {EnemyMeleeDamage}");
                        Console.WriteLine($"Special Roll [Secondary] - {EnemySpecial}");
                        Console.WriteLine($"Primary Weapon Name: {EnemyPrimaryName}");
                        Console.WriteLine($"Secondary Weapon Name: {EnemySecondaryName}");
                        Console.WriteLine($"Melee Weapon Name: {EnemyMeleeName}");
                        Console.WriteLine($"Special Move Name: {EnemySpecialName}");
                        Console.WriteLine(".....");
                    }
                    else
                    {
                        InputEnemy = true;
                    }

                }
            }
        }
    }
}