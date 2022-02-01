using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestForMS
{
    class SumofEvenAndOddNumbers
    {
        static int arrayResult(int[] arr)
        {
            int sumOfOdds = 0;
            int sumOfEvens = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumOfEvens = sumOfEvens + arr[i];
                }
                else
                {
                    sumOfOdds = sumOfOdds + arr[i];
                }
            }
            return sumOfOdds-sumOfEvens;
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 4, 4 };
            Console.WriteLine("Result:" + arrayResult(arr).ToString());

        }
    }
}
