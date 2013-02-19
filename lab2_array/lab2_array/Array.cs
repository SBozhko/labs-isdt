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
        public enum Order { FIRST, LAST }

        public Array()
        {
            arraySize = 10;
            array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
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
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = new Random().Next();
            }
        }

        public long GetEvenIndexItemsProduction()
        {
            long result = 1;
            for (int i = 0; i < arraySize; i += 2)
            {
                result *= array[i];
            }
            return result;
        }

        public int GetSumBetweenFirstAndLastZeros()
        {
            return GetItemsSumBetweenIndexes(GetItemIndex(0, Order.FIRST), GetItemIndex(0, Order.LAST));
        }

        private int GetItemIndex(int item, Order order)
        {
            switch (order)
            {
                case Order.FIRST:
                    for (int i = 0; i < arraySize; i++)
                    {
                        if (array[i] == item)
                        {
                            return i;
                        }
                    }
                    break;
                case Order.LAST:
                    for (int i = arraySize - 1; i >= 0; i--)
                    {
                        if (array[i] == item)
                        {
                            return i;
                        }
                    }
                    break;
            }
            return -1;
        }

        private int GetItemsSumBetweenIndexes(int firstIndex, int lastIndex)
        {
            if (firstIndex > lastIndex)
            {
                throw new IllegalArgumentException("First index > last index");
            }

            if (firstIndex < 0 || lastIndex < 0)
            {
                throw new IllegalArgumentException("Check array indexes. One/both of them < 0");
            }

            int result = 0;
            for (int i = firstIndex + 1; i < lastIndex; i++)
            {
                result += array[i];
            }

            return result;
        }

        public void Transform()
        {
            int[] transformedArray = new int[arraySize];
            int j = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] >= 0)
                {
                    transformedArray[j++] = array[i];
                }
            }

            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] < 0)
                {
                    transformedArray[j++] = array[i];
                }
            }
            array = transformedArray;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[");
            for (int i = 0; i < arraySize; i++)
            {
                sb.Append(array[i]);
                if (i != arraySize - 1)
                {
                    sb.Append(", ");
                }
            }
            return sb.Append("]").ToString();
        }

    }
}
