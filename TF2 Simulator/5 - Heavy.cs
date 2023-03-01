using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Heavy
    {
        public static int HeavyHealth()
        {
            int Health = 300;
            return Health;
        }
        public static string HeavyPrimaryName()
        {
            return "Minigun";
        }
        public static string HeavySecondaryName()
        {
            return "Shotgun";
        }
        public static string HeavyMeleeName()
        {
            return "Fists";
        }
        public static int HeavyPrimaryDamage()

        {
            // Weapon Name: Minigun
            // Damage 6-12 x 1-5
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(6, 13); // creates a number between 6 & 12
            int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 5 (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int HeavySecondaryDamage()
        {
            // Weapon Name: Shotgun
            // Damage 4-6 x 1-10
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(4, 7); // creates a number between 4 & 6
            int BulletsFired = randomdamage.Next(1, 11); // creates a multiplier between 1 & 11 (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int HeavyMeleeDamage()
        {
            //Weapon Name: Fists
            //Damage: 30-65
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(30, 66); // creates a number between 30 & 65
            int Totaldamage = BaseDamage;
            return Totaldamage;
        }

        /* 
        Class Name: Heavy [heavyweapons / Heavy / Heavyweapons] 
        HP: 300
        --Weapons Used:
        -Primary: Minigun [Check TF2 Wiki for Stats]
         Damage: 6-12
         Ammo: 200/0
         Rate of Fire: 1-5 Bullets per Turn [6-48 HP]
        -Secondary: Shotgun [Check TF2 Wiki for Stats]
         Damage: 4-6 [x10]
         Ammo: 6/32
         Rate of Fire: 1 Shot per Turn. may hit 1-10 pellets [4-60 HP]
         Reload: 1-3 Shells per Turn
        -Melee: Fists [Check TF2 Wiki for Stats]
         Damage: 30-65
         Rate of Fire: 1 Hit per Turn. Randomizer Determines Damage.
        --Passive Stats:
          - None
        */
    }
}
