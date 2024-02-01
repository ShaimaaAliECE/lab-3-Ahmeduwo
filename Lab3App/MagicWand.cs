using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
  
    class MagicWand : Tool
    {
        // Constructor for MagicWand, taking a Description parameter and calling the base class constructor
        public MagicWand(string Description) : base(Description) { }

        // Override the DoAction method from the base class 
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }

        // Override the Display method 
        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.Description + " is displayed");
        }

    }
}
