using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Net_Sort;
using System.Diagnostics;

namespace TestFramework
{
    class Program
    {
        static public byte[] descendingTest = new byte[100];
        static public byte[] randomTest = new byte[100];

        static public void initializeDescendingTest()
        {
            for (int i = 0; i < descendingTest.Length; i++)
            {
                descendingTest[i] = (byte)(100 - i);
            }
        }

        static public void initializeRandomTest()
        {
            Random rnd = new Random();

            for (int i = 0; i < randomTest.Length; i++)
            {
                randomTest[i] = (byte)rnd.Next(0, 100);
            }
        }

        static void Main(string[] args)
        {
            initializeDescendingTest();
            initializeRandomTest();

            ReadOnlyCollection<byte> descendingTestRO = new ReadOnlyCollection<byte>(descendingTest);
            ReadOnlyCollection<byte> randomTestRO = new ReadOnlyCollection<byte>(randomTest);

            byte[] testResultData = new byte[100];
            bool testResult = false;
            Stopwatch timer;

            //Bubble Sort

            Console.WriteLine("Testing Bubble Sort:\n");

            timer = Stopwatch.StartNew();
            testResultData = BubbleSort.bubbleSort(descendingTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tDescending Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);

            timer = Stopwatch.StartNew();
            testResultData = BubbleSort.bubbleSort(randomTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tRandom Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);


            //Selection Sort

            Console.WriteLine("\nTesting Selection Sort:\n");

            timer = Stopwatch.StartNew();
            testResultData = SelectionSort.selectionSort(descendingTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tDescending Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);

            timer = Stopwatch.StartNew();
            testResultData = SelectionSort.selectionSort(randomTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tRandom Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);

            
            //Insertion Sort

            Console.WriteLine("\nTesting Insertion Sort:\n");

            timer = Stopwatch.StartNew();
            testResultData = InsertionSort.insertionSort(descendingTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tDescending Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);

            timer = Stopwatch.StartNew();
            testResultData = InsertionSort.insertionSort(randomTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tRandom Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);


            //Merge Sort

            Console.WriteLine("\nTesting Merge Sort:\n");

            timer = Stopwatch.StartNew();
            testResultData = MergeSort.mergeSort(descendingTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tDescending Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);

            timer = Stopwatch.StartNew();
            testResultData = MergeSort.mergeSort(randomTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tRandom Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);

            ////////////////////////////////////////////////////////////////////////////////////
            //Tree Sort
            ///////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nTesting Tree Sort:\n");

            timer = Stopwatch.StartNew();
            testResultData = TreeSort.treeSort(descendingTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tDescending Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);

            timer = Stopwatch.StartNew();
            testResultData = TreeSort.treeSort(randomTestRO.ToArray());
            timer.Stop();
            testResult = isSortedInAscendingOrder(testResultData);

            Console.WriteLine("\tRandom Test took: " + timer.ElapsedTicks + " ticks. Sort success: " + testResult);




            Console.ReadKey();
        }

        static bool isSortedInAscendingOrder(byte[] data)
        {
            bool result = true;

            for(int i = 1; i < data.Length; i++)
            {
                if(data[i - 1] > data[i])
                {
                    result = false;
                }
            }

            return result;
        }

    }
}
