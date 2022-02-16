using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNullHW.Extensions
{
    static class ExtensionMethods
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static int[] GetValueIndexies(this int[] arr,int num)
        {
            int[] result = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = i;
                }
            }

            return result;
        }
    }
}
