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
            return tabResult;
        }

        private static int[] Fusion(int[] a, int[] b)
        {
            return null;
        }
    }
}
