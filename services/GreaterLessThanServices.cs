using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_MC_3_TwoToFour.services
{
    public class GreaterLessThanServices
    {
        
        public string GreaterLess = "";


        public string GTLT(int firstNum, int secondNum)
        {

            if (firstNum > secondNum)
            {
                GreaterLess = $"{firstNum} is greater than {secondNum}\n{secondNum} is less than {firstNum}";
            }
            else if (firstNum == secondNum)
            {
                GreaterLess = $"{firstNum} is equal to {secondNum}\n{secondNum} is equal to {firstNum}";
            }
            else if (firstNum < secondNum)
            {
                GreaterLess = $"{firstNum} is less than {secondNum}\n{secondNum} is greater than {firstNum}";
            }
           

            return GreaterLess;

        }

    }
}