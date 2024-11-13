using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Interfaces
{
    [Obsolete("Use IFly, IHunt or ISwim instead.", true)]
    public interface IMove
    {
        void Move();
    }
}
