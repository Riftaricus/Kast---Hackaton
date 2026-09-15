using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class CursusSubscription : Subscription
    {
        public CursusSubscription() : base()
        {
            Name = "Cursus Subscription";
        }

        public override bool Use()
        {
            return false;
        }
    }
}