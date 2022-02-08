using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactors.Interfaces
{
public interface IPrimeFactors
    {
        List<long> PrimeFactors(long num);
    }

    class PrimeFactorsClass : IPrimeFactors
    {
        List<long> IPrimeFactors.PrimeFactors(long num)
        {
            // Return the number's prime factors.
            {
                List<long> result = new List<long>();

                // Take out the 2s.
                while (num % 2 == 0)
                {
                    result.Add(2);
                    num /= 2;
                }

                // Take out other primes.
                long factor = 3;
                while (factor * factor <= num)
                {
                    if (num % factor == 0)
                    {
                        // This is a factor.
                        result.Add(factor);
                        num /= factor;
                    }
                    else
                    {
                        // Go to the next odd number.
                        factor += 2;
                    }
                }

                // If num is not 1, then whatever is left is prime.
                if (num > 1) result.Add(num);

                return result;
            }
        }

    }
}
