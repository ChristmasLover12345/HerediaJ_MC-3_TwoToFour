
using HerediaJ_MC_3_TwoToFour.services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_MC_3_TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpTimeController : ControllerBase
    {
        
        private readonly WakeUpTimeService _wakeUpTimeService;

        public WakeUpTimeController(WakeUpTimeService wakeUpTimeService)
        {
            _wakeUpTimeService = wakeUpTimeService;
        }

        [HttpPost]
        [Route("WakeUpTime/{userName}/{wakeTime}")]
        public string YouWokeUpAt(string userName, string wakeTime)
        {
            return _wakeUpTimeService.YouWokeUpAt(userName, wakeTime);
        }


    }
}