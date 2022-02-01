using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestForMS
{
    class CharArrayTest
    {
        static string checkArray(string[] arr,int startIndex,int endIndex)
        {
            if (arr.Length > 0)
            {
                if (startIndex > 0 && endIndex>0 && endIndex < arr.Length)
                {
                    string[] newArr = new ArraySegment<string>(arr, startIndex, endIndex).ToArray();
                    string res = "";
                    for(int i = 0; i < newArr.Length; i++)
                    {
                        res += "," + newArr[i];
                    }
                    return res;
                }
                else
                {
                    return "null";
                }
            }
            return "{}";
        }

        static void Main(string[] args)
        {
            string[] arr = { "ab", "bb", "cb" };
            Console.WriteLine(checkArray(arr, 1, 3));
        }
    }
}
