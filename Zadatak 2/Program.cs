using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] testArray = {1.5,8.9,6.4,7.5,8.13,1.45,6.78,4.35,9.654,1.123,8.35};

            NumberSequence sequence = new NumberSequence(testArray);
            
            Console.WriteLine("Before sorting:");
            Console.WriteLine(sequence.ToString());

            SortStrategy bubbleSort = new BubbleSort();
            sequence.SetSortStrategy(bubbleSort);
            sequence.Sort();
            
            ISearchStrategy searchStrategy = new BinarySearch();
            sequence.SetSearchStrategy(searchStrategy);
            
            Console.WriteLine(sequence.Search(6.78) ? "Your number is in sequence!":"Your number is not in sequence!");
            
        }
    }
}
