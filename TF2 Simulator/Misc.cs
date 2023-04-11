using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Misc
    {
        public static int CondCheck(int ClassID, int WeaponID, int StatusID_1, int StatusID_2, int StatusID_3)
        {
            string CondType = "";
            if (ClassID == 5 && WeaponID == 109 && StatusID_1 == 1 || StatusID_2 == 1 || StatusID_3 == 1)
            {
                return 0;
            }
            return 0;
        }
    }
}
