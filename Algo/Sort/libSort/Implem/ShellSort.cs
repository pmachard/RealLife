using System.Collections.Generic;
using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class ShellSort : ISort
    {
        static public int[] Run(int[] tabSource)
        {
            int firstCurent, secondCurrent, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (firstCurent = 0; firstCurent < tabSource.Length; firstCurent++)
                {
                    secondCurrent = firstCurent;
                    temp = tabSource[firstCurent];
                    while ((secondCurrent >= inc) && (tabSource[secondCurrent - inc] > temp))
                    {
                        tabSource[secondCurrent] = tabSource[secondCurrent - inc];
                        secondCurrent = secondCurrent - inc;
                    }
                    tabSource[secondCurrent] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
            return tabSource;
        }
    }
}
