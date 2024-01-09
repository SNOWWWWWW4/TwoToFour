using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Service.Comparison
{
    public class ComparisonService : IComparisonService
    {
        public string AddCompare(string num1, string num2)
        {
            double yes = 0;
            double yes2 = 0;

            bool success = double.TryParse(num1, out yes) && double.TryParse(num2, out yes2);

            if(success)
            {
                if( yes > yes2)
                {
                    return $"{yes} is greater than {yes2} \n{yes2} is less than {yes}";

                }else if(yes < yes2)
                {
                    return $"{yes} is less than {yes2} \n{yes2} is greater than {yes}";
                }else{

                    return $"{yes} is equal to {yes2} \n{yes2} is equal to {yes}";
                }

            }else{
                return "One or more inputs is not a number. Please make sure both inputs are numbers";
            }

        }
    }
}