using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HerediaJ_MC_3_TwoToFour.services
{
    public class SumOfServices
    {

        public string SumOf = "";

        public string AddUpTo(int firstNum, int secondNum)
        {
            SumOf = $"The sum of {firstNum} and {secondNum} is {firstNum + secondNum}";
            return SumOf;
        }

    }
}