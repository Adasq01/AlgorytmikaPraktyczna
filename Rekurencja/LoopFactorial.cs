using System;

namespace Rekurencja
{
    public static class LoopFactorial 
    {
        public static Int64 Factorial(int number)
        {
            if(number < 0)
                throw new ArgumentException("Only natural numbers.");

            if (number < 2)
                return 1;

            var result = number;
            for (var i = number - 1; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
