using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class Human
    {
        private string firstName;
        private string surName;
        public string FirstName { get { return firstName; } }
        public string SurName { get { return surName; } }

        public Human(string firstName, string surName)
        {
            this.firstName = firstName;
            this.surName = surName;
        }

        public void Debug()
        {
            Console.WriteLine(firstName + " " + surName);
        }
    }
}