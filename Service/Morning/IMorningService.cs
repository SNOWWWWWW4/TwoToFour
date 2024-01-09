using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Service.Morning
{
    public interface IMorningService
    {
        string AddGreeting(string name, string time);
    }
}