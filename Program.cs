using System.Runtime.InteropServices;

namespace Kast___Hackaton
{
    class Program
    {
        static void Main()
        {
            foreach (Sporter sporter in Factory.GenerateSporters())
            {
                sporter.Debug();
            }

            foreach (Coach coach in Factory.GenerateCoaches())
            {
                coach.Debug();
            }



        }
    }
}