using System;
using System.Collections.Generic;

namespace Utopia.Algo.Sequence.Implem
{
    public class SumCube
    {
        public static int RunIteratif(int n)
        {
            int somme = 0;

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            for (int i = 1; i <= n; i++)
                somme += i * i * i;

            return somme;
        }
    }
}
