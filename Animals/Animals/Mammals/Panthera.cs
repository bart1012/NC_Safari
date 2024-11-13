using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Mammals
{
    internal class Panthera
    {
        public void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }
    }
}
