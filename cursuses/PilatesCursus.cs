using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class PilatesCursus : Cursus
    {
        public PilatesCursus(string name, Subscription requiredSubscription) : base(name, requiredSubscription)
        {
        }
    }
}