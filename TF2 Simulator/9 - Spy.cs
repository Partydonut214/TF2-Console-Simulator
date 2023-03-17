using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Spy
    {
        public static int SpyHealth()
        {
            int Health = 125;
            return Health;
        }
        public static string SpyName()
        {
            return "Spy";
        }
        public static string SpyMaxHP()
        {
            return "125";
        }
        public static string SpySecondaryName()
        {
            return "Revolver";
        }
        public static string SpyMeleeName()
        {
            return "Knife";
        }
        public static int SpySecondaryDamage()
        {
            // Weapon Name: Revolver
            // Damage 4-20 * 1-2
            var randomdamage = new Random();
            int Totaldamage = 0;
            int BulletsFired = randomdamage.Next(1, 3); // creates a multiplier between 1 & 11 (Implementing random damage per bullet now.)
            for (int i = 0; i < BulletsFired; i++)
            {
                Totaldamage = Totaldamage + randomdamage.Next(4, 21); // creates a number between 4 & 6
            }
            return Totaldamage;
        }
        public static int SpyMeleeDamage()
        {
            //Weapon Name: Knife
            //Damage: 35-60
            var randomdamage = new Random();

            //int BaseDamage = randomdamage.Next(35, 61); // creates a number between 20 & 36
            int BaseDamage = randomdamage.Next(1, 2); // creates a number between 20 & 36
            int Special = randomdamage.Next(0, 11); // creates a number between 0 & 100, if the number is 1 or lower, the Special will be activated.
            int SpecialBonus = 1; // probably for the scout's special, but I cannot confirm if this affects the spy yet. will leave here
            if (Special == 1)
            {
                return 99999;
            }
            int Totaldamage = BaseDamage * SpecialBonus;
            return Totaldamage;
        }
        /* 
        Class Name:  
        HP: 125
        --Weapons Used:
        -Primary: Revolver
         Damage: 20-60
         Ammo: 6/24
         Reload: 1 Turn
         Rate of Fire: 1 shot Per Turn
        -Secondary: Invis Watch
         Damage: 0
         Ammo: 1
         Reload: 1 Turn
         Rate of Fire: 1 
        -Melee: Knife
         Damage: 40-50
         Rate of Fire: 1 Per Turn
         Special: 1% Chance to Instantly Kill Enemy
        --Passive Stats:
          - None
        */
    }
}
