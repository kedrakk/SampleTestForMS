using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestForMS
{
    class CenteredArrayTest
    {

        static int checkArray(int[] arr)
        {
            if (arr.Length % 2 == 0) return 0;
            else
            {
                int middleIndex = arr.Length / 2;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != middleIndex && arr[i] > arr[middleIndex])
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the length of your array:");
            int length = int.Parse(Console.ReadLine().ToString());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number " + (i + 1) + " :");
                arr[i] = int.Parse(Console.ReadLine().ToString());
            }
            Console.WriteLine("");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            int res = CenteredArrayTest.checkArray(arr);
            Console.Write("\n" + res.ToString());
        }

    }
}
