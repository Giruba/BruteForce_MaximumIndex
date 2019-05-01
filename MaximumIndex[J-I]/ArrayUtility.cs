
using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumIndex_J_I_
{
    public static class ArrayUtility
    {
        public static int[] GetArrayFromUser() {
            int[] array = null;
            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int numberOfElements = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter the elements of the array separated by " +
                    "space, comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ', ',', ';');
                array = new int[numberOfElements];
                for (int index = 0; index < numberOfElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return array;

        }

        public static int GetMaximumIndexInArray(int[] array) {
            int arrayLength = array.Length;
            int index = int.MinValue;
            int minIndex = int.MaxValue;
            int maxIndex = int.MinValue;

            for (int arrayIndex = 0; arrayIndex < arrayLength; arrayIndex++) {
                for(int comparingIndex = arrayIndex+1; comparingIndex < arrayLength; comparingIndex++)
                if (array[comparingIndex] > array[arrayIndex] &&
                        (comparingIndex - arrayIndex) > index) {
                    index = comparingIndex - arrayIndex;
                    minIndex = arrayIndex;
                    maxIndex = comparingIndex;
                }
            }
            Console.WriteLine("Min Element index is " + minIndex +
                " and Max Element index is " + maxIndex);
            return (maxIndex-minIndex);
        }
    }
}
