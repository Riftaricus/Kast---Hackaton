using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class Cursus
    {
        private string type;
        private string name;

        public string Type { get { return type; } }
        public string Name { get { return name; } }

        public Cursus(string type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public void signUp()
        {

        }
        
        public void remove()
        {
            
        }
    }
}