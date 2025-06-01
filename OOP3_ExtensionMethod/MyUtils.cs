using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_ExtensionMethod
{
    public static class MyUtils
    {
        public static int tongTu1ToiN(this int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        /// <summary>
        /// Ham de tinh tong 2 so nguyen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int cong(this int a, int b)
        {
            return a + b;
        }

        public static void taoMang(this int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
            }
        }
        public static void xuatMang(this int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + "\t");
            }
            Console.WriteLine();
        }

        public static void sapXepMangTangDan(this int[] arr)
        {
            for (int i = 0;i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        public static int[] sapXepMangGiamDan(this int[] arr)
        {
            return arr.OrderByDescending(x => x).ToArray();
        }

    }
}
