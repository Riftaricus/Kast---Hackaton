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

        public void AddCursus(Cursus cursus)
        {
            if (cursus == null) return;
            if (cursuses.Contains(cursus)) return;
            cursuses.Add(cursus);
        }

        public void RemoveCursus(Cursus cursus)
        {
            if (cursus == null) return;
            if (!cursuses.Contains(cursus)) return;
            cursuses.Remove(cursus);
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

        public List<Sporter> GetSporters()
        {
            if (sporters == null)
            {
                return null;
            }

            return sporters;
        }


        public List<Cursus> GetCursuses()
        {
            if (cursuses == null)
            {
                return null;
            }

            return cursuses;
        }



        public Sporter SelectSporter()
        {
            List<string> sporterNames = new List<string>();

            foreach (Sporter sporter in Program.client.GetSporters())
            {
                sporterNames.Add($"{sporter.FirstName} {sporter.SurName}");
            }

            string[] sporters = sporterNames.ToArray();
            int sporterId = UI.ShowOptions(sporters);

            return Program.client.GetSporters()[sporterId - 1];
        }

        public Cursus SelectCursus()
        {
            List<string> cursusNames = new List<string>();

            foreach (Cursus cursus in Program.client.GetCursuses())
            {
                cursusNames.Add(cursus.Name);
            }

            string[] cursuses = cursusNames.ToArray();
            int cursusId = UI.ShowOptions(cursuses);

            return Program.client.GetCursuses()[cursusId - 1];
        }

        public void Run()
        {
            UI.PrintMenu();
        }   
    }
}