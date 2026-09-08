using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class UI
    {
        public static void PrintMenu()
        {
            PrintDivider();
            Console.WriteLine("Hackaton 1 - De Kast");
            PrintDivider();
            Console.WriteLine("Options:");
            int response = 0;
            string[] options = ["Test", "Test2", "Test3"];
            while (response == 0 || response > options.Length) 
            {
                response = ShowOptions(["Test", "Test2", "Test3"]);
                Console.WriteLine(response);
            }

        }

        public static void PrintDivider()
        {
            Console.WriteLine("----------------------------------");
        }

        public static int ShowOptions(string[] options)
        {
            int index = 0;
            foreach (string option in options)
            {
                index++;
                Console.WriteLine(index + ". " + option);
            }
            string response = Console.ReadLine();

            try
            {
                return Int32.Parse(response);
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
    }
}