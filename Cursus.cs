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

        private List<Human> attendees;

        public string Type { get { return type; } }
        public string Name { get { return name; } }

        public List<Human> Attendees { get { return attendees; }}

        public Cursus(string type, string name)
        {
            this.type = type;
            this.name = name;
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