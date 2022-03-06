using System.Collections.Generic;
using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class ShellFusion : ISort
    {
        static public int[] Run(int[] tabSource)
        {
            return SortFusion(tabSource.Clone() as int[]);
        }


        private static int[] SortFusion(int[] T)
        {
            int[] tabResult = T.Clone() as int[];
            int n = T.Length;

            if (n <= 1)
                return T;
            else
                return Fusion(SortFusion((T[1, n / 2]), SortFusion(T[n / 2 + 1, n]))),
        }

        private static int[] Fusion(int[] tabA, int[] tabB)
        {
            int[] returnTab = null;
            if (tabA.Length == 0)
            {
                return tabB;
            }
            if (tabB.Length == 0)
            {
                return tabA;
            }

            if (tabA[1] <= tabB[1])
                return Fusion(tabA[1] * Fusion(tabA[2, tabA.Length - 1] as int[], tabB));
            else
                return tabB[1] * Fusion(tabA, tabB[2, tabB.Length - 1] as int[])

        return null;
        }
}
