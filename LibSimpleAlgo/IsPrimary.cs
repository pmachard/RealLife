using System;
using System.Collections.Generic;

namespace Utopia.Algo.Simple
{
    public class IsPrimary
    {
        public static bool RunIteratif(int n)
        {
            if (n <= 1) return false;
            int k = 2;

            while (k * k <= n)
            {
                if (n % k == 0)
                    return false;
                else
                    k += 1;
            }
            return true;
        }
    }
}


