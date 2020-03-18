namespace Lab1.PrimeSearcher
{
    public static class NumbersHelper
    {
        public static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            for (var i = 3; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}