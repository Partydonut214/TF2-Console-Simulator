﻿// TF2 Text Based Fighting Sim

using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace TF2_Simulator
{
    internal class Game
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("┌───────────┬────────────┐");
            Console.WriteLine("   What is your Name? ");
            Console.WriteLine("└───────────┴────────────┘");
            Console.Write("Name: ");
            string PlayerName = Console.ReadLine();
            Console.Clear();
            /* //Code is Cut out to improve design efficently, as the player can change their name again on the main screen.
            Console.WriteLine($"Would you like to have {PlayerName} as your name? [Y/N]");
            string Name_Answer = Console.ReadLine();
            if (Name_Answer.ToLower() == "n")
            {
                Console.Clear();
                Console.Write("Name: ");
                PlayerName = Console.ReadLine();
            }
            */
            string EnemyPrefix = "Enemy";

            #region Color Set and Check
            ConsoleColor Color_Game = ConsoleColor.Gray;
            ConsoleColor Color_Player = ConsoleColor.Gray;
            ConsoleColor Color_Enemy = ConsoleColor.Gray;
            ConsoleColor Color_Input = ConsoleColor.Gray;
            ConsoleColor BorderColor = ConsoleColor.Gray;
            string ColorResult = Colors.CheckName_for_Color(PlayerName);
            if (ColorResult != "none")
            {
                if (ColorResult == "SetRed") { Console.WriteLine("'red' found in your name, setting Game Color to Red...."); Color_Game = Color_Player = ConsoleColor.Red; }
                if (ColorResult == "SetYellow") { Console.WriteLine("'yellow' found in your name, setting Game Color to Yellow...."); Color_Game = Color_Player = ConsoleColor.Yellow; }
                if (ColorResult == "SetGreen") { Console.WriteLine("'green' found in your name, setting Game Color to Green...."); Color_Game = Color_Player = ConsoleColor.Green; }
                if (ColorResult == "SetBlue") { Console.WriteLine("'blue' found in your name, setting Game Color to Blue...."); Color_Game = Color_Player = ConsoleColor.Blue; }
                if (ColorResult == "SetPink") { Console.WriteLine("'pink' found in your name, setting Game Color to Pink...."); Color_Game = Color_Player = ConsoleColor.Magenta; }
                if (ColorResult == "SetGrey") { Console.WriteLine("'grey' found in your name, setting Game Color to Grey...."); Color_Game = Color_Player = ConsoleColor.DarkGray; }
                if (ColorResult == "SetDarkRed") { Console.WriteLine("'darkred' found in your name, setting Game Color to DarkRed...."); Color_Game = Color_Player = ConsoleColor.DarkRed; }
                if (ColorResult == "SetDarkYellow") { Console.WriteLine("'darkyellow' found in your name, setting Game Color to DarkYellow...."); Color_Game = Color_Player = ConsoleColor.DarkYellow; }
                if (ColorResult == "SetDarkGreen") { Console.WriteLine("'darkgreen' found in your name, setting Game Color to DarkGreen...."); Color_Game = Color_Player = ConsoleColor.DarkGreen; }
                if (ColorResult == "SetDarkBlue") { Console.WriteLine("'darkblue' found in your name, setting Game Color to DarkBlue...."); Color_Game = Color_Player = ConsoleColor.DarkBlue; }
                if (ColorResult == "SetDarkCyan") { Console.WriteLine("'darkcyan' found in your name, setting Game Color to DarkCyan...."); Color_Game = Color_Player = ConsoleColor.DarkCyan; }
                if (ColorResult == "SetDarkPurple") { Console.WriteLine("'purple' found in your name, setting Game Color to Purple...."); Color_Game = Color_Player = ConsoleColor.DarkMagenta; }
            }
            #endregion

            if (PlayerName == "")
            {
                PlayerName = "someone who apparently doesn't have a name";
            }

            #region Secret Names
            if (PlayerName == "Caden")
            {
                Console.Clear();
                Console.WriteLine("Sandy");
                Console.WriteLine("**************,.,*///*,..............,,,*///////////////....                    \r\n*,,,,**,.,**********/////,........*//*,,************/**,...                     \r\n,,. .,,,.,,,,,,,,,,,,,**/,,///(/*,*/****//**/*///***///***,..                   \r\n,,.............,,,,,..,,,,***////////////**,****,,,,,,,,*****,,.                \r\n............ ...,,,,,,,,,,*////////////**,.       . .......,,,**,,,.            \r\n.................,....,.....,///////**,..        ..........,,.....,,,,..        \r\n,,,,,..................,....,*********,.        ......,,,,,,........,,,,...     \r\n,,********,,..........,,,,,,*********,.        .,,,,,,,,....  .....,,,,,***,.   \r\n.,,*****//////**,,....,,,,**********,.        ..,,,,,.....,,,,,..,,,,****///**,.\r\n,,,***********//////*,,,,,,***,,****,.       ..,,,,,,,,,,,,,,,....,,*//***///*,,\r\n,,,,,,,,*****/////*******,,,,*,,,,,,,         .....,,,,,**,*,,,...,,*/##////////\r\n,,,,,,,,,**//*///*********,..,,,,,,..   .,,,,.,......,,****/,,*,,,.,*/###(//////\r\n,**********/*******,,..,,,,..,,,,,,.    .,,,,,,.  ....,,**/////*,**,*(#%###((((/\r\n.....,*//**,,,,,......,,,,,,,,,,,,.       .,,...   .....,*///((((/((((########(/\r\n((,.,*/(/***,,,,,,,*****,,,,,,,,...                 .......,*((((((((((*,,,,*//(\r\n//((((((/***,,,********,**,..,,... .    .             ....,,,,,,,****/,,,,.,.,,*\r\n((((((//****,,,,,,,,**********,....,.. ..              ...,,,,,,**,,.......,,,,,\r\n((((///*****,,,*******,*//*,//**..*(,......             ...................,,,,,\r\n//((//**********///*/**///(//((##(###(*,.....   .          ...................,,\r\n.*//***********//*//////((((((((########(,...   ...        .. ......,.....,,.,,,\r\n.*//*************////////////((/((((/((##(/,,  .,.......... . .......,,,,,,,,,,,\r\n,****,,,*,,*******///////*,,**////((/(((((/,,...,,..,,,,,...............,,.,,***\r\n.*///*,...,,,,********,,,,..     ,*/*////*..           ..........,,,,..,,*******\r\n,/((/*. ..,,,,,,,,,,***,,,,,,......,,,**,,,              ......,,,,,,,,******///\r\n((((/, ..,,,,,,,,,,,,*****,,,,,,,,...,,**//, .          ......,,,,,,,***///(((((\r\n////.  .,...,,,,,,,,,,,,,,,,,,,,,,,,,*/(###(##/,.. .....,,,,**********//(((#####\r\n(((/.     ...,,,,,,,,,,,,,,,,,,,,,,*(((####((%%##(/***,*/******/////(((#########\r\n///,,    ....,,,.,,******,,,,*****,,/((############(((/////(((((################\r\n//* .**///*,/***,,*****,,,,,,,,,,,,*,*///(/(((((/(((((/((((####%##%%%#%%%#######\r\n///**((((/./(,//,/********,,,,,,,,,,,,,,,,,********///(#####%%%%%%%%%%%%%%%%%%##\r\n///**(((#(.((,(/,/***************************/////((######%%%%%%%%%%%%%%%%%%%%%%\r\n///*/((((/,((,//*/*,*******////*******/////(#########%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Thread.Sleep(5000);
                Color_Player = ConsoleColor.DarkMagenta;
                Color_Enemy = ConsoleColor.DarkMagenta;
                Color_Game = ConsoleColor.DarkMagenta;
                Color_Input = ConsoleColor.DarkMagenta;
            }

            if (PlayerName.StartsWith("BLU "))
            {
                EnemyPrefix = "RED";
                Color_Player = ConsoleColor.DarkCyan;
                Color_Enemy = ConsoleColor.DarkRed;
                Color_Game = ConsoleColor.DarkCyan;
            }
            if (PlayerName.StartsWith("RED "))
            {
                EnemyPrefix = "BLU";
                Color_Player = ConsoleColor.DarkRed;
                Color_Enemy = ConsoleColor.DarkCyan;
                Color_Game = ConsoleColor.DarkRed;
            }
            if (PlayerName.StartsWith("GRN "))
            {
                EnemyPrefix = "YLW";
                Color_Player = ConsoleColor.DarkGreen;
                Color_Enemy = ConsoleColor.DarkYellow;
                Color_Game = ConsoleColor.DarkGreen;
            }
            if (PlayerName.StartsWith("YLW "))
            {
                EnemyPrefix = "GRN";
                Color_Player = ConsoleColor.DarkYellow;
                Color_Enemy = ConsoleColor.DarkGreen;
                Color_Game = ConsoleColor.DarkYellow;
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
            /*
            #region TF2 Extra Teams
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
            #endregion
            */
            #region YT
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
            #endregion
            #region Other Games
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
            #endregion

            int P1_ThreadSleep = 4000;
            int E1_ThreadSleep = 4000;
            bool SkipDebug = false;


            #region Dividers & Borders
            string Header = "┌────────────────────────┬────────────────────────┐";
            string Footer = "└────────────────────────┴────────────────────────┘";
            string HeaderShort = "┌───────────────┬───────────────┐";
            string FooterShort = "└───────────────┴───────────────┘";
            string HeaderLong = "┌────────────────────────────────────────────────┬────────────────────────────────────────────────┐";
            string FooterLong = "└────────────────────────────────────────────────┴────────────────────────────────────────────────┘";
            string BarLoaded = "█";
            string BarUnloaded = "▒";
            #endregion

            bool GAMERESET = true;
            bool QuittingGame = false;
            while (GAMERESET == true)
            {
                GAMERESET = false;
                #region PlayerStats V2
                //Information
                int P1_Health = 0;
                int P1_MaxHP = 0;
                int P1_ClassID = 0;
                string P1_ClassName = "Not Set";
                int P1_PrimaryWeaponID = 0;
                int P1_SecondaryWeaponID = 0;
                int P1_MeleeWeaponID = 0;
                string P1_SecondaryTriggerName = "";
                string P1_SecondaryFunctionAttackString = "None";
                string P1_SecondaryFunctionShort = "None";
                int P1_WeaponSpecialStat = 0;
                int P1_Commitment = 0;
                //Status
                int P1_Cooldown_P = 0; //Primary
                int P1_Cooldown_S = 0; //Secondary
                int P1_Cooldown_M = 0; //Melee
                int P1_Cooldown_E = 0; //Extra
                int P1_Cooldown_Damage = 0; //Damage Based

                //Switches
                bool P1_RoboSandvichResist = false;

                int P1_StatusEffect_1_ID = 0;
                int P1_StatusEffect_2_ID = 0;
                int P1_StatusEffect_3_ID = 0;
                int P1_StatusOnFireCooldown = 0;
                int P1_StatusJaratedCooldown = 0;
                int P1_StatusMadMilkedCooldown = 0;
                int P1_StatusBleedingCooldown = 0;
                int P1_StatusMFDCooldown = 0;
                int P1_SecondaryTrigger = 0;
                bool P1_SecondaryTriggerExists = false;
                //Value Holders
                int P1_Damage = 0;
                #endregion

                #region Enemystats V2
                //Information
                int E1_Health = 0;
                int E1_MaxHP = 0;
                int E1_ClassID = 0;
                string E1_ClassName = "Not Set";
                int E1_PrimaryWeaponID = 0;
                int E1_SecondaryWeaponID = 0;
                int E1_MeleeWeaponID = 0;
                string E1_SecondaryTriggerName = "";
                string E1_SecondaryFunctionAttackString = "None";
                string E1_SecondaryFunctionShort = "None";
                int E1_WeaponSpecialStat = 0;
                //Status
                int E1_Cooldown_P = 0; //Primary
                int E1_Cooldown_S = 0; //Secondary
                int E1_Cooldown_M = 0; //Melee
                int E1_Cooldown_E = 0; //Extra
                int E1_Cooldown_Damage = 0; //Damage Based
                int E1_Cooldown = 0;
                int E1_StatusEffect_1_ID = 0;
                int E1_StatusEffect_2_ID = 0;
                int E1_StatusEffect_3_ID = 0;
                int E1_StatusOnFireCooldown = 0;
                int E1_StatusJaratedCooldown = 0;
                int E1_StatusMadMilkedCooldown = 0;
                int E1_StatusBleedingCooldown = 0;
                int E1_StatusMFDCooldown = 0;
                int E1_SecondaryTrigger = 0;
                bool E1_SecondaryTriggerExists = false;

                //Switches
                bool E1_RoboSandvichResist = false;

                //Value Holders
                int E1_Damage = 0;
                #endregion

                #region Weapon Lists
                #region Weapons with Special Mechanics
                List<int> Weapons_SpecialFunction = new List<int>
                {
                    21,
                    28
                };
 
                List<int> PrimaryWeapons_SlotStealers = new List<int>
            {
                46, // B.A.S.E. Jumper
                82, // Ali Baba's Wee Booties
                83, // Bootlegger

            };
                List<int> SecondaryWeapons_SlotStealers = new List<int>
            {
                40, // Buff Banner
                41, // Gunboats
                42, // Battalion's Backup
                43, // Concheror
                44, // Mantreads
                46, // B.A.S.E. Jumper
                88, // Chargin' Targe
                90, // Splendid Screen
                91, // Tide Turner
                169, // Razorback
                170, // Darwin's Danger Shield
                171, // Cozy Camper

            };
                List<int> Demoman_SecondaryWeapons_StickyBombLaunchers = new List<int>
            {
                86, // Stickybomb Launcher
                87, // Scottish Resistance
                89, // Sticky Jumper
                92, // Quickiebomb Launcher
            };  
                
                List<int> Heavy_Lunchbox = new List<int>
            {
                111, // Sandvich
                112, // Robo-Sandvich
                113, // Dalokohs Bar
                114, // Fishcake
                115, // Buffalo Steak Sandvich
            };

                List<int> Sniper_PrimaryWeapons_Charging = new List<int>
            {
                155, // Sniper Rifle
                156, // AWPer Hand
                159, // Sydney Sleeper
                160, // Bazzar Bargain
                161, // Machina
                162, // Shooting Star
                163, // Hitman's Heatmaker
                164, // Classic
            };
                List<int> Sniper_PrimaryWeapons_Bows = new List<int>
            {
                157, // Huntsman
                158, // Fortified Compound
            };

                List<int> Medic_PrimaryWeapons = new List<int>
            {
                142,
                143,
                144,
                145,
            };

                List<int> Medic_SecondaryWeapons = new List<int>
            {
                146, // Medigun
                147, // Kritzkrieg
                148, // Quick-Fix
                149, // Vaccinator
            };
                #endregion

                #region "Elemental" Weapons
                List<int> PrimaryWeapons_CanInflictFire = new List<int>
            {
                35, // Cow Mangler 5000
                55, // Flame Thrower
                56, // Rainblower
                57, // Nostromo Napalmer
                58, // Backburner
                59, // Degreaser
                60, // Phlogistinator
                61, // Dragon's Fury
                109, // Huo-Long Heater
            };

                List<int> Attack_HealWeapons = new List<int>
            {
                130,
                32,
            };

                List<int> SecondaryWeapons_CanInflictFire = new List<int>
                {
                    62,	// Flare Gun
                    63, // Detonator
                    64, // Manmelter
                    65, // Scorch Shot
                };
                List<int> MeleeWeapons_CanInflictFire = new List<int>
                {
                    25, //Scout - Sun on a Stick
                    76, //Sharpened Volcano Fragment
                };

                List<int> PrimaryWeapons_CanInflictJarate = new List<int>
                {
                    // Sydney Sleeper
                };
                List<int> SecondaryWeapons_CanInflictJarate = new List<int>
                {
                    167,
                };
                #endregion
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
                Console.Clear();
                while (InputOK == false)
                {
                    InputOK = true;
                    Console.WriteLine();
                    Console.ForegroundColor = Color_Player;
                    Console.WriteLine($"Welcome {PlayerName}!");
                    Console.ForegroundColor = Color_Enemy;
                    Console.WriteLine($"Enemy Prefix: {EnemyPrefix}");
                    Console.ForegroundColor = Color_Game;
             //     Console.WriteLine("Pick your class! or type '!Help' to view the class choices and other important info!");
                    Console.WriteLine("Pick your class from the List below, or pick from any of the Quick Commands!");
                    Console.WriteLine();
                    Console.WriteLine(HeaderShort);
                    //Console.WriteLine("====Available Classes====");
                    Console.WriteLine("  1. Scout");
                    Console.WriteLine("  2. Soldier");
                    Console.WriteLine("  3. Pyro");
                    Console.WriteLine("  4. Demoman");
                    Console.WriteLine("  5. Heavy");
                    Console.WriteLine("  6. Engineer");
                    Console.WriteLine("  7. Medic");
                    Console.WriteLine("  8. Sniper");
                    Console.WriteLine("  9. Spy");
                    Console.WriteLine(FooterShort);
                    Console.WriteLine(HeaderShort);
                    //Console.WriteLine("┌───────────────┬───────────────┐");
                    Console.WriteLine($"  Quick Commands");
             //     Console.WriteLine($"  10. Help");
                    Console.WriteLine($"  11. Clear Color(s)");
                    Console.WriteLine($"  12. Set Game Colors");
                    Console.WriteLine($"  13. Set Enemy Prefix");
                    Console.WriteLine($"  14. Change Turn Timers");
                    Console.WriteLine($"  15. Disable Debug Info: {SkipDebug}");
                    Console.WriteLine($"  16. Change Player Name");

                    Console.WriteLine(FooterShort);
                    //Console.WriteLine("=========================");
                    Console.WriteLine();
                    Console.Write("Choose a Class, or type a Command: ");
                    Console.ForegroundColor = Color_Input;

                    string UserInput = Console.ReadLine();
                    #region Player Commands
                    if (UserInput.ToLower() == "clearcolor" || UserInput == "11")
                    {
                        Console.ResetColor();
                        Color_Player = ConsoleColor.White;
                        Color_Game = ConsoleColor.White;
                        Color_Enemy = ConsoleColor.White;
                        Color_Input = ConsoleColor.White;
                        Console.WriteLine("Color Cleared.");
                        Thread.Sleep(1000);
                        InputOK = false;
                    }
                    if (UserInput == "12")
                    {
                        Console.Clear();
                        Console.ResetColor();
                        Console.ForegroundColor = Color_Game;
                        Console.WriteLine(HeaderShort);
                        Console.WriteLine("  1. Set Game Color");
                        Console.ForegroundColor = Color_Player;
                        Console.WriteLine("  2. Set Player's Color");
                        Console.ForegroundColor = Color_Enemy;
                        Console.WriteLine("  3. Set Enemy's Color");
                        Console.ForegroundColor = Color_Input;
                        Console.WriteLine("  4. Set Input Color");
                        Console.ForegroundColor = Color_Game;
                        Console.WriteLine(FooterShort);
                        Console.WriteLine();
                        Console.Write("Action: ");
                        Console.ForegroundColor = Color_Input;

                        string ColorChoice = Console.ReadLine();
                        if (ColorChoice == "1")
                        {
                            Console.WriteLine(HeaderShort);
                            Console.WriteLine("  Setting Game's Color");
                            Console.WriteLine("  Color List:");
                            Console.WriteLine("- Red");
                            Console.WriteLine("- Yellow");
                            Console.WriteLine("- Green");
                            Console.WriteLine("- Blue");
                            Console.WriteLine("- Cyan");
                            Console.WriteLine("- Purple");
                            Console.WriteLine("- Pink");
                            Console.WriteLine("- White");
                            Console.WriteLine("- Dark Red");
                            Console.WriteLine("- Dark Yellow");
                            Console.WriteLine("- Dark Green");
                            Console.WriteLine("- Dark Blue");
                            Console.WriteLine("- Dark Cyan");
                            Console.WriteLine("- Dark Grey");
                            Console.Write("  -Color Choice: ");
                            string GameColorChoice = Console.ReadLine();
                            Color_Game = Colors.SetColor(GameColorChoice);
                            if (Color_Game != ConsoleColor.Gray)
                            {
                                Console.WriteLine($"Game Color set to {Color_Game}");
                                Thread.Sleep(1000);
                            }
                            if (Color_Game == ConsoleColor.Gray)
                            {
                                Console.WriteLine("There was an error. The color was set back to Grey.");
                                Thread.Sleep(3000);
                                InputOK = false;
                            }

                        }
                        if (ColorChoice == "2")
                        {
                            Console.WriteLine(HeaderShort);
                            Console.WriteLine("  Setting Player's Color");
                            Console.WriteLine("  Color List:");
                            Console.WriteLine("- Red");
                            Console.WriteLine("- Yellow");
                            Console.WriteLine("- Green");
                            Console.WriteLine("- Blue");
                            Console.WriteLine("- Cyan");
                            Console.WriteLine("- Purple");
                            Console.WriteLine("- Pink");
                            Console.WriteLine("- White");
                            Console.WriteLine("- Dark Red");
                            Console.WriteLine("- Dark Yellow");
                            Console.WriteLine("- Dark Green");
                            Console.WriteLine("- Dark Blue");
                            Console.WriteLine("- Dark Cyan");
                            Console.WriteLine("- Dark Grey");
                            Console.Write("  -Color Choice: ");
                            string PlayerColorChoice = Console.ReadLine();
                            Color_Player = Colors.SetColor(PlayerColorChoice);
                            if (Color_Player != ConsoleColor.Gray)
                            {
                                Console.WriteLine($"Game Color set to {Color_Player}");
                                Thread.Sleep(1000);
                            }
                            if (Color_Player == ConsoleColor.Gray)
                            {
                                Console.WriteLine("There was an error. The color was set back to Grey.");
                                Thread.Sleep(5000);
                                InputOK = false;
                            }

                        }
                        if (ColorChoice == "3")
                        {
                            Console.WriteLine(HeaderShort);
                            Console.WriteLine("  Setting Enemy's Color");
                            Console.WriteLine("  Color List:");
                            Console.WriteLine("- Red");
                            Console.WriteLine("- Yellow");
                            Console.WriteLine("- Green");
                            Console.WriteLine("- Blue");
                            Console.WriteLine("- Cyan");
                            Console.WriteLine("- Purple");
                            Console.WriteLine("- Pink");
                            Console.WriteLine("- White");
                            Console.WriteLine("- Dark Red");
                            Console.WriteLine("- Dark Yellow");
                            Console.WriteLine("- Dark Green");
                            Console.WriteLine("- Dark Blue");
                            Console.WriteLine("- Dark Cyan");
                            Console.WriteLine("- Dark Grey");
                            Console.Write("  -Color Choice: ");
                            string EnemyColorChoice = Console.ReadLine();
                            Color_Enemy = Colors.SetColor(EnemyColorChoice);
                            if (Color_Enemy != ConsoleColor.Gray)
                            {
                                Console.WriteLine($"Game Color set to {Color_Enemy}");
                                Thread.Sleep(1000);
                            }
                            if (Color_Enemy == ConsoleColor.Gray)
                            {
                                Console.WriteLine("There was an error. The color was set back to Grey.");
                                Thread.Sleep(5000);
                                InputOK = false;
                            }
                        }
                        if (ColorChoice == "4")
                        {
                            Console.WriteLine(HeaderShort);
                            Console.WriteLine("  Setting Input's Color");
                            Console.WriteLine("  Color List:");
                            Console.WriteLine("- Red");
                            Console.WriteLine("- Yellow");
                            Console.WriteLine("- Green");
                            Console.WriteLine("- Blue");
                            Console.WriteLine("- Cyan");
                            Console.WriteLine("- Purple");
                            Console.WriteLine("- Pink");
                            Console.WriteLine("- White");
                            Console.WriteLine("- Dark Red");
                            Console.WriteLine("- Dark Yellow");
                            Console.WriteLine("- Dark Green");
                            Console.WriteLine("- Dark Blue");
                            Console.WriteLine("- Dark Cyan");
                            Console.WriteLine("- Dark Grey");
                            Console.Write("  -Color Choice: ");
                            string InputColorChoice = Console.ReadLine();
                            Color_Input = Colors.SetColor(InputColorChoice);
                            if (Color_Input != ConsoleColor.Gray)
                            {
                                Console.WriteLine($"Input Color set to {Color_Input}");
                                Thread.Sleep(1000);
                            }
                            if (Color_Input == ConsoleColor.Gray)
                            {
                                Console.WriteLine("There was an error. We set the color back to Grey.");
                                Thread.Sleep(5000);
                                InputOK = false;
                            }

                        }
                        if (ColorChoice == "5")
                        {
                            Console.WriteLine(HeaderShort);
                            Console.WriteLine("  Setting Border's Color");
                            Console.WriteLine("  Color List:");
                            Console.WriteLine("- Red");
                            Console.WriteLine("- Yellow");
                            Console.WriteLine("- Green");
                            Console.WriteLine("- Blue");
                            Console.WriteLine("- Cyan");
                            Console.WriteLine("- Purple");
                            Console.WriteLine("- Pink");
                            Console.WriteLine("- White");
                            Console.WriteLine("- Dark Red");
                            Console.WriteLine("- Dark Yellow");
                            Console.WriteLine("- Dark Green");
                            Console.WriteLine("- Dark Blue");
                            Console.WriteLine("- Dark Cyan");
                            Console.WriteLine("- Dark Grey");
                            Console.Write("  -Color Choice: ");
                            string BorderColorChoice = Console.ReadLine();
                            Color_Input = Colors.SetColor(BorderColorChoice);
                            if (BorderColor != ConsoleColor.Gray)
                            {
                                Console.WriteLine($"Game Color set to {BorderColor}");
                                Thread.Sleep(1000);
                            }
                            if (BorderColor == ConsoleColor.Gray)
                            {
                                Console.WriteLine("There was an error. We set the color back to Grey.");
                                Thread.Sleep(5000);
                                InputOK = false;
                            }

                        }
                    }
                    if (UserInput == "13")
                    {
                        Console.Clear();
                        Console.ForegroundColor = Color_Game;
                        Console.WriteLine(HeaderShort);
                        Console.ForegroundColor = Color_Enemy;
                        Console.WriteLine($"  Enemy Prefix: {EnemyPrefix}");
                        Console.ForegroundColor = Color_Game;
                        Console.WriteLine("  Enter a New One, or keep blank to keep current one.");
                        Console.Write("New Prefix: ");
                        Console.ForegroundColor = Color_Input;
                        string PrefixInput = Console.ReadLine();
                        if (PrefixInput == "")
                        {
                            Console.WriteLine($"Prefix Unchanged: {EnemyPrefix}");
                        }
                        if (PrefixInput != "")
                        {
                            EnemyPrefix = PrefixInput;
                            Console.WriteLine($"Prefix Changed to: {EnemyPrefix}");
                        }
                    }
                    /*
                    if (UserInput == "14")
                    {
                        Console.WriteLine("Select a Class to Preview a Loadout");
                        Console.Write("Class: ");
                        string classchoice = Console.ReadLine();
                        if (int.TryParse(classchoice, out int ClassID))
                        {
                            P1_ClassID = ClassID;
                            Console.WriteLine(PrimaryWeapons.Names(ClassID));
                            Thread.Sleep(5000);
                        }
                    }
                    */
                    if (UserInput == "14")
                    {
                        Console.Clear();
                        Console.ForegroundColor = Color_Game;
                        Console.WriteLine(Header);
                        Console.WriteLine($"  Changing Information Display Times");
                        Console.WriteLine($"  1. Player Time: {P1_ThreadSleep}");
                        Console.WriteLine($"  2. Enemy Time: {E1_ThreadSleep}");
                        Console.WriteLine(Footer);
                        Console.Write("Action: "); Console.ForegroundColor = Color_Input;
                        string Choice_Timers = Console.ReadLine();
                        if (Choice_Timers == "1")
                        {
                            Console.WriteLine(HeaderShort);
                            Console.WriteLine($"  Player Timer: {P1_ThreadSleep}");
                            Console.WriteLine($"  Set the Timer [1000 = 1 Second]");
                            Console.WriteLine(FooterShort);
                            Console.Write("Time: ");
                            string DisplayInput = Console.ReadLine();
                            if (int.TryParse(DisplayInput, out int PlayerTimer))
                            {
                                P1_ThreadSleep = PlayerTimer;
                                Console.WriteLine($"  Set Timer to {P1_ThreadSleep} Milliseconds");
                            }
                        }
                        if (Choice_Timers == "2")
                        {
                            Console.WriteLine(HeaderShort);
                            Console.WriteLine($"  Enemy Timer: {E1_ThreadSleep}");
                            Console.WriteLine($"  Set the Timer [1000 = 1 Second]");
                            Console.WriteLine(FooterShort);
                            Console.Write("Time: ");
                            string DisplayInput = Console.ReadLine();
                            if (int.TryParse(DisplayInput, out int EnemyTimer))
                            {
                                E1_ThreadSleep = EnemyTimer;
                                Console.WriteLine($"  Set Timer to {E1_ThreadSleep} Milliseconds");
                            }
                        }
                    }
                    if (UserInput == "15")
                    {
                        Console.WriteLine($"  {HeaderShort}");
                        if (SkipDebug == false)
                        {
                            SkipDebug = true;
                        }
                        else
                        {
                            SkipDebug = false;
                        }
                        Console.WriteLine($"    SkipDebug = {SkipDebug}");
                        Console.WriteLine($"  {FooterShort}");
                        Thread.Sleep(1200);
                    }
                    if (UserInput == "16")
                    {
                        Console.WriteLine(HeaderShort);
                        Console.WriteLine($"  Set Player Name:");
                        Console.WriteLine(FooterShort);
                        Console.Write("Name: ");
                        PlayerName = Console.ReadLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new String(' ', Console.BufferWidth));
                        Console.WriteLine(HeaderShort);
                        Console.WriteLine($"Setting Player's Name to {PlayerName}");
                        Console.WriteLine(FooterShort);
                        Thread.Sleep(2500);

                    }
                    #endregion

                    #region Help Menu
                    /*
                    if ((UserInput.ToLower() == "!help") || (UserInput.ToLower() == "help") || UserInput == "10")
                    {
                        bool InputOKHelp = false;
                        while (InputOKHelp == false)
                        {
                            InputOKHelp = true;
                            Console.Clear();
                            Console.WriteLine("====Help Topics====");
                            Console.WriteLine("Select Using Numbers, or type 'Back' to go back");
                            Console.WriteLine("1. Classes");
                            Console.WriteLine("2. About the Game");
                            Console.WriteLine("3. Commands");
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
                            else if (HelpInput == "3")
                            {
                                Console.Clear();
                                Console.WriteLine("-- ClearColor -- Works on the Main Menu, will reverse any colors back to normal");
                                Console.Write("Press Enter to Go Back:");
                                string GoBack = Console.ReadLine();
                                if (GoBack != null)
                                {
                                    InputOKHelp = false;
                                }
                            }
                            else if (HelpInput.ToLower() == "back")
                            {
                                InputOK = false;
                            }
                            else
                            {
                                InputOKHelp = false;
                                Console.Clear();
                            }
                        }
                    }
                    */
                    #endregion
                    #region Player Classes
                    if (int.TryParse(UserInput, out int ClassChoice))
                    {
                        if (ClassChoice >= 1 && ClassChoice <= 9)
                        {
                            Console.Clear();
                            Console.ResetColor();
                            Console.ForegroundColor = Color_Game;
                            P1_ClassID = ClassChoice;
                            P1_ClassName = Classes.ClassNamefromID(P1_ClassID);
                            P1_Health = Classes.ClassHealthfromID(P1_ClassID);
                            P1_MaxHP = P1_Health;
                            P1_PrimaryWeaponID = Classes.StockPrimaryWeapon(P1_ClassID);
                            P1_SecondaryWeaponID = Classes.StockSecondaryWeapon(P1_ClassID);
                            P1_MeleeWeaponID = Classes.StockMeleeWeapon(P1_ClassID);
                            if (P1_ClassID == 8)
                            {
                                P1_WeaponSpecialStat = 1;
                            }
                            if (P1_ClassID == 7)
                            {
                                P1_Cooldown_S = 4;
                            }
                            if (SkipDebug == false)
                            {
                                Console.WriteLine(Header);
                                Console.WriteLine($"  ClassID: {P1_ClassID}");
                                Console.WriteLine($"  Player Class: {P1_ClassName}");
                                Console.WriteLine($"  Health: {P1_Health}/{P1_MaxHP}");
                                Console.WriteLine(Footer);
                                Thread.Sleep(2000);
                            }
                            Console.WriteLine();
                            Console.WriteLine(Header);
                            bool Selecting_Loadout = true;
                            while (Selecting_Loadout == true)
                            {

                                Selecting_Loadout = false;
                                Console.ForegroundColor = Color_Game;
                                Console.Clear();
                                Console.WriteLine(Header);
                                Console.WriteLine($"  ClassID: {P1_ClassID}");
                                Console.WriteLine($"  Player Class: {P1_ClassName}");
                                Console.WriteLine($"  Health: {P1_Health}/{P1_MaxHP}");
                                Console.WriteLine(Footer);
                                Console.WriteLine();
                                Console.WriteLine(Header);
                                Console.WriteLine($"Select your Loadout!");
                                Console.WriteLine($"1.  Primary Weapon: {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}");
                                Console.WriteLine($"2.  Secondary Weapon: {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}");
                                Console.WriteLine($"3.  Melee Weapon: {MeleeWeapons.SpecificWeaponName(P1_MeleeWeaponID)}");
                                Console.WriteLine($"4.  Finish Setting up Loadout");
                                Console.WriteLine(Footer);
                                Console.Write($"Choice: "); Console.ForegroundColor = Color_Input;
                                string LoadoutChoice = Console.ReadLine();
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                Console.Write(new String(' ', Console.BufferWidth));
                                if (LoadoutChoice == "1")
                                {
                                    //Console.Clear();
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(Header);
                                    Console.WriteLine($"  === Class: {P1_ClassName}");
                                    Console.WriteLine($"  === Selecting Primary Weapon");
                                    Console.WriteLine(PrimaryWeapons.Names(P1_ClassID));
                                    Console.WriteLine(Footer);
                                    Console.Write("Weapon ID: "); Console.ForegroundColor = Color_Input;
                                    string PrimarySelecion = Console.ReadLine();
                                    if (int.TryParse(PrimarySelecion, out int PrimaryID)) { P1_PrimaryWeaponID = PrimaryID; }
                                    if (SkipDebug == false)
                                    {
                                        Console.WriteLine($"Primary Weapon: {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}");
                                        Console.WriteLine($"Attack: {PrimaryWeapons.Attack(P1_ClassID, P1_PrimaryWeaponID, P1_Cooldown_P, P1_SecondaryTriggerExists, P1_WeaponSpecialStat)}");
                                        Thread.Sleep(1500);
                                    }
                                    Selecting_Loadout = true;
                                }
                                if (LoadoutChoice == "2")
                                {
                                    //Console.Clear();
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(Header);
                                    Console.WriteLine($"  === Class: {P1_ClassName}");
                                    Console.WriteLine($"  === Selecting Secondary Weapon");
                                    Console.WriteLine(SecondaryWeapons.Names(P1_ClassID));
                                    Console.WriteLine(Footer);
                                    Console.Write("Weapon ID: "); Console.ForegroundColor = Color_Input;
                                    string SecondarySelecion = Console.ReadLine();
                                    if (int.TryParse(SecondarySelecion, out int SecondaryID)) { P1_SecondaryWeaponID = SecondaryID; }
                                    if (SkipDebug == false)
                                    {
                                        Console.WriteLine($"Secondary Weapon: {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}");
                                        Console.WriteLine($"Attack: {SecondaryWeapons.Attack(P1_ClassID, P1_SecondaryWeaponID, P1_Cooldown_S, P1_SecondaryTriggerExists, P1_WeaponSpecialStat)}");
                                        Thread.Sleep(1500);
                                    }
                                    Selecting_Loadout = true;
                                }
                                if (LoadoutChoice == "3")
                                {
                                    //Console.Clear();
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(Header);
                                    Console.WriteLine($"  === Class: {P1_ClassName}");
                                    Console.WriteLine($"  === Selecting Melee Weapon");
                                    Console.WriteLine(MeleeWeapons.Names(P1_ClassID));
                                    Console.WriteLine(Footer);
                                    Console.Write("Weapon ID: "); Console.ForegroundColor = Color_Input;
                                    string MeleeSelecion = Console.ReadLine();
                                    if (int.TryParse(MeleeSelecion, out int MeleeID)) { P1_MeleeWeaponID = MeleeID; }
                                    if (SkipDebug == false)
                                    {
                                        Console.WriteLine($"Melee Weapon: {MeleeWeapons.SpecificWeaponName(P1_MeleeWeaponID)}");
                                        Console.WriteLine($"Attack: {MeleeWeapons.Attack(P1_ClassID, P1_MeleeWeaponID, P1_Cooldown_M, P1_SecondaryTriggerExists, P1_Health, P1_MaxHP)}");
                                        Thread.Sleep(1500);
                                    }
                                    Selecting_Loadout = true;
                                }
                                if (LoadoutChoice == "4")
                                {

                                    PlayerSetClass = true;
                                    break;
                                }
                                else
                                {
                                    Selecting_Loadout = true;
                                }
                            }
                        }
                        else if (ClassChoice < 0 || ClassChoice > 10)
                        {
                            Console.Clear();
                            InputOK = false;

                        }
                        else
                        {
                            Console.Clear();
                            InputOK = false;
                        }
                    }
                    #endregion
                    #region Tests
                    else if (UserInput.ToLower() == "print_all")
                    {
                        for (int i = 0; i < 210; i++)
                        {
                            string name = "";
                            name = PrimaryWeapons.SpecificWeaponName(i);
                            Console.WriteLine(name);
                            Console.WriteLine();

                        }
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
                        Console.WriteLine("-- Close //Easily the greatest cheat & secret of all");
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
                                PlayerSpecial = Sniper.SniperSecondaryDamage();
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
                                PlayerSpecial = Sniper.SniperSecondaryDamage();
                                Console.WriteLine($"Total Damage {PlayerSpecial}");
                                Console.WriteLine($"Charge Level When Shot: {PlayerWeaponFeature}");
                                PlayerWeaponFeature = 1;
                                Console.WriteLine($"Current Charge Level: {PlayerWeaponFeature}");
                                Console.WriteLine(Footer);
                                Thread.Sleep(2000);
                            }
                        }

                    }
                    else if (UserInput.ToLower() == "quit")
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
                    else if (UserInput.ToLower() == "minicrit test")
                    {
                        // Test Results: Mini-Crits [+35%] work. Mostly. It will Always round down to the Nearest Whole Number.
                        // This test worked first try so I am not going to be picky.
                        // Crits also work. [x3]
                        // Code: DAMAGE = DAMAGE + (35 * DAMAGE / 100) || Damage[33] == Damage[33] + (35 * [33] / 100) = Damage[44.5] --> Damage[44]
                        Console.Clear();
                        string CritInput = Console.ReadLine();
                        while (CritInput.ToLower() != "quit")
                        {
                            for (int g = 0; g < 5; g++)
                            {
                                Random damage = new Random();
                                int Totaldamage = 0;
                                int BulletsFired = damage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                                for (int i = 0; i < BulletsFired; i++)
                                { Totaldamage = Totaldamage + damage.Next(6, 13); } // creates a number between 6 & 12 [Damage]
                                Console.WriteLine($"Normal Attack: {Totaldamage}");
                            }
                            Console.WriteLine("Type 'Mini-Crits' to add Mini-Crits, 'Crits' for Crits, or anything else to restart this loop.");
                            CritInput = Console.ReadLine();
                            if (CritInput.ToLower() == "crits")
                            {
                                for (int g = 0; g < 5; g++)
                                {
                                    Random damage = new Random();
                                    int Totaldamage = 0;
                                    int BulletsFired = damage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                                    for (int i = 0; i < BulletsFired; i++)
                                    { Totaldamage = Totaldamage + damage.Next(6, 13); } // creates a number between 6 & 12 [Damage]
                                    Console.WriteLine($"Normal Attack: {Totaldamage}");
                                    Totaldamage = Totaldamage * 3;
                                    Console.WriteLine($"Crit Attack [x3]: {Totaldamage}");
                                }
                            }
                            if (CritInput.ToLower() == "mini-crits")
                            {
                                for (int g = 0; g < 5; g++)
                                {
                                    Random damage = new Random();
                                    int Totaldamage = 0;
                                    int BulletsFired = damage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                                    for (int i = 0; i < BulletsFired; i++)
                                    { Totaldamage = Totaldamage + damage.Next(6, 13); } // creates a number between 6 & 12 [Damage]
                                    Console.WriteLine($"Attack before Minicrits: {Totaldamage} ");
                                    Totaldamage = Totaldamage + (35 * Totaldamage / 100);
                                    Console.WriteLine($"Attack after adding Mini-Crits [+35%] {Totaldamage}");
                                }
                            }
                        }
                    }
                    else if (UserInput.ToLower() == "airstrike")
                    {
                        //This thing is stupidly overpowered. good thing this is a random drop.
                        Random ran = new Random();
                        int damage = 0;
                        int Special = 0;
                        string airstikeinput = Console.ReadLine();
                        while (airstikeinput.ToLower() != "quit")
                        {
                            Special++;
                            for (int i = 0; i < Special; i++)
                            {
                                damage = damage + ran.Next(12, 22);
                            }
                            Console.WriteLine(damage);
                        }
                    }
                    #endregion
                    #region MainMenu Reset
                    else
                    {
                        InputOK = false;
                        Console.Clear();
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
                        Console.ForegroundColor = Color_Game;
                        Console.Clear();
                        Console.WriteLine("Pick The Enemy's class!");
                        Console.WriteLine();
                        Console.WriteLine(HeaderShort);
                        //Console.WriteLine("====Available Classes====");
                        Console.WriteLine("  1. Scout");
                        Console.WriteLine("  2. Soldier");
                        Console.WriteLine("  3. Pyro");
                        Console.WriteLine("  4. Demoman");
                        Console.WriteLine("  5. Heavy");
                        Console.WriteLine("  6. Engineer");
                        Console.WriteLine("  7. Medic");
                        Console.WriteLine("  8. Sniper");
                        Console.WriteLine("  9. Spy");
                        Console.WriteLine(FooterShort);
                        //Console.WriteLine("=========================");
                        Console.WriteLine();
                        Console.Write("Choose a Class: "); Console.ForegroundColor = Color_Input;
                        string UserInputEnemy = Console.ReadLine();
                        if (int.TryParse(UserInputEnemy, out int ClassChoice))
                        {
                            if (ClassChoice >= 1 && ClassChoice <= 9)
                            {
                                Console.Clear();
                                Console.ResetColor();
                                Console.ForegroundColor = Color_Game;
                                E1_ClassID = ClassChoice;
                                E1_ClassName = Classes.ClassNamefromID(E1_ClassID);
                                E1_Health = Classes.ClassHealthfromID(E1_ClassID);
                                E1_MaxHP = E1_Health;
                                E1_PrimaryWeaponID = Classes.StockPrimaryWeapon(E1_ClassID);
                                E1_SecondaryWeaponID = Classes.StockSecondaryWeapon(E1_ClassID);
                                E1_MeleeWeaponID = Classes.StockMeleeWeapon(E1_ClassID);
                                if (SkipDebug == false)
                                {
                                    Console.WriteLine(Header);
                                    Console.WriteLine($"  ClassID: {E1_ClassID}");
                                    Console.WriteLine($"  Player Class: {E1_ClassName}");
                                    Console.WriteLine($"  Health: {E1_Health}/{E1_MaxHP}");
                                    Console.WriteLine(Footer);
                                    Thread.Sleep(2000);
                                }
                                Console.WriteLine();
                                Console.WriteLine(Header);
                                bool Selecting_Loadout = true;
                                while (Selecting_Loadout == true)
                                {
                                    Selecting_Loadout = false;
                                    Console.Clear();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(Header);
                                    Console.WriteLine($"  ClassID: {E1_ClassID}");
                                    Console.WriteLine($"  Player Class: {E1_ClassName}");
                                    Console.WriteLine($"  Health: {E1_Health}/{E1_MaxHP}");
                                    Console.WriteLine(Footer);
                                    Console.WriteLine();
                                    Console.WriteLine(Header);
                                    Console.WriteLine($"Select Their Loadout!");
                                    Console.WriteLine($"1.  Primary Weapon: {PrimaryWeapons.SpecificWeaponName(E1_PrimaryWeaponID)}");
                                    Console.WriteLine($"2.  Secondary Weapon: {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}");
                                    Console.WriteLine($"3.  Melee Weapon: {MeleeWeapons.SpecificWeaponName(E1_MeleeWeaponID)}");
                                    Console.WriteLine($"4.  Finish Setting up Loadout");
                                    Console.WriteLine(Footer);
                                    Console.Write($"Choice: "); Console.ForegroundColor = Color_Input;
                                    string LoadoutChoice = Console.ReadLine();
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.Write(new String(' ', Console.BufferWidth));
                                    if (LoadoutChoice == "1")
                                    {
                                        //Console.Clear();
                                        Console.ResetColor();
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine(Header);
                                        Console.WriteLine($"  === Class: {E1_ClassName}");
                                        Console.WriteLine($"  === Selecting Primary Weapon");
                                        Console.WriteLine(PrimaryWeapons.Names(E1_ClassID));
                                        Console.WriteLine(Footer);
                                        Console.Write("Weapon ID: "); Console.ForegroundColor = Color_Input;
                                        string PrimarySelecion = Console.ReadLine();
                                        if (int.TryParse(PrimarySelecion, out int PrimaryID)) { E1_PrimaryWeaponID = PrimaryID; }
                                        if (SkipDebug == false)
                                        {
                                            Console.WriteLine($"Primary Weapon: {PrimaryWeapons.SpecificWeaponName(E1_PrimaryWeaponID)}");
                                            Console.WriteLine($"Attack: {PrimaryWeapons.Attack(E1_ClassID, E1_PrimaryWeaponID, E1_Cooldown, E1_SecondaryTriggerExists, P1_WeaponSpecialStat)}");
                                            Thread.Sleep(1500);
                                        }
                                        Selecting_Loadout = true;
                                    }
                                    if (LoadoutChoice == "2")
                                    {
                                        //Console.Clear();
                                        Console.ResetColor();
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine(Header);
                                        Console.WriteLine($"  === Class: {E1_ClassName}");
                                        Console.WriteLine($"  === Selecting Secondary Weapon");
                                        Console.WriteLine(SecondaryWeapons.Names(E1_ClassID));
                                        Console.WriteLine(Footer);
                                        Console.Write("Weapon ID: "); Console.ForegroundColor = Color_Input;
                                        string SecondarySelecion = Console.ReadLine();
                                        if (int.TryParse(SecondarySelecion, out int SecondaryID)) { E1_SecondaryWeaponID = SecondaryID; }
                                        if (SkipDebug == false)
                                        {
                                            Console.WriteLine($"Secondary Weapon: {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}");
                                            Console.WriteLine($"Attack: {SecondaryWeapons.Attack(E1_ClassID, E1_SecondaryWeaponID, E1_Cooldown, E1_SecondaryTriggerExists, E1_WeaponSpecialStat)}");
                                            Thread.Sleep(1500);
                                        }
                                        Selecting_Loadout = true;
                                    }
                                    if (LoadoutChoice == "3")
                                    {
                                        //Console.Clear();
                                        Console.ResetColor();
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine(Header);
                                        Console.WriteLine($"  === Class: {E1_ClassName}");
                                        Console.WriteLine($"  === Selecting Melee Weapon");
                                        Console.WriteLine(MeleeWeapons.Names(E1_ClassID));
                                        Console.WriteLine(Footer);
                                        Console.Write("Weapon ID: "); Console.ForegroundColor = Color_Input;
                                        string MeleeSelecion = Console.ReadLine();
                                        if (int.TryParse(MeleeSelecion, out int MeleeID)) { E1_MeleeWeaponID = MeleeID; }
                                        if (SkipDebug == false)
                                        {
                                            Console.WriteLine($"Melee Weapon: {MeleeWeapons.SpecificWeaponName(E1_MeleeWeaponID)}");
                                            Console.WriteLine($"Attack: {MeleeWeapons.Attack(E1_ClassID, E1_MeleeWeaponID, E1_Cooldown, E1_SecondaryTriggerExists, P1_Health, P1_MaxHP)}");
                                            Thread.Sleep(1500);
                                        }
                                        Selecting_Loadout = true;
                                    }
                                    if (LoadoutChoice == "4")
                                    {
                                        EnemySetClass = true;
                                        break;
                                    }
                                    else
                                    {
                                        Selecting_Loadout = true;
                                    }
                                }
                            }
                            else if (ClassChoice < 0 || ClassChoice > 10)
                            {
                                Console.Clear();
                                InputEnemy = false;
                            }
                            else
                            {
                                Console.Clear();
                                InputEnemy = true;
                            }
                        }
                    }
                    #endregion
                    #region Game
                    if (EnemySetClass == true) //Game Start
                    {
                        #region Pre-Game Checks
                        //Player Checks
                        if (Weapons_SpecialFunction.Contains(P1_PrimaryWeaponID) || Weapons_SpecialFunction.Contains(P1_SecondaryWeaponID) || Weapons_SpecialFunction.Contains(P1_MeleeWeaponID))
                        {
                            P1_SecondaryTriggerName = Misc.SecondaryFunctionName(P1_PrimaryWeaponID, P1_SecondaryWeaponID, P1_MeleeWeaponID);
                            P1_SecondaryFunctionShort = Misc.SecondaryFunctionNameShort(P1_PrimaryWeaponID, P1_SecondaryWeaponID, P1_MeleeWeaponID);
                            P1_SecondaryTriggerExists = true;
                            P1_SecondaryFunctionAttackString = Misc.SecondaryFunctionAttackPrompt_Player(PlayerName, EnemyPrefix, E1_ClassName, P1_PrimaryWeaponID, P1_SecondaryWeaponID, P1_MeleeWeaponID);
                        }
                        if (Sniper_PrimaryWeapons_Charging.Contains(P1_PrimaryWeaponID))
                        {
                            P1_SecondaryTriggerName = $"Charge {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}";
                            P1_SecondaryTrigger++;
                        }
                        if (P1_MeleeWeaponID == 152 && P1_ClassID == 7)
                        {
                            P1_Health = P1_Health + 10;
                            P1_MaxHP = P1_MaxHP + 10;
                            Console.ForegroundColor = Color_Game;
                            Console.WriteLine($"   {HeaderShort}");
                            Console.ForegroundColor = Color_Player;
                            Console.WriteLine($"      {PlayerName} is Holding the Vita-Saw!");
                            Console.WriteLine($"         +10 Max HP");
                            Console.ForegroundColor = Color_Game;
                            Console.WriteLine($"   {FooterShort}");
                            Thread.Sleep(P1_ThreadSleep);
                        }
                        if (Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(P1_SecondaryWeaponID)) 
                        {
                            P1_SecondaryTriggerName = $"Place a Stickybomb using {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}";
                        }

                        //Enemy Checks
                        if (Weapons_SpecialFunction.Contains(E1_PrimaryWeaponID) || Weapons_SpecialFunction.Contains(E1_SecondaryWeaponID) || Weapons_SpecialFunction.Contains(E1_MeleeWeaponID))
                        {
                            E1_SecondaryTriggerName = Misc.SecondaryFunctionName(E1_PrimaryWeaponID, E1_SecondaryWeaponID, E1_MeleeWeaponID);
                            E1_SecondaryFunctionShort = Misc.SecondaryFunctionNameShort(E1_PrimaryWeaponID, E1_SecondaryWeaponID, E1_MeleeWeaponID);
                            E1_SecondaryTriggerExists = true;
                            E1_SecondaryFunctionAttackString = Misc.SecondaryFunctionAttackPrompt_Enemy(PlayerName, EnemyPrefix, E1_ClassName, E1_PrimaryWeaponID, E1_SecondaryWeaponID, E1_MeleeWeaponID);
                        }
                        if (Sniper_PrimaryWeapons_Charging.Contains(E1_PrimaryWeaponID))
                        {
                            E1_SecondaryTriggerName = $"Charge {PrimaryWeapons.SpecificWeaponName(E1_PrimaryWeaponID)}";
                            E1_SecondaryTrigger++;
                        }
                        if (E1_MeleeWeaponID == 152 && E1_ClassID == 7)
                        {
                            E1_Health = E1_Health + 10;
                            E1_MaxHP = E1_MaxHP + 10;
                            Console.ForegroundColor = Color_Game;
                            Console.WriteLine($"   {HeaderShort}");
                            Console.ForegroundColor = Color_Player;
                            Console.WriteLine($"      {EnemyPrefix} {E1_ClassName} is Holding the Vita-Saw!");
                            Console.WriteLine($"         +10 Max HP");
                            Console.ForegroundColor = Color_Game;
                            Console.WriteLine($"   {FooterShort}");
                            Thread.Sleep(E1_ThreadSleep);
                        }
                        if (Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(E1_SecondaryWeaponID))
                        {
                            E1_SecondaryTriggerName = $"Place a Stickybomb using {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}";
                        }
                        #endregion

                        while (GameInputOK == false)
                        {
                            GameInputOK = true;
                            while (P1_Health > 0 && E1_Health > 0)
                            {
                                Console.Clear();
                                #region Status Effect Resets
                                #region Fire Status Reset
                                if (P1_StatusOnFireCooldown == 0)
                                {
                                    if (P1_StatusEffect_1_ID == 1) { P1_StatusEffect_1_ID = 0; }
                                    if (P1_StatusEffect_2_ID == 1) { P1_StatusEffect_2_ID = 0; }
                                    if (P1_StatusEffect_3_ID == 1) { P1_StatusEffect_3_ID = 0; }
                                }

                                if (E1_StatusOnFireCooldown == 0)
                                {
                                    if (E1_StatusEffect_1_ID == 1) { E1_StatusEffect_1_ID = 0; }
                                    if (E1_StatusEffect_2_ID == 1) { E1_StatusEffect_2_ID = 0; }
                                    if (E1_StatusEffect_3_ID == 1) { E1_StatusEffect_3_ID = 0; }
                                }
                                #endregion
                                #region Jarate Status Reset
                                if (P1_StatusJaratedCooldown == 0)
                                {
                                    if (P1_StatusEffect_1_ID == 3) { P1_StatusEffect_1_ID = 0; }
                                    if (P1_StatusEffect_2_ID == 3) { P1_StatusEffect_2_ID = 0; }
                                    if (P1_StatusEffect_3_ID == 3) { P1_StatusEffect_3_ID = 0; }
                                }

                                if (E1_StatusJaratedCooldown == 0)
                                {
                                    if (E1_StatusEffect_1_ID == 3) { E1_StatusEffect_1_ID = 0; }
                                    if (E1_StatusEffect_2_ID == 3) { E1_StatusEffect_2_ID = 0; }
                                    if (E1_StatusEffect_3_ID == 3) { E1_StatusEffect_3_ID = 0; }
                                }
                                #endregion
                                #region Mad-Milk Status Reset
                                if (P1_StatusMadMilkedCooldown == 0)
                                {
                                    if (P1_StatusEffect_1_ID == 2) { P1_StatusEffect_1_ID = 0; }
                                    if (P1_StatusEffect_2_ID == 2) { P1_StatusEffect_2_ID = 0; }
                                    if (P1_StatusEffect_3_ID == 2) { P1_StatusEffect_3_ID = 0; }
                                }

                                if (E1_StatusMadMilkedCooldown == 0)
                                {
                                    if (E1_StatusEffect_1_ID == 2) { E1_StatusEffect_1_ID = 0; }
                                    if (E1_StatusEffect_2_ID == 2) { E1_StatusEffect_2_ID = 0; }
                                    if (E1_StatusEffect_3_ID == 2) { E1_StatusEffect_3_ID = 0; }
                                }
                                #endregion
                                #region Bleeding Status Reset
                                if (P1_StatusBleedingCooldown == 0)
                                {
                                    if (P1_StatusEffect_1_ID == 4) { P1_StatusEffect_1_ID = 0; }
                                    if (P1_StatusEffect_2_ID == 4) { P1_StatusEffect_2_ID = 0; }
                                    if (P1_StatusEffect_3_ID == 4) { P1_StatusEffect_3_ID = 0; }
                                }

                                if (E1_StatusBleedingCooldown == 0)
                                {
                                    if (E1_StatusEffect_1_ID == 4) { E1_StatusEffect_1_ID = 0; }
                                    if (E1_StatusEffect_2_ID == 4) { E1_StatusEffect_2_ID = 0; }
                                    if (E1_StatusEffect_3_ID == 4) { E1_StatusEffect_3_ID = 0; }
                                }
                                #endregion
                                #region Marked For Death Status Reset
                                if (P1_StatusMFDCooldown == 0)
                                {
                                    if (P1_StatusEffect_1_ID == 7) { P1_StatusEffect_1_ID = 0; }
                                    if (P1_StatusEffect_2_ID == 7) { P1_StatusEffect_2_ID = 0; }
                                    if (P1_StatusEffect_3_ID == 7) { P1_StatusEffect_3_ID = 0; }
                                }

                                if (E1_StatusMFDCooldown == 0)
                                {
                                    if (E1_StatusEffect_1_ID == 7) { E1_StatusEffect_1_ID = 0; }
                                    if (E1_StatusEffect_2_ID == 7) { E1_StatusEffect_2_ID = 0; }
                                    if (E1_StatusEffect_3_ID == 7) { E1_StatusEffect_3_ID = 0; }
                                }
                                #endregion

                                P1_Damage = 0;
                                E1_Damage = 0;

                                if (PlayerCooldown < 0)
                                {
                                    PlayerCooldown = 0; //Checks if the Cooldown went into the negatives and reverses it to 0.
                                }
                                #endregion
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(Header);
                                Console.ForegroundColor = Color_Player;
                                Console.WriteLine($"  {PlayerName}'s Class is {P1_ClassName} with {P1_Health}/{P1_MaxHP} Health");
                                Console.ForegroundColor = Color_Enemy;
                                Console.WriteLine($"  The {EnemyPrefix} {E1_ClassName} has {E1_Health}/{E1_MaxHP} Health");
                                Console.ForegroundColor = Color_Game;
                                int HalfOfE1_HP = E1_MaxHP / 2;
                                if (E1_Health < HalfOfE1_HP)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"  {Header}");
                                    Console.WriteLine($"    The {EnemyPrefix} {E1_ClassName} has less than Half Health!");
                                    Console.WriteLine($"    Type 'Taunt' to taunt them and finish them off!");
                                    Console.WriteLine($"  {Footer}");
                                }
                                Console.WriteLine(Footer);
                                Console.ForegroundColor = Color_Player;
                                #region Status / Information
                                if (P1_Cooldown_P > 0)
                                {
                                    Console.WriteLine($"┌──Primary Weapon Cooldown─────────┐");
                                    Console.WriteLine($"| Cooldown: {P1_Cooldown_P} ");
                                    Console.WriteLine($"└──────────────────────────────────┘");
                                }
                                if (P1_Cooldown_S > 0 && Medic_SecondaryWeapons.Contains(P1_SecondaryWeaponID) == false)
                                {
                                    Console.WriteLine($"┌──Secondary Weapon Cooldown─────────┐");
                                    Console.WriteLine($"| Cooldown: {P1_Cooldown_S} ");
                                    Console.WriteLine($"└────────────────────────────────────┘");
                                }
                                if (P1_Cooldown_M > 0)
                                {
                                    Console.WriteLine($"┌──Melee Weapon Cooldown─────────┐");
                                    Console.WriteLine($"| Cooldown: {P1_Cooldown_M} ");
                                    Console.WriteLine($"└────────────────────────────────┘");
                                }
                                if (P1_Cooldown_E > 0)
                                {
                                    Console.WriteLine($"┌──{P1_SecondaryFunctionShort} Cooldown─────────┐");
                                    Console.WriteLine($"| Cooldown: {P1_Cooldown_E} ");
                                    Console.WriteLine($"└──────────────────────────┘");
                                }
                                Console.ForegroundColor = Color_Enemy;
                                if (P1_StatusEffect_1_ID == 1 || P1_StatusEffect_2_ID == 1 || P1_StatusEffect_3_ID == 1)
                                {
                                    Console.WriteLine($"┌──YOU ARE BURNING!!!─────────┐");
                                    Console.WriteLine($"| Time To Extinguish: {P1_StatusOnFireCooldown} ");
                                    Console.WriteLine($"└─────────────────────────────┘");
                                }
                                if (P1_StatusEffect_1_ID == 2 || P1_StatusEffect_2_ID == 2 || P1_StatusEffect_3_ID == 2)
                                {
                                    Console.WriteLine($"┌──YOU HAVE BEEN HIT WITH A JAR OF MAD-MILK!!!────┐");
                                    Console.WriteLine($"| Time To Dry: {P1_StatusMadMilkedCooldown} ");
                                    Console.WriteLine($"└─────────────────────────────────────────────────┘");
                                }
                                if (P1_StatusEffect_1_ID == 3 || P1_StatusEffect_2_ID == 3 || P1_StatusEffect_3_ID == 3)
                                {
                                    Console.WriteLine($"┌──YOU HAVE BEEN JARATED!!!────┐");
                                    Console.WriteLine($"| Time To Dry: {P1_StatusJaratedCooldown} ");
                                    Console.WriteLine($"└──────────────────────────────┘");
                                }
                                if (P1_StatusEffect_1_ID == 4 || P1_StatusEffect_2_ID == 4 || P1_StatusEffect_3_ID == 4)
                                {
                                    Console.WriteLine($"┌──YOU HAVE AN OPEN WOUND!!!────┐");
                                    Console.WriteLine($"| Time To Heal: {P1_StatusBleedingCooldown} ");
                                    Console.WriteLine($"└───────────────────────────────┘");
                                }
                                if (P1_StatusEffect_1_ID == 5 || P1_StatusEffect_2_ID == 5 || P1_StatusEffect_3_ID == 5)
                                {
                                    Console.WriteLine($"┌──THE ENEMY HAS CRITS!!!──────┐");
                                    Console.WriteLine($"| Time Left: {P1_StatusBleedingCooldown} ");
                                    Console.WriteLine($"└──────────────────────────────┘");
                                }
                                if (P1_StatusEffect_1_ID == 6 || P1_StatusEffect_2_ID == 6 || P1_StatusEffect_3_ID == 6)
                                {
                                    Console.WriteLine($"┌──THE ENEMY HAS MINI-CRITS!!!────┐");
                                    Console.WriteLine($"| Time Left: {P1_StatusBleedingCooldown} ");
                                    Console.WriteLine($"└─────────────────────────────────┘");
                                }
                                if (P1_StatusEffect_1_ID == 7 || P1_StatusEffect_2_ID == 7 || P1_StatusEffect_3_ID == 7)
                                {
                                    Console.WriteLine($"┌──YOU ARE MARKED FOR DEATH!!!────┐");
                                    Console.WriteLine($"| Time Left: {P1_StatusMFDCooldown} ");
                                    Console.WriteLine($"└─────────────────────────────────┘");
                                }
                                Console.ForegroundColor = Color_Player;
                                // Enemy Status
                                if (E1_StatusEffect_1_ID == 1 || E1_StatusEffect_2_ID == 1 || E1_StatusEffect_3_ID == 1)
                                {
                                    Console.WriteLine($"┌──THE ENEMY IS ON FIRE!!!─────────┐");
                                    Console.WriteLine($"| Time Until Enemy Extinguishes: {E1_StatusOnFireCooldown} ");
                                    Console.WriteLine($"└──────────────────────────────────┘");
                                }
                                if (E1_StatusEffect_1_ID == 2 || E1_StatusEffect_2_ID == 2 || E1_StatusEffect_3_ID == 2)
                                {
                                    Console.WriteLine($"┌──THE ENEMY IS UNDER THE EFFECTS OF MAD-MILK!!!────┐");
                                    Console.WriteLine($"| Time Until Enemy Dries: {E1_StatusMadMilkedCooldown} ");
                                    Console.WriteLine($"└───────────────────────────────────────────────────┘");
                                }
                                if (E1_StatusEffect_1_ID == 3 || E1_StatusEffect_2_ID == 3 || E1_StatusEffect_3_ID == 3)
                                {
                                    Console.WriteLine($"┌──THE ENEMY IS UNDER THE EFFECTS OF JARATE!!!────┐");
                                    Console.WriteLine($"| Time Until Enemy Dries: {E1_StatusJaratedCooldown} ");
                                    Console.WriteLine($"└─────────────────────────────────────────────────┘");
                                }
                                if (E1_StatusEffect_1_ID == 4 || E1_StatusEffect_2_ID == 4 || E1_StatusEffect_3_ID == 4)
                                {
                                    Console.WriteLine($"┌──THE ENEMY IS TAKING BLEED DAMAGE!!!────┐");
                                    Console.WriteLine($"| Time Until Enemy Heals: {E1_StatusBleedingCooldown} ");
                                    Console.WriteLine($"└─────────────────────────────────────────┘");
                                }
                                if (E1_StatusEffect_1_ID == 5 || E1_StatusEffect_2_ID == 5 || E1_StatusEffect_3_ID == 5)
                                {
                                    Console.WriteLine($"┌──YOU HAVE CRITS!!!──────┐");
                                    Console.WriteLine($"| Time Left: {E1_StatusBleedingCooldown} ");
                                    Console.WriteLine($"└─────────────────────────┘");
                                }
                                if (E1_StatusEffect_1_ID == 6 || E1_StatusEffect_2_ID == 6 || E1_StatusEffect_3_ID == 6)
                                {
                                    Console.WriteLine($"┌──YOU HAVE MINI-CRITS!!!────┐");
                                    Console.WriteLine($"| Time Left: {E1_StatusBleedingCooldown} ");
                                    Console.WriteLine($"└────────────────────────────┘");
                                }
                                if (E1_StatusEffect_1_ID == 7 || E1_StatusEffect_2_ID == 7 || E1_StatusEffect_3_ID == 7)
                                {
                                    Console.WriteLine($"┌──THE ENEMY IS MARKED FOR DEATH!!!────┐");
                                    Console.WriteLine($"| Time Left: {E1_StatusMFDCooldown} ");
                                    Console.WriteLine($"└──────────────────────────────────────┘");
                                }
                                Console.ForegroundColor = Color_Player;
                                if (P1_ClassID == 4 && Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(P1_SecondaryWeaponID))
                                {
                                    Console.WriteLine($"  ┌──Stickies Placed:───────┐");
                                    Console.WriteLine($"  |            {P1_SecondaryTrigger}            |      ");
                                    Console.WriteLine($"  └─────────────────────────┘");
                                }
                                if (P1_ClassID == 7)
                                {

                                    // New Design Concept
                                    //Console.WriteLine($"  ┌──Medigun Cooldown:──┐");
                                    //Console.WriteLine($"  | Turns Remaining: {PlayerCooldown}  |");
                                    //Console.WriteLine($"  └─────────────────────┘");

                                    if (P1_Cooldown_S == 4)
                                    {
                                        Console.WriteLine($"  ┌──Medigun Charge:────┐");
                                        Console.WriteLine($"  |▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ - 0%|");
                                        Console.WriteLine($"  └─────────────────────┘");
                                        // ▒ █
                                    }
                                    if (P1_Cooldown_S == 3)
                                    {
                                        Console.WriteLine($"  ┌──Medigun Charge:─────┐");
                                        Console.WriteLine($"  |████▒▒▒▒▒▒▒▒▒▒▒▒ - 25%|");
                                        Console.WriteLine($"  └──────────────────────┘");
                                        // ▒ █
                                    }
                                    if (P1_Cooldown_S == 2)
                                    {
                                        Console.WriteLine($"  ┌──Medigun Charge:─────┐");
                                        Console.WriteLine($"  |████████▒▒▒▒▒▒▒▒ - 50%|");
                                        Console.WriteLine($"  └──────────────────────┘");
                                        // ▒ █
                                    }
                                    if (P1_Cooldown_S == 1)
                                    {
                                        Console.WriteLine($"  ┌──Medigun Charge:─────┐");
                                        Console.WriteLine($"  |████████████▒▒▒▒ - 75%|");
                                        Console.WriteLine($"  └──────────────────────┘");
                                        // ▒ █
                                    }
                                    if (P1_Cooldown_S == 0)
                                    {
                                        Console.WriteLine("  ┌──Medigun Charge:──────┐    ");
                                        Console.WriteLine("  |████████████████ - 100%|  ");
                                        Console.WriteLine("  └───────────────────────┘  ");
                                    }

                                }
                                if (P1_ClassID == 8)
                                {
                                    Console.WriteLine($"  ┌──Charge Level:──┐");
                                    Console.WriteLine($"  |        {P1_SecondaryTrigger}        | ");
                                    Console.WriteLine($"  └─────────────────┘");
                                }
                                #endregion
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine();
                                Console.WriteLine(Header);
                                Console.WriteLine($"  Actions [Select using Numbers]:");
                                if (P1_PrimaryWeaponID != 0) if (P1_Commitment == 0 || P1_Commitment == 1 && P1_Commitment! >= 2) if (PrimaryWeapons_SlotStealers.Contains(P1_PrimaryWeaponID) == false) { Console.WriteLine($"  1. {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}"); }
                                if (P1_SecondaryWeaponID != 0) if (P1_Commitment == 0 || P1_Commitment == 2 && P1_Commitment != 1 && P1_Commitment! >= 3) if (SecondaryWeapons_SlotStealers.Contains(P1_SecondaryWeaponID) == false) { Console.WriteLine($"  2. {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}"); }
                                if (P1_MeleeWeaponID != 0) if (P1_Commitment == 0 || P1_Commitment == 3 && P1_Commitment! <= 2 && P1_Commitment! >= 4) Console.WriteLine($"  3. {MeleeWeapons.SpecificWeaponName(P1_MeleeWeaponID)}");
                                if (P1_Commitment == 0 || P1_Commitment == 4 && P1_Commitment! <= 3) if (P1_SecondaryTriggerExists || Sniper_PrimaryWeapons_Charging.Contains(P1_PrimaryWeaponID) || Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(P1_SecondaryWeaponID)) { Console.WriteLine($"  4. {P1_SecondaryTriggerName}"); }

                                Console.WriteLine(Footer);
                                Console.Write("Action: "); Console.ForegroundColor = Color_Input;
                                string PlayerAction = Console.ReadLine();
                                if (PlayerAction == "1")
                                {
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.WriteLine(new String(' ', Console.BufferWidth));
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    Console.ForegroundColor = Color_Player;
                                    Console.WriteLine($"{PlayerName} attacked with their {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}!");
                                    P1_Damage = PrimaryWeapons.Attack(P1_ClassID, P1_PrimaryWeaponID, P1_Cooldown_P, P1_SecondaryTriggerExists, P1_SecondaryTrigger);
                                    if (Medic_PrimaryWeapons.Contains(P1_PrimaryWeaponID))
                                    {
                                        if (P1_Cooldown_P > 0)
                                        {
                                            P1_Damage = 0;
                                            Console.WriteLine("Your Weapon was cooling Down!!");
                                            Console.WriteLine("You Dealt no damage");
                                        }
                                        P1_Cooldown_P = 2;
                                    }
                                    if (Attack_HealWeapons.Contains(P1_PrimaryWeaponID))
                                    {
                                        P1_Health = P1_Health + P1_Damage / 2;
                                        Console.WriteLine(Header);
                                        Console.WriteLine($"   Healed {P1_Damage / 2} Health!");
                                        Console.WriteLine(Footer);
                                    }
                                    if (Sniper_PrimaryWeapons_Charging.Contains(P1_PrimaryWeaponID))
                                    {
                                        P1_SecondaryTrigger = 1;
                                    }
                                    if (PrimaryWeapons_CanInflictFire.Contains(P1_PrimaryWeaponID)) 
                                    {
                                        if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 1)
                                        {
                                            E1_StatusEffect_1_ID = 1; E1_StatusOnFireCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_1_ID > 0)
                                        {
                                            if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 1)
                                            {
                                                E1_StatusEffect_2_ID = 1; E1_StatusOnFireCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_2_ID > 0)
                                            {
                                                if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_2_ID == 1)
                                                {
                                                    E1_StatusEffect_3_ID = 1; E1_StatusOnFireCooldown = 4;
                                                }
                                                else if (E1_StatusEffect_3_ID > 0)
                                                {
                                                    Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                }
                                            }
                                        }
                                    }
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(P1_ThreadSleep);

                                }
                                if (PlayerAction == "2")
                                {
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.WriteLine(new String(' ', Console.BufferWidth));
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    Console.ForegroundColor = Color_Player;
                                    if (P1_ClassID == 7 && Medic_SecondaryWeapons.Contains(P1_SecondaryWeaponID))
                                    {
                                        if (P1_Cooldown_S == 0)
                                        {
                                            Console.WriteLine($"{PlayerName} Used their {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}!");
                                            P1_Damage = SecondaryWeapons.Attack(P1_ClassID, P1_SecondaryWeaponID, P1_Cooldown_S, P1_SecondaryTriggerExists, P1_WeaponSpecialStat);
                                            P1_Health = P1_Health + P1_Damage;
                                            Console.WriteLine($"It healed {P1_Damage} Health!");
                                            P1_Damage = 0;
                                            P1_Cooldown_S = 5;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{PlayerName} Used their {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}!");
                                            Console.WriteLine($"It Backfired!!! The {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)} was still Cooling down!!");
                                            P1_Damage = SecondaryWeapons.Attack(P1_ClassID, P1_SecondaryWeaponID, P1_Cooldown_S, P1_SecondaryTriggerExists, P1_WeaponSpecialStat);
                                            P1_Health = P1_Health - P1_Damage;
                                            Console.WriteLine($"It Dealt {P1_Damage} Self-Damage!");
                                            P1_Damage = 0;
                                        }
                                    }
                                    if (P1_ClassID == 3 && SecondaryWeapons_CanInflictFire.Contains(P1_SecondaryWeaponID))
                                    {
                                        if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 1)
                                        {
                                            E1_StatusEffect_1_ID = 1; E1_StatusOnFireCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_1_ID > 0)
                                        {
                                            if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 1)
                                            {
                                                E1_StatusEffect_2_ID = 1; E1_StatusOnFireCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_2_ID > 0)
                                            {
                                                if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_2_ID == 1)
                                                {
                                                    E1_StatusEffect_3_ID = 1; E1_StatusOnFireCooldown = 4;
                                                }
                                                else if (E1_StatusEffect_3_ID > 0)
                                                {
                                                    Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                }
                                            }
                                        }
                                    }
                                    if (P1_ClassID == 1 && P1_SecondaryWeaponID == 15 || P1_SecondaryWeaponID == 16) // Mad Milk & Re-skin
                                    {
                                        if (P1_Cooldown_S > 0)
                                        {
                                            Console.WriteLine("Your Mad Milk was still cooling down!");
                                        }
                                        if (P1_Cooldown_S == 0)
                                        {
                                            Console.WriteLine("Threw Mad Milk at the Enemy!");
                                            P1_Damage = 0;
                                            P1_Cooldown_S = 5;
                                            if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 2)
                                            {
                                                E1_StatusEffect_1_ID = 2; E1_StatusMadMilkedCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_1_ID > 0)
                                            {
                                                if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 2)
                                                {
                                                    E1_StatusEffect_2_ID = 2; E1_StatusMadMilkedCooldown = 4;
                                                }
                                                else if (E1_StatusEffect_2_ID > 0)
                                                {
                                                    if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_3_ID == 2)
                                                    {
                                                        E1_StatusEffect_3_ID = 2; E1_StatusMadMilkedCooldown = 3;
                                                    }
                                                    else if (E1_StatusEffect_3_ID > 0)
                                                    {
                                                        Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (P1_ClassID == 8 && P1_SecondaryWeaponID == 167 || P1_SecondaryWeaponID == 168) // Jarate & Re-skin
                                    {
                                        if (P1_Cooldown_S > 0)
                                        {
                                            Console.WriteLine("Your Jarate was still cooling down!");
                                        }
                                        if (P1_Cooldown_S == 0)
                                        { 
                                        Console.WriteLine("Threw Jarate at the Enemy!");
                                        P1_Damage = 0;
                                        P1_Cooldown_S = 5;
                                        P1_Cooldown_S = 5;
                                            if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 3)
                                            {
                                                E1_StatusEffect_1_ID = 3; E1_StatusJaratedCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_1_ID > 0)
                                            {
                                                if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 3)
                                                {
                                                    E1_StatusEffect_2_ID = 3; E1_StatusJaratedCooldown = 4;
                                                }
                                                else if (E1_StatusEffect_2_ID > 0)
                                                {
                                                    if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_3_ID == 3)
                                                    {
                                                        E1_StatusEffect_3_ID = 3; E1_StatusJaratedCooldown = 4;
                                                    }
                                                    else if (E1_StatusEffect_3_ID > 0)
                                                    {
                                                        Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (P1_ClassID == 1 && P1_SecondaryWeaponID == 11)
                                    {
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine($"   {HeaderShort}");
                                        Console.ForegroundColor = Color_Player;
                                        Console.WriteLine("      Regenerated 3 HP!");
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine($"   {FooterShort}");
                                        P1_Health = P1_Health + 3;
                                    }
                                    if (P1_ClassID == 5 && Heavy_Lunchbox.Contains(P1_SecondaryWeaponID))
                                    {
                                        if (P1_Cooldown_S > 0)
                                        {
                                            Console.WriteLine(Header);
                                            Console.WriteLine($"   {PlayerName}'s {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)} is Still being Made!");
                                            Console.WriteLine(Footer);
                                            P1_Damage = 0;
                                        }
                                        if (P1_Cooldown_S == 0)
                                        {
                                            P1_Damage = SecondaryWeapons.Attack(P1_ClassID, P1_SecondaryWeaponID, P1_Cooldown_S, P1_SecondaryTriggerExists, P1_WeaponSpecialStat );
                                            P1_Health = P1_Health + P1_Damage;
                                            Console.WriteLine(Header);
                                            Console.WriteLine($"   {PlayerName} ate a {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}, and Healed {P1_Damage} Health!");
                                            Console.WriteLine(Footer);
                                            P1_Damage = 0;
                                            P1_Cooldown_S = 5;
                                        }
                                        if (P1_SecondaryWeaponID == 112)
                                        {
                                            P1_RoboSandvichResist = true;
                                        }
                                        if (P1_SecondaryWeaponID == 113)
                                        {
                                            P1_MaxHP = P1_MaxHP + 50;
                                        }
                                        if (P1_SecondaryWeaponID == 114)
                                        {
                                            P1_MaxHP = P1_MaxHP + 100;
                                        }
                                        if (P1_SecondaryWeaponID == 115)
                                        {
                                            P1_Damage = 0;
                                            if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 7)
                                            {
                                                E1_StatusEffect_1_ID = 7; E1_StatusMFDCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_1_ID > 0)
                                            {
                                                if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 7)
                                                {
                                                    E1_StatusEffect_2_ID = 7; E1_StatusMFDCooldown = 4;
                                                }
                                                else if (E1_StatusEffect_2_ID > 0)
                                                {
                                                    if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_2_ID == 7)
                                                    {
                                                        E1_StatusEffect_3_ID = 7; E1_StatusMFDCooldown = 4;
                                                    }
                                                    else if (E1_StatusEffect_3_ID > 0)
                                                    {
                                                        Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                    }
                                                }
                                            }
                                        }
                                        if (P1_SecondaryWeaponID == 116)
                                        {
                                            P1_MaxHP = P1_MaxHP + 100;
                                        }
                                        if (P1_Health > P1_MaxHP) { P1_Health = P1_MaxHP; }
                                    }
                                    if (Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(P1_SecondaryWeaponID))
                                    {
                                        Console.WriteLine($"{PlayerName} Detontated {P1_SecondaryTrigger} Stickies with their {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}!");
                                        P1_Damage = SecondaryWeapons.Attack(P1_ClassID, P1_SecondaryWeaponID, P1_Cooldown_S, P1_SecondaryTriggerExists, P1_SecondaryTrigger);
                                        E1_Health = E1_Health - P1_Damage;
                                        if (P1_Damage > 0)
                                        {
                                            Console.WriteLine($"It dealt {P1_Damage} damage!");
                                        }
                                        if (P1_Damage == 0)
                                        {
                                            Console.WriteLine($"It dealt 0 damage! You need to place down stickybombs first!");
                                        }
                                        P1_Damage = 0;
                                        P1_SecondaryTrigger = 0;
                                    }
                                    else
                                    {
                                        if (Medic_SecondaryWeapons.Contains(P1_SecondaryWeaponID) == false && SecondaryWeapons_SlotStealers.Contains(P1_SecondaryWeaponID) == false && Heavy_Lunchbox.Contains(P1_SecondaryWeaponID) == false)
                                        {
                                            Console.WriteLine($"{PlayerName} attacked with their {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}!");
                                            P1_Damage = SecondaryWeapons.Attack(P1_ClassID, P1_SecondaryWeaponID, P1_Cooldown_S, P1_SecondaryTriggerExists, P1_WeaponSpecialStat);
                                        }
                                    }
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(P1_ThreadSleep);

                                }
                                if (PlayerAction == "3")
                                {
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.WriteLine(new String(' ', Console.BufferWidth));
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    Console.ForegroundColor = Color_Player;
                                    Console.WriteLine($"{PlayerName} attacked with their {MeleeWeapons.SpecificWeaponName(P1_MeleeWeaponID)}!");
                                    P1_Damage = MeleeWeapons.Attack(P1_ClassID, P1_MeleeWeaponID, P1_Cooldown_M, P1_SecondaryTriggerExists, P1_Health, P1_MaxHP);
                                    if (P1_MeleeWeaponID == 51)
                                    {
                                        Console.WriteLine("Half-Zatochi Duel Won!");
                                        P1_Damage = E1_Health;
                                    }
                                    if (P1_MeleeWeaponID == 151)
                                    {
                                        P1_Cooldown_S--;
                                        Console.WriteLine($"  {HeaderShort}");
                                        Console.WriteLine($"      - Gained 25% percent Uber on Hit!");
                                        Console.WriteLine($"  {FooterShort}");
                                    }
                                    if (MeleeWeapons_CanInflictFire.Contains(P1_MeleeWeaponID))
                                    {
                                        if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 1)
                                        {
                                            E1_StatusEffect_1_ID = 1; E1_StatusOnFireCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_1_ID > 0)
                                        {
                                            if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 1)
                                            {
                                                E1_StatusEffect_2_ID = 1; E1_StatusOnFireCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_2_ID > 0)
                                            {
                                                if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_2_ID == 1)
                                                {
                                                    E1_StatusEffect_3_ID = 1; E1_StatusOnFireCooldown = 4;
                                                }
                                                else if (E1_StatusEffect_3_ID > 0)
                                                {
                                                    Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                }
                                            }
                                        }
                                    }
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(P1_ThreadSleep);
                                }
                                if (PlayerAction == "4" && P1_SecondaryTriggerExists == false && Sniper_PrimaryWeapons_Charging.Contains(P1_PrimaryWeaponID) == false && Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(P1_SecondaryWeaponID) == false)
                                {
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.WriteLine(new String(' ', Console.BufferWidth));
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    Console.ForegroundColor = Color_Player;
                                    Console.WriteLine($"{PlayerName} attacked with their {MeleeWeapons.SpecificWeaponName(P1_MeleeWeaponID)}!");
                                    P1_Damage = MeleeWeapons.Attack(P1_ClassID, P1_MeleeWeaponID, P1_Cooldown_M, P1_SecondaryTriggerExists, P1_Health, P1_MaxHP);
                                    if (P1_MeleeWeaponID == 51)
                                    {
                                        Console.WriteLine("Half-Zatochi Duel Won!");
                                                P1_Damage = E1_Health;
                                    }
                                    if (MeleeWeapons_CanInflictFire.Contains(P1_MeleeWeaponID))
                                    {
                                        if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 1)
                                        {
                                            E1_StatusEffect_1_ID = 1; E1_StatusOnFireCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_1_ID > 0)
                                        {
                                            if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 1)
                                            {
                                                E1_StatusEffect_2_ID = 1; E1_StatusOnFireCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_2_ID > 0)
                                            {
                                                if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_2_ID == 1)
                                                {
                                                    E1_StatusEffect_3_ID = 1; E1_StatusOnFireCooldown = 4;
                                                }
                                                else if (E1_StatusEffect_3_ID > 0)
                                                {
                                                    Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                }
                                            }
                                        }
                                    }
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(P1_ThreadSleep);
                                }                                
                                if (PlayerAction == "4" && P1_SecondaryTriggerExists == true)
                                {

                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.WriteLine(new String(' ', Console.BufferWidth));
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    Console.ForegroundColor = Color_Player;
                                    if (P1_Cooldown_E == 0)
                                    {
                                        Console.WriteLine($"{P1_SecondaryFunctionAttackString}");
                                        P1_Damage = Misc.SecondaryFunction(P1_ClassID, P1_PrimaryWeaponID, P1_SecondaryWeaponID, P1_MeleeWeaponID, P1_Cooldown_P, P1_Cooldown_S, P1_Cooldown_M, P1_Cooldown_E);
                                        P1_Cooldown_E = 5;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{P1_SecondaryFunctionShort} is Still recharging!");
                                        Console.WriteLine($"You Dealt 0 Damage!");
                                    }
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(P1_ThreadSleep);
                                }
                                if (PlayerAction == "4" && Sniper_PrimaryWeapons_Charging.Contains(P1_PrimaryWeaponID))
                                {
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.WriteLine(new String(' ', Console.BufferWidth));
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    Console.ForegroundColor = Color_Player;
                                    Console.WriteLine($"{PlayerName} charged their {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}!");
                                    P1_SecondaryTrigger++;
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(P1_ThreadSleep);
                                }
                                if (PlayerAction == "4" && Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(P1_SecondaryWeaponID))
                                {
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Console.WriteLine(new String(' ', Console.BufferWidth));
                                    Console.ResetColor();
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    Console.ForegroundColor = Color_Player;
                                    Console.WriteLine($"{PlayerName} Placed a sticky with their {SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)}!");
                                    P1_SecondaryTrigger++;
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(P1_ThreadSleep);
                                }
                                /* Appears to give the player a Bonus Charge Disabled for now.
                                if (Sniper_PrimaryWeapons_Charging.Contains(P1_PrimaryWeaponID))
                                {
                                    P1_WeaponSpecialStat++;
                                }
                                */
                                #region In-Game Tests / Cheats
                                if (PlayerAction.ToLower() == "quit")
                                {
                                    QuittingGame = true;
                                    P1_Health = 0;
                                    Console.WriteLine(HeaderShort);
                                    Console.WriteLine($"  Quiting Game...");
                                    Console.WriteLine(FooterShort);
                                }
                                if (PlayerAction.ToLower() == "set commitment")
                                {
                                    Console.WriteLine("Set Commitment Slot:");
                                    Console.Write("slot: ");
                                    string e = Console.ReadLine();
                                    if (int.TryParse(e, out int commitmentid))
                                    {
                                        P1_Commitment = commitmentid;
                                    }
                                    else { Console.WriteLine("error"); }
                                }
                                if (PlayerAction.ToLower() == "heal player")
                                {
                                    P1_Damage = 0;
                                    P1_Health = P1_Health + 500;
                                    Console.WriteLine($"  ┌──Health Healed:───────┐");
                                    Console.WriteLine($"  |         +500          |      ");
                                    Console.WriteLine($"  └───────────────────────┘");
                                }
                                if (PlayerAction.ToLower() == "heal enemy")
                                {
                                    P1_Damage = 0;
                                    E1_Health = E1_Health + 500;
                                    Console.WriteLine($"  ┌──Enemy Health Healed:───────┐");
                                    Console.WriteLine($"  |           +500              |      ");
                                    Console.WriteLine($"  └─────────────────────────────┘");
                                }
                                if (PlayerAction.ToLower() == "ded")
                                {
                                    P1_Health = 0; E1_Health = 0;
                                }
                                if (PlayerAction.ToLower() == "taunt")
                                {
                                    Console.WriteLine($"  ┌──YOU HAVE FALLEN FOR {EnemyPrefix} {E1_ClassName}'s TRAP!!!───");
                                    Console.WriteLine($"  |  Given +1500 HP to {EnemyPrefix} {E1_ClassName}");
                                    Console.WriteLine($"  |  Given Golden Frying Pan to {EnemyPrefix} {E1_ClassName}");
                                    Console.WriteLine($"  └────────────────────────────────────────────────────────────────");
                                    E1_Health = E1_Health + 1500;
                                    E1_PrimaryWeaponID = 210;
                                    E1_SecondaryWeaponID = 210;
                                    E1_MeleeWeaponID = 210;
                                }
                                if (PlayerAction.ToLower() == "set fire")
                                {
                                    P1_Damage = 0;
                                    if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 1)
                                    {
                                        P1_StatusEffect_1_ID = 1; P1_StatusOnFireCooldown = 4;
                                    }
                                    else if (P1_StatusEffect_1_ID > 0)
                                    {
                                        if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 1)
                                        {
                                            P1_StatusEffect_2_ID = 1; P1_StatusOnFireCooldown = 4;
                                        }
                                        else if (P1_StatusEffect_2_ID > 0)
                                        {
                                            if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_2_ID == 1)
                                            {
                                                P1_StatusEffect_3_ID = 1; P1_StatusOnFireCooldown = 4;
                                            }
                                            else if (P1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }

                                if (PlayerAction.ToLower() == "set fire enemy")
                                {
                                    P1_Damage = 0;
                                    if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 1)
                                    {
                                        E1_StatusEffect_1_ID = 1; E1_StatusOnFireCooldown = 4;
                                    }
                                    else if (E1_StatusEffect_1_ID > 0)
                                    {
                                        if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 1)
                                        {
                                            E1_StatusEffect_2_ID = 1; E1_StatusOnFireCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_2_ID > 0)
                                        {
                                            if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_2_ID == 1)
                                            {
                                                E1_StatusEffect_3_ID = 1; E1_StatusOnFireCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }

                                if (PlayerAction.ToLower() == "set mfd")
                                {
                                    P1_Damage = 0;
                                    if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 7)
                                    {
                                        P1_StatusEffect_1_ID = 7; P1_StatusMFDCooldown = 4;
                                    }
                                    else if (P1_StatusEffect_1_ID > 0)
                                    {
                                        if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 7)
                                        {
                                            P1_StatusEffect_2_ID = 7; P1_StatusMFDCooldown = 4;
                                        }
                                        else if (P1_StatusEffect_2_ID > 0)
                                        {
                                            if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_2_ID == 7)
                                            {
                                                P1_StatusEffect_3_ID = 7; P1_StatusMFDCooldown = 4;
                                            }
                                            else if (P1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }

                                if (PlayerAction.ToLower() == "set mfd enemy")
                                {
                                    P1_Damage = 0;
                                    if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 7)
                                    {
                                        E1_StatusEffect_1_ID = 7; E1_StatusMFDCooldown = 4;
                                    }
                                    else if (E1_StatusEffect_1_ID > 0)
                                    {
                                        if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 7)
                                        {
                                            E1_StatusEffect_2_ID = 7; E1_StatusMFDCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_2_ID > 0)
                                        {
                                            if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_2_ID == 7)
                                            {
                                                E1_StatusEffect_3_ID = 7; E1_StatusMFDCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }
                                if (PlayerAction.ToLower() == "set jarate")
                                {
                                    P1_Damage = 0;
                                    if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 3)
                                    {
                                        P1_StatusEffect_1_ID = 3; P1_StatusJaratedCooldown = 4;
                                    }
                                    else if (P1_StatusEffect_1_ID > 0)
                                    {
                                        if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 3)
                                        {
                                            P1_StatusEffect_2_ID = 3; P1_StatusJaratedCooldown = 4;
                                        }
                                        else if (P1_StatusEffect_2_ID > 0)
                                        {
                                            if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_3_ID == 3)
                                            {
                                                P1_StatusEffect_3_ID = 3; P1_StatusJaratedCooldown = 4;
                                            }
                                            else if (P1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }

                                if (PlayerAction.ToLower() == "set jarate enemy")
                                {
                                    P1_Damage = 0;
                                    if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 3)
                                    {
                                        E1_StatusEffect_1_ID = 3; E1_StatusJaratedCooldown = 4;
                                    }
                                    else if (E1_StatusEffect_1_ID > 0)
                                    {
                                        if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 3)
                                        {
                                            E1_StatusEffect_2_ID = 3; E1_StatusJaratedCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_2_ID > 0)
                                        {
                                            if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_3_ID == 3)
                                            {
                                                E1_StatusEffect_3_ID = 3; E1_StatusJaratedCooldown = 4;
                                            }
                                            else if (E1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }

                                if (PlayerAction.ToLower() == "set mad-milk")
                                {
                                    P1_Damage = 0;
                                    if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 2)
                                    {
                                        P1_StatusEffect_1_ID = 2; P1_StatusMadMilkedCooldown = 4;
                                    }
                                    else if (P1_StatusEffect_1_ID > 0)
                                    {
                                        if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 2)
                                        {
                                            P1_StatusEffect_2_ID = 2; P1_StatusMadMilkedCooldown = 4;
                                        }
                                        else if (P1_StatusEffect_2_ID > 0)
                                        {
                                            if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_3_ID == 2)
                                            {
                                                P1_StatusEffect_3_ID = 2; P1_StatusMadMilkedCooldown = 4;
                                            }
                                            else if (P1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }

                                if (PlayerAction.ToLower() == "set mad-milk enemy")
                                {
                                    P1_Damage = 0;
                                    if (E1_StatusEffect_1_ID == 0 || E1_StatusEffect_1_ID == 2)
                                    {
                                        E1_StatusEffect_1_ID = 2; E1_StatusMadMilkedCooldown = 4;
                                    }
                                    else if (E1_StatusEffect_1_ID > 0)
                                    {
                                        if (E1_StatusEffect_2_ID == 0 || E1_StatusEffect_2_ID == 2)
                                        {
                                            E1_StatusEffect_2_ID = 2; E1_StatusMadMilkedCooldown = 4;
                                        }
                                        else if (E1_StatusEffect_2_ID > 0)
                                        {
                                            if (E1_StatusEffect_3_ID == 0 || E1_StatusEffect_3_ID == 2)
                                            {
                                                E1_StatusEffect_3_ID = 2; E1_StatusMadMilkedCooldown = 3;
                                            }
                                            else if (E1_StatusEffect_3_ID > 0)
                                            {
                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                            }
                                        }
                                    }
                                }

                                if (PlayerAction.ToLower() == "see effects")
                                {
                                    P1_Damage = 0;
                                    Console.WriteLine($"Effects:");
                                    Console.WriteLine($"Slot 1: {Misc.EffectNamefromID(P1_StatusEffect_1_ID)} ");
                                    Console.WriteLine($"Slot 2: {Misc.EffectNamefromID(P1_StatusEffect_2_ID)} ");
                                    Console.WriteLine($"Slot 3: {Misc.EffectNamefromID(P1_StatusEffect_3_ID)} ");
                                    Console.WriteLine();
                                }
                                #endregion
                                if (QuittingGame == false)
                                {
                                    #region StatusEffect_BulletEnhancer
                                    int StatusEffect_BulletEnhancer = 0;
                                    if (E1_StatusEffect_1_ID > 0 || E1_StatusEffect_2_ID > 0 || E1_StatusEffect_3_ID > 0)
                                    {
                                        if (E1_StatusEffect_1_ID == 3 || E1_StatusEffect_2_ID == 3 || E1_StatusEffect_3_ID == 3)
                                        {
                                            StatusEffect_BulletEnhancer = 3;
                                        }
                                        if (E1_StatusEffect_1_ID == 5 || E1_StatusEffect_2_ID == 5 || E1_StatusEffect_3_ID == 5)
                                        {
                                            StatusEffect_BulletEnhancer = 5;
                                        }
                                        if (E1_StatusEffect_1_ID == 6 || E1_StatusEffect_2_ID == 6 || E1_StatusEffect_3_ID == 6)
                                        {
                                            StatusEffect_BulletEnhancer = 6;
                                        }
                                        if (E1_StatusEffect_1_ID == 7 || E1_StatusEffect_2_ID == 7 || E1_StatusEffect_3_ID == 7)
                                        {
                                            StatusEffect_BulletEnhancer = 7;
                                        }
                                        bool ForceBreak = false;
                                        int E1_HealthPlaceHolder = E1_Health;
                                        int Damage = 0;
                                        // ForceBreak if Poison Effect
                                        if (E1_StatusEffect_1_ID == 1 || E1_StatusEffect_2_ID == 1 || E1_StatusEffect_3_ID == 1)
                                        {
                                            StatusEffect_BulletEnhancer = 1;
                                        }
                                        if (E1_StatusEffect_1_ID == 4 || E1_StatusEffect_2_ID == 4 || E1_StatusEffect_3_ID == 4)
                                        {
                                            StatusEffect_BulletEnhancer = 4;
                                        }
                                        if (E1_StatusEffect_1_ID == 2 || E1_StatusEffect_2_ID == 2 || E1_StatusEffect_3_ID == 2)
                                        {
                                            StatusEffect_BulletEnhancer = 2;
                                        }
                                        if (StatusEffect_BulletEnhancer == 1 || StatusEffect_BulletEnhancer == 4 || StatusEffect_BulletEnhancer == 2)
                                        {
                                            ForceBreak = true;
                                        }
                                        int P1_HealthPlaceHolder = P1_Health;
                                        if (ForceBreak == false)
                                        {
                                            if (P1_MeleeWeaponID != 174)
                                            {
                                                Damage = Misc.BulletEnhancer(StatusEffect_BulletEnhancer, P1_Damage);
                                            }
                                            if (P1_MeleeWeaponID == 174)
                                            {
                                                P1_Damage = P1_Damage * 3;
                                            }
                                            E1_Health = E1_Health - Damage;
                                            if (Damage > 0)
                                            { P1_Damage = 0; }
                                        }
                                        if (E1_Health < E1_HealthPlaceHolder)
                                        {
                                            if (StatusEffect_BulletEnhancer == 3)
                                            {
                                                Console.WriteLine($"   ┌──THE ENEMY HAS TAKEN JARATE DAMAGE!!!────┐");
                                                Console.WriteLine($"   | Dealt {E1_HealthPlaceHolder - E1_Health} Damage to the {EnemyPrefix} {E1_ClassName}!");
                                                Console.WriteLine($"   └──────────────────────────────────────────┘");
                                                Thread.Sleep(P1_ThreadSleep);
                                            }
                                            if (StatusEffect_BulletEnhancer == 5)
                                            {
                                                Console.WriteLine($"   ┌──THE ENEMY HAS TAKEN MINI-CRIT DAMAGE!!!────┐");
                                                Console.WriteLine($"   | Dealt {E1_HealthPlaceHolder - E1_Health} Damage to the {EnemyPrefix} {E1_ClassName}!");
                                                Console.WriteLine($"   └─────────────────────────────────────────────┘");
                                                Thread.Sleep(P1_ThreadSleep);
                                            }
                                            if (StatusEffect_BulletEnhancer == 6)
                                            {
                                                Console.WriteLine($"   ┌──THE ENEMY HAS TAKEN CRIT DAMAGE!!!─────────┐");
                                                Console.WriteLine($"   | Dealt {E1_HealthPlaceHolder - E1_Health} Damage to the {EnemyPrefix} {E1_ClassName}!");
                                                Console.WriteLine($"   └─────────────────────────────────────────────┘");
                                                Thread.Sleep(P1_ThreadSleep);
                                            }
                                        }
                                    }
                                    #endregion
                                    #region StatusEffect_PoisonEffects
                                    int StatusEffect_PoisonEffects_Player = 0;
                                    int StatusEffect_PoisonEffects_Enemy = 0;
                                    if (P1_StatusEffect_1_ID > 0 || P1_StatusEffect_2_ID > 0 || P1_StatusEffect_3_ID > 0 || E1_StatusEffect_1_ID > 0 || E1_StatusEffect_2_ID > 0 || E1_StatusEffect_3_ID > 0)
                                    {
                                        if (P1_StatusEffect_1_ID == 1 || P1_StatusEffect_2_ID == 1 || P1_StatusEffect_3_ID == 1) //Check Player
                                        {
                                            StatusEffect_PoisonEffects_Player = 1;
                                        }
                                        if (E1_StatusEffect_1_ID == 1 || E1_StatusEffect_2_ID == 1 || E1_StatusEffect_3_ID == 1) //Check Enemy
                                        {
                                            StatusEffect_PoisonEffects_Enemy = 1;
                                        }
                                        if (P1_StatusEffect_1_ID == 4 || P1_StatusEffect_2_ID == 4 || P1_StatusEffect_3_ID == 4) //Check Player
                                        {
                                            StatusEffect_PoisonEffects_Player = 5;
                                        }
                                        if (E1_StatusEffect_1_ID == 4 || E1_StatusEffect_2_ID == 4 || E1_StatusEffect_3_ID == 4) //Check Enemy
                                        {
                                            StatusEffect_PoisonEffects_Enemy = 5;
                                        }
                                        int E1_HealthPlaceHolder = E1_Health;
                                        int Damage = Misc.PoisonEffects(StatusEffect_PoisonEffects_Enemy, E1_Health);
                                        E1_Health = E1_Health - Damage;
                                        if (E1_Health < E1_HealthPlaceHolder)
                                        {
                                            if (StatusEffect_PoisonEffects_Enemy == 1)
                                            {
                                                Console.WriteLine($"   ┌──THE ENEMY HAS TAKEN FIRE DAMAGE!!!──────────────────────┐");
                                                Console.WriteLine($"   | The {EnemyPrefix} {E1_ClassName} Has Taken {E1_HealthPlaceHolder - E1_Health} Burn Damage!");
                                                Console.WriteLine($"   └──────────────────────────────────────────────────────────┘");
                                            }
                                            if (StatusEffect_PoisonEffects_Enemy == 5)
                                            {
                                                Console.WriteLine($"   ┌──THE ENEMY HAS TAKEN BLEEDING DAMAGE!!!──────────────────────┐");
                                                Console.WriteLine($"   | The {EnemyPrefix} {E1_ClassName} Has Taken {E1_HealthPlaceHolder - E1_Health} Bleeding Damage!");
                                                Console.WriteLine($"   └──────────────────────────────────────────────────────────────┘");
                                            }
                                        }
                                        int P1_HealthPlaceHolder = P1_Health;
                                        int DamagePlayer = Misc.PoisonEffects(StatusEffect_PoisonEffects_Player, P1_Health);
                                        P1_Health = P1_Health - DamagePlayer;
                                        if (P1_Health < P1_HealthPlaceHolder)
                                        {
                                            if (StatusEffect_PoisonEffects_Player == 1)
                                            {
                                                Console.WriteLine($"   ┌──YOU ARE TAKING FIRE DAMAGE!!!─────────────┐");
                                                Console.WriteLine($"   | Taken {P1_HealthPlaceHolder - P1_Health} Burn Damage!      ");
                                                Console.WriteLine($"   └────────────────────────────────────────────┘");
                                            }
                                            if (StatusEffect_PoisonEffects_Player == 4)
                                            {
                                                Console.WriteLine($"   ┌──YOU ARE TAKING BLEEDING DAMAGE!!!─────────────┐");
                                                Console.WriteLine($"   | Taken {P1_HealthPlaceHolder - P1_Health} Bleeding Damage!  ");
                                                Console.WriteLine($"   └────────────────────────────────────────────────┘");
                                            }
                                        }
                                    }
                                    #endregion
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(HeaderLong);
                                    if (E1_StatusMadMilkedCooldown > 0)
                                    {
                                        P1_Health = P1_Health + (P1_Damage * 60 / 100);
                                        Console.WriteLine($"Gained {P1_Damage * 60 / 100} Health from the attack! [Mad Milk]");
                                    }
                                    if (E1_RoboSandvichResist == true)
                                    {
                                        P1_Damage = P1_Damage - (35 * E1_Damage / 100);
                                        Console.WriteLine($"The Enemy was Protected against 35% of the damage!");
                                    }
                                    if (E1_MeleeWeaponID == 174)
                                    {
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine(Header);
                                        Console.ForegroundColor = Color_Player;
                                        P1_Damage = P1_Damage + (20 * P1_Damage / 100);
                                        Console.WriteLine("The Enemy has taken 20% more damage while holding the Bushwacka!");
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine(Footer);
                                    }
                                    if (P1_Damage > 0)
                                    {
                                        Console.WriteLine($"Your Attack Dealt {P1_Damage} Damage to the {EnemyPrefix} {E1_ClassName}!");
                                    }
                                    E1_Health = E1_Health - P1_Damage;
                                    if (E1_Health < 0) { E1_Health = 0; }
                                    Console.ForegroundColor = Color_Enemy;
                                    Console.WriteLine($"The {EnemyPrefix} {E1_ClassName}'s Remaining HP: {E1_Health}");
                                    Console.ForegroundColor = Color_Game;
                                    Console.WriteLine(FooterLong);
                                    E1_RoboSandvichResist = false;
                                    if (P1_MeleeWeaponID == 153 && P1_ClassID == 7 && P1_Health < P1_MaxHP && P1_Health > 0)
                                    {
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine($"   {HeaderShort}");
                                        Console.ForegroundColor = Color_Player;
                                        Console.WriteLine("      Healed 3 HP! -- Amputator");
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine($"   {FooterShort}");
                                        P1_Health = P1_Health + 3;
                                    }
                                    if (P1_ClassID == 7 && P1_Health < P1_MaxHP && P1_Health > 0)
                                    {
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine($"   {HeaderShort}");
                                        Console.ForegroundColor = Color_Player;
                                        Console.WriteLine("      Regenerated 3 HP!");
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine($"   {FooterShort}");
                                        P1_Health = P1_Health + 3;
                                    }
                                    Thread.Sleep(E1_ThreadSleep);
                                    if (SkipDebug == false)
                                    {
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine(HeaderLong);
                                        Console.ForegroundColor = Color_Player;
                                        Console.WriteLine($"{PlayerName}'s Remaining HP: {P1_Health}");
                                        Console.ForegroundColor = Color_Game;
                                        Console.WriteLine(FooterLong);
                                        Thread.Sleep(P1_ThreadSleep);
                                    }
                                    // For Status Effects to Work, Move Attack Diolouge Out of the PlayerAction if Statements and integrate Effects.

                                    if (E1_Health > 0 && P1_Health > 0)
                                    {
                                        int EnemyAction = EnemyTurn.EnemyChoice(E1_Cooldown);

                                        if (EnemyAction == 1)
                                        {
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"{EnemyPrefix} {E1_ClassName} attacked with their {PrimaryWeapons.SpecificWeaponName(E1_PrimaryWeaponID)}!");
                                            E1_Damage = PrimaryWeapons.Attack(E1_ClassID, E1_PrimaryWeaponID, E1_Cooldown_P, E1_SecondaryTriggerExists, E1_SecondaryTrigger);
                                            if (Medic_PrimaryWeapons.Contains(E1_PrimaryWeaponID))
                                            {
                                                if (E1_Cooldown_P > 0)
                                                {
                                                    E1_Damage = 0;
                                                    Console.WriteLine("The Enemy's Primary Weapon was cooling Down!!");
                                                    Console.WriteLine("They Dealt 0 damage");
                                                }
                                                E1_Cooldown_P = 2;
                                            }
                                            if (Attack_HealWeapons.Contains(E1_PrimaryWeaponID))
                                            {
                                                E1_Health = E1_Health + E1_Damage / 2;
                                                Console.WriteLine(Header);
                                                Console.WriteLine($"   The Enemy Healed {E1_Damage / 2} Health!");
                                                Console.WriteLine(Footer);
                                            }
                                            if (Sniper_PrimaryWeapons_Charging.Contains(E1_PrimaryWeaponID))
                                            {
                                                E1_SecondaryTrigger = 1;
                                            }
                                            if (PrimaryWeapons_CanInflictFire.Contains(E1_PrimaryWeaponID))
                                            {
                                                if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 1)
                                                {
                                                    P1_StatusEffect_1_ID = 1; P1_StatusOnFireCooldown = 4;
                                                }
                                                else if (P1_StatusEffect_1_ID > 0)
                                                {
                                                    if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                    {
                                                        P1_StatusEffect_2_ID = 1; P1_StatusOnFireCooldown = 4;
                                                    }
                                                    else if (P1_StatusEffect_2_ID > 0)
                                                    {
                                                        if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                        {
                                                            P1_StatusEffect_3_ID = 1; P1_StatusOnFireCooldown = 4;
                                                        }
                                                        else if (P1_StatusEffect_3_ID > 0)
                                                        {
                                                            Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                        }
                                                    }
                                                }
                                            }
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(P1_ThreadSleep);

                                        }
                                        if (EnemyAction == 2)
                                        {
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            if (E1_ClassID == 7 && Medic_SecondaryWeapons.Contains(E1_SecondaryWeaponID))
                                            {
                                                if (E1_Cooldown_S == 0)
                                                {
                                                    Console.WriteLine($"{EnemyPrefix} {E1_ClassName} Used their {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}!");
                                                    E1_Damage = SecondaryWeapons.Attack(E1_ClassID, E1_SecondaryWeaponID, E1_Cooldown_S, E1_SecondaryTriggerExists, E1_WeaponSpecialStat);
                                                    E1_Health = E1_Health + E1_Damage;
                                                    Console.WriteLine($"It healed {P1_Damage} Health!");
                                                    E1_Damage = 0;
                                                    E1_Cooldown_S = 5;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{EnemyPrefix} {E1_ClassName} Used their {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}!");
                                                    Console.WriteLine($"It Backfired!!! The {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)} was still Cooling down!!");
                                                    E1_Damage = SecondaryWeapons.Attack(E1_ClassID, E1_SecondaryWeaponID, E1_Cooldown_S, E1_SecondaryTriggerExists, E1_WeaponSpecialStat);
                                                    E1_Health = E1_Health - E1_Damage;
                                                    Console.WriteLine($"It Dealt {E1_Damage} Self-Damage!");
                                                    E1_Damage = 0;
                                                }
                                            }
                                            if (E1_ClassID == 3 && SecondaryWeapons_CanInflictFire.Contains(E1_SecondaryWeaponID))
                                            {
                                                if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 1)
                                                {
                                                    P1_StatusEffect_1_ID = 1; P1_StatusOnFireCooldown = 4;
                                                }
                                                else if (P1_StatusEffect_1_ID > 0)
                                                {
                                                    if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                    {
                                                        P1_StatusEffect_2_ID = 1; P1_StatusOnFireCooldown = 4;
                                                    }
                                                    else if (P1_StatusEffect_2_ID > 0)
                                                    {
                                                        if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                        {
                                                            P1_StatusEffect_3_ID = 1; P1_StatusOnFireCooldown = 4;
                                                        }
                                                        else if (P1_StatusEffect_3_ID > 0)
                                                        {
                                                            Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                        }
                                                    }
                                                }
                                            }
                                            if (E1_ClassID == 1 && E1_SecondaryWeaponID == 15 || E1_SecondaryWeaponID == 16) // Mad Milk & Re-skin
                                            {
                                                if (E1_Cooldown_S > 0)
                                                {
                                                    Console.WriteLine("The Enemy's Mad Milk was still cooling down!");
                                                }
                                                if (E1_Cooldown_S == 0)
                                                {
                                                    Console.WriteLine("The Enemy Threw Mad Milk at You!");
                                                    E1_Damage = 0;
                                                    E1_Cooldown_S = 5;
                                                    if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 2)
                                                    {
                                                        P1_StatusEffect_1_ID = 2; P1_StatusMadMilkedCooldown = 4;
                                                    }
                                                    else if (P1_StatusEffect_1_ID > 0)
                                                    {
                                                        if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 2)
                                                        {
                                                            P1_StatusEffect_2_ID = 2; P1_StatusMadMilkedCooldown = 4;
                                                        }
                                                        else if (P1_StatusEffect_2_ID > 0)
                                                        {
                                                            if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_3_ID == 2)
                                                            {
                                                                P1_StatusEffect_3_ID = 2; P1_StatusMadMilkedCooldown = 3;
                                                            }
                                                            else if (P1_StatusEffect_3_ID > 0)
                                                            {
                                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (E1_ClassID == 8 && E1_SecondaryWeaponID == 167 || E1_SecondaryWeaponID == 168) // Jarate & Re-skin
                                            {
                                                if (E1_Cooldown_S > 0)
                                                {
                                                    Console.WriteLine("The Enemy's Jarate was still cooling down!");
                                                }
                                                if (E1_Cooldown_S == 0)
                                                {
                                                    Console.WriteLine("The Enemy Threw Jarate at You!");
                                                    E1_Damage = 0;
                                                    E1_Cooldown_S = 5;
                                                    E1_Cooldown_S = 5;
                                                    if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 3)
                                                    {
                                                        P1_StatusEffect_1_ID = 3; P1_StatusJaratedCooldown = 4;
                                                    }
                                                    else if (P1_StatusEffect_1_ID > 0)
                                                    {
                                                        if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 3)
                                                        {
                                                            P1_StatusEffect_2_ID = 3; P1_StatusJaratedCooldown = 4;
                                                        }
                                                        else if (P1_StatusEffect_2_ID > 0)
                                                        {
                                                            if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_3_ID == 3)
                                                            {
                                                                P1_StatusEffect_3_ID = 3; P1_StatusJaratedCooldown = 4;
                                                            }
                                                            else if (P1_StatusEffect_3_ID > 0)
                                                            {
                                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (E1_ClassID == 1 && E1_SecondaryWeaponID == 11)
                                            {
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine($"   {HeaderShort}");
                                                Console.ForegroundColor = Color_Player;
                                                Console.WriteLine("      The Enemy Regenerated 3 HP!");
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine($"   {FooterShort}");
                                                E1_Health = E1_Health + 3;
                                            }
                                            if (E1_ClassID == 5 && Heavy_Lunchbox.Contains(E1_SecondaryWeaponID))
                                            {
                                                if (E1_Cooldown_S > 0)
                                                {
                                                    Console.WriteLine(Header);
                                                    Console.WriteLine($"  {EnemyPrefix} {E1_ClassName}'s {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)} is Still being Made!");
                                                    Console.WriteLine(Footer);
                                                    E1_Damage = 0;
                                                }
                                                if (E1_Cooldown_S == 0)
                                                {
                                                    E1_Damage = SecondaryWeapons.Attack(E1_ClassID, E1_SecondaryWeaponID, E1_Cooldown_S, E1_SecondaryTriggerExists, E1_WeaponSpecialStat);
                                                    E1_Health = E1_Health + E1_Damage;
                                                    Console.WriteLine(Header);
                                                    Console.WriteLine($"   {EnemyPrefix} {E1_ClassName} ate a {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}, and Healed {E1_Damage} Health!");
                                                    Console.WriteLine(Footer);
                                                    E1_Damage = 0;
                                                    E1_Cooldown_S = 5;
                                                }
                                                if (E1_SecondaryWeaponID == 112)
                                                {
                                                    E1_RoboSandvichResist = true;
                                                }
                                                if (E1_SecondaryWeaponID == 113)
                                                {
                                                    E1_MaxHP = E1_MaxHP + 50;
                                                }
                                                if (E1_SecondaryWeaponID == 114)
                                                {
                                                    E1_MaxHP = E1_MaxHP + 100;
                                                }
                                                if (E1_SecondaryWeaponID == 115)
                                                {
                                                    E1_Damage = 0;
                                                    if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 7)
                                                    {
                                                        P1_StatusEffect_1_ID = 7; P1_StatusMFDCooldown = 4;
                                                    }
                                                    else if (P1_StatusEffect_1_ID > 0)
                                                    {
                                                        if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 7)
                                                        {
                                                            P1_StatusEffect_2_ID = 7; P1_StatusMFDCooldown = 4;
                                                        }
                                                        else if (P1_StatusEffect_2_ID > 0)
                                                        {
                                                            if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_2_ID == 7)
                                                            {
                                                                P1_StatusEffect_3_ID = 7; P1_StatusMFDCooldown = 4;
                                                            }
                                                            else if (P1_StatusEffect_3_ID > 0)
                                                            {
                                                                Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                            }
                                                        }
                                                    }
                                                }
                                                if (E1_SecondaryWeaponID == 116)
                                                {
                                                    E1_MaxHP = E1_MaxHP + 100;
                                                }
                                                if (E1_Health > E1_MaxHP) { E1_Health = E1_MaxHP; }
                                            }
                                            if (Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(E1_SecondaryWeaponID))
                                            {
                                                Console.WriteLine($"{EnemyPrefix} {E1_ClassName} Detontated {E1_SecondaryTrigger} Stickies with their {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}!");
                                                E1_Damage = SecondaryWeapons.Attack(E1_ClassID, E1_SecondaryWeaponID, E1_Cooldown_S, E1_SecondaryTriggerExists, E1_SecondaryTrigger);
                                                P1_Health = P1_Health - E1_Damage;
                                                if (E1_Damage > 0)
                                                {
                                                    Console.WriteLine($"It dealt {E1_Damage} damage!");
                                                }
                                                if (E1_Damage == 0)
                                                {
                                                    Console.WriteLine($"It dealt 0 damage! The Enemy Should Place Down Stickybombs First!");
                                                }
                                                E1_Damage = 0;
                                                E1_SecondaryTrigger = 0;
                                            }
                                            else
                                            {
                                                if (Medic_SecondaryWeapons.Contains(E1_SecondaryWeaponID) == false && SecondaryWeapons_SlotStealers.Contains(E1_SecondaryWeaponID) == false && Heavy_Lunchbox.Contains(E1_SecondaryWeaponID) == false)
                                                {
                                                    Console.WriteLine($"{EnemyPrefix} {E1_ClassName} attacked with their {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}!");
                                                    E1_Damage = SecondaryWeapons.Attack(E1_ClassID, E1_SecondaryWeaponID, E1_Cooldown_S, E1_SecondaryTriggerExists, E1_WeaponSpecialStat);
                                                }
                                            }
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(E1_ThreadSleep);

                                        }
                                        if (EnemyAction == 3)
                                        {
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"{EnemyPrefix} {E1_ClassName} attacked with their {MeleeWeapons.SpecificWeaponName(E1_MeleeWeaponID)}!");
                                            E1_Damage = MeleeWeapons.Attack(E1_ClassID, E1_MeleeWeaponID, E1_Cooldown_M, E1_SecondaryTriggerExists, E1_Health, E1_MaxHP);
                                            if (E1_MeleeWeaponID == 51)
                                            {
                                                Console.WriteLine("Half-Zatochi Duel Won!");
                                                E1_Damage = P1_Health;
                                            }
                                            if (E1_MeleeWeaponID == 151)
                                            {
                                                E1_Cooldown_S--;
                                                Console.WriteLine($"  {HeaderShort}");
                                                Console.WriteLine($"      - Gained 25% percent Uber on Hit!");
                                                Console.WriteLine($"  {FooterShort}");
                                            }
                                            if (MeleeWeapons_CanInflictFire.Contains(E1_MeleeWeaponID))
                                            {
                                                if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 1)
                                                {
                                                    P1_StatusEffect_1_ID = 1; P1_StatusOnFireCooldown = 4;
                                                }
                                                else if (P1_StatusEffect_1_ID > 0)
                                                {
                                                    if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                    {
                                                        P1_StatusEffect_2_ID = 1; P1_StatusOnFireCooldown = 4;
                                                    }
                                                    else if (P1_StatusEffect_2_ID > 0)
                                                    {
                                                        if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                        {
                                                            P1_StatusEffect_3_ID = 1; P1_StatusOnFireCooldown = 4;
                                                        }
                                                        else if (P1_StatusEffect_3_ID > 0)
                                                        {
                                                            Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                        }
                                                    }
                                                }
                                            }
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(E1_ThreadSleep);
                                        }
                                        if (EnemyAction == 4 && E1_SecondaryTriggerExists == false && Sniper_PrimaryWeapons_Charging.Contains(E1_PrimaryWeaponID) == false && Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(E1_SecondaryWeaponID) == false)
                                        {
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"{EnemyPrefix} {E1_ClassName} attacked with their {MeleeWeapons.SpecificWeaponName(E1_MeleeWeaponID)}!");
                                            E1_Damage = MeleeWeapons.Attack(E1_ClassID, E1_MeleeWeaponID, E1_Cooldown_M, E1_SecondaryTriggerExists, E1_Health, E1_MaxHP);
                                            if (E1_MeleeWeaponID == 51)
                                            {
                                                Console.WriteLine("Half-Zatochi Duel Won!");
                                                E1_Damage = P1_Health;
                                            }
                                            if (MeleeWeapons_CanInflictFire.Contains(E1_MeleeWeaponID))
                                            {
                                                if (P1_StatusEffect_1_ID == 0 || P1_StatusEffect_1_ID == 1)
                                                {
                                                    P1_StatusEffect_1_ID = 1; P1_StatusOnFireCooldown = 4;
                                                }
                                                else if (P1_StatusEffect_1_ID > 0)
                                                {
                                                    if (P1_StatusEffect_2_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                    {
                                                        P1_StatusEffect_2_ID = 1; P1_StatusOnFireCooldown = 4;
                                                    }
                                                    else if (P1_StatusEffect_2_ID > 0)
                                                    {
                                                        if (P1_StatusEffect_3_ID == 0 || P1_StatusEffect_2_ID == 1)
                                                        {
                                                            P1_StatusEffect_3_ID = 1; P1_StatusOnFireCooldown = 4;
                                                        }
                                                        else if (P1_StatusEffect_3_ID > 0)
                                                        {
                                                            Console.WriteLine("Error: All Slots Full. Dropping Effect.");
                                                        }
                                                    }
                                                }
                                            }
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(E1_ThreadSleep);
                                        }
                                        if (EnemyAction == 4 && E1_SecondaryTriggerExists == true)
                                        {
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Player;
                                            if (E1_Cooldown_E == 0)
                                            {
                                                Console.WriteLine($"{E1_SecondaryFunctionAttackString}");
                                                E1_Damage = Misc.SecondaryFunction(E1_ClassID, E1_PrimaryWeaponID, E1_SecondaryWeaponID, E1_MeleeWeaponID, E1_Cooldown_P, E1_Cooldown_S, E1_Cooldown_M, E1_Cooldown_E);
                                                E1_Cooldown_E = 5;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{E1_SecondaryFunctionShort} is Still recharging!");
                                                Console.WriteLine($"The Enemy Dealt 0 Damage!");
                                            }
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(E1_ThreadSleep);
                                        }
                                        if (EnemyAction == 4 && Sniper_PrimaryWeapons_Charging.Contains(E1_PrimaryWeaponID))
                                        {
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"{EnemyPrefix} {E1_ClassName} charged their {PrimaryWeapons.SpecificWeaponName(E1_PrimaryWeaponID)}!");
                                            E1_SecondaryTrigger++;
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(E1_ThreadSleep);
                                        }
                                        if (EnemyAction == 4 && Demoman_SecondaryWeapons_StickyBombLaunchers.Contains(E1_SecondaryWeaponID))
                                        {
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"{EnemyPrefix} {E1_ClassName} Placed a sticky with their {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}!");
                                            E1_SecondaryTrigger++;
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(E1_ThreadSleep);
                                        }
                                        Console.ForegroundColor = Color_Game;
                                        #region BulletEnhancers_Enemy
                                        if (P1_StatusEffect_1_ID > 0 || P1_StatusEffect_2_ID > 0 || P1_StatusEffect_3_ID > 0)
                                        {
                                            bool ForceBreak = false;
                                            if (P1_StatusEffect_1_ID == 3 || P1_StatusEffect_2_ID == 3 || P1_StatusEffect_3_ID == 3)
                                            {
                                                StatusEffect_BulletEnhancer = 3;
                                            }
                                            if (P1_StatusEffect_1_ID == 5 || P1_StatusEffect_2_ID == 5 || P1_StatusEffect_3_ID == 5)
                                            {
                                                StatusEffect_BulletEnhancer = 5;
                                            }
                                            if (P1_StatusEffect_1_ID == 6 || P1_StatusEffect_2_ID == 6 || P1_StatusEffect_3_ID == 6)
                                            {
                                                StatusEffect_BulletEnhancer = 6;
                                            }
                                            if (P1_StatusEffect_1_ID == 7 || P1_StatusEffect_2_ID == 7 || P1_StatusEffect_3_ID == 7)
                                            {
                                                StatusEffect_BulletEnhancer = 7;
                                            }
                                            // ForceBreak if Poison Effect
                                            if (P1_StatusEffect_1_ID == 1 || P1_StatusEffect_2_ID == 1 || P1_StatusEffect_3_ID == 1)
                                            {
                                                StatusEffect_BulletEnhancer = 1;
                                            }
                                            if (P1_StatusEffect_1_ID == 4 || P1_StatusEffect_2_ID == 4 || P1_StatusEffect_3_ID == 4)
                                            {
                                                StatusEffect_BulletEnhancer = 4;
                                            }
                                            if (P1_StatusEffect_1_ID == 2 || P1_StatusEffect_2_ID == 2 || P1_StatusEffect_3_ID == 2)
                                            {
                                                StatusEffect_BulletEnhancer = 2;
                                            }
                                            if (StatusEffect_BulletEnhancer == 1 || StatusEffect_BulletEnhancer == 4 || StatusEffect_BulletEnhancer == 2)
                                            {
                                                ForceBreak = true;
                                            }
                                            int P1_HealthPlaceHolder = P1_Health;
                                            if (ForceBreak == false)
                                            {
                                                int Damage = Misc.BulletEnhancer(StatusEffect_BulletEnhancer, E1_Damage);
                                                P1_Health = P1_Health - Damage;
                                                if (Damage > 0)
                                                { E1_Damage = 0; }
                                            }
                                            if (P1_Health < P1_HealthPlaceHolder)
                                            {
                                                if (StatusEffect_BulletEnhancer == 3)
                                                {
                                                    Console.WriteLine($"   ┌──YOU TOOK JARATE DAMAGE!!!───────────────┐");
                                                    Console.WriteLine($"   | You have taken {P1_HealthPlaceHolder - P1_Health} Damage from the {EnemyPrefix} {E1_ClassName}!");
                                                    Console.WriteLine($"   └──────────────────────────────────────────┘");
                                                    Thread.Sleep(E1_ThreadSleep);
                                                }
                                                if (StatusEffect_BulletEnhancer == 5 || StatusEffect_BulletEnhancer == 7)
                                                {
                                                    Console.WriteLine($"   ┌──YOU TOOK MINI-CRIT DAMAGE!!!───────────────┐");
                                                    Console.WriteLine($"   | You have taken {P1_HealthPlaceHolder - P1_Health} Damage from the {EnemyPrefix} {E1_ClassName}!");
                                                    Console.WriteLine($"   └─────────────────────────────────────────────┘");
                                                    Thread.Sleep(E1_ThreadSleep);
                                                }
                                                if (StatusEffect_BulletEnhancer == 6)
                                                {
                                                    Console.WriteLine($"   ┌──YOU TOOK CRIT DAMAGE!!!────────────────────┐");
                                                    Console.WriteLine($"   | You have taken {P1_HealthPlaceHolder - P1_Health} Damage from the {EnemyPrefix} {E1_ClassName}!");
                                                    Console.WriteLine($"   └─────────────────────────────────────────────┘");
                                                    Thread.Sleep(E1_ThreadSleep);
                                                }
                                            }
                                        }
                                        #endregion

                                        if (P1_StatusMadMilkedCooldown > 0)
                                        {
                                            
                                            
                                            Console.ForegroundColor = Color_Enemy;
                                            E1_Health = E1_Health + (E1_Damage * 60 / 100);
                                            Console.WriteLine($"The Enemy Gained {E1_Damage * 60 / 100} Health from the attack! [Mad Milk]");
                                        }
                                        if (P1_RoboSandvichResist == true)
                                        {
                                            
                                            Console.ForegroundColor = Color_Enemy;
                                            E1_Damage = E1_Damage - (35 * E1_Damage / 100);
                                            Console.WriteLine($"You were Protected against 35% of the damage!");
                                        }

                                        /* Fall Back Code incase everything goes terribly wrong
                                        if (EnemyAction == 1)
                                        {
                                            Console.ResetColor();
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"The {EnemyPrefix} {E1_ClassName} attacked with their {PrimaryWeapons.SpecificWeaponName(E1_PrimaryWeaponID)}!");
                                            E1_Damage = PrimaryWeapons.Attack(E1_ClassID, E1_PrimaryWeaponID, E1_Cooldown, E1_SecondaryTriggerExists, E1_SecondaryTrigger);
                                        }
                                        if (EnemyAction == 2)
                                        {
                                            Console.ResetColor();
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"The {EnemyPrefix} {E1_ClassName} attacked with their {SecondaryWeapons.SpecificWeaponName(E1_SecondaryWeaponID)}!");
                                            E1_Damage = SecondaryWeapons.Attack(E1_ClassID, E1_SecondaryWeaponID, E1_Cooldown, E1_SecondaryTriggerExists, E1_WeaponSpecialStat);
                                        }
                                        if (EnemyAction == 3)
                                        {
                                            Console.ResetColor();
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"The {EnemyPrefix} {E1_ClassName} attacked with their {MeleeWeapons.SpecificWeaponName(E1_MeleeWeaponID)}!");
                                            E1_Damage = MeleeWeapons.Attack(E1_ClassID, E1_MeleeWeaponID, E1_Cooldown, E1_SecondaryTriggerExists, E1_Health, E1_MaxHP);
                                            if (P1_MeleeWeaponID == 51)
                                            {
                                                Console.WriteLine("Half-Zatochi Duel Won! By the Enemy.");
                                                E1_Damage = P1_Health;
                                            }
                                        }
                                        if (EnemyAction == 4)
                                        {
                                            Console.ResetColor();
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"The {EnemyPrefix} {E1_ClassName} attacked with their {MeleeWeapons.SpecificWeaponName(E1_MeleeWeaponID)}!");
                                            E1_Damage = MeleeWeapons.Attack(E1_ClassID, E1_MeleeWeaponID, E1_Cooldown, E1_SecondaryTriggerExists, E1_Health, E1_MaxHP);
                                            if (P1_MeleeWeaponID == 51)
                                            {
                                                Console.WriteLine("Half-Zatochi Duel Won! By the Enemy.");
                                                E1_Damage = P1_Health;
                                            }
                                        }
                                        */
                                        if (E1_Damage > 0)
                                        {
                                            if (P1_StatusMadMilkedCooldown > 0)
                                            {
                                                E1_Health = E1_Health + (E1_Damage * 60 / 100);
                                            }
                                            if (P1_ClassID == 8 && P1_SecondaryWeaponID == 169 || P1_SecondaryWeaponID == 170)
                                            {
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine(Header);
                                                Console.ForegroundColor = Color_Player;
                                                E1_Damage = E1_Damage - (35 * E1_Damage / 100);
                                                Console.WriteLine($"Protected against 35% of the damage!");
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine(Footer);
                                            }
                                            if (P1_MeleeWeaponID == 174)
                                            {
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine(Header);
                                                Console.ForegroundColor = Color_Player;
                                                E1_Damage = E1_Damage + (20 * E1_Damage / 100);
                                                Console.WriteLine("Taken 20% more damage while holding the Bushwacka!");
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine(Footer);
                                            }
                                            if (P1_RoboSandvichResist == true)
                                            {
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine(Header);
                                                Console.ForegroundColor = Color_Player;
                                                E1_Damage = E1_Damage - (35 * E1_Damage / 100);
                                                Console.WriteLine($"  - Protected against 35% damage for this turn!");
                                                Console.ForegroundColor = Color_Game;
                                                Console.WriteLine(Footer);
                                            }
                                            
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(HeaderLong);
                                            Console.ForegroundColor = Color_Enemy;
                                            Console.WriteLine($"It Dealt {E1_Damage} Damage to {PlayerName}!");
                                            P1_Health = P1_Health - E1_Damage;
                                            if (P1_Health < 0) { P1_Health = 0; }
                                            if (P1_Health > 0 && P1_SecondaryWeaponID == 171 && P1_ClassID == 8)
                                            {
                                                Console.ForegroundColor = Color_Player;
                                                Console.WriteLine("Healed 10 Health!");
                                                P1_Health = P1_Health + 10;
                                            }
                                            Console.ForegroundColor = Color_Player;
                                            Console.WriteLine($"{PlayerName}'s Remaining HP: {P1_Health}");
                                            Console.ForegroundColor = Color_Game;
                                            Console.WriteLine(FooterLong);
                                            Thread.Sleep(E1_ThreadSleep);
                                        }
                                    }

                                    // VERY SPECIFIC BOOLS
                                    P1_RoboSandvichResist = false;
                                    
                                    P1_StatusOnFireCooldown--;
                                    P1_StatusJaratedCooldown--;
                                    P1_StatusMadMilkedCooldown--;
                                    P1_StatusBleedingCooldown--;
                                    if (P1_StatusOnFireCooldown < 0) { P1_StatusOnFireCooldown = 0; }
                                    if (P1_StatusJaratedCooldown < 0) { P1_StatusJaratedCooldown = 0; }
                                    if (P1_StatusMadMilkedCooldown < 0) { P1_StatusMadMilkedCooldown = 0; }
                                    if (P1_StatusBleedingCooldown < 0) { P1_StatusBleedingCooldown = 0; }
                                    E1_StatusOnFireCooldown--;
                                    E1_StatusJaratedCooldown--;
                                    E1_StatusMadMilkedCooldown--;
                                    E1_StatusBleedingCooldown--;
                                    if (E1_StatusOnFireCooldown < 0) { E1_StatusOnFireCooldown = 0; }
                                    if (E1_StatusJaratedCooldown < 0) { E1_StatusJaratedCooldown = 0; }
                                    if (E1_StatusMadMilkedCooldown < 0) { E1_StatusMadMilkedCooldown = 0; }
                                    if (E1_StatusBleedingCooldown < 0) { E1_StatusBleedingCooldown = 0; }
                                    P1_Cooldown_P--;
                                    P1_Cooldown_S--;
                                    P1_Cooldown_M--;
                                    P1_Cooldown_E--;
                                    if (P1_Cooldown_P < 0) { P1_Cooldown_P = 0; }
                                    if (P1_Cooldown_S < 0) { P1_Cooldown_S = 0; }
                                    if (P1_Cooldown_M < 0) { P1_Cooldown_M = 0; }
                                    if (P1_Cooldown_E < 0) { P1_Cooldown_E = 0; }
                                    E1_Cooldown_P--;
                                    E1_Cooldown_S--;
                                    E1_Cooldown_M--;
                                    E1_Cooldown_E--;
                                    if (E1_Cooldown_P < 0) { E1_Cooldown_P = 0; }
                                    if (E1_Cooldown_S < 0) { E1_Cooldown_S = 0; }
                                    if (E1_Cooldown_M < 0) { E1_Cooldown_M = 0; }
                                    if (E1_Cooldown_E < 0) { E1_Cooldown_E = 0; }
                                }
                            }
                            bool EndingTriggered = false;
                            if (P1_Health <= 0 && E1_Health <= 0 && EndingTriggered != true)
                            {
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"Your Both Lost this battle! You have been defeated by {EnemyPrefix} {E1_ClassName}, yet you also defeated them");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(3000);
                                EndingTriggered = true;

                            }
                            if (P1_Health <= 0 && EndingTriggered != true && QuittingGame != true)
                            {
                                Console.WriteLine(Header);
                                Console.WriteLine($"Your Health Reached 0! You have been defeated by {EnemyPrefix} {E1_ClassName}.");
                                Thread.Sleep(2000);
                                Console.WriteLine($"They had {E1_Health} Health left when you were defeated.");
                                Console.WriteLine(Footer);
                                Thread.Sleep(3000);
                                EndingTriggered = true;
                            }
                            if (E1_Health <= 0 && EndingTriggered != true)
                            {
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(Header);
                                Console.Write($"You defeated the"); Console.ForegroundColor = Color_Enemy; Console.WriteLine($" {EnemyPrefix} {E1_ClassName}!");
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine();
                                Console.Write($"You had "); Console.ForegroundColor = Color_Player; Console.Write($"{P1_Health} Health"); Console.ForegroundColor = Color_Game; Console.WriteLine(" Left!");
                                Console.WriteLine(Footer);
                                EndingTriggered = true;
                            }
                            #endregion
                            if (EndingTriggered == true)
                            {
                                Thread.Sleep(P1_ThreadSleep);
                                Console.WriteLine(Header);
                                Console.WriteLine($"  Game Over!");
                                Console.WriteLine($"    - Would you like to Play Again?");
                                //Console.WriteLine($"  ");
                                //Console.WriteLine($"  ");
                                Console.WriteLine(Footer);
                                Console.Write("Choice: "); Console.ForegroundColor = Color_Input;
                                string GameResetDecider = Console.ReadLine();
                                if (GameResetDecider.ToLower() == "y" || GameResetDecider.ToLower() == "yes")
                                {
                                    Console.WriteLine($"  {HeaderShort}");
                                    Console.WriteLine("  Reseting Game...");
                                    Console.WriteLine($"  {FooterShort}");
                                    Thread.Sleep(P1_ThreadSleep);
                                    GAMERESET = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}