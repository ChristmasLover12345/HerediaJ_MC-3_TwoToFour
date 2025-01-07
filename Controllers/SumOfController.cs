
using HerediaJ_MC_3_TwoToFour.services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_MC_3_TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumOfController : ControllerBase
    {
        
        private readonly SumOfServices _sumOfServices;

        public SumOfController(SumOfServices sumOfServices)
        {
            _sumOfServices = sumOfServices;
        }



        [HttpPost]
        [Route("TheSumOf/{firstNum}/{secondNum}")]
        public string TheSumOf(int firstNum, int secondNum)
        {
            return _sumOfServices.AddUpTo(firstNum, secondNum);
        }

    }
}