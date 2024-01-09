using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoToFour.Service.Comparison;

namespace TwoToFour.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComparisonController : ControllerBase
    {
        private readonly IComparisonService _comparisonService;

        public ComparisonController(IComparisonService ComparisonService)
        {
            _comparisonService = ComparisonService;
        }

        [HttpPost("Compare/{number1}/{number2}")]

        public string AddCompare(string num1, string num2)
        {
            return _comparisonService.AddCompare(num1, num2);
        }
    }
}