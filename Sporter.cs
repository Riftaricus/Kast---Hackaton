using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class Sporter : Human
    {
        private Subscription subscription;
        public Subscription Subscription { get { return subscription; } }

        public Sporter(string firstName, string surName, Subscription subscription) : base(firstName, surName)
        {
            this.subscription = subscription;
        }
    }
}