using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {
        // Constructor for the 'Axe' class, taking 'Description' parameter, and passing it to the base class constructor
        public Axe(string Description) : base(Description) { }

        // Override the 'DoAction' method from the base class 
        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        // Override the 'Display' method from the base class 
        public override void Display()
        {
            Console.WriteLine("Axe " + this.Description + " is displayed");
        }
    }
}