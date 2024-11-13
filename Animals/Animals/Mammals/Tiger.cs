using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals.Mammals
{
    internal class Tiger : Panthera, IMove
    {
        public Tiger(float weight) : base(weight)
        {

        }

        public void Move() 
        {
            Console.WriteLine("Tiger is moving!");
        }
    }
}
