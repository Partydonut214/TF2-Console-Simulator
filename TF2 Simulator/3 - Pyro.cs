using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Pyro
    {
        public static int PyroHealth()
        {
            int Health = 175;
            return Health;
        }
        public static string PyroName()
        {
            return "Pyro";
        }
        public static string PyroMaxHP()
        {
            return "175";
        }
        public static string PyroPrimaryName()
        {
            return "Flame Thrower";
        }
        public static string PyroSecondaryName()
        {
            return "Shotgun";
        }
        public static string PyroMeleeName()
        {
            return "Fire Axe";
        }
        public static int PyroPrimaryDamage()
        {
            // Weapon Name: Flame Thrower
            // Damage 6-13 x 1-5
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(6, 13); // creates a number between 4 & 10
            int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 10 (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int PyroSecondaryDamage()
        {
            // Weapon Name: Shotgun
            // Damage 4-6 x 1-10
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(4, 7); // creates a number between 4 & 6
            int BulletsFired = randomdamage.Next(1, 11); // creates a multiplier between 1 & 11 (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int PyroMeleeDamage()
        {
            //Weapon Name: Fire Axe
            //Damage: 30-65
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(30, 66); // creates a number between 30 & 65
            int Totaldamage = BaseDamage;
            return Totaldamage;
        }
        /* 
        Class Name: Pyro [ID: 3] 
        HP: 175
        --Weapons Used:
        -Primary: Flamethrower 
         Damage: 8-13 * 1-6 + (3-4 * 1-2turns)  [Max Damage: 78 - 86]
         Ammo: 200/0
         Reload: None
         Rate of Fire: 10-30 Spent Per Turn
        -Secondary: Shotgun [Check TF2 Wiki for Stats]
         Damage: 4-6 [x10]
         Ammo: 6/32
         Rate of Fire: 1 Shot per Turn. may hit 1-10 pellets [4-60 HP]
         Reload: 1-3 Shells per Turn 
        -Melee: Fire Axe
         Damage: 30-65
         Rate of Fire: 1 Hit Per turn
        --Passive Stats:
          - When Damage is Dealt by the Flamethrower, Afterburn will deal 3-4 Damage for 1-2 turns.
        */
    }
}
