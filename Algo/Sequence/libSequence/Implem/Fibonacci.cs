using System;
using System.Collections.Generic;

namespace Utopia.Algo.Sequence.Implem
{
    public class Fibonacci
    {
        public static int RunRecursive(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return RunRecursive(n - 2) + RunRecursive(n - 1);
        }

        public static int RunRecursiveCach(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return RunRecursiveCach(n - 2) + RunRecursiveCach(n - 1);
        }

        public static int RunIteratif(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int w, u = 0, r = 1;

            for (int i = 2; i <= n; i++)
            {
                w = u + r;
                u = r;
                r = w;
            };
            return r;
        }

        static Dictionary<int, int> cacheFibonacci = new Dictionary<int, int>();

        public static int RunRecursiveCache(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int result = 0;
            if (cacheFibonacci.TryGetValue(n, out result))
                return result;

            result = RunRecursive(n - 2) + RunRecursive(n - 1);
            cacheFibonacci[n] = result;

            return result;
        }
    }
}
