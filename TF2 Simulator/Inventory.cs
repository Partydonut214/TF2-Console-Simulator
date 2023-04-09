using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class Inventory
    {
        public static void InventoryLoader()
        {
            string Savepath = @"C:\Users\Public\Documents\TF2Sim\Save_01.txt";
            foreach (char inventory in Savepath)
            {
                using (StreamReader sr = File.OpenText(Savepath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(s);
                        if (s.StartsWith("cID"))
                        {
                            Console.WriteLine($"{s}");
                        }
                    }
                }
            }
        }
    }
}
