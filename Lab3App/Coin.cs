using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int Value;

        // Constructor for the 'Coin' class, taking 'Description', 'score', and 'value' parameters, and passing 'Description' and 'score' to the base class constructor
        public Coin(string Description, int score, int value) : base(Description, score)
        {
            this.Value = value;
        }

        // Method to update the total value on the 'Board' by adding the value 
        public void UpdateTotalValue()
        {
            Board.TotalValue += this.Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        // Override the 'AddMe' method from the base class 
        public override void AddMe(List<Collectable> possibleCollectable)
        {
            base.AddMe(possibleCollectable);
            UpdateTotalValue();
        }

        // Override the 'Display' method from the base class 
        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed");
        }
    }
}
