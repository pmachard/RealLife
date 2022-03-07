using System.Collections.Generic;
using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class ShortInsertion : ISort
    {
        static public int[] Run(int[] tabSource)
        {
            return SortInsert(tabSource.Clone() as int[]);
        }

        private static int[] SortInsert(int[] tab)
        {
            int[] result = new int[tab.Length];
            int x,j;

            for (int i = 0; i < tab.Length; i++)
            {
                x = tab[i];
                j = i;

                while ((j > 0) && (tab[j - 1] > x))
                {
                    tab[j] = tab[j - 1];
                    j = j - 1;
                    tab[j] = x;
                }
            }
            return result;
        }
    }
}
