using System.Runtime.InteropServices;

namespace SortingProj
{
    internal class Program
    {
        static void InsertionSort(string[] args)
        {
            int[] arr = { 4, 5, 1, 3, 2, 6, 0, 8 };
            int curr, i, j;
            for (i = 1; i < arr.Length; i++)
            {
                curr = arr[i];
                for (j = i - 1; j >= 0 && arr[j] > curr; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = curr;
            }
        }
            static void OldMain(string[] args) {
            int[] a = { 2, 3, 7, 8, 11, 20, 55 };
            int[] b = { 0, 1, 9, 10, 13 };
            int[] x = [];
            int[] c = Sort.MergeArray(x);

            foreach (int value in c)
            {
                Console.WriteLine(value);
            }
        }
    }
}
