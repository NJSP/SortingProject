using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProj
{
    internal class Sort2
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 5, 40 };
            int[] arr2 = { 3, 4, 15, 7, -25 };
            int[] a = { 1, 3, 5, 8, 9 };
            int[] b = { 2, 4, 6, 7 };
            int[] c = new int[a.Length + b.Length];
            MergeSort(arr);
            Print(arr);
            //MergeSort(0, arr2.Length-1, arr2);
            Print(arr2);
            MergeSort2(arr2);
            Print(arr2);
        }

        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int[] a = new int[arr.Length / 2];
                int[] b = new int[arr.Length - a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = arr[i];
                }
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = arr[i + a.Length];
                }
                MergeSort(a);
                MergeSort(b);
                Merge(a, b, arr);
            }
        }

        public static void MergeSort(int left, int right, int[] arr)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(left, mid, arr);
                MergeSort(mid + 1, right, arr);

                Merge(arr, left, mid, right);
            }
        }

        public static void MergeSort2(int[] arr)
        {
            MergeSort(0, arr.Length-1, arr);
        }
        public static void Merge(int[] a, int[] b, int[] c)
        {
            int i = 0; int j = 0; int k = 0;

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
        }

        public static void Merge(int[] c, int left, int mid, int right)
        {
            int[] m = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (c[i] < c[j])
                {
                    m[k++] = c[i++];
                }
                else
                {
                    m[k++] = c[j++];
                }
            }
            while (i <= mid)
            {
                m[k++] = c[i++];
            }
            while (j <= right)
            {
                m[k++] = c[j++];
            }
            for (int l = 0; l < m.Length; l++)
            {
                c[left + l] = m[l];
            }
        }
    }
}

