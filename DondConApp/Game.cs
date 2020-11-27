
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOND
{
    // TODO: Move class to Lib and make static
    public class Game
    {
        private Random rnd = new Random();
         string choice;
         int choiceInt;

        public List<Case> Cases { get; private set; }
        public Case PlayersCase { get; private set; }

        public Game()
        {
            Cases = new List<Case>();
            ShuffleMoney();

            for (int i = 0; i < 26; i++)
            {
                Cases.Add(new Case(moneyOptions[i], numbers[i]));
            }

        }

        public void PlayerSelectCase(Case c)
        {
            PlayersCase = c;
            Cases.Remove(c);
        }

        public string OpenCase(Case c)
        {
            c.IsOpen = true;
            return c.DollarAmount.ToString();
        }

        private double[] moneyOptions = new double[26]
        {
                1, 2, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000,  1000000
        };

        private int[] numbers = new int[26]
        {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26
        };

        private void ShuffleMoney()
        {
            this.moneyOptions = moneyOptions.OrderBy(x => rnd.Next()).ToArray();
        }

        public void PrintCases()
        {
            foreach (Case c in Cases)
            {
                string box;
                if (c.IsOpen)
                {
                    box = "[ x ]";
                }

                else
                {
                    box = "[  ]";
                }

                Console.WriteLine($"{c.Name} -- {box}");
            }
        }

        private void Shuffle()
        {
            
        }

        public Case PickCase()
        {
            Console.WriteLine("select a case to open...");

            choice = Console.ReadLine();

            if (!int.TryParse(choice, out choiceInt))
            {
                Console.WriteLine("Please enter valid input for age ! ");
                PickCase();
                //return;
            }


            return this.Cases.Where(u => u.Name == choiceInt).FirstOrDefault();
        }

        
    }
}
