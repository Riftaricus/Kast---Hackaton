using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public abstract class Subscription
    {
        string name;

        public Subscription()
        {

        }

        public bool CompareType(Subscription type)
        {
            if (type != null) return false;

            if (type.GetType() != this.GetType())
            {
                return false;
            }
            return true;
        }
        
        public void Debug()
        {
            Console.WriteLine(this.GetType());
        }

        

    }
}