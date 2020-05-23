using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnaApp
{
    class Result
    {
        public static int minSum(List<int> num, int k)
        {
            var arr = num.ToArray();
            int length = num.Count;
            int index;
            try
            {
                if ((num.Count >= 1 && num.Count <= Math.Pow(10, 5)) && (k >= 1 && k <= Math.Pow(10, 7)))
                {
                    for (int i = 1; i <= k; i++)
                    {
                        index = i;
                        if (index > length)
                        {
                            index = 1;
                        }
                        if (i >= k)
                        {
                            index = Array.IndexOf(arr, arr.Max());
                            Console.WriteLine(index + "max");
                            GetMinSum(ref num, index);
                        }
                        else
                        {
                            GetMinSum(ref num, length - index);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid data.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            int sum = 0;
            for (int i = 0; i < num.Count; i++)
            {
                sum += num[i];
            }
            return sum;
        }

        private static void GetMinSum(ref List<int> num, int index)
        {
            Console.WriteLine("Element to remove" + num[index]);
            int ceiling = (int)Math.Ceiling((double)num[index] / 2);
            num.Remove(num[index]);
            Console.WriteLine("After removal");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After adding ceiling");
            num.Insert(index, ceiling);
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }

    }
}
