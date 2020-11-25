using System;
using System.Collections.Generic;
using System.Linq;

namespace DOND
{
    class Program
    {
        static Game g = new Game();
        static string choice;
        static int choiceInt;

        static void Main(string[] args)
        {


            

            //g.PrintCases();

            Console.WriteLine("select a case to keep...");

            choice = Console.ReadLine();

         
            
            if (!int.TryParse(choice, out choiceInt))
            {
                Console.WriteLine("Please enter valid input for age ! ");
                return;
            }

            Case query = g.Cases.Where(u => u.Name == choiceInt).FirstOrDefault();

            g.PlayerSelectCase(query);

            g.PrintCases();

            var x = g.PickCase();

            Console.WriteLine( g.OpenCase(x));


        }

        private void AskCase()
        {
            Console.WriteLine("select a case to open...");

            choice = Console.ReadLine();

            if (!int.TryParse(choice, out choiceInt))
            {
                Console.WriteLine("Please enter valid input for age ! ");
                return;
            }
        }
    }
}
