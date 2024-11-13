using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProj
{
    internal class Sort
    {

        public static int[] MergeArray(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
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

            return c;
        }

        public static int[] MergeArray(int[] x)
        {
            if (x.Length == 1)
                return x;

            int mid = x.Length / 2;

            int[] p = new int[mid];
            for (int i = 0; i < mid; i++)
                p[i] = x[i];

            int[] q = new int[x.Length - mid];
            for (int i = mid; i < x.Length; i++)
                q[i - mid] = x[i];

            p = MergeArray(p);
            q = MergeArray(q);

            return MergeArray(p, q);
        }
    }
}
