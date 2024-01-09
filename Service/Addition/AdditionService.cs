using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace TwoToFour.Service.Addition
{
    public class AdditionService : IAdditionService
    {
        public string AddNums(string num1, string num2)
        {
            double yes = 0;
            double yes2 = 0;

            bool success = double.TryParse(num1, out yes) && double.TryParse(num2, out yes2);

            if(success){
            
                Double sum = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                return $"The sum of {num1} and {num2} is {sum}";

            }else{

                return "One or more inputs is not a number. Please make sure both inputs are numbers";
            }
            
        }
    }
}