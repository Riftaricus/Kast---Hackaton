using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class Factory
    {
        private static readonly string[] firstNames = { "John", "Bob", "Robin", "Rob", "John", "Theodore", "Lila", "Layla", "Antonio", "Jen", "Gregory", "Greg" };
        private static readonly string[] lastNames = { "Rosalyn", "Smith", "Kora", "Andrea", "Gerrit", "Pippa", "Susan", "Nikolas", "Tesla" };

        private static Sporter GenerateSporter()
        {
            Random random = new Random();

            string firstName = firstNames[random.Next(0, firstNames.Length)];
            string lastName = lastNames[random.Next(0, lastNames.Length)];

            return new Sporter(firstName, lastName);

        }

        public static List<Sporter> GenerateSporters()
        {
            List<Sporter> sporters = new List<Sporter>();
            for (int i = 0; i < 10; i++)
            {
                sporters.Add(GenerateSporter());
            }

            return sporters;
        }

        private static Coach GenerateCoach()
        {
            Random random = new Random();

            string firstName = firstNames[random.Next(0, firstNames.Length)];
            string lastName = lastNames[random.Next(0, lastNames.Length)];

            return new Coach(firstName, lastName);

        }

        public static List<Coach> GenerateCoaches()
        {
            List<Coach> coaches = new List<Coach>();
            for (int i = 0; i < 10; i++)
            {
                coaches.Add(GenerateCoach());
            }

            return coaches;
        }
    }
}