using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollTheDice;

namespace RollTheDiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceCup cup = new DiceCup();

            // Role the dice 100 times...
            for (int i = 0; i < 100; i++)
            {
                List<int> results = cup.Roll(2);

                int total = 0;
                foreach (int r in results)
                {
                    total += r;
                }

                Console.WriteLine(String.Format("Roll result = {0}", total));
            }

            Console.ReadLine();
        }
    }
}
