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

        void initializeDescendingTest()
        {
            for (int i = 0; i < descendingTest.Length; i++)
            {
                descendingTest[i] = (byte)(100 - i);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
