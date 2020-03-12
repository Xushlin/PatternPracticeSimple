using System;

namespace PatternPractice.StaticFactory.Calculator
{
    internal static class Convertor
    {
        public static double ToDouble(this string me)
        {
            double result = 0;
            if(Double.TryParse(me, out result))
            {
              return  result;
            }

            throw new Exception("Your must enter a number");            
        }
    }
}
