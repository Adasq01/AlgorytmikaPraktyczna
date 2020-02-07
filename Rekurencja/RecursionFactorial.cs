using System;

namespace Rekurencja
{
    public static class RecursionFactorial
    {
        public static Int64 Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Only natural numbers.");
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
    }
}
