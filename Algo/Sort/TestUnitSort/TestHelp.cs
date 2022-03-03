using System;
using System.Collections.Generic;
using System.Text;

namespace Utopia.Algo.Sort.TestUnit
{
    class TestHelp
    {
        static public bool IsSorted(int[] tabToCheck,int tabSize)
        {

            if (tabToCheck.Length != tabSize)
                return false;

            if (tabToCheck.Length > 1)
            {
                int last = 0;
                foreach (int current in tabToCheck)
                {
                    if (last > current)
                        return false;
                    last = current;
                }
            }
            return true;
        }
    }
}
