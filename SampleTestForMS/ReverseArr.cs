using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTestForMS
{
    class ReverseArr
    {
        static int reverseResult(int num)
        {
            if (num.ToString().Length > 1)
            {
                String res = "";
                if (num < 0)
                {
                    res = "-";
                    num = Math.Abs(num);
                }
                for (int i = num.ToString().Length; i >= 1; i--)
                {
                    res += num.ToString()[i-1];
                }
                return int.Parse(res);
            }
            return num;
        }

        static void Main(string[] args)
        {
            int num = -12345;
            Console.WriteLine("Result:" + reverseResult(num).ToString());
        }
    }
}
