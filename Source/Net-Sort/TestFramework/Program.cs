using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            byte[] testResultData = new byte[100];
            bool testResult = false;
            Stopwatch timer;

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
