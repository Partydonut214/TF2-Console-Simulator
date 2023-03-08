using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class EnemyTurn
    {
        public static int EnemyChoice(int cooldown)
        {
        Random randomChoice = new Random();
        int Choice = randomChoice.Next(1, 5); // Random Number from 1 - 4.
        if (cooldown >= 1)
            {
                while (Choice == 2) 
                { 
                Choice = randomChoice.Next(1, 5);
                }
                return Choice;
            }
            return Choice;
        }
    }
}
