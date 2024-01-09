using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoToFour.Service.Addition;

namespace TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdditionController : ControllerBase
    {
        private readonly IAdditionService _additionService;

        public AdditionController(IAdditionService AdditionService )
        {
            _additionService = AdditionService;
        }

        [HttpPost ("AddNums/{num1}/{num2}")]
        public string AddNums(string num1, string num2)
        {
            return _additionService.AddNums(num1, num2);
        }
    }
}