using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class BucketSort
    {

        public static byte[] bucketSort(byte[] data)
        {

            List<byte>[] buckets = new List<byte>[17];
            for(int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<byte>();
            }


            for(int i = 0; i < data.Length; i++)
            {
                buckets[data[i] / 16].Add(data[i]);
            }

            int index = 0;
            for(int i = 0; i < buckets.Length; i++)
            {
                buckets[i].Sort();

                for(int j = 0; j < buckets[i].Count; j++)
                {
                    data[index++] = buckets[i][j];
                }
            }

            return data;
        }

    }
}
