using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class BubbleSort
    {

        public static byte[] bubbleSort(byte[] data)
        {
            byte c = 0;

            bool hasSwapped = true;

            while (hasSwapped)
            {
                hasSwapped = false;

                for (int i = 1; i < data.Length; i++)
                {

                    if (data[i - 1] > data[i])
                    {
                        //Swap current entry with previous entry

                        c = data[i - 1];        //c = a
                        data[i - 1] = data[i];  //a = b
                        data[i] = c;            //b = c

                        hasSwapped = true;
                    }
                }
            }

            return data;
        }

    }
}
