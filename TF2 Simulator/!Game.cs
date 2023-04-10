// TF2 Text Based Fighting Sim
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Xml.Schema;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace TF2_Simulator
{
    internal class Game
    {
        static void Main(string[] args)
        {
            
            Console.Write("This game uses Saves."); Thread.Sleep(1000); Console.WriteLine(" Checking for Saves... ");
            bool SavesDiscovered = false;
            string Savepath = "";
            string Template = "====Player Information====\r\nPlayer/Save Name: \r\nPlayer Color:\r\nGame Color:\r\nEnemy Color:\r\nInput Color:\r\n\r\n====Inventory====\r\nint ID;\r\nstring n; //Name\r\nint c; //Count\r\nint cID; //Currency\r\nstring cn; //Currency Name\r\nint cCount; //Currency Count\r\n\r\nID = 0; n = \"Error\"; c = 0;\r\nID = 1; n = \"Scattergun\"; c = 0;\r\nID = 2; n = \"Force-A-Nature\"; c = 0;\r\nID = 3; n = \"Shortstop\"; c = 0;\r\nID = 4; n = \"Soda Popper\"; c = 0;\r\nID = 5; n = \"Baby Face's Blaster\"; c = 0;\r\nID = 6; n = \"Back Scatter\"; c = 0;\r\nID = 7; n = \"Pistol\"; c = 0;\r\nID = 8; n = \"Lugermorph\"; c = 0;\r\nID = 9; n = \"C.A.P.P.E.R\"; c = 0;\r\nID = 10; n = \"Winger\"; c = 0;\r\nID = 11; n = \"Pretty Boy's Pocket Pistol\"; c = 0;\r\nID = 12; n = \"Flying Guillotine\"; c = 0;\r\nID = 13; n = \"Bonk! Atomic Punch\"; c = 0;\r\nID = 14; n = \"Crit-a-Cola\"; c = 0;\r\nID = 15; n = \"Mad Milk\"; c = 0;\r\nID = 16; n = \"Mutated Milk\"; c = 0;\r\nID = 17; n = \"Bat\"; c = 0;\r\nID = 18; n = \"Holy Mackerel\"; c = 0;\r\nID = 19; n = \"Unarmed Combat\"; c = 0;\r\nID = 20; n = \"Batsaber\"; c = 0;\r\nID = 21; n = \"Sandman\"; c = 0;\r\nID = 22; n = \"Candy Cane\"; c = 0;\r\nID = 23; n = \"Boston Basher\"; c = 0;\r\nID = 24; n = \"Three-Rune Blade\"; c = 0;\r\nID = 25; n = \"Sun-on-a-Stick\"; c = 0;\r\nID = 26; n = \"Fan O'War\"; c = 0;\r\nID = 27; n = \"Atomizer\"; c = 0;\r\nID = 28; n = \"Wrap Assassin\"; c = 0;\r\nID = 29; n = \"Rocket Launcher\"; c = 0;\r\nID = 30; n = \"Original\"; c = 0;\r\nID = 31; n = \"Direct Hit\"; c = 0;\r\nID = 32; n = \"Black Box\"; c = 0;\r\nID = 33; n = \"Rocket Jumper\"; c = 0;\r\nID = 34; n = \"Liberty Launcher\"; c = 0;\r\nID = 35; n = \"Cow Mangler 5000\"; c = 0;\r\nID = 36; n = \"Beggar's Bazooka\"; c = 0;\r\nID = 37; n = \"Air Strike\"; c = 0;\r\nID = 38; n = \"Shotgun\"; c = 0;\r\nID = 39; n = \"Reserve Shooter\"; c = 0;\r\nID = 40; n = \"Buff Banner\"; c = 0;\r\nID = 41; n = \"Gunboats\"; c = 0;\r\nID = 42; n = \"Battalion's Backup\"; c = 0;\r\nID = 43; n = \"Concheror\"; c = 0;\r\nID = 44; n = \"Mantreads\"; c = 0;\r\nID = 45; n = \"Righteous Bison\"; c = 0;\r\nID = 46; n = \"B.A.S.E. Jumper\"; c = 0;\r\nID = 47; n = \"Panic Attack\"; c = 0;\r\nID = 48; n = \"Shovel\"; c = 0;\r\nID = 49; n = \"Equalizer\"; c = 0;\r\nID = 50; n = \"Pain Train\"; c = 0;\r\nID = 51; n = \"Half-Zatoichi\"; c = 0;\r\nID = 52; n = \"Disciplinary Action\"; c = 0;\r\nID = 53; n = \"Market Gardener\"; c = 0;\r\nID = 54; n = \"Escape Plan\"; c = 0;\r\nID = 55; n = \"Flame Thrower\"; c = 0;\r\nID = 56; n = \"Rainblower\"; c = 0;\r\nID = 57; n = \"Nostromo Napalmer\"; c = 0;\r\nID = 58; n = \"Backburner\"; c = 0;\r\nID = 59; n = \"Degreaser\"; c = 0;\r\nID = 60; n = \"Phlogistinator\"; c = 0;\r\nID = 61; n = \"Dragon's Fury\"; c = 0;\r\nID = 62; n = \"Flare Gun\"; c = 0;\r\nID = 63; n = \"Detonator\"; c = 0;\r\nID = 64; n = \"Manmelter\"; c = 0;\r\nID = 65; n = \"Scorch Shot\"; c = 0;\r\nID = 66; n = \"Thermal Thruster\"; c = 0;\r\nID = 67; n = \"Gas Passer\"; c = 0;\r\nID = 68; n = \"Fire Axe\"; c = 0;\r\nID = 69; n = \"Lollichop\"; c = 0;\r\nID = 70; n = \"Axtinguisher\"; c = 0;\r\nID = 71; n = \"Postal Pummeler\"; c = 0;\r\nID = 72; n = \"Homewrecker\"; c = 0;\r\nID = 73; n = \"Maul\"; c = 0;\r\nID = 74; n = \"Powerjack\"; c = 0;\r\nID = 75; n = \"Back Scratcher\"; c = 0;\r\nID = 76; n = \"Sharpened Volcano Fragment\"; c = 0;\r\nID = 77; n = \"Third Degree\"; c = 0;\r\nID = 78; n = \"Neon Annihilator\"; c = 0;\r\nID = 79; n = \"Hot Hand\"; c = 0;\r\nID = 80; n = \"Grenade Launcher\"; c = 0;\r\nID = 81; n = \"Loch-n-Load\"; c = 0;\r\nID = 82; n = \"Ali Baba's Wee Booties\"; c = 0;\r\nID = 83; n = \"Bootlegger\"; c = 0;\r\nID = 84; n = \"Loose Cannon\"; c = 0;\r\nID = 85; n = \"Iron Bomber\"; c = 0;\r\nID = 86; n = \"Stickybomb Launcher\"; c = 0;\r\nID = 87; n = \"Scottish Resistance\"; c = 0;\r\nID = 88; n = \"Chargin' Targe\"; c = 0;\r\nID = 89; n = \"Sticky Jumper\"; c = 0;\r\nID = 90; n = \"Splendid Screen\"; c = 0;\r\nID = 91; n = \"Tide Turner\"; c = 0;\r\nID = 92; n = \"Quickiebomb Launcher\"; c = 0;\r\nID = 93; n = \"Bottle\"; c = 0;\r\nID = 94; n = \"Scottish Handshake\"; c = 0;\r\nID = 95; n = \"Eyelander\"; c = 0;\r\nID = 96; n = \"Horseless Headless Horsemann's Headtaker\"; c = 0;\r\nID = 97; n = \"Nessie's Nine Iron\"; c = 0;\r\nID = 98; n = \"Scotsman's Skullcutter\"; c = 0;\r\nID = 99; n = \"Pain Train\"; c = 0;\r\nID = 100; n = \"Ullapool Caber\"; c = 0;\r\nID = 101; n = \"Claidheamh Mòr\"; c = 0;\r\nID = 102; n = \"Half-Zatoichi\"; c = 0;\r\nID = 103; n = \"Persian Persuader\"; c = 0;\r\nID = 104; n = \"Minigun\"; c = 0;\r\nID = 105; n = \"Iron Curtain\"; c = 0;\r\nID = 106; n = \"Natascha\"; c = 0;\r\nID = 107; n = \"Brass Beast\"; c = 0;\r\nID = 108; n = \"Tomislav\"; c = 0;\r\nID = 109; n = \"Huo-Long Heater\"; c = 0;\r\nID = 110; n = \"Family Business\"; c = 0;\r\nID = 111; n = \"Sandvich\"; c = 0;\r\nID = 112; n = \"Robo-Sandvich\"; c = 0;\r\nID = 113; n = \"Dalokohs Bar\"; c = 0;\r\nID = 114; n = \"Fishcake\"; c = 0;\r\nID = 115; n = \"Buffalo Steak Sandvich\"; c = 0;\r\nID = 116; n = \"Panic Attack\"; c = 0;\r\nID = 117; n = \"Second Banana\"; c = 0;\r\nID = 118; n = \"Fists\"; c = 0;\r\nID = 119; n = \"Apoco-Fists\"; c = 0;\r\nID = 120; n = \"Killing Gloves of Boxing\"; c = 0;\r\nID = 121; n = \"Gloves of Running Urgently\"; c = 0;\r\nID = 122; n = \"Bread Bite\"; c = 0;\r\nID = 123; n = \"Warrior's Spirit\"; c = 0;\r\nID = 124; n = \"Fists of Steel\"; c = 0;\r\nID = 125; n = \"Eviction Notice\"; c = 0;\r\nID = 126; n = \"Holiday Punch\"; c = 0;\r\nID = 127; n = \"Frontier Justice\"; c = 0;\r\nID = 128; n = \"Widowmaker\"; c = 0;\r\nID = 129; n = \"Pomson 6000\"; c = 0;\r\nID = 130; n = \"Rescue Ranger\"; c = 0;\r\nID = 131; n = \"Wrangler\"; c = 0;\r\nID = 132; n = \"Giger Counter\"; c = 0;\r\nID = 133; n = \"Short Circuit\"; c = 0;\r\nID = 134; n = \"Wrench\"; c = 0;\r\nID = 135; n = \"Golden Wrench\"; c = 0;\r\nID = 136; n = \"Gunslinger\"; c = 0;\r\nID = 137; n = \"Southern Hospitality\"; c = 0;\r\nID = 138; n = \"Jag\"; c = 0;\r\nID = 139; n = \"Eureka Effect\"; c = 0;\r\nID = 140; n = \"Consturction PDA\"; c = 0;\r\nID = 141; n = \"Destruction PDA\"; c = 0;\r\nID = 142; n = \"Syringe Gun\"; c = 0;\r\nID = 143; n = \"Blutsauger\"; c = 0;\r\nID = 144; n = \"Crusader's Crossbow\"; c = 0;\r\nID = 145; n = \"Overdose\"; c = 0;\r\nID = 146; n = \"Medi Gun\"; c = 0;\r\nID = 147; n = \"Kritzkrieg\"; c = 0;\r\nID = 148; n = \"Quick-Fix\"; c = 0;\r\nID = 149; n = \"Vaccinator\"; c = 0;\r\nID = 150; n = \"Bonesaw\"; c = 0;\r\nID = 151; n = \"Übersaw\"; c = 0;\r\nID = 152; n = \"Vita-Saw\"; c = 0;\r\nID = 153; n = \"Amputator\"; c = 0;\r\nID = 154; n = \"Solemn Vow\"; c = 0;\r\nID = 155; n = \"Sniper Rifle\"; c = 0;\r\nID = 156; n = \"AWPer Hand\"; c = 0;\r\nID = 157; n = \"Huntsman\"; c = 0;\r\nID = 158; n = \"Fortified Compound\"; c = 0;\r\nID = 159; n = \"Sydney Sleeper\"; c = 0;\r\nID = 160; n = \"Bazaar Bargain\"; c = 0;\r\nID = 161; n = \"Machina\"; c = 0;\r\nID = 162; n = \"Shooting Star\"; c = 0;\r\nID = 163; n = \"Hitman's Heatmaker\"; c = 0;\r\nID = 164; n = \"Classic\"; c = 0;\r\nID = 165; n = \"SMG\"; c = 0;\r\nID = 166; n = \"Cleaner's Carbine\"; c = 0;\r\nID = 167; n = \"Jarate\"; c = 0;\r\nID = 168; n = \"Self-Aware Beauty Mark\"; c = 0;\r\nID = 169; n = \"Razorback\"; c = 0;\r\nID = 170; n = \"Darwin's Danger Shield\"; c = 0;\r\nID = 171; n = \"Cozy Camper\"; c = 0;\r\nID = 172; n = \"Kukri\"; c = 0;\r\nID = 173; n = \"Tribalman's Shiv\"; c = 0;\r\nID = 174; n = \"Bushwacka\"; c = 0;\r\nID = 175; n = \"Shahanshah\"; c = 0;\r\nID = 176; n = \"Revolver\"; c = 0;\r\nID = 177; n = \"Big Kill\"; c = 0;\r\nID = 178; n = \"Ambassador\"; c = 0;\r\nID = 179; n = \"L'Etranger\"; c = 0;\r\nID = 180; n = \"Enforcer\"; c = 0;\r\nID = 181; n = \"Diamondback\"; c = 0;\r\nID = 182; n = \"Knife\"; c = 0;\r\nID = 183; n = \"Sharp Dresser\"; c = 0;\r\nID = 184; n = \"Black Rose\"; c = 0;\r\nID = 185; n = \"Your Eternal Reward\"; c = 0;\r\nID = 186; n = \"Wanga Prick\"; c = 0;\r\nID = 187; n = \"Conniver's Kunai\"; c = 0;\r\nID = 188; n = \"Big Earner\"; c = 0;\r\nID = 189; n = \"Spy-cicle\"; c = 0;\r\nID = 190; n = \"Disguise Kit\"; c = 0;\r\nID = 191; n = \"Invis Watch\"; c = 0;\r\nID = 192; n = \"Enthusiast's Timepiece\"; c = 0;\r\nID = 193; n = \"Quäckenbirdt\"; c = 0;\r\nID = 194; n = \"Cloak and Dagger\"; c = 0;\r\nID = 195; n = \"Dead Ringer\"; c = 0;\r\nID = 196; n = \"Sapper\"; c = 0;\r\nID = 197; n = \"Ap-Sap\"; c = 0;\r\nID = 198; n = \"Snack Attack\"; c = 0;\r\nID = 199; n = \"Red-Tape Recorder\"; c = 0;\r\nID = 200; n = \"Saxxy\"; c = 0;\r\nID = 201; n = \"Frying Pan\"; c = 0;\r\nID = 202; n = \"Conscientious Objector\"; c = 0;\r\nID = 203; n = \"Freedom Staff\"; c = 0;\r\nID = 204; n = \"Bat Outta Hell\"; c = 0;\r\nID = 205; n = \"Memory Maker\"; c = 0;\r\nID = 206; n = \"Ham Shank\"; c = 0;\r\nID = 207; n = \"Necro Smasher\"; c = 0;\r\nID = 208; n = \"Crossing Guard\"; c = 0;\r\nID = 209; n = \"Prinny Machete\"; c = 0;\r\nID = 210; n = \"Golden Frying Pan\"; c = 0;\r\nID = 211; n = \"Legendary Ticket\"; c = 0;\r\nID = 212; n = \"Backpack Expander\"; c = 0;\r\n\r\ncID = 0; cn = \"Error\"; cCount = 0; \r\ncID = 1; cn = \"Half-Scrap\"; cCount = 0;\r\ncID = 2; cn = \"Scrap\"; cCount = 0;\r\ncID = 3; cn = \"Reclaimed\"; cCount = 0;\r\ncID = 4; cn = \"Refined\"; cCount = 0;\r\n\r\n====Special Items====\r\nint legendaryID;\r\nint legendslot1;\r\nint legendslot2;\r\nint legendslot3;\r\nSyntax: ID = #; n = Inventory.IDtoName(ID); c = ++; legendslot1 = legendaryID.Next(1,11);  legendslot2 = legendaryID.Next(1,11); legendslot3 = legendaryID.Next(1,11);\r\nList Begins on Line 243.";


            for (int i = 1; i <= 100; i++)
            {
                Savepath = $@"C:\Users\Public\Documents\TF2Sim\Save_{i}.txt";
            try
            {
                    if (File.Exists(Savepath))
                    {
                        Console.WriteLine($"[{i}. (PlayerName) | Inventory [(InventoryCount)/(MaxInventory)]");
                        
                        SavesDiscovered = true;
                        //writes to file
                        //System.IO.File.WriteAllText(Savepath, "This File Exists.\n");
                        //Inventory.InventoryLoader(); //SUPER BROKEN
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if (SavesDiscovered == false)
                {
                    Console.WriteLine("There was no Save File Found, Would you like to create one? [Type 'Yes' to Confirm]");
                    Console.WriteLine($"Current Directory: {Savepath}");
                    string FileAuthorization = Console.ReadLine();
                    if (FileAuthorization.ToLower() == "yes")
                    {
                        System.IO.File.WriteAllText(Savepath, Template);
                    }
                }
            }
            Console.WriteLine("Would you like to load a file or create a new one?");
            Console.WriteLine("Type 'New save' to create a new save or type the save's number to load it.");
            string SaveChoice = Console.ReadLine();
            if (int.TryParse(SaveChoice, out int SaveInt)) 
            {
                //SaveFile.SaveLoad(SaveInt);
            }
            else if (SaveChoice.ToLower() == "new save")
            {
                System.IO.File.WriteAllText(Savepath, Template);
            }
            else
            {
                Console.WriteLine("Something went wrong with the Selection, Starting without a save.");
            }
            try
            {
                if (File.Exists(Savepath))
                {
                    Console.WriteLine("Save File Found!");
                }
                else
                {
                    // Create the file.
                    Console.WriteLine("There was no Save File Found, Would you like to create one? [Type 'Yes' to Confirm]");
                    Console.WriteLine($"Current Directory: {Savepath}");
                    string FileAuthorization = Console.ReadLine();
                    if (FileAuthorization.ToLower() == "yes")
                    { 
                        System.IO.File.WriteAllText(Savepath, "====Player Information====\r\nPlayer/Save Name: \r\nPlayer Color:\r\nGame Color:\r\nEnemy Color:\r\nInput Color:\r\n\r\n====Inventory====\r\nint ID;\r\nstring n; //Name\r\nint c; //Count\r\nint cID; //Currency\r\nstring cn; //Currency Name\r\nint cCount; //Currency Count\r\n\r\nID = 0; n = \"Error\"; c = 0;\r\nID = 1; n = \"Scattergun\"; c = 0;\r\nID = 2; n = \"Force-A-Nature\"; c = 0;\r\nID = 3; n = \"Shortstop\"; c = 0;\r\nID = 4; n = \"Soda Popper\"; c = 0;\r\nID = 5; n = \"Baby Face's Blaster\"; c = 0;\r\nID = 6; n = \"Back Scatter\"; c = 0;\r\nID = 7; n = \"Pistol\"; c = 0;\r\nID = 8; n = \"Lugermorph\"; c = 0;\r\nID = 9; n = \"C.A.P.P.E.R\"; c = 0;\r\nID = 10; n = \"Winger\"; c = 0;\r\nID = 11; n = \"Pretty Boy's Pocket Pistol\"; c = 0;\r\nID = 12; n = \"Flying Guillotine\"; c = 0;\r\nID = 13; n = \"Bonk! Atomic Punch\"; c = 0;\r\nID = 14; n = \"Crit-a-Cola\"; c = 0;\r\nID = 15; n = \"Mad Milk\"; c = 0;\r\nID = 16; n = \"Mutated Milk\"; c = 0;\r\nID = 17; n = \"Bat\"; c = 0;\r\nID = 18; n = \"Holy Mackerel\"; c = 0;\r\nID = 19; n = \"Unarmed Combat\"; c = 0;\r\nID = 20; n = \"Batsaber\"; c = 0;\r\nID = 21; n = \"Sandman\"; c = 0;\r\nID = 22; n = \"Candy Cane\"; c = 0;\r\nID = 23; n = \"Boston Basher\"; c = 0;\r\nID = 24; n = \"Three-Rune Blade\"; c = 0;\r\nID = 25; n = \"Sun-on-a-Stick\"; c = 0;\r\nID = 26; n = \"Fan O'War\"; c = 0;\r\nID = 27; n = \"Atomizer\"; c = 0;\r\nID = 28; n = \"Wrap Assassin\"; c = 0;\r\nID = 29; n = \"Rocket Launcher\"; c = 0;\r\nID = 30; n = \"Original\"; c = 0;\r\nID = 31; n = \"Direct Hit\"; c = 0;\r\nID = 32; n = \"Black Box\"; c = 0;\r\nID = 33; n = \"Rocket Jumper\"; c = 0;\r\nID = 34; n = \"Liberty Launcher\"; c = 0;\r\nID = 35; n = \"Cow Mangler 5000\"; c = 0;\r\nID = 36; n = \"Beggar's Bazooka\"; c = 0;\r\nID = 37; n = \"Air Strike\"; c = 0;\r\nID = 38; n = \"Shotgun\"; c = 0;\r\nID = 39; n = \"Reserve Shooter\"; c = 0;\r\nID = 40; n = \"Buff Banner\"; c = 0;\r\nID = 41; n = \"Gunboats\"; c = 0;\r\nID = 42; n = \"Battalion's Backup\"; c = 0;\r\nID = 43; n = \"Concheror\"; c = 0;\r\nID = 44; n = \"Mantreads\"; c = 0;\r\nID = 45; n = \"Righteous Bison\"; c = 0;\r\nID = 46; n = \"B.A.S.E. Jumper\"; c = 0;\r\nID = 47; n = \"Panic Attack\"; c = 0;\r\nID = 48; n = \"Shovel\"; c = 0;\r\nID = 49; n = \"Equalizer\"; c = 0;\r\nID = 50; n = \"Pain Train\"; c = 0;\r\nID = 51; n = \"Half-Zatoichi\"; c = 0;\r\nID = 52; n = \"Disciplinary Action\"; c = 0;\r\nID = 53; n = \"Market Gardener\"; c = 0;\r\nID = 54; n = \"Escape Plan\"; c = 0;\r\nID = 55; n = \"Flame Thrower\"; c = 0;\r\nID = 56; n = \"Rainblower\"; c = 0;\r\nID = 57; n = \"Nostromo Napalmer\"; c = 0;\r\nID = 58; n = \"Backburner\"; c = 0;\r\nID = 59; n = \"Degreaser\"; c = 0;\r\nID = 60; n = \"Phlogistinator\"; c = 0;\r\nID = 61; n = \"Dragon's Fury\"; c = 0;\r\nID = 62; n = \"Flare Gun\"; c = 0;\r\nID = 63; n = \"Detonator\"; c = 0;\r\nID = 64; n = \"Manmelter\"; c = 0;\r\nID = 65; n = \"Scorch Shot\"; c = 0;\r\nID = 66; n = \"Thermal Thruster\"; c = 0;\r\nID = 67; n = \"Gas Passer\"; c = 0;\r\nID = 68; n = \"Fire Axe\"; c = 0;\r\nID = 69; n = \"Lollichop\"; c = 0;\r\nID = 70; n = \"Axtinguisher\"; c = 0;\r\nID = 71; n = \"Postal Pummeler\"; c = 0;\r\nID = 72; n = \"Homewrecker\"; c = 0;\r\nID = 73; n = \"Maul\"; c = 0;\r\nID = 74; n = \"Powerjack\"; c = 0;\r\nID = 75; n = \"Back Scratcher\"; c = 0;\r\nID = 76; n = \"Sharpened Volcano Fragment\"; c = 0;\r\nID = 77; n = \"Third Degree\"; c = 0;\r\nID = 78; n = \"Neon Annihilator\"; c = 0;\r\nID = 79; n = \"Hot Hand\"; c = 0;\r\nID = 80; n = \"Grenade Launcher\"; c = 0;\r\nID = 81; n = \"Loch-n-Load\"; c = 0;\r\nID = 82; n = \"Ali Baba's Wee Booties\"; c = 0;\r\nID = 83; n = \"Bootlegger\"; c = 0;\r\nID = 84; n = \"Loose Cannon\"; c = 0;\r\nID = 85; n = \"Iron Bomber\"; c = 0;\r\nID = 86; n = \"Stickybomb Launcher\"; c = 0;\r\nID = 87; n = \"Scottish Resistance\"; c = 0;\r\nID = 88; n = \"Chargin' Targe\"; c = 0;\r\nID = 89; n = \"Sticky Jumper\"; c = 0;\r\nID = 90; n = \"Splendid Screen\"; c = 0;\r\nID = 91; n = \"Tide Turner\"; c = 0;\r\nID = 92; n = \"Quickiebomb Launcher\"; c = 0;\r\nID = 93; n = \"Bottle\"; c = 0;\r\nID = 94; n = \"Scottish Handshake\"; c = 0;\r\nID = 95; n = \"Eyelander\"; c = 0;\r\nID = 96; n = \"Horseless Headless Horsemann's Headtaker\"; c = 0;\r\nID = 97; n = \"Nessie's Nine Iron\"; c = 0;\r\nID = 98; n = \"Scotsman's Skullcutter\"; c = 0;\r\nID = 99; n = \"Pain Train\"; c = 0;\r\nID = 100; n = \"Ullapool Caber\"; c = 0;\r\nID = 101; n = \"Claidheamh Mòr\"; c = 0;\r\nID = 102; n = \"Half-Zatoichi\"; c = 0;\r\nID = 103; n = \"Persian Persuader\"; c = 0;\r\nID = 104; n = \"Minigun\"; c = 0;\r\nID = 105; n = \"Iron Curtain\"; c = 0;\r\nID = 106; n = \"Natascha\"; c = 0;\r\nID = 107; n = \"Brass Beast\"; c = 0;\r\nID = 108; n = \"Tomislav\"; c = 0;\r\nID = 109; n = \"Huo-Long Heater\"; c = 0;\r\nID = 110; n = \"Family Business\"; c = 0;\r\nID = 111; n = \"Sandvich\"; c = 0;\r\nID = 112; n = \"Robo-Sandvich\"; c = 0;\r\nID = 113; n = \"Dalokohs Bar\"; c = 0;\r\nID = 114; n = \"Fishcake\"; c = 0;\r\nID = 115; n = \"Buffalo Steak Sandvich\"; c = 0;\r\nID = 116; n = \"Panic Attack\"; c = 0;\r\nID = 117; n = \"Second Banana\"; c = 0;\r\nID = 118; n = \"Fists\"; c = 0;\r\nID = 119; n = \"Apoco-Fists\"; c = 0;\r\nID = 120; n = \"Killing Gloves of Boxing\"; c = 0;\r\nID = 121; n = \"Gloves of Running Urgently\"; c = 0;\r\nID = 122; n = \"Bread Bite\"; c = 0;\r\nID = 123; n = \"Warrior's Spirit\"; c = 0;\r\nID = 124; n = \"Fists of Steel\"; c = 0;\r\nID = 125; n = \"Eviction Notice\"; c = 0;\r\nID = 126; n = \"Holiday Punch\"; c = 0;\r\nID = 127; n = \"Frontier Justice\"; c = 0;\r\nID = 128; n = \"Widowmaker\"; c = 0;\r\nID = 129; n = \"Pomson 6000\"; c = 0;\r\nID = 130; n = \"Rescue Ranger\"; c = 0;\r\nID = 131; n = \"Wrangler\"; c = 0;\r\nID = 132; n = \"Giger Counter\"; c = 0;\r\nID = 133; n = \"Short Circuit\"; c = 0;\r\nID = 134; n = \"Wrench\"; c = 0;\r\nID = 135; n = \"Golden Wrench\"; c = 0;\r\nID = 136; n = \"Gunslinger\"; c = 0;\r\nID = 137; n = \"Southern Hospitality\"; c = 0;\r\nID = 138; n = \"Jag\"; c = 0;\r\nID = 139; n = \"Eureka Effect\"; c = 0;\r\nID = 140; n = \"Consturction PDA\"; c = 0;\r\nID = 141; n = \"Destruction PDA\"; c = 0;\r\nID = 142; n = \"Syringe Gun\"; c = 0;\r\nID = 143; n = \"Blutsauger\"; c = 0;\r\nID = 144; n = \"Crusader's Crossbow\"; c = 0;\r\nID = 145; n = \"Overdose\"; c = 0;\r\nID = 146; n = \"Medi Gun\"; c = 0;\r\nID = 147; n = \"Kritzkrieg\"; c = 0;\r\nID = 148; n = \"Quick-Fix\"; c = 0;\r\nID = 149; n = \"Vaccinator\"; c = 0;\r\nID = 150; n = \"Bonesaw\"; c = 0;\r\nID = 151; n = \"Übersaw\"; c = 0;\r\nID = 152; n = \"Vita-Saw\"; c = 0;\r\nID = 153; n = \"Amputator\"; c = 0;\r\nID = 154; n = \"Solemn Vow\"; c = 0;\r\nID = 155; n = \"Sniper Rifle\"; c = 0;\r\nID = 156; n = \"AWPer Hand\"; c = 0;\r\nID = 157; n = \"Huntsman\"; c = 0;\r\nID = 158; n = \"Fortified Compound\"; c = 0;\r\nID = 159; n = \"Sydney Sleeper\"; c = 0;\r\nID = 160; n = \"Bazaar Bargain\"; c = 0;\r\nID = 161; n = \"Machina\"; c = 0;\r\nID = 162; n = \"Shooting Star\"; c = 0;\r\nID = 163; n = \"Hitman's Heatmaker\"; c = 0;\r\nID = 164; n = \"Classic\"; c = 0;\r\nID = 165; n = \"SMG\"; c = 0;\r\nID = 166; n = \"Cleaner's Carbine\"; c = 0;\r\nID = 167; n = \"Jarate\"; c = 0;\r\nID = 168; n = \"Self-Aware Beauty Mark\"; c = 0;\r\nID = 169; n = \"Razorback\"; c = 0;\r\nID = 170; n = \"Darwin's Danger Shield\"; c = 0;\r\nID = 171; n = \"Cozy Camper\"; c = 0;\r\nID = 172; n = \"Kukri\"; c = 0;\r\nID = 173; n = \"Tribalman's Shiv\"; c = 0;\r\nID = 174; n = \"Bushwacka\"; c = 0;\r\nID = 175; n = \"Shahanshah\"; c = 0;\r\nID = 176; n = \"Revolver\"; c = 0;\r\nID = 177; n = \"Big Kill\"; c = 0;\r\nID = 178; n = \"Ambassador\"; c = 0;\r\nID = 179; n = \"L'Etranger\"; c = 0;\r\nID = 180; n = \"Enforcer\"; c = 0;\r\nID = 181; n = \"Diamondback\"; c = 0;\r\nID = 182; n = \"Knife\"; c = 0;\r\nID = 183; n = \"Sharp Dresser\"; c = 0;\r\nID = 184; n = \"Black Rose\"; c = 0;\r\nID = 185; n = \"Your Eternal Reward\"; c = 0;\r\nID = 186; n = \"Wanga Prick\"; c = 0;\r\nID = 187; n = \"Conniver's Kunai\"; c = 0;\r\nID = 188; n = \"Big Earner\"; c = 0;\r\nID = 189; n = \"Spy-cicle\"; c = 0;\r\nID = 190; n = \"Disguise Kit\"; c = 0;\r\nID = 191; n = \"Invis Watch\"; c = 0;\r\nID = 192; n = \"Enthusiast's Timepiece\"; c = 0;\r\nID = 193; n = \"Quäckenbirdt\"; c = 0;\r\nID = 194; n = \"Cloak and Dagger\"; c = 0;\r\nID = 195; n = \"Dead Ringer\"; c = 0;\r\nID = 196; n = \"Sapper\"; c = 0;\r\nID = 197; n = \"Ap-Sap\"; c = 0;\r\nID = 198; n = \"Snack Attack\"; c = 0;\r\nID = 199; n = \"Red-Tape Recorder\"; c = 0;\r\nID = 200; n = \"Saxxy\"; c = 0;\r\nID = 201; n = \"Frying Pan\"; c = 0;\r\nID = 202; n = \"Conscientious Objector\"; c = 0;\r\nID = 203; n = \"Freedom Staff\"; c = 0;\r\nID = 204; n = \"Bat Outta Hell\"; c = 0;\r\nID = 205; n = \"Memory Maker\"; c = 0;\r\nID = 206; n = \"Ham Shank\"; c = 0;\r\nID = 207; n = \"Necro Smasher\"; c = 0;\r\nID = 208; n = \"Crossing Guard\"; c = 0;\r\nID = 209; n = \"Prinny Machete\"; c = 0;\r\nID = 210; n = \"Golden Frying Pan\"; c = 0;\r\nID = 211; n = \"Legendary Ticket\"; c = 0;\r\nID = 212; n = \"Backpack Expander\"; c = 0;\r\n\r\ncID = 0; cn = \"Error\"; cCount = 0; \r\ncID = 1; cn = \"Half-Scrap\"; cCount = 0;\r\ncID = 2; cn = \"Scrap\"; cCount = 0;\r\ncID = 3; cn = \"Reclaimed\"; cCount = 0;\r\ncID = 4; cn = \"Refined\"; cCount = 0;\r\n\r\n====Special Items====\r\nint legendaryID;\r\nint legendslot1;\r\nint legendslot2;\r\nint legendslot3;\r\nSyntax: ID = #; n = Inventory.IDtoName(ID); c = ++; legendslot1 = legendaryID.Next(1,11);  legendslot2 = legendaryID.Next(1,11); legendslot3 = legendaryID.Next(1,11);\r\nList Begins on Line 243.");
                    }

                }
                /*
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(Savepath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
            Console.WriteLine("Waiting.....");
            Thread.Sleep(1000);
           
            Console.Clear();
            Console.Write("What is your Name: ");
            string PlayerName = Console.ReadLine();
            string EnemyPrefix = "Enemy";
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
            if (PlayerName == "")
            {
                PlayerName = "someone who apparently doesn't have a name";
            }
            #region Secret Names
            if (PlayerName.StartsWith("BLU "))
            {
                EnemyPrefix = "RED";
                Color_Player = ConsoleColor.DarkCyan;
                Color_Enemy = ConsoleColor.DarkRed;

            }
            if (PlayerName.StartsWith("RED "))
            {
                EnemyPrefix = "BLU";
                Color_Player = ConsoleColor.DarkRed;
                Color_Enemy = ConsoleColor.DarkCyan;
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
            #region Contains a Color

            //Checks all colors.
            #endregion
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
            #region Dividers & Borders
            string Header = "┌────────────────────────┬────────────────────────┐";
            string Footer = "└────────────────────────┴────────────────────────┘";
            string HeaderShort = "┌───────────────┬───────────────┐";
            string FooterShort = "└───────────────┴───────────────┘";
            string HeaderLong = "┌────────────────────────────────────────────────┬────────────────────────────────────────────────┐";
            string FooterLong = "└────────────────────────────────────────────────┴────────────────────────────────────────────────┘";
            #endregion
            #region PlayerStats V2
            //Information
            int P1_Health = 0;
            string P1_MaxHP = "Not Set";
            int P1_ClassID = 0;
            string P1_ClassName = "Not Set";
            int P1_PrimaryWeaponID = 0;
            int P1_SecondaryWeaponID = 0;
            int P1_MeleeWeaponID = 0;
            //Status
            int P1_Cooldown = 0;
            int P1_StatusEffect_1_ID = 0;
            int P1_StatusEffect_2_ID = 0;
            int P1_StatusEffect_3_ID = 0;
            bool P1_SecondaryTrigger = false;
            //Value Holders
            int P1_PrimaryDamage = 0;
            int P1_SecondaryDamage = 0;
            int P1_MeleeDamage = 0;


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
                Console.ForegroundColor = Color_Player;
                Console.WriteLine($"Welcome {PlayerName}!");
                Console.ForegroundColor = Color_Enemy;
                Console.WriteLine($"Enemy Prefix: {EnemyPrefix}");
                Console.ForegroundColor = Color_Game;
                Console.WriteLine("Pick your class! or type '!Help' to view the class choices and other important info!");
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
                Console.WriteLine("  Quick Commands");
                Console.WriteLine("  10. Help");
                Console.WriteLine("  11. Clear Color(s)");
                Console.WriteLine("  12. Set Game Colors");
                Console.WriteLine("  13. Set Enemy Prefix");
                Console.WriteLine("  14. Test Loadouts");
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

                #endregion
                #region Help Menu
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
                        P1_MaxHP = Classes.ClassHealthfromID(P1_ClassID).ToString();
                        Console.WriteLine(Header);
                        Console.WriteLine($"  ClassID: {P1_ClassID}");
                        Console.WriteLine($"  Player Class: {P1_ClassName}");
                        Console.WriteLine($"  Health: {P1_Health}/{P1_MaxHP}");
                        Console.WriteLine(Footer);
                        Thread.Sleep(2000);
                        //Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(Header);
                        bool Selecting_Loadout = true;
                        while (Selecting_Loadout == true) 
                        {
                            Selecting_Loadout = false;
                            Console.Clear();
                            Console.WriteLine(Header);
                            Console.WriteLine($"Select your Loadout!");
                            Console.WriteLine($"1.  Primary Weapon: {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}");
                            Console.WriteLine($"2.  Secondary Weapon: {P1_SecondaryWeaponID}"); //SecondaryWeapons.SpecificWeaponName(P1_SecondaryWeaponID)
                            Console.WriteLine($"3.  Melee Weapon: {P1_MeleeWeaponID}"); //MeleeWeapons.SpecificWeaponName(P1_MeleeWeaponID)
                            Console.WriteLine(Footer);
                            Console.Write($"Choice: "); Console.ForegroundColor = Color_Input;
                            string LoadoutChoice = Console.ReadLine();
                            if (LoadoutChoice == "1")
                            {
                                Console.Clear();
                                Console.ResetColor();
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(Header);
                                Console.WriteLine($"  === Class: {P1_ClassName}");
                                Console.WriteLine($"  === Selecting Primary Weapon");
                                Console.WriteLine(PrimaryWeapons.Names(P1_ClassID));
                                Console.WriteLine(Footer);
                                Console.Write("Weapon ID: ");
                                string PrimarySelecion = Console.ReadLine();
                                if (int.TryParse(PrimarySelecion, out int PrimaryID)) { P1_PrimaryWeaponID = PrimaryID; }
                                Console.WriteLine($"Primary Weapon: {PrimaryWeapons.SpecificWeaponName(P1_PrimaryWeaponID)}");
                                Console.WriteLine($"Attack: {PrimaryWeapons.Attack(P1_ClassID, P1_PrimaryWeaponID, P1_Cooldown, P1_SecondaryTrigger)}");
                                Thread.Sleep(1500);
                                Selecting_Loadout = true;
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
                        EnemySpecial = Sniper.SniperSecondaryDamage(); //Detonate Stickies. Uses EnemyWeaponFeature as a Damage Multiplier.
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
                    while (PlayerHP > 0 && EnemyHP > 0)
                    {
                        Console.Clear();
                        if (PlayerCooldown < 0)
                        {
                            PlayerCooldown = 0; //Checks if the Cooldown went into the negatives and reverses it to 0.
                        }
                        Console.ForegroundColor = Color_Game;
                        Console.WriteLine(Header);
                        Console.ForegroundColor = Color_Player;
                        Console.WriteLine($"  {PlayerName}'s Class is {PlayerClass} with {PlayerHP}/{PlayerMaxHP}"!);
                        Console.ForegroundColor = Color_Enemy;
                        Console.WriteLine($"  The {EnemyPrefix} {EnemyClass} has {EnemyHP}/{EnemyMaxHP}");
                        Console.ForegroundColor = Color_Player;
                        if (PlayerClass == "Demoman")
                        {
                            Console.WriteLine($"  ┌────────┬────────┐");
                            Console.WriteLine($"  Stickies Placed: {PlayerWeaponFeature}");
                            Console.WriteLine($"  └────────┴────────┘");
                        }
                        if (PlayerClass == "Medic")
                        {
                            if (PlayerCooldown == 0)
                            {
                                Console.WriteLine("  ┌───────┬───────┐  ");
                                Console.WriteLine("  Medigun  Ready!    ");
                                Console.WriteLine("  └───────┴───────┘  ");
                            }
                            if (PlayerCooldown >= 1)
                            {
                                Console.WriteLine($"  ┌──────────────────┬──────────────────┐");
                                Console.WriteLine($"  Medigun Cooldown: {PlayerCooldown} Turns Remaining");
                                Console.WriteLine($"  └──────────────────┴──────────────────┘");
                            }
                        }
                        if (PlayerClass == "Sniper")
                        {
                            Console.WriteLine($"  ┌────────┬────────┐");
                            Console.WriteLine($"  Charge Level: {PlayerWeaponFeature}");
                            Console.WriteLine($"  └────────┴────────┘");
                        }
                        Console.ForegroundColor = Color_Game;
                        Console.WriteLine($"  Actions:");
                        #region PlayerClass - Actions

                        if (PlayerClass == "Scout")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. {PlayerSecondaryName}");
                            Console.WriteLine($"  3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Soldier")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. {PlayerSecondaryName}");
                            Console.WriteLine($"  3. {PlayerMeleeName}");
                            Console.WriteLine($"  4. {PlayerSpecialName}");
                        }
                        if (PlayerClass == "Pyro")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. {PlayerSecondaryName}");
                            Console.WriteLine($"  3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Demoman")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. {PlayerSecondaryName}"); //Place Sticky
                            Console.WriteLine($"  3. {PlayerSpecialName}"); //Detonate Stickies
                            Console.WriteLine($"  4. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Heavy")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. {PlayerSecondaryName}");
                            Console.WriteLine($"  3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Engineer")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. {PlayerSecondaryName}");
                            Console.WriteLine($"  3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Medic")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. {PlayerSecondaryName}");
                            Console.WriteLine($"  3. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Sniper")
                        {
                            Console.WriteLine($"  1. {PlayerPrimaryName}");
                            Console.WriteLine($"  2. Charge Sniper Rifle");
                            Console.WriteLine($"  3. {PlayerSecondaryName}");
                            Console.WriteLine($"  4. {PlayerMeleeName}");
                        }
                        if (PlayerClass == "Spy")
                        {
                            Console.WriteLine($"  1. {PlayerSecondaryName}");
                            Console.WriteLine($"  2. {PlayerMeleeName}");
                        }
                        #endregion
                        Console.WriteLine(Footer);
                        Console.Write("Action: ");
                        Console.ForegroundColor = Color_Input;
                        string PlayerAction = Console.ReadLine();
                        if (PlayerClass == "Scout")
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.ResetColor();
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(HeaderLong);
                                Console.ForegroundColor = Color_Player;
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Scout.ScoutPrimaryDamage();
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage to the {EnemyPrefix} {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.ForegroundColor = Color_Enemy;
                                Console.WriteLine($"The {EnemyPrefix} {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.ResetColor();
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(HeaderLong);
                                Console.ForegroundColor = Color_Player;
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Scout.ScoutSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.ForegroundColor = Color_Enemy;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.ResetColor();
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(HeaderLong);
                                Console.ForegroundColor = Color_Player;
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Scout.ScoutMeleeDamage();
                                Console.ForegroundColor = Color_Enemy;
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
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
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Soldier.SoldierSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Soldier.SoldierMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
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
                                        Console.WriteLine($"You launched yourself and hit the enemy! You Dealt 195 Damage, their HP is now {EnemyHP}");
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
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Pyro.PyroSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Pyro.PyroMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                        }
                        if (PlayerClass == "Demoman") // Finish Later
                        {
                            if (PlayerAction == "1")
                            {
                                Console.Clear();
                                Console.ForegroundColor = Color_Game;
                                Console.WriteLine(HeaderLong);
                                Console.ForegroundColor = Color_Player;
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerPrimaryName}!");
                                PlayerPrimaryDamage = Demoman.DemomanPrimaryDamage();
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} placed a Sticky with their {PlayerSecondaryName}!");
                                PlayerWeaponFeature++;
                                Console.WriteLine($"Player has {PlayerWeaponFeature} stickies placed!");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} detonated their stickies!");
                                PlayerSpecial = Demoman.DemomanSpecial(PlayerWeaponFeature);
                                PlayerWeaponFeature = 0;
                                Console.WriteLine($"It Dealt {PlayerSpecial} damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSpecial;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "4")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Demoman.DemomanMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
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
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Heavy.HeavySecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Heavy.HeavyMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
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
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);

                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Engineer.EngineerSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Engineer.EngineerMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
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
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                PlayerHP = PlayerHP + (PlayerPrimaryDamage / 2);
                                PlayerCooldown--;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} healed themselves with their {PlayerSecondaryName}!");
                                if (PlayerCooldown == 0)
                                {
                                    PlayerSecondaryDamage = Medic.MedicSecondaryDamage(PlayerCooldown);
                                    PlayerHP = PlayerHP + PlayerSecondaryDamage;
                                    PlayerCooldown = 3;
                                    Console.WriteLine($"It Healed {PlayerSecondaryDamage} HP!");
                                    Console.WriteLine($"The Medigun needs to cooldown for {PlayerCooldown} Turns");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                                else if (PlayerCooldown >= 1)
                                {
                                    PlayerSecondaryDamage = Medic.MedicSecondaryDamage(PlayerCooldown);
                                    PlayerHP = PlayerHP - PlayerSecondaryDamage;
                                    PlayerCooldown++;
                                    Console.WriteLine($"The Medigun Backfired! it was still cooling down from the last use");
                                    Console.WriteLine($"{PlayerName} took {PlayerSecondaryDamage} from the Backfire!");
                                    Console.WriteLine($"{PlayerName}'s Health is now {PlayerHP}");
                                    Console.WriteLine(FooterLong);
                                    Thread.Sleep(2000);
                                }
                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Medic.MedicMeleeDamage(PlayerCooldown);
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                PlayerCooldown--;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
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
                                Console.WriteLine($"It Dealt {PlayerPrimaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerPrimaryDamage;
                                PlayerWeaponFeature = 1;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} charged their {PlayerPrimaryName}!");
                                PlayerWeaponFeature++;
                                Console.WriteLine($"Charge: {PlayerWeaponFeature}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);

                            }
                            if (PlayerAction == "3")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerSecondaryName}!");
                                PlayerSecondaryDamage = Sniper.SniperSecondaryDamage();
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "4")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Sniper.SniperMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
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
                                Console.WriteLine($"It Dealt {PlayerSecondaryDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerSecondaryDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                            if (PlayerAction == "2")
                            {
                                Console.Clear();
                                Console.WriteLine(HeaderLong);
                                Console.WriteLine($"{PlayerName} attacked with their {PlayerMeleeName}!");
                                PlayerMeleeDamage = Spy.SpyMeleeDamage();
                                Console.WriteLine($"It Dealt {PlayerMeleeDamage} Damage to the Enemy {EnemyClass}!");
                                EnemyHP = EnemyHP - PlayerMeleeDamage;
                                Console.WriteLine($"The Enemy {EnemyClass}'s Remaining HP: {EnemyHP}");
                                Console.WriteLine(FooterLong);
                                Thread.Sleep(2000);
                            }
                        }
                    }
                    if (PlayerHP == 0 && EnemyHP == 0)
                    {
                        Console.WriteLine("You both lost this battle!");
                    }
                    if (PlayerHP <= 0)
                    {
                        Console.WriteLine($"Your Health Reached 0! You have been defeated by {EnemyPrefix} {EnemyClass}.");
                        Thread.Sleep(2000);
                        Console.WriteLine($"They had {EnemyHP} left when you fell.");
                        Thread.Sleep(3000);
                    }
                    if (EnemyHP <= 0)
                    {
                        Console.WriteLine("You win!");
                    }
                }

            }
        }
    }
}
