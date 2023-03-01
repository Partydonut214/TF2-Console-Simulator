﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Medic
    {
        public static int MedicHealth()
        {
            int Health = 150;
            return Health;
        }
        public static string MedicName()
        {
            return "Medic";
        }
        public static string MedicMaxHP()
        {
            return "150";
        }
        public static string MedicPrimaryName()
        {
            return "Blutsauger";
        }
        public static string MedicSecondaryName()
        {
            return "Medigun";
        }
        public static string MedicMeleeName()
        {
            return "Bonesaw";
        }
        public static int  MedicPrimaryDamage()

        {
            // Weapon Name: Blutsauger
            // Damage 5-12 * 1-4
            var randomdamage = new Random();

            int BaseDamage = randomdamage.Next(5, 13); // creates a number between 5 & 12
            int BulletsFired = randomdamage.Next(1, 4); // creates a multiplier between 1 & 4 (Implement random damage per bullet later.)
            int SelfHeal = BulletsFired;
            int Totaldamage = BaseDamage * BulletsFired;
            return Totaldamage;
        }
        public static int MedicSecondaryDamage()
        {
            // Weapon Name: Medigun
            // Heals: 24-36
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
        Class Name: Medic
        HP: 150
        --Weapons Used:
        -Primary: Blutsauger [Check TF2 Wiki for Stats]
         Damage: 5-12 * 1-4, +3 Self Heal Per Hit
         Ammo: 40/150
         Reload: 1 Turn
         Rate of Fire: 1-4 Syringes per Turn [5-48
        -Secondary: Medigun [Check TF2 Wiki for Stats]
         Damage: -24 [Check TF2 Wiki for Damage and Fire rate]
         Ammo: 1 [Cooldown: 3 Turns]
         Rate of Fire: 1. Wait 3 turns before re-using. Cannot cause overheal.
        -Melee: Bonesaw [Check TF2 Wiki for Stats]
         Damage: 30-65
         Rate of Fire: 1 Hit per Turn. Randomizer Determines Damage.
        --Passive Stats:
          - Heal 3 HP Per Turn unless HP Reaches 0 before the end of turn. Cannot cause overheal.
        */
    }
}
