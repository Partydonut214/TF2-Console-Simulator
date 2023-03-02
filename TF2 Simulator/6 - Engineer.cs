using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Engineer
    {
        public static int EngineerHealth()
        {
            int Health = 125;
            return Health;
        }
        public static string EngineerName()
        {
            return "Engineer";
        }
        public static string EngineerMaxHP()
        {
            return "125";
        }
        public static string EngineerPrimaryName()
        {
            return "Shotgun";
        }
        public static string EngineerSecondaryName()
        {
            return "Pistol";
        }
        public static string EngineerMeleeName()
        {
            return "Wrench";
        }
        public static int EngineerPrimaryDamage()
        {
            // Weapon Name: Shotgun
            // Damage 4-6 x 1-10
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(4, 7); // creates a number between 4 & 6
            int BulletsFired = randomdamage.Next(1, 11); // creates a multiplier between 1 & 11 (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int EngineerSecondaryDamage()
        {
            //Weapon Name: Pistol
            //Damage 8-12 * 3-6
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(8, 13); // creates a number between 8 & 12
            int BulletsFired = randomdamage.Next(3, 7); // creates a multiplier between 3 & 6 (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int EngineerMeleeDamage()
        {
            //Weapon Name: Wrench
            //Damage: 30-65
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(30, 66); // creates a number between 30 & 65
            int Totaldamage = BaseDamage;
            return Totaldamage;
        }
        /* 
        Class Name:  
        HP: 
        --Weapons Used:
        -Primary: 
         Damage: 
         Ammo: 
         Reload: 
         Rate of Fire: 
        -Secondary: 
         Damage: 
         Ammo:
         Reload:
         Rate of Fire: 
        -Melee: 
         Damage: 
         Rate of Fire: 
        --Passive Stats:
          - 
        */
    }
}
