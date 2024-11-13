using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Birds
{
    public class Penguin : Bird, IMove
    {
        public Penguin(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeek!");
        }

        public void Move()
        {
            Console.WriteLine("Penguin is moving.");
        }
    }
}
