using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public abstract class Subscription
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int usage = 1;
        public int Usage { get { return usage; } set { usage = value; } }

        public Subscription()
        {
        }

        public bool CompareType(Subscription type)
        {
            if (type == null) return false;

            if (type.GetType() != this.GetType())
            {
                return false;
            }
            return true;
        }

        public virtual bool Use()
        {
            Usage += 1;
            return true;
        }

        public void Debug()
        {
            Console.WriteLine(this.GetType());
        }



    }
}