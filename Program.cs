using System.Runtime.InteropServices;

namespace Kast___Hackaton
{
    class Program
    {

        public static Client client;
        static void Main()
        {
            Client localClient = new Client();

            foreach (Sporter sporter in Factory.GenerateSporters())
            {
                localClient.AddSporter(sporter);
            }

            foreach (Coach coach in Factory.GenerateCoaches())
            {
                localClient.AddCoach(coach);
            }

            localClient.AddCursus(new PilatesCursus("Pilates", new CursusSubscription()));
            localClient.AddCursus(new PoleDancingCursus("Pole Dancing", new CursusSubscription()));
            localClient.AddCursus(new YogaCursus("Yoga", new CursusSubscription()));

            client = localClient;

            localClient.Run();


        }
    }
}