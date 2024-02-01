using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        // Constructor for the 'Tool' class, taking a 'Description' parameter and passing it to the base class constructor.
        public Tool(string Description) : base(Description) { }

        // Override the 'AddMe' method from the base class 
        public override void AddMe(List<Collectable> possibleCollectable)
        {
            base.AddMe(possibleCollectable);

            DoAction();
        }

        public virtual void DoAction()
        {
        }
    }
}
