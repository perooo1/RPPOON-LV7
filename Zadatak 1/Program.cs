using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            double[] testArray = new double[10];

            for(int i = 0; i < 10; i++)
                testArray[i] = generator.NextDouble()*88;

            NumberSequence sequence = new NumberSequence(testArray);

            Console.WriteLine("Before sorting:");
            Console.WriteLine(sequence.ToString());
            
            SortStrategy bubbleSort = new BubbleSort();
            sequence.SetSortStrategy(bubbleSort);

            sequence.Sort(); 
            Console.WriteLine("After Bubble Sort:");
            Console.WriteLine(sequence.ToString());

            SortStrategy sequentialSort = new SequentialSort();
            sequence.SetSortStrategy(sequentialSort);

            sequence.Sort();
            Console.WriteLine("After Sequential Sort:");
            Console.WriteLine(sequence.ToString());

            SortStrategy combSort= new CombSort();
            sequence.SetSortStrategy(combSort);

            sequence.Sort();
            Console.WriteLine("After Comb Sort:");
            Console.WriteLine(sequence.ToString());
        }
    }
}
