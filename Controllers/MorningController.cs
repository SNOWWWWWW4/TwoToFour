using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoToFour.Service.Morning;

namespace TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MorningController : ControllerBase
    {
        private readonly IMorningService _morningService;

        public MorningController(IMorningService MorningService)
        {
            _morningService = MorningService;
        }

        [HttpPost("AddGreeting/{name}/{time}")]
        public string AddGreeting(string name, string time)
        {
            return _morningService.AddGreeting(name,time);
        }

    
    }
}