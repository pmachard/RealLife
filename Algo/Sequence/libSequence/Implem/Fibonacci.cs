using System;

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
    }
}
