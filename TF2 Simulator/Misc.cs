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
            if (EffectID == 7) { return ""; }
            if (EffectID == 8) { return ""; }
            if (EffectID == 9) { return ""; }
            if (EffectID == 10) { return ""; }

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
            if (EffectID == 5) //Mini-Crit Boost (+35% Damage) //Jarate and other Mini-Crit Inflicitng Weapons use this.
            {
                TotalDamage = TotalDamage + (TotalDamage * 35 / 100);
            }
            if (EffectID == 6) //Crits
            {
                TotalDamage = TotalDamage * 3;
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
    }
}
