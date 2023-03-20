using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Sniper
    {
        public static int SniperHealth()
        {
            int Health = 125;
            return Health;
        }
        public static string SniperName()
        {
            return "Sniper";
        }
        public static string SniperMaxHP()
        {
            return "125";
        }
        public static string SniperPrimaryName()
        {
            return "Sniper Rifle";
        }
        public static string SniperSecondaryName()
        {
            return "SMG";
        }
        public static string SniperMeleeName()
        {
            return "Kukri";
        }
        public static string SniperSpecialName()
        {
            return "Sniper Rifle - Charge";
        }
        public static int SniperPrimaryDamage(int PlayerWeaponFeature)
        {
            // Weapon Name: Sniper Rifle
            // Damage 50 [x Charge Level]
            int Damage = 50;
            int Totaldamage = Damage * PlayerWeaponFeature;
            if (PlayerWeaponFeature >= 4)
            {
                Totaldamage = Damage * PlayerWeaponFeature * 2;
            }
            return Totaldamage;
        }
        public static int SniperSecondaryDamage()
        {
            // Weapon Name: SMG
            // Damage 4-12 * 1-5
            var randomdamage = new Random();
            int Totaldamage = 0;
            int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 11 (Implementing random damage per bullet now.)
            for (int i = 0; i < BulletsFired; i++)
            {
                Totaldamage = Totaldamage + randomdamage.Next(4, 13); // creates a number between 4 & 6
            }
            return Totaldamage;
        }
        public static int SniperMeleeDamage()
        {
            //Weapon Name: Kukri
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
        -Primary: Sniper
         Damage: 50
         Ammo: 25
         Reload: None
         Rate of Fire: 1 Per Turn
         Special: Spend 1 Turn to Charge for More Sniper Damage on the Next Turn
        -Secondary: SMG
         Damage: 4-12 * 1-5
         Ammo: 25/75
         Reload: 1 Turn
         Rate of Fire: 1-5 Shots Per Turn
        -Melee: Kukri
         Damage: 30-65
         Rate of Fire: 1 Per Turn 
        --Passive Stats: 
          - If Charge passes 4. Damage is Doubled.
        */
    }
}
