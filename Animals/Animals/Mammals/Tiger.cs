using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals.Mammals
{
    internal class Tiger : Panthera, IHunt
    {
        public Tiger(float weight) : base(weight)
        {

        }

        public void Hunt()
        {
            Console.WriteLine("Tiger is hunting on land!");
        }
    }
}
