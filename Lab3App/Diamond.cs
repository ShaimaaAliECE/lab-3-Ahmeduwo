using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
   public class Diamond : Treasure
    {

        // Constructor for the 'Diamond' class, taking 'Description' and 'score' parameters, and passing them to the base class constructor
        public Diamond(string Description, int score) : base(Description, score) { }



        // Override the 'Display' method from the base class
        public override void Display()
        {
            Console.WriteLine("Diamond " + this.Description + " is displayed");
        }



    }
}
