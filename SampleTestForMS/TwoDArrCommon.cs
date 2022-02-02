using System;
using System.Collections.Generic;

namespace SampleTestForMS
{

    class TwoDArrCommon
    {

        static int[] commonRes(int[] arr1,int[] arr2)
        {
            List<int> numberList = new List<int>();
            if (arr1.Length > 0 && arr2.Length > 0)
            {
                for(int i = 0; i < arr1.Length; i++)
                {
                    for(int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            numberList.Add(arr1[i]);
                        }
                    }
                }

            }
            return numberList.ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 8, 3, 2 };
            int[] arr2 = { 4, 2, 6, 1 };
            int[] res = commonRes(arr1, arr2);
            for(int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + ",");
            }
        }
    }
}
