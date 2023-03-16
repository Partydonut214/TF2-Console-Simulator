using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Colors
    {
        public static string CheckName_for_Color(string PlayerNameInput)
        {
            #region Colors & Bools
            string ColorC_Red = "red";
            bool redTrue = PlayerNameInput.ToLower().Contains(ColorC_Red);
            string ColorC_Yellow = "yellow";
            bool yellowTrue = PlayerNameInput.ToLower().Contains(ColorC_Yellow);
            string ColorC_Green = "green";
            bool greenTrue = PlayerNameInput.ToLower().Contains(ColorC_Green);
            string ColorC_Blue = "blue";
            bool blueTrue = PlayerNameInput.ToLower().Contains(ColorC_Blue);
            string ColorC_Grey = "grey";
            bool greyTrue = PlayerNameInput.ToLower().Contains(ColorC_Grey);
            string ColorC_pink = "pink"; //magenta
            bool pinkTrue = PlayerNameInput.ToLower().Contains(ColorC_pink);
            string ColorC_Cyan = "cyan";
            bool cyanTrue = PlayerNameInput.ToLower().Contains(ColorC_Cyan);
            string ColorC_DarkRed = "darkred";
            bool DKRedTrue = PlayerNameInput.ToLower().Contains(ColorC_DarkRed);
            string ColorC_DarkYellow = "darkyellow";
            bool DKYellowTrue = PlayerNameInput.ToLower().Contains(ColorC_DarkYellow);
            string ColorC_DarkGreen = "darkgreen";
            bool DKGreenTrue = PlayerNameInput.ToLower().Contains(ColorC_DarkGreen);
            string ColorC_DarkBlue = "darkblue";
            bool DKBlueTrue = PlayerNameInput.ToLower().Contains(ColorC_DarkBlue);
            string ColorC_DarkPurple = "purple";
            bool DKPurpleTrue = PlayerNameInput.ToLower().Contains(ColorC_DarkPurple); //Dark Magenta
            string ColorC_DarkCyan = "darkcyan";
            bool DKCyanTrue = PlayerNameInput.ToLower().Contains(ColorC_DarkCyan);
            #endregion
            if (redTrue == true || yellowTrue == true || greenTrue == true || blueTrue == true || greyTrue == true || pinkTrue == true || cyanTrue == true || DKRedTrue == true || DKYellowTrue == true || DKGreenTrue == true || DKBlueTrue == true || DKPurpleTrue == true || DKCyanTrue == true)
            {
                if (redTrue == true) { return "SetRed"; }
                else if (yellowTrue == true) { return "SetYellow"; }
                else if (greenTrue == true) { return "SetGreen"; }
                else if (blueTrue == true) { return "SetBlue"; }
                else if (cyanTrue == true) { return "SetCyan"; }
                else if (pinkTrue == true) { return "SetPink"; }
                else if (DKRedTrue== true) { return "SetDarkRed"; }
                else if (DKYellowTrue== true) { return "SetDarkYellow"; }
                else if (DKGreenTrue== true) { return "SetDarkGreen"; }
                else if (DKBlueTrue== true) { return "SetDarkBlue"; }
                else if (DKCyanTrue== true) { return "SetDarkCyan"; }
                else if (DKPurpleTrue== true) { return "SetDarkPurple"; }
            }
            return "none";
        }
        public static ConsoleColor SetColor(string ColorInput)
        {
            if (ColorInput.ToLower() == "red") { return ConsoleColor.Red; }
            if (ColorInput.ToLower() == "yellow") { return ConsoleColor.Yellow; }
            if (ColorInput.ToLower() == "green") { return ConsoleColor.Green; }
            if (ColorInput.ToLower() == "blue") { return ConsoleColor.Blue; }
            if (ColorInput.ToLower() == "cyan") { return ConsoleColor.Cyan; }
            if (ColorInput.ToLower() == "purple") { return ConsoleColor.DarkMagenta; }
            if (ColorInput.ToLower() == "pink") { return ConsoleColor.Magenta; }
            return ConsoleColor.White;
        }
    }
}
