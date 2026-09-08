using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public abstract class Cursus
    {
        private string name;

        private List<Human> attendees;

        public string Name { get { return name; } }

        public List<Human> Attendees { get { return attendees; }}

        public Cursus(string name)
        {
            this.name = name;
            this.attendees = new List<Human>();
        }

        public void signUp(Human human)
        {
            if (human == null) return;

            if (attendees.Contains(human)) return;

            attendees.Add(human);
        }
        
        public void remove(Human human)
        {
            if (human == null) return;

            if (!attendees.Contains(human)) return;

            attendees.Remove(human);
        }
    }
}