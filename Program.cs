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

            client = localClient;

            localClient.Run();


        }
    }
}