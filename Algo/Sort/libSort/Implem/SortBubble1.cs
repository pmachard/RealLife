using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class QuickSort : ISort
    {
        public static int[] Run(int[] tab)
        {
            int[] tabSort = tab.Clone() as int[];
            RunQuickSort(tabSort, 0, tabSort.Length);
            return tabSort;
        }


        private static void RunQuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                RunQuickSort(arr, start, i - 1);
                RunQuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
}
