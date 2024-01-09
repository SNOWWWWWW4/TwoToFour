using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Service.Morning
{
    public class MorningService : IMorningService
    {
        public string AddGreeting(string name, string time)
        {
            return $"Hello, {name}! Why did you wake up at {time} today?";
        }
    }

}