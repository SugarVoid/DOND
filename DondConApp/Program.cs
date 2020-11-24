using System;
using System.Collections.Generic;
using System.Linq;

namespace DOND
{
    class Program
    {
        static void Main(string[] args)
        {


            Game g = new Game();

            //g.PrintCases();

            Console.WriteLine("select a case to keep...");

            string choice = Console.ReadLine();

            int age;
            
            if (!int.TryParse(choice, out age))
            {
                Console.WriteLine("Please enter valid input for age ! ");
                return;
            }


            Case query = g.Cases.Where(u => u.Name == age).FirstOrDefault();
            g.SelectCase(query);
            g.Cases.Remove(query);

            g.PrintCases();

            Console.WriteLine("select a case to open...");

            choice = Console.ReadLine();

            if (!int.TryParse(choice, out age))
            {
                Console.WriteLine("Please enter valid input for age ! ");
                return;
            }

            g.OpenCase();


        }
    }
}
