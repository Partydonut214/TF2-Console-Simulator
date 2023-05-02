using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Misc
    {


        public static string EffectNamefromID(int EffectID)
        {
            if (EffectID == 0) { return "No Effect Applied"; }
            if (EffectID == 1) { return "Burning"; }
            if (EffectID == 2) { return "Mad Milked"; }
            if (EffectID == 3) { return "Jarated"; }
            if (EffectID == 4) { return "Bleeding"; }
            if (EffectID == 5) { return "Mini-Crit"; }
            if (EffectID == 6) { return "Crits"; }
            if (EffectID == 7) { return "Marked for Death"; }

            return "error";
        }
       
        public static int BulletEnhancer(int EffectID, int TotalDamage)
        {
            // this Code will be run regardless if there is an effect or not. so the TotalDamage will be run through this like a Filter.
            // DO NOT Reset the TotalDamage.
            if (EffectID == 3) //Jarated (+35% Damage) //
            {
                TotalDamage = TotalDamage + (TotalDamage * 35 / 100);
            }
            if (EffectID == 5) //Mini-Crit Boost (+35% Damage) Mini-Crit Inflicitng Weapons use this.
            {
                TotalDamage = TotalDamage + (TotalDamage * 35 / 100);
            }
            if (EffectID == 6) //Crits
            {
                TotalDamage = TotalDamage * 3;
            }
            if (EffectID == 7) //Marked For Death [Mini-Crits]
            {
                TotalDamage = TotalDamage + (TotalDamage * 35 / 100);
            }
            return TotalDamage;
        }

        public static int PoisonEffects(int EffectID, int Health)
        {
            if (EffectID == 1) //Burning
            {
                int Burning = (Health * 5 / 100); // -5% of HP Each Half Turn as Burning Damage (Burning Damage gets Weaker as Enemy Dies.)
                return Burning;
            }
            if (EffectID == 4) //Bleeding
            {
                int Bleeding = (Health * 10 / 100);
                return Bleeding;
            }
            return 0;
        }

        public static int SelfHelp(int EffectID, int TotalDamage) //Returns Value to User
        {
            if (EffectID == 2) // Mad Milk
            {
                int Healing_MadMilk = (TotalDamage * 60 / 100); //Takes 60% of Damage and Heals the Player
                return Healing_MadMilk;
            }
            return 0;
        }

        public static int SecondaryFunction(int ClassID, int Primary, int Secondary, int Melee, int PC, int SC, int MC, int EC)
        {
            var randomdamage = new Random();
            int Damage;

            #region Scout_Melee
            if (Melee == 21 && ClassID == 1 && EC == 0) //Sandman Baseball
            {
                Damage = randomdamage.Next(15, 81);
                return Damage;
            }
            if (Melee == 28 && ClassID == 1 && EC == 0) //WrapAssassin Ornament
            {
                Damage = randomdamage.Next(15, 61);
                return Damage;
            }
            #endregion
            #region Soldier_Melee
            if (Melee == 53 && ClassID == 2)
            {
                Damage = randomdamage.Next(1, 11);
                if (Damage == 1)
                {
                    Damage = 195;
                }
                Damage = 0;
                return Damage;
            }
            #endregion
            #region Sniper_Primary

            #endregion
            return 0;
        }
        public static string SecondaryFunctionName(int P, int S, int M)
        {
            if (M == 21) { return "Throw a Baseball"; } //Sandman
            if (M == 28) { return "Throw an Ornament"; } //Wrapped Assassin
            if (P == 999) { return "Charge Weapon"; }
            return "error";
        }
        public static string SecondaryFunctionNameShort(int P, int S, int M)
        {
            if (M == 21) { return "Baseball"; } //Sandman
            if (M == 28) { return "Ornament"; } //Wrapped Assassin
            return "error";
        }
        public static string SecondaryFunctionAttackPrompt_Player(string Playername, string EnemyPrefix, string EnemyClass, int P, int S, int M)
        {
            if (M == 21) { return $"{Playername} Hit a Baseball at {EnemyPrefix} {EnemyClass}!"; } //Sandman
            if (M == 28) { return $"{Playername} Swung and hit an Ornament at {EnemyPrefix} {EnemyClass}!"; } //Wrapped Assassin
            return "error";
        }
        public static string SecondaryFunctionAttackPrompt_Enemy(string Playername, string EnemyPrefix, string EnemyClass, int P, int S, int M)
        {
            if (M == 21) { return $"{EnemyPrefix} {EnemyClass} Hit a Baseball at {Playername}!"; } //Sandman
            if (M == 28) { return $"{EnemyPrefix} {EnemyClass} Swung and hit an Ornament at {Playername}!"; } //Wrapped Assassin
            return "error";
        }
    }
}
