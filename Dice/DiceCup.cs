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
    }
}
