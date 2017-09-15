using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class GnomeSort
    {

        public static byte[] gnomeSort(byte[] data)
        {
            byte c = 0;

            for (int i = 0; i < data.Length;)
            {
                if ((i == 0) || (data[i]) >= data[i - 1])
                {
                    i++;
                }
                else
                {
                    c = data[i];
                    data[i] = data[i - 1];
                    data[i - 1] = c;
                    i--;
                }
            }

            return data;
        }

    }
}
