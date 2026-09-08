using System.Runtime.InteropServices;

namespace Kast___Hackaton
{
    class Program
    {
        static void Main()
        {
            Client client = new Client();

            foreach (Sporter sporter in Factory.GenerateSporters())
            {
                client.AddSporter(sporter);
            }

            foreach (Coach coach in Factory.GenerateCoaches())
            {
                client.AddCoach(coach);
            }

            client.Run();



        }
    }
}