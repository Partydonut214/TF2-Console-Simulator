using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Classes
    {
        public static string ClassNamefromID(int ID)
        {
            if (ID <= 0) return "None";
            if (ID == 1) return "Scout";
            if (ID == 2) return "Soldier";
            if (ID == 3) return "Pyro";
            if (ID == 4) return "Demoman";
            if (ID == 5) return "Heavy";
            if (ID == 6) return "Engineer";
            if (ID == 7) return "Medic";
            if (ID == 8) return "Sniper";
            if (ID == 9) return "Spy";
            if (ID >= 10) return "None";
            return "None";
        }
        public static string ConditionsfromID(int ID)
        {
            if (ID <= 0) return "None";
            if (ID == 1) return "Burning";
            if (ID == 2) return "Jarate-ed";
            if (ID == 3) return "Mad-Milked";
            if (ID == 4) return "+20 DMG Resist";
            if (ID == 5) return "+20 DMG Taken";
            if (ID == 6) return "Mini-Crit Boost";
            if (ID == 7) return "Crit Boost";
            if (ID == 8) return "GasCan";
            if (ID == 9) return "Wet";
            return "None";
        }
        public static int ClassHealthfromID(int ID)
        {
            int Health = 0;
            if (ID <= 0) Health = 0;
            if (ID == 1) Health = 125;
            if (ID == 2) Health = 200;
            if (ID == 3) Health = 175;
            if (ID == 4) Health = 175;
            if (ID == 5) Health = 300;
            if (ID == 6) Health = 125;
            if (ID == 7) Health = 150;
            if (ID == 8) Health = 125;
            if (ID == 9) Health = 125;
            if (ID >= 10) Health = 0;
            return Health;
        }
    }
}
