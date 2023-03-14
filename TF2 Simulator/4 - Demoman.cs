using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Demoman
    {
        public static int DemomanHealth()
        {
            int Health = 175;
            return Health;
        }
        public static string DemomanName()
        {
            return "Demoman";
        }
        public static string DemomanMaxHP()
        {
            return "175";
        }
        public static string DemomanPrimaryName()
        {
            return "Grenade Launcher";
        }
        public static string DemomanSecondaryName()
        {
            return "Stickybomb Launcher - Place Sticky";
        }
        public static string DemomanMeleeName()
        {
            return "Bottle";
        }
        public static string DemomanSpecialName()
        {
            return "Stickybomb Launcher - Detonate Stickies";
        }
        public static int DemomanPrimaryDamage()
        {
            // Weapon Name: Grenade Launcher
            // Damage 22-44
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(6, 13); // creates a number between 4 & 10
            int BulletsFired = randomdamage.Next(1, 6); // creates a multiplier between 1 & 10 (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int DemomanSecondaryDamage(int StickyPlaced)
        {
            // Weapon Name: Stickybomb Launcher
            // Damage 22-34 x 1-8 [User Managed]
            var randomdamage = new Random();

            StickyPlaced = 0;
            int BaseDamage = randomdamage.Next(22, 35); // doesn't actually do anything but the counter works and I am too scared to touch this
            int BulletsFired = StickyPlaced++; // adds a Multiplier to the Sticky Count (Implement random damage per bullet later.)
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int DemomanMeleeDamage()
        {
            //Weapon Name: Bottle
            //Damage: 30-65
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(30, 66); // creates a number between 30 & 65
            int Totaldamage = BaseDamage;
            return Totaldamage;
        }
        public static int DemomanSpecial(int PlayerWeaponFeature)
        {
            var randomdamage = new Random();
            int BaseDamage = randomdamage.Next(22, 35); // this one actually does something.
            int Totaldamage = BaseDamage * PlayerWeaponFeature;
            return Totaldamage;
        }
    }
}
