using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Algorithms.CodingChallangeOne
{
    public class StandardAlgorithm : IAlgorithm
    {
        public int Solution(int[] A, int K)
        {
            A = DescendingQuickSort(A, 0, A.Length - 1);
            
            for (int i = 0; i < A.Length; i++)
            {
                int sumPart1 = 0;
                for (int j = i; j < (i + K - 1); j++)
                {
                    sumPart1 += A[j];
                }

                for (int l = K - 1; l < A.Length; l++)
                {
                    int sum = sumPart1 + A[l];

                    if (sum % 2 == 0)
                    {
                        return sum;
                    }
                }
            }
            return -1;
        }

        private int[] DescendingQuickSort(int[] dataToSort, int start, int end)
        {
            if (start >= end)
            {
                return dataToSort;
            }

            int indexOfFirstBigestNumber = start;
            for (int i = start; i <= end; i++)
            {
                if (dataToSort[i] <= dataToSort[end])
                {
                    continue;
                }

                if (indexOfFirstBigestNumber != i)
                {
                    int temp = dataToSort[i];
                    dataToSort[i] = dataToSort[indexOfFirstBigestNumber];
                    dataToSort[indexOfFirstBigestNumber] = temp;
                }
                indexOfFirstBigestNumber++;
            }

            int pivotTemp = dataToSort[end];
            dataToSort[end] = dataToSort[indexOfFirstBigestNumber];
            dataToSort[indexOfFirstBigestNumber] = pivotTemp;

            DescendingQuickSort(dataToSort, start, indexOfFirstBigestNumber - 1);
            DescendingQuickSort(dataToSort, indexOfFirstBigestNumber + 1, end);
            return dataToSort;
        }
    }
}
