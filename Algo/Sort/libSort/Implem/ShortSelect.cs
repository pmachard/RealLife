using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class ShortSelect : ISort
    {
        static public int[] Run(int[] tabSource)
        {
            return RunShortSelect(tabSource.Clone() as int[]);
        }

        private static int[] RunShortSelect(int[] tab)
        {
            int[] result = tab.Clone() as int[];
            int n = result.Length;

            for (int i=0; i <= n - 2; i++)
            {
                int min = i;
                for (int j = i+1; j <= n - 1; j++)
                {
                    if (result[j] < result[min])
                    {
                        min = j;
                    }
                    if (min != i)
                    {
                        int aux = result[i];
                        result[i] = result[min];
                        result[min] = aux;
                    }
                 }
             }
            return result;
        }
    }
}
