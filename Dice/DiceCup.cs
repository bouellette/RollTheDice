using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheDice
{
    public class DiceCup
    {
        public DiceCup()
        {
            RandomNumberGenerator = new Random();
        }

        public Random RandomNumberGenerator { get; set; }

        public List<int> Roll(int numberOfDice)
        {
            List<int> dice = new List<int>();
            for (int i = 0; i < numberOfDice; i++)
            {
                dice.Add(RandomNumberGenerator.Next(1, 7));
            }
            return dice;
        }

        /// <summary>
        /// Overloaded Roll method accepts number of dice sides parameter...
        /// </summary>
        /// <param name="numberOfDice"></param>
        /// <param name="numberOfDiceSides"></param>
        /// <returns></returns>
                 
        public List<int> Roll(int numberOfDice, int numberOfDiceSides)
        {
            List<int> dice = new List<int>();
            for (int i = 0; i < numberOfDice; i++)
            {
                dice.Add(RandomNumberGenerator.Next(1, numberOfDiceSides + 1));
            }
            return dice;
        }
    }
}
