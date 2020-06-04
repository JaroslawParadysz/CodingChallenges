using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    //Write a program which for N elemental array finds the largest even sum of K elements. For example:
    //Array = [1, 2, 3]; K = 2; Bigest even sume = 4
    class CodingChallangeOne
    {
        public void Solution(int[] A, int K)
        {
            SumNumbers(A, new int[K], 0, 0);
        }

        private void SumNumbers(int[] inputNumbers, int[] numbersToSume, int indexOfNumber, int indexForNumber)
        {
            if (indexForNumber == numbersToSume.Length)
            {
                //Sum
                return;
            }

            if (indexOfNumber == inputNumbers.Length)
            {
                return;
            }

            SumNumbers(inputNumbers, numbersToSume, indexOfNumber + 1, indexForNumber + 1);
            SumNumbers(inputNumbers, numbersToSume, indexOfNumber + 1, indexForNumber);
        }
    }
}
