using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Birds
{
    public class Goose : Bird, IFly, ISwim
    {
        public Goose(float weight) : base(weight)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Goose is flying.");
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + "says quack!");
        }

        public void Swim()
        {
            Console.WriteLine("Goose is swimming.");
        }
    }
}
