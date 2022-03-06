using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class BubbleSort : ISort
    {
        public static int[] Run(int[] tabSource) 
        {
			int[] tabResult = tabSource.Clone() as int[];
			bool tabIsSort = true;

			for (int i = (tabResult.Length - 1); i >= 0; i--)
			{
				for (int j = 0; j < i; j++)
				{
					if (tabResult[j + 1] < tabResult[j])
					{
						(tabResult[j + 1], tabResult[j]) = (tabResult[j], tabResult[j + 1]);						
						tabIsSort = false;
					}
				}
				if (tabIsSort)
					return tabResult;
			}
			return tabResult; 
        }
    }
}
