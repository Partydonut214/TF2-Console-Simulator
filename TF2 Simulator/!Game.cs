// TF2 Text Based Fighting Sim
using System;
using System.ComponentModel;
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
            #region Secret Names
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
            if (PlayerName.ToLower() == "red")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "blu" || PlayerName.ToLower() == "blue")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "grn")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "ylw")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "markiplier")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "jacksepticeye")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "dantdm")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "fallout 3")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            if (PlayerName.ToLower() == "fallout new vegas")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("┌───────────┬────────────┐");
                Console.WriteLine("Secret Name Discovered");
                Console.WriteLine("└───────────┴────────────┘");
            }
            #endregion
            #region Dividers & Borders
            string Header = "┌────────────────────────┬────────────────────────┐";
            string Footer = "└────────────────────────┴────────────────────────┘";
            string HeaderLong = "┌────────────────────────────────────────────────┬────────────────────────────────────────────────┐";
            string FooterLong = "└────────────────────────────────────────────────┴────────────────────────────────────────────────┘";
            #endregion
            #region Player Stats
            int PlayerHP = 0;
            string PlayerMaxHP = "Not Set";
            string PlayerClass = "Unselected";
            int PlayerCooldown = 0;
            int PlayerPrimaryDamage = 0;
            int PlayerSecondaryDamage = 0;
            int PlayerMeleeDamage = 0;
            int PlayerSpecial = 0;
            int PlayerWeaponFeature = 0; //Add to Classes
            string PlayerPrimaryName = "Not Defined";
            string PlayerSecondaryName = "Not Defined";
            string PlayerMeleeName = "Not Defined";
            string PlayerSpecialName = "Not Defined";
            bool PlayerSetClass = false;
            string PlayerChoice = "9999"; //Implement
            #endregion
            #region Enemy Stats
            int EnemyHP = 0;
            string EnemyMaxHP = "Not Set";
            string EnemyClass = "Unselected";
            int EnemyCooldown = 0;
            int EnemyPrimaryDamage = 0;
            int EnemySecondaryDamage = 0;
            int EnemyMeleeDamage = 0;
            int EnemySpecial = 0;
            string EnemyPrimaryName = "Not Defined";
            string EnemySecondaryName = "Not Defined";
            string EnemyMeleeName = "Not Defined";
            string EnemySpecialName = "Not Defined";
            int EnemyWeaponFeature = 0; //Add to Classes
            bool EnemySetClass = false; //Implement
            int EnemyChoice = 0; // Implement
            #endregion
            #region Page Reset
            bool InputOK = false;
            bool GameInputOK = false;
            bool InputEnemy = false;
            #endregion
            #region MainMenu
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
                #region Help Menu
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
                #endregion
                #region Player Classes
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
                    PlayerPrimaryDamage = Medic.MedicPrimaryDamage(PlayerCooldown);
                    PlayerSecondaryDamage = Medic.MedicSecondaryDamage(PlayerCooldown);
                    PlayerMeleeDamage = Medic.MedicMeleeDamage(PlayerCooldown);
                    PlayerSpecial = Medic.MedicPrimaryDamage(PlayerCooldown);
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
                #endregion
                #region Tests
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
                else if (UserInput.ToLower() == "market garden")
                {
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
                    Console.Write("Type 'Start' to Start!: ");
                    string StartConfirm = Console.ReadLine();
                    if (StartConfirm == "Start")
                    {
                        while (PlayerHP >= 0 && EnemyHP >= 0)
                        {
                            Console.Clear();
                            Console.WriteLine(Header);
                            Console.WriteLine($"{PlayerName}'s Class is {PlayerClass} with {PlayerHP}/{PlayerMaxHP}"!);
                            Console.WriteLine($"The Enemy's Class is {EnemyClass} with {EnemyHP}/{EnemyMaxHP}");
                            Console.WriteLine($"Actions:");
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                            Console.WriteLine($"4. {PlayerSpecialName}");
                            Console.WriteLine(Footer);
                            Console.Write($"{PlayerName}'s Choice: ");
                            PlayerChoice = Console.ReadLine();
                            if (PlayerChoice == "1")
                            {
                                Console.WriteLine();
                                Console.WriteLine(HeaderLong);
                                PlayerPrimaryDamage = Soldier.SoldierPrimaryDamage();
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"{PlayerName} Dealt {PlayerPrimaryDamage} to the Enemy {EnemyClass} using {PlayerPrimaryName}! Their HP is now {EnemyHP}");
                                Thread.Sleep(1000);
                                Console.WriteLine(FooterLong);
                            }
                            if (PlayerChoice == "2")
                            {
                                Console.WriteLine();
                                Console.WriteLine(HeaderLong);
                                PlayerSecondaryDamage = Soldier.SoldierSecondaryDamage();
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"{PlayerName} Dealt {PlayerSecondaryDamage} to the Enemy {EnemyClass} using {PlayerSecondaryName}! Their HP is now {EnemyHP}!");
                                Thread.Sleep(1000);
                                Console.WriteLine(FooterLong);
                            }
                            if (PlayerChoice == "3")
                            {
                                Console.WriteLine();
                                Console.WriteLine(HeaderLong);
                                PlayerMeleeDamage = Soldier.SoldierMeleeDamage();
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"{PlayerName} Dealt {PlayerMeleeDamage} to the Enemy {EnemyClass} using {PlayerMeleeName}! Their HP is now {EnemyHP}!");
                                Thread.Sleep(1000);
                                Console.WriteLine(FooterLong);
                            }
                            if (PlayerChoice == "4")
                            {
                                Console.WriteLine();
                                Console.WriteLine(Header);
                                Console.WriteLine($"{PlayerName} choose to attempt the Market Garden.");
                                Console.WriteLine(Footer);
                                Thread.Sleep(1000);
                                PlayerPrimaryDamage = Soldier.SoldierPrimaryDamage();
                                PlayerHP = PlayerHP - PlayerPrimaryDamage;
                                Console.WriteLine();
                                Console.WriteLine(Header);
                                Console.WriteLine($"You Took {PlayerPrimaryDamage} from the Rocket Jump.");
                                Console.WriteLine($"Your HP is now {PlayerHP}.");
                                Console.WriteLine(Footer);
                                Thread.Sleep(1000);
                                if (PlayerHP < 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(Header);
                                    Console.WriteLine("The Rocket Jump sent you to your grave instead of ");
                                    Console.WriteLine("your shovel to your enemy's face.");
                                    Console.WriteLine(" -- You need to watch your HP!");
                                    Console.WriteLine(Footer);
                                    Thread.Sleep(5000);
                                }
                                if (PlayerHP >= 0)
                                {
                                    PlayerSpecial = Soldier.SoldierSpecial();
                                    EnemyHP -= PlayerSpecial;
                                    if (PlayerSpecial == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(Header);
                                        Console.WriteLine($"You Missed the Market Garden!");
                                        Console.WriteLine($"The Enemy's HP is still {EnemyHP}");
                                        Console.WriteLine(Footer);
                                        Thread.Sleep(3000);
                                    }
                                    if (PlayerSpecial == 195)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(HeaderLong);
                                        Console.WriteLine($"You Hit the Market Garden and hit the enemy! You Dealt 195 Damage, their HP is now {EnemyHP}");
                                        Console.WriteLine(FooterLong);
                                        Thread.Sleep(3000);
                                    }
                                }

                            }
                            if (EnemyHP > 0)
                            {
                                EnemyChoice = EnemyTurn.EnemyChoice(EnemyCooldown);
                                if (EnemyChoice == 1)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemyPrimaryDamage = Heavy.HeavyPrimaryDamage();
                                    PlayerHP = PlayerHP - EnemyPrimaryDamage;
                                    Console.WriteLine($"The Enemy {EnemyClass} Dealt {EnemyPrimaryDamage} to {PlayerName} using their {EnemyPrimaryName}! Your HP is now {PlayerHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                                if (EnemyChoice == 2)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemySecondaryDamage = Heavy.HeavySecondaryDamage();
                                    PlayerHP = PlayerHP - EnemySecondaryDamage;
                                    Console.WriteLine($"The Enemy {EnemyClass} Dealt {EnemySecondaryDamage} to {PlayerName} using their {EnemySecondaryName}! Your HP is now {PlayerHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                                if (EnemyChoice == 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemyMeleeDamage = Heavy.HeavyMeleeDamage();
                                    PlayerHP = PlayerHP - EnemyMeleeDamage;
                                    Console.WriteLine($"The Enemy {EnemyClass} Dealt {EnemyMeleeDamage} to {PlayerName} using their {EnemyMeleeName}! Your HP is now {PlayerHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                                if (EnemyChoice == 4)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemySpecial = Heavy.HeavyPrimaryDamage();
                                    PlayerHP = PlayerHP - EnemyPrimaryDamage;
                                    Console.WriteLine($"The Enemy {EnemyClass} Dealt {EnemyPrimaryDamage} to {PlayerName} using their {EnemyPrimaryName}! Your HP is now {PlayerHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }

                            }

                        }
                        if (PlayerHP <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(Header);
                            Console.WriteLine($"You Died! The Enemy {EnemyClass} Defeated you. ");
                            Console.WriteLine($"They had {EnemyHP}/{EnemyMaxHP} HP Remaining.");
                            Console.WriteLine(Footer);
                        }
                        if (EnemyHP <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(Header);
                            Console.WriteLine($"You Won! The Enemy {EnemyClass} Was Defeated! ");
                            Console.WriteLine($"You have {PlayerHP}/{PlayerMaxHP} HP Remaining!");
                            Console.WriteLine(Footer);
                        }
                    }
                }
                else if (UserInput.ToLower() == "medigun")
                {
                    Console.WriteLine(Header);
                    Console.WriteLine("Testing: The Medic's Medigun Cooldown.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Selected Classes:");
                    Thread.Sleep(1000);
                    Console.WriteLine("Player: Medic");
                    Thread.Sleep(1000);
                    Console.WriteLine("Enemy: Medic");
                    Thread.Sleep(1000);
                    Console.WriteLine(".....Loading Classes");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine(Header);
                    Console.WriteLine("Medic Selected");
                    PlayerHP = 1200;
                    PlayerClass = Medic.MedicName();
                    PlayerMaxHP = Medic.MedicMaxHP();
                    PlayerPrimaryDamage = Medic.MedicPrimaryDamage(PlayerCooldown);
                    PlayerSecondaryDamage = Medic.MedicSecondaryDamage(PlayerCooldown); //Add Cooldown
                    PlayerMeleeDamage = Medic.MedicMeleeDamage(PlayerCooldown);
                    PlayerSpecial = Medic.MedicPrimaryDamage(PlayerCooldown);
                    PlayerPrimaryName = Medic.MedicPrimaryName();
                    PlayerSecondaryName = Medic.MedicSecondaryName();
                    PlayerMeleeName = Medic.MedicMeleeName();
                    PlayerSpecialName = "No Special - Replaced By Primary";
                    Thread.Sleep(1000);
                    Console.WriteLine("...Medic Settings Applied");
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
                    Console.WriteLine("Enemy Medic Selected");
                    EnemyHP = 1200;
                    EnemyClass = Medic.MedicName();
                    EnemyMaxHP = Medic.MedicMaxHP();
                    EnemyPrimaryDamage = Medic.MedicPrimaryDamage(EnemyCooldown);
                    EnemySecondaryDamage = Medic.MedicSecondaryDamage(EnemyCooldown);
                    EnemyMeleeDamage = Medic.MedicMeleeDamage(EnemyCooldown);
                    EnemySpecial = Medic.MedicPrimaryDamage(EnemyCooldown);
                    EnemyPrimaryName = Medic.MedicPrimaryName();
                    EnemySecondaryName = Medic.MedicSecondaryName();
                    EnemyMeleeName = Medic.MedicMeleeName();
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
                    Console.Write("Type 'Start' to Start!: ");
                    string StartConfirm = Console.ReadLine();
                    if (StartConfirm == "Start")
                    {
                        while (PlayerHP >= 0 && EnemyHP >= 0)
                        {
                            Console.Clear();
                            Console.WriteLine(Header);
                            Console.WriteLine($"{PlayerName}'s Class is {PlayerClass} with {PlayerHP}/{PlayerMaxHP}"!);
                            Console.WriteLine($"The Enemy's Class is {EnemyClass} with {EnemyHP}/{EnemyMaxHP}");
                            Console.WriteLine($"Actions:");
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                            Console.WriteLine($"4. {PlayerSpecialName}");
                            Console.WriteLine(Footer);
                            Console.Write($"{PlayerName}'s Choice: ");
                            PlayerChoice = Console.ReadLine();
                            if (PlayerChoice == "1")
                            {
                                Console.WriteLine();
                                Console.WriteLine(HeaderLong);
                                PlayerPrimaryDamage = Medic.MedicPrimaryDamage(PlayerCooldown);
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                PlayerHP = PlayerHP + (PlayerPrimaryDamage / 2);
                                Console.WriteLine($"{PlayerName} Dealt {PlayerPrimaryDamage} to the Enemy {EnemyClass} using {PlayerPrimaryName}! Their HP is now {EnemyHP}");
                                Thread.Sleep(1000);
                                Console.WriteLine(FooterLong);
                            }
                            if (PlayerChoice == "2")
                            {
                                Console.WriteLine();
                                Console.WriteLine(HeaderLong);
                                PlayerSecondaryDamage = Medic.MedicSecondaryDamage(PlayerCooldown);
                                PlayerHP = PlayerHP + PlayerSecondaryDamage;
                                Console.WriteLine($"{PlayerName} Healed {PlayerSecondaryDamage} using {PlayerSecondaryName}! Your HP is now {PlayerHP}!");
                                Thread.Sleep(1000);
                                Console.WriteLine(FooterLong);
                            }
                            if (PlayerChoice == "3")
                            {
                                Console.WriteLine();
                                Console.WriteLine(HeaderLong);
                                PlayerMeleeDamage = Medic.MedicMeleeDamage(PlayerCooldown);
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"{PlayerName} Dealt {PlayerMeleeDamage} to the Enemy {EnemyClass} using {PlayerMeleeName}! Their HP is now {EnemyHP}!");
                                Thread.Sleep(1000);
                                Console.WriteLine(FooterLong);
                            }
                            if (PlayerChoice == "4")
                            {
                                Console.WriteLine();
                                Console.WriteLine(HeaderLong);
                                PlayerPrimaryDamage = Medic.MedicPrimaryDamage(PlayerCooldown);
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"{PlayerName} Dealt {PlayerPrimaryDamage} to the Enemy {EnemyClass} using {PlayerPrimaryName}! Their HP is now {EnemyHP}");
                                Thread.Sleep(1000);
                                Console.WriteLine(FooterLong);
                            }
                            if (EnemyHP > 0)
                            {
                                EnemyChoice = EnemyTurn.EnemyChoice(EnemyCooldown);
                                if (EnemyChoice == 1)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemyPrimaryDamage = Medic.MedicPrimaryDamage(EnemyCooldown);
                                    PlayerHP = PlayerHP - EnemyPrimaryDamage;
                                    EnemyHP = EnemyHP + (EnemyPrimaryDamage / 2);
                                    Console.WriteLine($"The Enemy {EnemyClass} Dealt {EnemyPrimaryDamage} to {PlayerName} using their {EnemyPrimaryName}! Your HP is now {PlayerHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                                if (EnemyChoice == 2)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemySecondaryDamage = Medic.MedicSecondaryDamage(EnemyCooldown);
                                    EnemyHP = EnemyHP + EnemySecondaryDamage;
                                    Console.WriteLine($"The Enemy {EnemyClass} Healed {EnemySecondaryDamage} using their {EnemySecondaryName}! Their HP is now {EnemyHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                                if (EnemyChoice == 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemyMeleeDamage = Medic.MedicMeleeDamage(EnemyCooldown);
                                    PlayerHP = PlayerHP - EnemyMeleeDamage;
                                    Console.WriteLine($"The Enemy {EnemyClass} Dealt {EnemyMeleeDamage} to {PlayerName} using their {EnemyMeleeName}! Your HP is now {PlayerHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                                if (EnemyChoice == 4)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HeaderLong);
                                    EnemySpecial = Medic.MedicPrimaryDamage(EnemyCooldown);
                                    PlayerHP = PlayerHP - EnemyPrimaryDamage;
                                    Console.WriteLine($"The Enemy {EnemyClass} Dealt {EnemyPrimaryDamage} to {PlayerName} using their {EnemyPrimaryName}! Your HP is now {PlayerHP}!");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }

                            }

                        }
                        if (PlayerHP <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(Header);
                            Console.WriteLine($"You Died! The Enemy {EnemyClass} Defeated you. ");
                            Console.WriteLine($"They had {EnemyHP}/{EnemyMaxHP} HP Remaining.");
                            Console.WriteLine(Footer);
                        }
                        if (EnemyHP <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(Header);
                            Console.WriteLine($"You Won! The Enemy {EnemyClass} Was Defeated! ");
                            Console.WriteLine($"You have {PlayerHP}/{PlayerMaxHP} HP Remaining!");
                            Console.WriteLine(Footer);
                        }
                    }
                }

                #endregion
                #region MainMenu Reset
                else
                {
                    InputOK = false;
                    Console.Clear();
                    Console.Write("Invalid Command Entered."); Thread.Sleep(1000); Console.Write(" Try Again");
                    Console.WriteLine();
                }
                #endregion
            }
            #endregion
            #region Pick Enemy
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
                    string UserInputEnemy = Console.ReadLine();
                    if (UserInputEnemy == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Scout Selected");
                        EnemyHP = 125;
                        EnemyClass = Scout.ScoutName();
                        EnemyMaxHP = Scout.ScoutMaxHP();
                        EnemyPrimaryDamage = Scout.ScoutPrimaryDamage();
                        EnemySecondaryDamage = Scout.ScoutSecondaryDamage();
                        EnemyMeleeDamage = Scout.ScoutMeleeDamage();
                        EnemySpecial = Scout.ScoutPrimaryDamage();
                        EnemyPrimaryName = Scout.ScoutPrimaryName();
                        EnemySecondaryName = Scout.ScoutSecondaryName();
                        EnemyMeleeName = Scout.ScoutMeleeName();
                        EnemySpecialName = "No Special - Replaced By Primary";
                        Thread.Sleep(1000);
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
                        Console.WriteLine(".....");
                        Thread.Sleep(2000);
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "2")
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
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "3")
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
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "4")
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
                        Thread.Sleep(2000);
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "5")
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
                        Thread.Sleep(2000);
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "6")
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
                        Thread.Sleep(2000);
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "7")
                    {
                        Console.Clear();
                        Console.WriteLine("Enemy Medic Selected");
                        EnemyHP = 150;
                        EnemyClass = Medic.MedicName();
                        EnemyMaxHP = Medic.MedicMaxHP();
                        EnemyPrimaryDamage = Medic.MedicPrimaryDamage(EnemyCooldown);
                        EnemySecondaryDamage = Medic.MedicSecondaryDamage(EnemyCooldown);
                        EnemyMeleeDamage = Medic.MedicMeleeDamage(EnemyCooldown);
                        EnemySpecial = Medic.MedicPrimaryDamage(EnemyCooldown);
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
                        Thread.Sleep(2000);
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "8")
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
                        Thread.Sleep(2000);
                        EnemySetClass = true;
                    }
                    else if (UserInputEnemy == "9")
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
                        Thread.Sleep(2000);
                        EnemySetClass = true;
                    }
                    else
                    {
                        InputEnemy = true;
                    }

                }
            }
            #endregion
            if (EnemySetClass == true) //Game Start
            {
                while (GameInputOK == false)
                {
                    GameInputOK = true;
                    while (PlayerHP >= 0 && EnemyHP >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Header);
                        Console.WriteLine($"{PlayerName}'s Class is {PlayerClass} with {PlayerHP}/{PlayerMaxHP}"!);
                        Console.WriteLine($"The Enemy's Class is {EnemyClass} with {EnemyHP}/{EnemyMaxHP}");
                        if (PlayerClass == "Demoman")
                        {
                            Console.WriteLine($"Stickies Placed: {PlayerWeaponFeature}");
                        }
                        if (PlayerClass == "Medic")
                        {
                            if (PlayerCooldown == 0)
                            { 
                                Console.WriteLine("====Medigun Ready!====");
                            }
                            if (PlayerCooldown >= 1)
                            {
                                Console.WriteLine($"Medigun Cooldown: {PlayerCooldown} Turns Remaining");
                            }
                        }
                        if (PlayerClass == "Sniper")
                        {
                            Console.WriteLine($"Charge Level: {PlayerWeaponFeature}");
                        }
                        Console.WriteLine($"Actions:");
                        #region PlayerClass - Actions

                        if (PlayerClass == "Scout")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Soldier")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                            Console.WriteLine($"4. {PlayerSpecialName}");
                        }
                        if (PlayerClass == "Pyro")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Demoman")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}"); //Place Sticky
                            Console.WriteLine($"3. {PlayerSpecialName}"); //Detonate Stickies
                            Console.WriteLine($"4. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Heavy")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Engineer")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Medic")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Sniper")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSpecialName}");
                            Console.WriteLine($"3. {PlayerSecondaryName}");
                            Console.WriteLine($"4. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Spy")
                        {
                            Console.WriteLine($"1. {PlayerPrimaryName}");
                            Console.WriteLine($"2. {PlayerSecondaryName}");
                            Console.WriteLine($"3. {PlayerMeleeName}");
                        }
                        #endregion
                        string PlayerAction = Console.ReadLine();
                        if (PlayerClass == "Scout")
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Scout.ScoutPrimaryDamage();
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Scout.ScoutSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Scout.ScoutMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                        if (PlayerClass == "Soldier")
                        {
                           if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Soldier.SoldierPrimaryDamage();
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Soldier.SoldierSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Soldier.SoldierMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "4")
                            {
                                Console.WriteLine();
                                Console.WriteLine(Header);
                                Console.WriteLine($"{PlayerName} choose to attempt the Market Garden.");
                                Console.WriteLine(Footer);
                                Thread.Sleep(1000);
                                PlayerPrimaryDamage = Soldier.SoldierPrimaryDamage();
                                PlayerHP = PlayerHP - PlayerPrimaryDamage;
                                Console.WriteLine();
                                Console.WriteLine(Header);
                                Console.WriteLine($"You Took {PlayerPrimaryDamage} from the Rocket Jump.");
                                Console.WriteLine($"Your HP is now {PlayerHP}.");
                                Console.WriteLine(Footer);
                                Thread.Sleep(1000);
                                if (PlayerHP < 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(Header);
                                    Console.WriteLine("The Rocket Jump sent you to your grave instead of ");
                                    Console.WriteLine("your shovel to your enemy's face.");
                                    Console.WriteLine(" -- You need to watch your HP!");
                                    Console.WriteLine(Footer);
                                    Thread.Sleep(5000);
                                }
                                if (PlayerHP >= 0)
                                {
                                    PlayerSpecial = Soldier.SoldierSpecial();
                                    EnemyHP -= PlayerSpecial;
                                    if (PlayerSpecial == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(Header);
                                        Console.WriteLine($"You Missed the Market Garden!");
                                        Console.WriteLine($"The Enemy's HP is still {EnemyHP}");
                                        Console.WriteLine(Footer);
                                        Thread.Sleep(3000);
                                    }
                                    if (PlayerSpecial == 195)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(HeaderLong);
                                        Console.WriteLine($"You Hit the Market Garden and hit the enemy! You Dealt 195 Damage, their HP is now {EnemyHP}");
                                        Console.WriteLine(FooterLong);
                                        Thread.Sleep(3000);
                                    }
                                }
                            }
                        }
                        if (PlayerClass == "Pyro")
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Pyro.PyroPrimaryDamage();
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Pyro.PyroSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Pyro.PyroMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                        if (PlayerClass == "Demoman") // Finish Later
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage}! to the Enemy {EnemyClass}!");
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage}! to the Enemy {EnemyClass}!");
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage}! to the Enemy {EnemyClass}!");
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                        if (PlayerClass == "Heavy")
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Heavy.HeavyPrimaryDamage();
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Heavy.HeavySecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Heavy.HeavyMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                        if (PlayerClass == "Engineer")
                        { 
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Engineer.EngineerPrimaryDamage();
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Engineer.EngineerSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Engineer.EngineerMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                        if (PlayerClass == "Medic")
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Medic.MedicPrimaryDamage(PlayerCooldown);
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Medic.MedicSecondaryDamage(PlayerCooldown);
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Medic.MedicMeleeDamage(PlayerCooldown);
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                        if (PlayerClass == "Sniper")
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Sniper.SniperPrimaryDamage(PlayerWeaponFeature);
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Sniper.SniperSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Sniper.SniperMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                        if (PlayerClass == "Spy")
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Spy.SpySecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Spy.SpyMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage! to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                            }
                        }
                    }
                }
            }
        }
    }
}