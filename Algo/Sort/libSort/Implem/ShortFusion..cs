using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class ShortFusion : ISort
    {
        public static int[] Run(int[] tab)
        {
            int[] tabSort = tab.Clone() as int[];
            return RunFusion(tabSort);
        }

        private static int[] RunFusion(int[] arr)
        {
            return RunFusionTab(arr, 0, arr.Length);
        }

        private static int[] RunFusionTab(int[] tab, int start, int end)
        {
            int[] result = new int[tab.Length];
            if (tab.Length > 1)
            {
                int[] tabA = new int[tab.Length / 2];
                // tabA = tab[1, tab.Length / 2];

                for (int i = 0; i < tabA.Length; i++)
                {
                    // tabA+=;
                }
                // return FusionTab(, FusionTab(tab[n / 2 + 1, tab.Length]);
            }

            return tab;
        }

        private static int[] FusionTab(int[] A, int[] B)
        {
            return null;
        }
        /*
        fonction fusion(A[1, …, a], B[1, …, b])
      si A est le tableau vide
              renvoyer B
      si B est le tableau vide
              renvoyer A
      si A[1] ≤ B[1]
              renvoyer A[1] ⊕ fusion(A[2, …, a], B)
      sinon
              renvoyer B[1] ⊕ fusion(A, B[2, …, b])
        */
    }
 }
