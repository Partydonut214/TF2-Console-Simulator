using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class PrimaryWeapons
    {
        public static int Attack(int ClassID, int WeaponID, int PlayerCooldown, bool SecondaryTrigger)
        {
            var randomdamage = new Random();
            int Totaldamage = 0;
            int BabyFaceBuildup = 5;
            int Special = 0;
            int RocketsLoaded = 0;

            #region Scout
            if (ClassID == 1 && WeaponID == 1)
            {
                // Scattergun - 6-12 x 1-5 [6-60]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between 6 & 12 [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 2)
            {
                // Force-A-Nature - 4-9 x 3-7 [12-63]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(3, 8); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(4, 10); } // creates a number between 6 & 12 [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 3)
            {
                // Shortstop - 12-18 x 1-4 [12-72]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 5); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(12, 19); } // creates a number between 6 & 12 [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 4)
            {
                // Soda Popper - 5-10 x 3-6 [15-60] //Slightly Less Max damage than the FaN, but with more min damage.
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(2, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(5, 11); } // creates a number between 6 & 12 [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 5)
            {
                // Baby Face's Blaster - 4-8 x 1-effectively ∞ [4-effectively ∞]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, BabyFaceBuildup); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(0, 0); } // creates a number between 6 & 12 [Damage]
                BabyFaceBuildup =+ randomdamage.Next(0, 5); //This is going to be very weird and can probably be abused by ALL Scouts holding this weapon at once.
                //May add a Max cap for pellets later. Nerfing Damage for now.
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 6)
            {
                // Back Scatter - 6-12 x 1-5 [6-60] + 20% Chance for a Mini-crit "Boomerang" --> (8-16) x 1-5 [8-80]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between 6 & 12 [Damage]
                Special = randomdamage.Next(1, 11); // 1-10, Trips weapon Special if RareUse == 1 or 2,
                if (Special <= 2) { Totaldamage = Totaldamage + (35 * Totaldamage / 100); } // 20% Chance for Mini-Crits
                return Totaldamage;
            }
            #endregion
            #region Soldier
            if (ClassID == 2 && WeaponID == 29)
            {
                // Rocket Launcher - 36-52 -- Rocket Launchers are SIMPLE, wow.
                Totaldamage = randomdamage.Next(36, 53);
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 30)
            {
                // The Original - 38-54 -- Functions Exactly like the Rocket Launcher other than the Positioning, that doesn't matter in this game, so it has a slight damage boost.
                Totaldamage = randomdamage.Next(38, 55);
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 31)
            {
                // Direct Hit - 43-76 [0-43-76] 40% chance to hit
                Totaldamage = 0;
                Special = randomdamage.Next(1, 11); //Rolls a 1-10, if the number is 4 or lower, the shot lands.
                if (Special <= 4) { Totaldamage = randomdamage.Next(43, 77); } //Damage is rolled only if the Special rolls a 4 or lower.
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 32)
            {
                // Black Box - 36-52 -- Functions Exactly like the Rocket Launcher, but will grant the wielder 1/4th of the damage dealt as HP.
                Totaldamage = randomdamage.Next(36, 53);
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 33)
            {
                // Rocket Jumper - 0 -- Deals 0 damage, no need for a randomizer here!
                Totaldamage = 0;
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 34)
            {
                // Liberty Launcher - 30-46 -- 40-62 [Mini] -- 90-138 [Crit]
                Totaldamage = randomdamage.Next(30, 47);
                Special = randomdamage.Next(1, 101); 
                if (Special <= 10) { Totaldamage = Totaldamage + (35 * Totaldamage / 100); }
                if (Special == 1) { Totaldamage = Totaldamage * 3; }
                // 10% chance of a Mini-Crit
                // 1% chance of a Crit
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 35)
            {
                // Cow Mangler 5000 - 36-52 -- Functions as Rocket Launcher, add Mini-Crit + Cooldown Later.
                Totaldamage = randomdamage.Next(36, 53);
                if (PlayerCooldown == 0 & SecondaryTrigger == true)
                {
                    SecondaryTrigger = false;
                    Totaldamage = Totaldamage + (35 * Totaldamage / 100);
                    //PlayerCooldown = 4;
                }
                return Totaldamage; //return PlayerCooldown;
            }

            if (ClassID == 2 && WeaponID == 36)
            {
                // Beggar's Bazooka - 42-58 x 1-10
                Totaldamage = 0;
                if (SecondaryTrigger == true)
                {
                    SecondaryTrigger = false;
                    RocketsLoaded++;
                }
                for (int i = 0; i < RocketsLoaded; i++)
                {
                    Totaldamage = Totaldamage + randomdamage.Next(42, 59);
                }
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 37)
            {
                // Air Strike - 12-21 -- Damage Greatly Reduced, but an extra rocket is fired each time.
                Special++;
                for (int i = 0; i < Special; i++)
                {
                    Totaldamage = Totaldamage + randomdamage.Next(12, 22);
                }
                return Totaldamage;
            }
            #endregion
            #region Pyro
            // Finish Later.
            #endregion
            return 0;
        }
        public static string Name(int ClassID)
        {
            if (ClassID == 1)
            {
                return "Scattergun -- ID 1\r\nForce-A-Nature -- ID 2\r\nShortstop -- ID 3\r\nSoda Popper -- ID 4\r\nBaby Face's Blaster -- ID 5\r\nBack Scatter -- ID 5";
            }
            return "Error";
        }
             



















        public PrimaryWeapons() 
        {
            int PrimaryWeaponID;
            string PrimaryWeaponName;
        }
        public static int PrimaryWeaponCompatable(int ClassID)
        {
            //Scout
            if (ClassID == 0) return 0;
            if (ClassID == 1) return 1;
            if (ClassID == 2) return 2;
            if (ClassID == 3) return 3;
            if (ClassID == 4) return 4;
            if (ClassID == 5) return 5;
            if (ClassID == 6) return 6;
            if (ClassID == 7) return 7;
            if (ClassID == 8) return 8;
            if (ClassID == 9) return 9;
            if (ClassID == 10) return 0;
            return 0;
        }
    }
}
