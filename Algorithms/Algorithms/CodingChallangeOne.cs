using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    //Write a program which for N elemental array finds the largest even sum of K elements. For example:
    //Array = [1, 2, 3]; K = 2; Bigest even sume = 4
    class CodingChallangeOne
    {
        public int Solution(int[] A, int K)
        {
            int sum = SumNumbers(A, new int[K], 0, 0, -1);
            return sum; 
        }

        private int SumNumbers(int[] inputNumbers, int[] numbersToSum, int indexOfNumber, int indexForNumber, int maxSum)
        {
            if (indexForNumber == numbersToSum.Length)
            {
                int sum = 0;
                for(int i = 0; i < numbersToSum.Length; i++)
                {
                    sum += numbersToSum[i];
                }
                
                return sum % 2 == 0 && sum > maxSum ? sum : maxSum;
            }

            if (indexOfNumber == inputNumbers.Length)
            {
                return maxSum;
            }

            numbersToSum[indexForNumber] = inputNumbers[indexOfNumber];
            maxSum = SumNumbers(inputNumbers, numbersToSum, indexOfNumber + 1, indexForNumber + 1, maxSum);            
            return SumNumbers(inputNumbers, numbersToSum, indexOfNumber + 1, indexForNumber, maxSum);
        }
    }
}
