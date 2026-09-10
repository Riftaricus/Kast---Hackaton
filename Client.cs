using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class Client
    {
        private List<Sporter> sporters = new List<Sporter>();
        private List<Coach> coaches = new List<Coach>();

        private List<Cursus> cursuses = new List<Cursus>();

        public void AddSporter(Sporter sporter)
        {
            if (sporter == null) return;
            if (sporters.Contains(sporter)) return;
            sporters.Add(sporter);
        }

        public void RemoveSporter(Sporter sporter)
        {
            if (sporter == null) return;
            if (!sporters.Contains(sporter)) return;
            sporters.Remove(sporter);
        }

        public void AddCoach(Coach coach)
        {
            if (coach == null) return;
            if (coaches.Contains(coach)) return;
            coaches.Add(coach);
        }

        public void RemoveCoach(Coach coach)
        {
            if (coach == null) return;
            if (!coaches.Contains(coach)) return;
            coaches.Remove(coach);
        }

        public List<Sporter>? GetSporters()
        {
            if (sporters == null)
            {
                return null;
            }

            return sporters;
        }

        public void Run()
        {
            UI.PrintMenu();
        }   
    }
}