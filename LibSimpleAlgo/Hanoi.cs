using System;
using System.Collections.Generic;

namespace Utopia.Algo.Simple
{
    public class Hanoi
    {
        /*
        n: number of disks used
        D: Starting location
        A: arrival location
        I: intermediate location
        */
        public static List<string> Run(int n, char D, char A, char I)
        {
            List<string> result = new List<string>();
            if (n == 1)
                result.Add(D + " to "+ A);
            else
                result.AddRange(Run(n - 1, D, I, A));
            return result;
        }
    }
}

