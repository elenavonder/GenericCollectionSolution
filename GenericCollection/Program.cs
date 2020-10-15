using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bowling Example
            var rnd = new Random();
            var score = new List<int>();
            for (var idx = 1; idx <= 10; idx++)
            {
               var nbr = rnd.Next(0, 31);
                score.Add(nbr);
            }
            var total = 0;
            foreach (var score1 in score)
            {
                total += score1;
            }
            Console.WriteLine($"Bowling score is {total}");

            //go through generic collection of names in class
            var Names = new List<string>();
            Names.Add("Elena");
            Names.Add("Christian");
            Names.Add("Tracy");
            Names.Add("Yvonne");
            Names.Add("Mark");
            Names.Add("Fred");
            Names.Add("Manami");
            Names.Add("Sarah");
            Names.Add("Greg");
            //sort all the names alphabetically
            Names.Sort();
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }//removing "Fred" from names
            Names.Remove("Fred");
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
