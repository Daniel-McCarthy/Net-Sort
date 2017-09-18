using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class ShellSort
    {

        public static byte[] shellSort(byte[] data)
        {
            byte c = 0;
            int gap = data.Length / 2;

            while(gap > 0)
            {
                for(int i = 0; (i + gap) < data.Length; i++)
                {
                    int j = (gap + i);
                    c = data[(gap + i)];

                    while (j >= gap && c < data[j - gap])
                    {
                        data[j] = data[j - gap];
                        j -= gap;
                    }

                    data[j] = c;
                }

                gap /= 2;
            }

            return data;
        }

    }
}
