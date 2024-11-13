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

        public void Move()
        {
            Console.WriteLine("Penguin is moving!");
        }
    }
}
