﻿using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.SafariEnvironment
{
    internal class HuntingGround : SafariEnvironment<IHunt>
    {
        public override void CheckAnimalsInEnvironment()
        {
            throw new NotImplementedException();
        }
    }
}
