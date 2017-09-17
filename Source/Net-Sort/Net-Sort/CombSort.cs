using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class CombSort
    {

        public static byte[] combSort(byte[] data)
        {
            int combWidth = 19;
            byte c = 0;

            while(combWidth > 0)
            {
                int i = 0;
                while ((i + combWidth) < data.Length)
                {
                    if(data[i] > data[i + combWidth])
                    {
                        c = data[i];
                        data[i] = data[i + combWidth];
                        data[i + combWidth] = c;
                    }
                    i++;
                }
                combWidth--;
            }

            return data;
        }

    }
}
