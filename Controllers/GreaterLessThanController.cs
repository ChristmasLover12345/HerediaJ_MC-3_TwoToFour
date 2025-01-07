using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_MC_3_TwoToFour.services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_MC_3_TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterLessThanController : ControllerBase
    {

        private readonly GreaterLessThanServices _greaterLessThanServices;

        public GreaterLessThanController(GreaterLessThanServices greaterLessThanServices)
        {
            _greaterLessThanServices = greaterLessThanServices;
        }

        [HttpPost]
        [Route("GTLT/{firstNum}/{secondNum}")]
        public string GTLT(int firstNum, int secondNum)
        {
            return _greaterLessThanServices.GTLT(firstNum, secondNum);
        }


    }
}