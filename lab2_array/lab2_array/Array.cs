using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_array
{
    class Array
    {
        private int[] array;
        private readonly int arraySize;

        public Array()
        {
            arraySize = 10;
            array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
            }
        }

        public Array(int[] initArray)
        {
            array = initArray;
            arraySize = initArray.Length;
        }

        public Array(int arraySize)
        {
            this.arraySize = arraySize;
            array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
            }
        }

        public long getEvenArrayIndexesProduction()
        {
            long result = 1;
            for (int i = 0; i < array.Length; i += 2)
            {
                result *= array[i];
            }
            return result;
        }

        public int getSumBeteenZeros()
        {
            return getItemsSumBeteenIndexes(getFirstZeroItemIndex(), getLastZeroItemIndex());
        }

        private int getFirstZeroItemIndex()
        {
            int firstZeroIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    return i;
                }
            }
            return firstZeroIndex;
        }

        private int getLastZeroItemIndex()
        {
            int lastZeroIndex = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 0)
                {
                    return i;
                }
            }
            return lastZeroIndex;
        }

        private int getItemsSumBeteenIndexes(int firstindex, int lastIndex)
        {
            if (firstindex > lastIndex)
            {
                throw new IllegalArgumentException("First index > last index");
            }

            if (firstindex < 0 || lastIndex < 0)
            {
                throw new IllegalArgumentException("Check array indexes. One/both of them < 0");
            }

            int result = 0;
            for (int i = firstindex + 1; i < lastIndex; i++)
            {
                result += array[i];
            }

            return result;
        }



    }
}
