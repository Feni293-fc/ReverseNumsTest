using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNums
{
    public class Rotate
    {
        public static void Right(int[] arr, int start)
        {
            if (arr == null || arr.Length == 0)
                return;

            int end = arr.Length;
            start %= end;

            if (start == 0)
                return;

            ReverseNums(arr, 0, end - 1);
            ReverseNums(arr, 0, start - 1);
            ReverseNums(arr, start, end - 1);
        }

        public static void ReverseNums(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
