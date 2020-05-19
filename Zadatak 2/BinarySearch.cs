using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class BinarySearch : ISearchStrategy
    {
        public bool Search(double[] array, double numToFind)
        {
            int arraySize = array.Length;

            int upperBound = arraySize - 1;
            int lowerBound = 0;
            int s = (upperBound - lowerBound) / 2;

            while(lowerBound <= upperBound)
            {
                if (array[s] == numToFind) return true;
                else if (array[s] < numToFind) { upperBound = s - 1; }
                else if(array[s] > numToFind) { lowerBound = s + 1; }
                s = (upperBound - lowerBound) / 2;
            }
            return false;
        }
    }
}
