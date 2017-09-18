using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class CocktailSort
    {

        public static byte[] cocktailSort(byte[] data)
        {
            byte c = 0;
            int beginning = 0;
            int end = data.Length - 1;

            for (int i = 0; i < data.Length / 2; i++)
            {
                for (int j = 0; (beginning + j) < end; j++)
                {
                    if (data[(beginning + j)] > data[(beginning + j) + 1])
                    {
                        c = data[(beginning + j)];
                        data[(beginning + j)] = data[(beginning + j) + 1];
                        data[(beginning + j) + 1] = c;
                    }
                }
                end--;

                for (int j = 0; (end + j) > beginning; j--)
                {
                    if (data[(end + j)] < data[(end + j) - 1])
                    {
                        c = data[(end + j)];
                        data[(end + j)] = data[(end + j) - 1];
                        data[(end + j) - 1] = c;
                    }
                }
                beginning++;
            }

            return data;
        }

    }
}
