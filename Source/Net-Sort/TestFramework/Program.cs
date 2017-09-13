using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    class Program
    {
        byte[] descendingTest = new byte[100];
        byte[] randomTest = new byte[100];

        void initializeDescendingTest()
        {
            for (int i = 0; i < descendingTest.Length; i++)
            {
                descendingTest[i] = (byte)(100 - i);
            }
        }

        void initializeRandomTest()
        {
            for (int i = 0; i < randomTest.Length; i++)
            {
                Random rnd = new Random();
                randomTest[i] = (byte)rnd.Next(0, 100);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
