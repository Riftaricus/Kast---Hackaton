using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
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

            int response = ShowOptions(["Register for Course", "Test2", "Test3"]);


            switch (response)
            {
                case 1:
                    {
                        Sporter sporter = Program.client.SelectSporter();

                        Cursus cursus = Program.client.SelectCursus();

                        if (cursus.RequiredSubscription.CompareType(sporter.Subscription))
                        {
                            cursus.signUp(sporter);
                            Console.WriteLine("Succesfully signed up user to course");
                        }
                        else
                        {
                            Console.WriteLine("Failed to sign up user for course (Wrong subscription type)");
                        }


                        break;

                    }
                case 2:
                    {
                        Console.WriteLine(2);
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine(3);
                        break;
                    }
            }

        }

        public static void PrintDivider()
        {
            Console.WriteLine("----------------------------------");
        }

        public static int ShowOptions(IReadOnlyList<string> options)
        {
            while (true)
            {
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {options[i]}");
                }

                Console.Write("Choose an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice) &&
                    choice >= 1 &&
                    choice <= options.Count)
                {
                    return choice;
                }

                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}