using NUnit.Framework;
using Utopia.Algo.KeyWordCompletion.Interface;
using Utopia.Algo.KeyWordCompletion.Implem;
using Utopia.Algo.KeyWordsCompletion.UnitTest.Mock;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest
{
    public class TestUnitKeySetWordsCompare
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCompareConst()
        {
            var listOfKey = new List<string>()
                {
                    "abcd",
                    "ABCD",
                    "abzz",
                    "azzz",
                    "zzzz",
                };
            
            IKeyWordSet wordSet = new KeyWordSet<MockCompareKeyAll00>(listOfKey);

            wordSet.Keys = listOfKey;            
            Assert.AreEqual(100, wordSet.Compare("abc"));
        }
    }
}

/*
 
 using System;

namespace Algorithms
{
    public static class LevenshteinDistance
    {
        /// <summary>
        ///     Calculate the difference between 2 strings using the Levenshtein distance algorithm
        /// </summary>
        /// <param name="source1">First string</param>
        /// <param name="source2">Second string</param>
        /// <returns></returns>
        public static int Calculate(string source1, string source2) //O(n*m)
        {
            var source1Length = source1.Length;
            var source2Length = source2.Length;

            var matrix = new int[source1Length + 1, source2Length + 1];

            // First calculation, if one entry is empty return full length
            if (source1Length == 0)
                return source2Length;

            if (source2Length == 0)
                return source1Length;

            // Initialization of matrix with row size source1Length and columns size source2Length
            for (var i = 0; i <= source1Length; matrix[i, 0] = i++){}
            for (var j = 0; j <= source2Length; matrix[0, j] = j++){}

            // Calculate rows and collumns distances
            for (var i = 1; i <= source1Length; i++)
            {
                for (var j = 1; j <= source2Length; j++)
                {
                    var cost = (source2[j - 1] == source1[i - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                        matrix[i - 1, j - 1] + cost);
                }
            }
            // return result
            return matrix[source1Length, source2Length];
        }
    }
}
 
 */