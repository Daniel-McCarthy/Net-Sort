using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class InsertionSort
    {

        public static byte[] insertionSort(byte[] data)
        {
            byte c = 0;

            for(int i = 1; i < data.Length; i++)
            {
                bool swapNeeded = data[i] < data[i-1];

                int j = i;
                while(swapNeeded)
                {
                    
                    c = data[j - 1];
                    data[j - 1] = data[j];
                    data[j] = c;

                    j--;

                    if (j > 0)
                    {
                        swapNeeded = data[j] < data[j - 1];
                    }
                    else
                    {
                        swapNeeded = false;
                    }
                }
            }

            return data;
        }

    }
}
