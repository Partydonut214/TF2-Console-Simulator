using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class SaveFile
    {
        public void SaveLoad(int Choice)
        {
            string SavePath = $@"C:\Users\Public\Documents\TF2Sim\Save_{Choice}.txt";
            try
            {
                if (File.Exists(SavePath))
                {
                    Console.WriteLine($"Save File {Choice} Found!");

                    //writes to file
                    //System.IO.File.WriteAllText(Savepath, "This File Exists.\n");
                    //Inventory.InventoryLoader(); //SUPER BROKEN
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
