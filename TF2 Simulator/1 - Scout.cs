using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Scout
    {
        public static int ScoutHealth()
        {
            int Health = 125;
            return Health;
        }
        public static string ScoutName() 
        { 
            return "Scout"; 
        }
        public static string ScoutMaxHP() 
        { 
            return "125"; 
        }
        public static string ScoutPrimaryName()
        {
            return "Scattergun";
        }
        public static string ScoutSecondaryName()
        {
            return "Pistol";
        }
        public static string ScoutMeleeName()
        {
            return "Bat";
        }
        public static int ScoutPrimaryDamage()
        {
            // Weapon Name: Scattergun
            // Damage 6-12 x 1-5
            var randomdamage = new Random();
            int Totaldamage = 0;
            int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implementing random damage per bullet now.)
            for (int i = 0; i < BulletsFired; i++)
            {
                Totaldamage = Totaldamage + randomdamage.Next(6, 13); // creates a number between 6 & 12
            }
            return Totaldamage;
        }
        public static int ScoutSecondaryDamage()
        {
            //Weapon Name: Pistol
            //Damage 8-12 * 3-6
            var randomdamage = new Random();
            int Totaldamage = 0;
            int BulletsFired = randomdamage.Next(3, 7); // creates a number between 3 & 7 (Implementing random damage per bullet now.)
            for (int i = 0; i < BulletsFired; i++)
            {
                Totaldamage = Totaldamage + randomdamage.Next(8, 13); // creates a number between 8 & 12
            }
            return Totaldamage;
        }
        public static int ScoutMeleeDamage()
        {
            //Weapon Name: Bat
            //Damage: 20-35
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(20, 36); // creates a number between 20 & 36
            int Special = randomdamage.Next(0, 101); // creates a number between 0 & 100, if the number is 2 or lower, Special Bonus will be activated.
            int SpecialBonus = 1;
            if (Special <= 2) 
            {
                SpecialBonus = 2;
                Console.WriteLine("Special Activated!: Swing 2 Times [x2 Damage]");
            }
            int Totaldamage = BaseDamage * SpecialBonus;
            return Totaldamage;
        }
        /* 
        Class Name: Scout [ID: 1] 
        HP: 125
        --Weapons Used:
        -Primary: Scattergun
         Damage: 4-10 [x10]
         Ammo: 6/32
         Reload: 1-6 Shells per Turn
         Rate of Fire: 1 Shell per Turn
        -Secondary: Pistol
         Damage: 8-12
         Ammo: 12/36
         Reload: Full Mag [12] in 1 Turn
         Rate of Fire: 3-6 bullets.
        -Melee: Bat
         Damage: 20-35
         Rate of Fire: 1 with a 20% chance for a second hit per Turn.
        --Passive Stats:
          - 2% Chance to get a Second Turn
        */
    }
}
