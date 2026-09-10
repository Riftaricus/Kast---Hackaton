using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast___Hackaton
{
    public class Meeting
    {
        public readonly Coach coach;
        public readonly Sporter sporter;

        private Meeting(Coach coach, Sporter sporter)
        {
            this.coach = coach;
            this.sporter = sporter;
        }

        public static Meeting CreateMeeting(Coach coach, Sporter sporter)
        {
            return new Meeting(coach, sporter);
        }
    }
}