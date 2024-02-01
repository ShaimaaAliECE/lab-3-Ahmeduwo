using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        private int Score;

        // Constructor for the 'Treasure' class, taking 'Description' and 'Score' parameters, and passing 'Description' to the base class constructor
        public Treasure(string Description, int Score) : base(Description)
        {
            this.Score = Score;
        }

        // Method to update the total score on the 'Board' by adding the score of this treasure
        public void UpdateTotalScore()
        {
            Board.TotalScore += this.Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        // Override the 'AddMe' method from the base class 
        public override void AddMe(List<Collectable> possibleCollectable)
        {
            base.AddMe(possibleCollectable);
            UpdateTotalScore();
        }
    }
}
