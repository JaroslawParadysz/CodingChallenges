using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CodingChallangeOne
{
    public class StandardAlgorithm : IAlgorithm
    {
        public int Solution(int[] A, int K)
        {
            int indexOfSum = 0;
            int[] arrayOfSum = new int[K];
            int indexOfA = 0;

            Calc(A, indexOfA, arrayOfSum, indexOfSum);

            return 0;
        }

        private void Calc(int[] a, int indexOfA, int[] arrayOfSum, int indexOfSum)
        {
            if (indexOfSum == arrayOfSum.Length)
            {
                for (int i = 0; i < arrayOfSum.Length; i++)
                {
                    Console.WriteLine(arrayOfSum[i]);
                }
                Console.WriteLine();
                return;
            }
            arrayOfSum[indexOfSum] = a[indexOfA];
            Calc(a, indexOfA + 1, arrayOfSum, indexOfSum + 1);
        }
    }
}
