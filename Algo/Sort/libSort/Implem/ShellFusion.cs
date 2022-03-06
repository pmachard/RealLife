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


        private static int[] SortFusion(int[] sourceTab)
        {

            int[] tabResult = sourceTab.Clone() as int[];
            /*
            int n = sourceTab.Length;

            if (n <= 1)
            {
                return sourceTab;
            }
            else
            {
                return Fusion((sourceTab[1] sourceTab[n / 2]),
                                (sourceTab[n / 2], sourceTab[n]));
            }
            */
            return tabResult;
        }

        private static int[] Fusion(int[] a, int[] b)
        {
            /*
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
                return Fusion(tabA[1] * Fusion(tabA[2, tabA.Length - 1], tabB));
            else
                return tabB[1] * Fusion(tabA, tabB[2, tabB.Length - 1] as int[]);

            */
            return a;
        }
    }
}
