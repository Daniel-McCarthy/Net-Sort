using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class OddEvenSort
    {

        public static byte[] oddEvenSort(byte[] data)
        {
            byte c = 0;

            for (int i = 0; i < data.Length; i++)
            {
                int j = ((i % 2) == 0) ? 2 : 1;

                while(j < data.Length)
                {
                    if (data[j] < data[j - 1])
                    {
                        c = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = c;
                    }

                    j += 2;
                }
            }

            return data;
        }

    } 
}
