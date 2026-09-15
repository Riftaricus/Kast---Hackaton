using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class OncePerWeekSubscription : Subscription
    {
        public OncePerWeekSubscription() : base()
        {
            Name = "Once Per Week Subscription";
        }

        public override bool Use()
        {
            if (Usage > 1) return false;
            Usage += 1;
            return true;
        }
    }
}