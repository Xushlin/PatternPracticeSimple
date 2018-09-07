using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Adapter.Structure
{
    public class Adaptee
    {
        public void PerformRequest()
        {
            Console.WriteLine("Addaptee perform request.");
        }
    }
}
