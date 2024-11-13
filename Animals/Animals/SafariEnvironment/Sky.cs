using Animals.Interfaces;
using Animals.Birds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.SafariEnvironment
{
    internal class Sky : SafariEnvironment<IFly>
    {
        public override void CheckAnimalsInEnvironment()
        {
            if (animalsInEnvironment.Count != 0)
            {
                foreach (Animal item in animalsInEnvironment)
                {
                    Console.WriteLine(item.GetType().Name + " is flying!");
                }
            }
            throw new Exception();
        }
    }
}
