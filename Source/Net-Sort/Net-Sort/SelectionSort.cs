using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class SelectionSort
    {
        public static byte[] selectionSort(byte[] data)
        {
            byte c = 0;
            bool swapNeeded = false;
            
            for(int i = 0; i < data.Length; i++)
            {
                int closestValue = data[i];
                int closestIndex = i;

                for(int j = (i + 1); j < data.Length; j++)
                {
                    if(data[j] < closestValue)
                    {
                        closestValue = data[j];
                        closestIndex = j;
                        swapNeeded = true;
                    }
                }

                if (swapNeeded)
                {
                    c = data[i];
                    data[i] = data[closestIndex];
                    data[closestIndex] = c;
                }

                swapNeeded = false;
            }
            

            return data;
        }

    }
}
