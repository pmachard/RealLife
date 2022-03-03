using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class BubbleSort : ISort
    {
        public static int[] Run(int[] tabSource) 
        {
			int[] tab = tabSource.Clone() as int[];
			bool tableauTrie = true;

			for (int i = (tab.Length - 1); i > 1; i--)
			{
				for (int j = 0; j < i - 1; j++)
				{
					if (tab[j + 1] < tab[j])
					{
						(tab[j + 1], tab[j]) = (tab[j], tab[j + 1]);						
						tableauTrie = false;
					}
				}
				if (tableauTrie)
					return tab;
			}
			return tab; 
        }
    }
}
