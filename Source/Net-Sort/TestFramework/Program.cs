using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
