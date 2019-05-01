using System;

namespace MaximumIndex_J_I_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum index (j-i) in the array where element at j is greater than that at i!");
            Console.WriteLine("--------------------------------------------------------------------");

            int[] array = ArrayUtility.GetArrayFromUser();
            Console.WriteLine("Maximum index [j-i] in the array is "+
                ArrayUtility.GetMaximumIndexInArray(array));

            Console.ReadLine();
        }
    }
}
