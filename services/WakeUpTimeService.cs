using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_MC_3_TwoToFour.services
{
    public class WakeUpTimeService
    {
        
        public string wakeUpTime = "";

        public string YouWokeUpAt(string userName, string wakeTime)
        {
            wakeUpTime = $"Your name is {userName} and you woke up at {wakeTime}";
            return wakeUpTime;
        }


    }
}