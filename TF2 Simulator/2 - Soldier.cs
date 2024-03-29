﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Soldier
    {
        public static int SoldierHealth()
        {
            int Health = 200;
            return Health;
        }
        public static string SoldierName() 
        {
            return "Soldier";
        }
        public static string SoldierMaxHP() 
        {
            return "200";
        }
        public static string SoldierPrimaryName()
        {
            return "Rocket Launcher";
        }
        public static string SoldierSecondaryName()
        {
            return "Shotgun";
        }
        public static string SoldierMeleeName()
        {
            return "Market Gardener";
        }
        public static string SoldierSpecialName() 
        {
            return "Market Garden";
        }
        public static int SoldierPrimaryDamage()
        {
            // Weapon Name: Rocket Launcher
            // Damage 36-52
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(26, 53); // creates a number between 26-52
            int Totaldamage = BaseDamage; // basically goes unused with the random bullets fired removed, but I leave it here because it is a bit easier to troubleshoot.
            return Totaldamage;
        }
        public static int SoldierSecondaryDamage()
        {
            // Weapon Name: Shotgun
            // Damage 4-6 x 1-10
            var randomdamage = new Random();
            int Totaldamage = 0;
            int BulletsFired = randomdamage.Next(1, 11); // creates a multiplier between 1 & 11 (Implementing random damage per bullet now.)
            for (int i = 0; i < BulletsFired; i++ )
            {
                Totaldamage = Totaldamage + randomdamage.Next(4, 7); // creates a number between 4 & 6
            }

            return Totaldamage;
        }
        public static int SoldierMeleeDamage()
        {
            //Weapon Name: Market Gardener
            //Damage: 30-65
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(30, 66); // creates a number between 30 & 65
            int Totaldamage = BaseDamage;
            return Totaldamage;
        }
        public static int SoldierSpecial()
        { 
            var randomchance = new Random();

            int totaldamage = 195;
            int Special = randomchance.Next(1, 11);
            if (Special == 1) 
            {
                return totaldamage;
            }
            else
            {
                return 0;
            }
        }
        /* 
        Class Name: Soldier [ID: 2]  
        HP: 200
        --Weapons Used: 
        -Primary: Rocket Launcher
         Damage: 36-50 [20% Chance to Deal 10-35 Self-Damage]
         Ammo: 4/20
         Reload: 1-4 Per Turn 
         Rate of Fire: 1 Per Turn
        -Secondary: Shotgun
         Damage: 4-6 [x10]
         Ammo: 6/32
         Rate of Fire: 1 Shot per Turn. may hit 1-10 pellets [4-60 HP]
         Reload: 1-3 Shells per Turn
        -Melee: Market Gardener
         Damage: 30-65
         Rate of Fire: 1 Hit Per Turn 
         Special: Deal 25-30 Self Damage, and recieve a 10% Chance to deal 195 Damage to the Enemy with a Market Garden
        --Passive Stats:
          - None
        */
    }
}
