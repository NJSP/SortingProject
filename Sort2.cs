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
            int[] arr = { 2, 1, 5, 4 };
            Print(arr);
            int[] a = { 1, 3, 5, 7 };
            int[] b = { 2, 4, 6, 8 };
            int[] c = new int[a.Length + b.Length];
            Merge(a, b, c);
            Print(c);
        }

        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Merge(int[] a, int[] b, int[] c)
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
        }
    }

