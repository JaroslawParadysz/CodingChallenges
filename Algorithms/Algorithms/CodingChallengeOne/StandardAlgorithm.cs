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
            A = QuickSort(A, 0, A.Length - 1);

            return -1;
        }

        private int[] QuickSort(int[] dataToSort, int start, int end)
        {
            if (start >= end)
            {
                return dataToSort;
            }

            int indexOfFirstBigestNumber = start;
            for (int i = start; i <= end; i++)
            {
                if (dataToSort[i] >= dataToSort[end])
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

            QuickSort(dataToSort, start, indexOfFirstBigestNumber - 1);
            QuickSort(dataToSort, indexOfFirstBigestNumber + 1, end);
            return dataToSort;
        }
    }
}
