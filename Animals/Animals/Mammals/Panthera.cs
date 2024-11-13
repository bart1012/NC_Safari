﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Mammals
{
    internal class Panthera : Mammal
    {
        public Panthera(float weight) : base(weight)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }
    }
}
