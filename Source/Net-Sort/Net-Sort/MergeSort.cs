using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Sort
{
    public static class MergeSort
    {

        public static byte[] mergeSort(byte[] data)
        {
            byte c = 0;

            //Divide data into single index arrays
            byte[][] arrays = new byte[data.Length][];

            for (int i = 0; i < arrays.Length; i++)
            {
                byte[] newArray = { data[i] };
                arrays[i] = newArray;
            }

            bool finished = false;

            //Merge down until sorted into single array
            while(arrays.Length > 1 && !finished)
            {
                
                //Ensure arrays are even (pad if not)
                int newArrayLength = arrays.Length / 2;
                bool isDataEven = (newArrayLength % 2) == 0;
                byte[][] newArrays = new byte[newArrayLength + ((isDataEven) ? 0 : 1)][];
                byte[] paddingArray = new byte[0];
                if(!isDataEven)
                {
                    newArrays[newArrays.Length - 1] = paddingArray;
                }


                //Merge arrays
                for (int i = 0; i < arrays.Length; i += 2)
                {
                    byte[] newArray = new byte[arrays[i].Length + arrays[i + 1].Length];
                    byte smallestValue = 0;
                    int smallestValueIndex = 0;
                    int smallestValueArray = 0;

                    //Fill new array with merged values
                    for(int j = 0; j < newArray.Length; j++)
                    {
                        //Set first value of first array to comparison value
                        smallestValue = arrays[i][0];
                        smallestValueArray = 0;
                        smallestValueIndex = 0;

                        //Search for smallest value in two arrays
                        for(int k = 1; k < arrays[i].Length; k++)
                        {
                            if(arrays[i][k] < smallestValue)
                            {
                                smallestValue = arrays[i][k];
                                smallestValueArray = 0;
                                smallestValueIndex = k;
                            }
                        }

                        for (int k = 0; k < arrays[i + 1].Length; k++)
                        {
                            if (arrays[i + 1][k] < smallestValue)
                            {
                                smallestValue = arrays[i + 1][k];
                                smallestValueArray = 1;
                                smallestValueIndex = k;
                            }
                        }

                        newArray[j] = smallestValue;

                        //Set chosen index to max value
                        //So that it is not chosen again
                        //unless the last value is max value
                        arrays[i + smallestValueArray][smallestValueIndex] = byte.MaxValue;

                    }

                    newArrays[i/2] = newArray;
                }

                arrays = newArrays;

                //Check if only one array index has entries
                if((newArrays.Length == 2) && (newArrays[1].Length == 0))
                {
                    finished = true;
                }
            }

            data = arrays[0];

            return data;
        }

    }
}
