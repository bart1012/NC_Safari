using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals.Mammals
{
    internal class Bat : Mammal, IHunt, IFly
    {
        public Bat(float weight) : base(weight)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("Bat is hunting in the air.");
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + "says screech!");
        }
    }
}
