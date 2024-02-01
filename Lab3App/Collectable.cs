using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {

        public CollectionBoard Board;

        public string Description;

        // Constructor for the 'Collectable' class, taking 'Description' parameter and initializing it
        public Collectable(string Description) {
            this.Description = Description;

        }

        // Virtual method 'AddMe' with default implementation, which adds the collectable to a list and prints a message.

        public virtual void AddMe(List<Collectable> possibleCollectable)
        {
            possibleCollectable.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");

        }

        public abstract void Display();


    }
}
