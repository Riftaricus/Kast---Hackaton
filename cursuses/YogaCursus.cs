using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class YogaCursus : Cursus
    {
        public YogaCursus(string name, Subscription requiredSubscription) : base(name, requiredSubscription)
        {
        }
    }
}