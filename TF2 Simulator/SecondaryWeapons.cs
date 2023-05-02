using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class SecondaryWeapons
    {
        public static int Attack(int ClassID, int WeaponID, int PlayerCooldown, bool SecondaryTrigger, int WeaponSpecialStat)
        {
            var randomdamage = new Random();
            int Totaldamage = 0;
            int Special = 0;
            
            if (WeaponID == 210)
            {
                // Golden Frying Pan - a "little" bit of damage
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(999, 99999999);  // creates a number between  [Damage]
                return Totaldamage;
            }
            //Continue Here ↓
            #region Scout
            //|| ClassID == 6 // Shared Weapons will have to be copy and pasted. or the player can access all classe's weapons and weapons from other slots.
            if (ClassID == 1 && WeaponID == 7)
            {
                // Pistol - 6-9 x 1-6 [6-54]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 8)
            {
                // Lugermorph - 6-9 x 1-6 [6-54]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 9)
            {
                // C.A.P.P.E.R - 6-9 x 1-6 [6-54]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 15)
            {
                // Mad Milk [+60% Damage returned as HP for 3 Turns]
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 16)
            {
                // Mutated Milk [+60% Damage returned as HP for 3 Turns]
                Totaldamage = 0;
                return Totaldamage;
            }
            #endregion

            #region Soldier
            if (ClassID == 2 && WeaponID == 38)
            {
                // Shotgun - 4-6 x 1-11 [4-66]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 12); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(4, 7); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 47)
            {
                // Panic Attack - 3-5 x 2-17 [6-85]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(2, 18); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(3, 6); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 39)
            {
                // Reserve Shooter - 7-10 x 2-6 [14-60] //More min Base Damage, but less Max Damage.
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(2, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(7, 11); } // creates a number between   [Damage]
                return Totaldamage;
            }
            #endregion

            #region Pyro
            if (ClassID == 3 && WeaponID == 38)
            {
                // Shotgun - 4-6 x 1-11 [4-66]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 12); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(4, 7); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 3 && WeaponID == 47)
            {
                // Panic Attack - 3-5 x 2-17 [6-85]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(2, 18); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(3, 6); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 3 && WeaponID == 39)
            {
                // Reserve Shooter - 7-10 x 2-6 [14-60] //More min Base Damage, but less Max Damage.
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(2, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(7, 11); } // creates a number between   [Damage]
                return Totaldamage;
            }
            #endregion

            #region Demoman
            if (ClassID == 4 && WeaponID == 86)
            {
                // Stickybomb Launcher - 20-50 [each sticky]
                int Damage = 0;
                for (int i = 0; i < WeaponSpecialStat; i++)
                { Damage = Damage + randomdamage.Next(20, 51); } // creates a number between   [Damage]
                return Damage;
            }
            if (ClassID == 4 && WeaponID == 87)
            {
                // Scottish Resistance - 20-50 [each sticky]
                int Damage = 0;
                int BulletsFired = WeaponSpecialStat;
                for (int i = 0; i < BulletsFired; i++)
                { Damage = Damage + randomdamage.Next(20, 51); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 4 && WeaponID == 88)
            {
                // Chargin' Targe - 0
                Totaldamage = 0;
                return Totaldamage;
            }

            if (ClassID == 4 && WeaponID == 89)
            {
                // Sticky Jumper - 0 [each sticky]
                Totaldamage = 0;
                return Totaldamage;
            }

            if (ClassID == 4 && WeaponID == 90)
            {
                // Splendid Screen - 0
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 4 && WeaponID == 91)
            {
                // Tide Turner - 0
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 4 && WeaponID == 92)
            {
                // Quickiebomb Launcher - 0
                int Damage = 0;
                int BulletsFired = WeaponSpecialStat;
                for (int i = 0; i < BulletsFired; i++)
                { Damage = Damage + randomdamage.Next(20, 51); } // creates a number between   [Damage]
                return Totaldamage;
            }
            #endregion

            #region Heavy
            if (ClassID == 5 && WeaponID == 38)
            {
                // Shotgun - 4-6 x 1-11 [4-66]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 12); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(4, 7); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 5 && WeaponID == 47)
            {
                // Panic Attack - 3-5 x 2-17 [6-85]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(2, 18); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(3, 6); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 5 && WeaponID == 110)
            {
                // Family Business - 20 x 1-3 [20-60]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 4); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + 20; }
                return Totaldamage;
            }
            //Lunchbox
            if (ClassID == 5 && WeaponID == 111)
            {
                // Sandvich - +50-250HP
                Totaldamage = randomdamage.Next(50, 251);
                return Totaldamage;
            }
            if (ClassID == 5 && WeaponID == 112)
            {
                // Robo-Sandvich - +50HP & 35% Damage Resist [1 Turn]
                Totaldamage = 50;
                return Totaldamage;
            }
            if (ClassID == 5 && WeaponID == 113)
            {
                // Dalokohs Bar - +50-100HP +50 MAX_HP [INF / Stackable]
                Totaldamage = randomdamage.Next(50, 101);
                return Totaldamage;
            }
            if (ClassID == 5 && WeaponID == 114)
            {
                // Fishcake - +50HP +100 MAX_HP [INF / Stackable]
                Totaldamage = 50;
                return Totaldamage;
            }
            if (ClassID == 5 && WeaponID == 115)
            {
                // Buffalo Steak Sandvich - +0 HP & Marks Enemy for Death [3 Turns]
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 5 && WeaponID == 116)
            {
                // Second Banana - +25-125 HP [2 Turn Faster Recharge]
                Totaldamage = randomdamage.Next(25, 126);
                return Totaldamage;
            }
            #endregion

            #region Engineer
            if (ClassID == 6 && WeaponID == 7)
            {
                // Pistol - 6-9 x 1-6 [6-54]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 6 && WeaponID == 8)
            {
                // Lugermorph - 6-9 x 1-6 [6-54]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 6 && WeaponID == 9)
            {
                // C.A.P.P.E.R - 6-9 x 1-6 [6-54]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 6 && WeaponID == 133)
            {
                // Short Circuit - 10 x 1-5 [10-50]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + 10; } // creates a number between   [Damage]
                return Totaldamage;
            }
            #endregion

            #region Medic
            if (ClassID == 7 && WeaponID == 146)
            {
                // Medi Gun - +12-60HP
                Totaldamage = 0;
                Totaldamage = randomdamage.Next(12, 61); 
                return Totaldamage;
            }
            if (ClassID == 7 && WeaponID == 147)
            {
                // Kritzkrieg - +12-60HP
                Totaldamage = 0;
                Totaldamage = randomdamage.Next(12, 61);
                return Totaldamage;
            }
            if (ClassID == 7 && WeaponID == 148)
            {
                // Quick-Fix - +12-60HP
                Totaldamage = 0;
                Totaldamage = randomdamage.Next(12, 61);
                return Totaldamage;
            }
            if (ClassID == 7 && WeaponID == 149) //Right now all the Medi Guns are Identical. I will add their different uses later.
            {
                // Vaccinator - +12-60HP
                Totaldamage = 0;
                Totaldamage = randomdamage.Next(12, 61);
                return Totaldamage;
            }

            #endregion

            #region Sniper
            if (ClassID == 8 && WeaponID == 165)
            {
                // SMG - 6-9 x 1-6 [6-54]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 166)
            {
                // Cleaner's Carbine - 10-12 x 1-4 [10-48]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 4); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(10, 13); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 167)
            {
                // Jarate [+35% Damage for 3 Turns]
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 168)
            {
                // Self-Aware Beauty Mark [+35% Damage for 3 Turns]
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 169)
            {
                // Razorback - [+35% Damage Resistance]
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 170)
            {
                // Darwin's Danger Shield - [+35% Damage Resistance]
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 171)
            {
                // Cozy Camper - 0 [10 HP Healed Per Turn]
                Totaldamage = 0;
                return Totaldamage;
            }
            #endregion

            #region Spy
            if (ClassID == 9 && WeaponID == 176)
            {
                // Revolver - 30-50
                Totaldamage = randomdamage.Next(30, 51);
            }
            if (ClassID == 9 && WeaponID == 176)
            {
                // Big Kill - 30-50
                Totaldamage = randomdamage.Next(30, 51);
            }
            if (ClassID == 9 && WeaponID == 176)
            {
                // Ambassador - 30-50
                Totaldamage = randomdamage.Next(30, 51);
            }
            if (ClassID == 9 && WeaponID == 176)
            {
                // L'Etranger - 30-50
                Totaldamage = randomdamage.Next(30, 51);
            }
            if (ClassID == 9 && WeaponID == 176)
            {
                // Enforcer - 30-50
                Totaldamage = randomdamage.Next(30, 51);
            }
            if (ClassID == 9 && WeaponID == 176)
            {
                // Diamondback - 30-50
                Totaldamage = randomdamage.Next(30, 51);
            }
            #endregion

            return 0;
        }
        public static string Names(int ClassID)
        {
            if (ClassID == 1)
            {
                return "  ID 7 == Pistol\r\n  ID 8 == Lugermorph\r\n  ID 9 == C.A.P.P.E.R\r\n  ID 10 == Winger\r\n  ID 11 == Pretty Boy's Pocket Pistol\r\n  ID 12 == Flying Guillotine\r\n  ID 13 == Bonk! Atomic Punch\r\n  ID 14 == Crit-a-Cola\r\n  ID 15 == Mad Milk\r\n  ID 16 == Mutated Milk";
            }
            if (ClassID == 2)
            {
                return "  ID 38 == Shotgun\r\n  ID 39 == Reserve Shooter\r\n  ID 47 == Panic Attack";
            }
            if (ClassID == 3)
            {
                return "  ID 38 == Shotgun\r\n  ID 39 == Reserve Shooter\r\n  ID 47 == Panic Attack";
            }
            if (ClassID == 4)
            {
                return "  ID 80 == Grenade Launcher\r\n  ID 81 == Loch-n-Load\r\n  ID 82 == Ali Baba's Wee Booties\r\n  ID 83 == Bootlegger\r\n  ID 84 == Loose Cannon\r\n  ID 85 == Iron Bomber";
            }
            if (ClassID == 5)
            {
                return "  ID 38 == Shotgun\r\n  ID 47 == Panic Attack";
            }
            if (ClassID == 6)
            {
                return "  ID 7 == Pistol\r\n  ID 8 == Lugermorph\r\n  ID 9 == C.A.P.P.E.R\r\n";
            }
            if (ClassID == 7)
            {
                return "  ID 146 == Medi Gun\r\n  ID 147 == Kritzkrieg\r\n  ID 148 == Quick-Fix\r\n  ID 149 == Vaccinator";
            }
            if (ClassID == 8)
            {
                return "  ID 167 == Jarate\r\n  ID 168 == Self-Aware Beauty Mark\r\n";
            }
            if (ClassID == 9)
            {
                return "  ID 999 == GUN\r\n  ID 168 == Self-Aware Beauty Mark\r\n";
            }
            return "Error";
        }
        public static string SpecificWeaponName(int WeaponID)
        {
            if (WeaponID == 0) { return "No Weapon"; }
            if (WeaponID == 1) { return "Scattergun"; }
            if (WeaponID == 2) { return "Force-A-Nature"; }
            if (WeaponID == 3) { return "Shortstop"; }
            if (WeaponID == 4) { return "Soda Popper"; }
            if (WeaponID == 5) { return "Baby Face's Blaster"; }
            if (WeaponID == 6) { return "Back Scatter"; }
            if (WeaponID == 7) { return "Pistol"; }
            if (WeaponID == 8) { return "Lugermorph"; }
            if (WeaponID == 9) { return "C.A.P.P.E.R"; }
            if (WeaponID == 10) { return "Winger"; }
            if (WeaponID == 11) { return "Pretty Boy's Pocket Pistol"; }
            if (WeaponID == 12) { return "Flying Guillotine"; }
            if (WeaponID == 13) { return "Bonk! Atomic Punch"; }
            if (WeaponID == 14) { return "Crit-a-Cola"; }
            if (WeaponID == 15) { return "Mad Milk"; }
            if (WeaponID == 16) { return "Mutated Milk"; }
            if (WeaponID == 17) { return "Bat"; }
            if (WeaponID == 18) { return "Holy Mackerel"; }
            if (WeaponID == 19) { return "Unarmed Combat"; }
            if (WeaponID == 20) { return "Batsaber"; }
            if (WeaponID == 21) { return "Sandman"; }
            if (WeaponID == 22) { return "Candy Cane"; }
            if (WeaponID == 23) { return "Boston Basher"; }
            if (WeaponID == 24) { return "Three-Rune Blade"; }
            if (WeaponID == 25) { return "Sun-on-a-Stick"; }
            if (WeaponID == 26) { return "Fan O'War"; }
            if (WeaponID == 27) { return "Atomizer"; }
            if (WeaponID == 28) { return "Wrap Assassin"; }
            if (WeaponID == 29) { return "Rocket Launcher"; }
            if (WeaponID == 30) { return "Original"; }
            if (WeaponID == 31) { return "Direct Hit"; }
            if (WeaponID == 32) { return "Black Box"; }
            if (WeaponID == 33) { return "Rocket Jumper"; }
            if (WeaponID == 34) { return "Liberty Launcher"; }
            if (WeaponID == 35) { return "Cow Mangler 5000"; }
            if (WeaponID == 36) { return "Beggar's Bazooka"; }
            if (WeaponID == 37) { return "Air Strike"; }
            if (WeaponID == 38) { return "Shotgun"; }
            if (WeaponID == 39) { return "Reserve Shooter"; }
            if (WeaponID == 40) { return "Buff Banner"; }
            if (WeaponID == 41) { return "Gunboats"; }
            if (WeaponID == 42) { return "Battalion's Backup"; }
            if (WeaponID == 43) { return "Concheror"; }
            if (WeaponID == 44) { return "Mantreads"; }
            if (WeaponID == 45) { return "Righteous Bison"; }
            if (WeaponID == 46) { return "B.A.S.E. Jumper"; }
            if (WeaponID == 47) { return "Panic Attack"; }
            if (WeaponID == 48) { return "Shovel"; }
            if (WeaponID == 49) { return "Equalizer"; }
            if (WeaponID == 50) { return "Pain Train"; }
            if (WeaponID == 51) { return "Half-Zatoichi"; }
            if (WeaponID == 52) { return "Disciplinary Action"; }
            if (WeaponID == 53) { return "Market Gardener"; }
            if (WeaponID == 54) { return "Escape Plan"; }
            if (WeaponID == 55) { return "Flame Thrower"; }
            if (WeaponID == 56) { return "Rainblower"; }
            if (WeaponID == 57) { return "Nostromo Napalmer"; }
            if (WeaponID == 58) { return "Backburner"; }
            if (WeaponID == 59) { return "Degreaser"; }
            if (WeaponID == 60) { return "Phlogistinator"; }
            if (WeaponID == 61) { return "Dragon's Fury"; }
            if (WeaponID == 62) { return "Flare Gun"; }
            if (WeaponID == 63) { return "Detonator"; }
            if (WeaponID == 64) { return "Manmelter"; }
            if (WeaponID == 65) { return "Scorch Shot"; }
            if (WeaponID == 66) { return "Thermal Thruster"; }
            if (WeaponID == 67) { return "Gas Passer"; }
            if (WeaponID == 68) { return "Fire Axe"; }
            if (WeaponID == 69) { return "Lollichop"; }
            if (WeaponID == 70) { return "Axtinguisher"; }
            if (WeaponID == 71) { return "Postal Pummeler"; }
            if (WeaponID == 72) { return "Homewrecker"; }
            if (WeaponID == 73) { return "Maul"; }
            if (WeaponID == 74) { return "Powerjack"; }
            if (WeaponID == 75) { return "Back Scratcher"; }
            if (WeaponID == 76) { return "Sharpened Volcano Fragment"; }
            if (WeaponID == 77) { return "Third Degree"; }
            if (WeaponID == 78) { return "Neon Annihilator"; }
            if (WeaponID == 79) { return "Hot Hand"; }
            if (WeaponID == 80) { return "Grenade Launcher"; }
            if (WeaponID == 81) { return "Loch-n-Load"; }
            if (WeaponID == 82) { return "Ali Baba's Wee Booties"; }
            if (WeaponID == 83) { return "Bootlegger"; }
            if (WeaponID == 84) { return "Loose Cannon"; }
            if (WeaponID == 85) { return "Iron Bomber"; }
            if (WeaponID == 86) { return "Stickybomb Launcher"; }
            if (WeaponID == 87) { return "Scottish Resistance"; }
            if (WeaponID == 88) { return "Chargin' Targe"; }
            if (WeaponID == 89) { return "Sticky Jumper"; }
            if (WeaponID == 90) { return "Splendid Screen"; }
            if (WeaponID == 91) { return "Tide Turner"; }
            if (WeaponID == 92) { return "Quickiebomb Launcher"; }
            if (WeaponID == 93) { return "Bottle"; }
            if (WeaponID == 94) { return "Scottish Handshake"; }
            if (WeaponID == 95) { return "Eyelander"; }
            if (WeaponID == 96) { return "Horseless Headless Horsemann's Headtaker"; }
            if (WeaponID == 97) { return "Nessie's Nine Iron"; }
            if (WeaponID == 98) { return "Scotsman's Skullcutter"; }
            if (WeaponID == 99) { return "Pain Train"; }
            if (WeaponID == 100) { return "Ullapool Caber"; }
            if (WeaponID == 101) { return "Claidheamh Mòr"; }
            if (WeaponID == 102) { return "Half-Zatoichi"; }
            if (WeaponID == 103) { return "Persian Persuader"; }
            if (WeaponID == 104) { return "Minigun"; }
            if (WeaponID == 105) { return "Iron Curtain"; }
            if (WeaponID == 106) { return "Natascha"; }
            if (WeaponID == 107) { return "Brass Beast"; }
            if (WeaponID == 108) { return "Tomislav"; }
            if (WeaponID == 109) { return "Huo-Long Heater"; }
            if (WeaponID == 110) { return "Family Business"; }
            if (WeaponID == 111) { return "Sandvich"; }
            if (WeaponID == 112) { return "Robo-Sandvich"; }
            if (WeaponID == 113) { return "Dalokohs Bar"; }
            if (WeaponID == 114) { return "Fishcake"; }
            if (WeaponID == 115) { return "Buffalo Steak Sandvich"; }
            if (WeaponID == 116) { return "Error: Duplicated Weapon [Panic Attack]"; } //Scrapped Weapon due to Duplication
            if (WeaponID == 117) { return "Second Banana"; }
            if (WeaponID == 118) { return "Fists"; }
            if (WeaponID == 119) { return "Apoco-Fists"; }
            if (WeaponID == 120) { return "Killing Gloves of Boxing"; }
            if (WeaponID == 121) { return "Gloves of Running Urgently"; }
            if (WeaponID == 122) { return "Bread Bite"; }
            if (WeaponID == 123) { return "Warrior's Spirit"; }
            if (WeaponID == 124) { return "Fists of Steel"; }
            if (WeaponID == 125) { return "Eviction Notice"; }
            if (WeaponID == 126) { return "Holiday Punch"; }
            if (WeaponID == 127) { return "Frontier Justice"; }
            if (WeaponID == 128) { return "Widowmaker"; }
            if (WeaponID == 129) { return "Pomson 6000"; }
            if (WeaponID == 130) { return "Rescue Ranger"; }
            if (WeaponID == 131) { return "Wrangler"; }
            if (WeaponID == 132) { return "Giger Counter"; }
            if (WeaponID == 133) { return "Short Circuit"; }
            if (WeaponID == 134) { return "Wrench"; }
            if (WeaponID == 135) { return "Golden Wrench"; }
            if (WeaponID == 136) { return "Gunslinger"; }
            if (WeaponID == 137) { return "Southern Hospitality"; }
            if (WeaponID == 138) { return "Jag"; }
            if (WeaponID == 139) { return "Eureka Effect"; }
            if (WeaponID == 140) { return "Consturction PDA"; }
            if (WeaponID == 141) { return "Destruction PDA"; }
            if (WeaponID == 142) { return "Syringe Gun"; }
            if (WeaponID == 143) { return "Blutsauger"; }
            if (WeaponID == 144) { return "Crusader's Crossbow"; }
            if (WeaponID == 145) { return "Overdose"; }
            if (WeaponID == 146) { return "Medi Gun"; }
            if (WeaponID == 147) { return "Kritzkrieg"; }
            if (WeaponID == 148) { return "Quick-Fix"; }
            if (WeaponID == 149) { return "Vaccinator"; }
            if (WeaponID == 150) { return "Bonesaw"; }
            if (WeaponID == 151) { return "Übersaw"; }
            if (WeaponID == 152) { return "Vita-Saw"; }
            if (WeaponID == 153) { return "Amputator"; }
            if (WeaponID == 154) { return "Solemn Vow"; }
            if (WeaponID == 155) { return "Sniper Rifle"; }
            if (WeaponID == 156) { return "AWPer Hand"; }
            if (WeaponID == 157) { return "Huntsman"; }
            if (WeaponID == 158) { return "Fortified Compound"; }
            if (WeaponID == 159) { return "Sydney Sleeper"; }
            if (WeaponID == 160) { return "Bazaar Bargain"; }
            if (WeaponID == 161) { return "Machina"; }
            if (WeaponID == 162) { return "Shooting Star"; }
            if (WeaponID == 163) { return "Hitman's Heatmaker"; }
            if (WeaponID == 164) { return "Classic"; }
            if (WeaponID == 165) { return "SMG"; }
            if (WeaponID == 166) { return "Cleaner's Carbine"; }
            if (WeaponID == 167) { return "Jarate"; }
            if (WeaponID == 168) { return "Self-Aware Beauty Mark"; }
            if (WeaponID == 169) { return "Razorback"; }
            if (WeaponID == 170) { return "Darwin's Danger Shield"; }
            if (WeaponID == 171) { return "Cozy Camper"; }
            if (WeaponID == 172) { return "Kukri"; }
            if (WeaponID == 173) { return "Tribalman's Shiv"; }
            if (WeaponID == 174) { return "Bushwacka"; }
            if (WeaponID == 175) { return "Shahanshah"; }
            if (WeaponID == 176) { return "Revolver"; }
            if (WeaponID == 177) { return "Big Kill"; }
            if (WeaponID == 178) { return "Ambassador"; }
            if (WeaponID == 179) { return "L'Etranger"; }
            if (WeaponID == 180) { return "Enforcer"; }
            if (WeaponID == 181) { return "Diamondback"; }
            if (WeaponID == 182) { return "Knife"; }
            if (WeaponID == 183) { return "Sharp Dresser"; }
            if (WeaponID == 184) { return "Black Rose"; }
            if (WeaponID == 185) { return "Your Eternal Reward"; }
            if (WeaponID == 186) { return "Wanga Prick"; }
            if (WeaponID == 187) { return "Conniver's Kunai"; }
            if (WeaponID == 188) { return "Big Earner"; }
            if (WeaponID == 189) { return "Spy-cicle"; }
            if (WeaponID == 190) { return "Disguise Kit"; }
            if (WeaponID == 191) { return "Invis Watch"; }
            if (WeaponID == 192) { return "Enthusiast's Timepiece"; }
            if (WeaponID == 193) { return "Quäckenbirdt"; }
            if (WeaponID == 194) { return "Cloak and Dagger"; }
            if (WeaponID == 195) { return "Dead Ringer"; }
            if (WeaponID == 196) { return "Sapper"; }
            if (WeaponID == 197) { return "Ap-Sap"; }
            if (WeaponID == 198) { return "Snack Attack"; }
            if (WeaponID == 199) { return "Red-Tape Recorder"; }
            if (WeaponID == 200) { return "Saxxy"; }
            if (WeaponID == 201) { return "Frying Pan"; }
            if (WeaponID == 202) { return "Conscientious Objector"; }
            if (WeaponID == 203) { return "Freedom Staff"; }
            if (WeaponID == 204) { return "Bat Outta Hell"; }
            if (WeaponID == 205) { return "Memory Maker"; }
            if (WeaponID == 206) { return "Ham Shank"; }
            if (WeaponID == 207) { return "Necro Smasher"; }
            if (WeaponID == 208) { return "Crossing Guard"; }
            if (WeaponID == 209) { return "Prinny Machete"; }
            if (WeaponID == 210) { return "Golden Frying Pan"; }
            if (WeaponID == 211) { return "Legendary Ticket"; }
            if (WeaponID == 212) { return "Backpack Expander"; }
            return "error";
        }
    }
}
