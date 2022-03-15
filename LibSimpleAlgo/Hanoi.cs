using System;
using System.Collections.Generic;

namespace Utopia.Algo.Simple
{
    public class Hanoi
    {
        /*
         * int  ndisque
         * char source
         * char intermediaire
         * char destination
        */
        public static List<string> RunRecursive(int ndisque, char source, char intermediaire, char destination)
        {
            List<string> lResult = new List<string>();
            if (ndisque == 1)
            {
                lResult.Add(source + ">" + destination);
            }
            else
            {
                lResult.AddRange(RunRecursive(ndisque - 1, source, destination, intermediaire));
                lResult.AddRange(RunRecursive(1, source, intermediaire, destination));
                lResult.AddRange(RunRecursive(ndisque - 1, intermediaire, source, destination));
            }
            return lResult;
        }
    }
}


