using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Birds
{
    public class Penguin : Bird, IHunt, ISwim
    {
        public Penguin(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " squeeks!");
        }

        public void Hunt()
        {
            Console.WriteLine("Penguin is hunting in the water!");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }
    }
}
