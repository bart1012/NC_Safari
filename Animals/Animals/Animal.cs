using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public float Weight;

        protected Animal(float weight)
        {
            Weight = weight;
        }

        public abstract void MakeSound();
    }
}
