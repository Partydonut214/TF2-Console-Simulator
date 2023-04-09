using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class PrimaryWeapons
    {
        public PrimaryWeapons() 
        {
            int PrimaryWeaponID;
            string PrimaryWeaponName;
        }
        public static int PrimaryWeaponCompatable(int ClassID)
        {
            //Scout
            if (ClassID == 0) return 0;
            if (ClassID == 1) return 1;
            if (ClassID == 2) return 2;
            if (ClassID == 3) return 3;
            if (ClassID == 4) return 4;
            if (ClassID == 5) return 5;
            if (ClassID == 6) return 6;
            if (ClassID == 7) return 7;
            if (ClassID == 8) return 8;
            if (ClassID == 9) return 9;
            if (ClassID == 10) return 0;
            return 0;
        }
    }
}
