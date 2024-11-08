using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProj
{
    internal class Sort
    {
        static void Main()
        {
            int[] a = { 2, 3, 7, 8 };
            int[] b = { 0, 1, 9, 10 };
            int[] c = new int[8];
            MergeArray(a, b, c);
        }

        static void MergeArray(int[] a, int[] b, int[] c)
        {
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }
            while (i < a.Length)
            {
                c[k++] = a[i++];
            }
            while (j < b.Length)
            {
                c[k++] = b[j++];
            }
            for (int l = 0; l < c.Length; l++)
            {
                Console.WriteLine(c[l]);
            }
        }
    }
}
