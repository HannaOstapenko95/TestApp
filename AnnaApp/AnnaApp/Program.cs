using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AnnaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(), true);
            Console.WriteLine("Enter Number of elements:");
            int numCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> num = new List<int>();
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < numCount; i++)
            {
                int numItem = Convert.ToInt32(Console.ReadLine().Trim());
                num.Add(numItem);
            }
            Console.WriteLine("Enter K (number of iterations)");
            int k = Convert.ToInt32(Console.ReadLine().Trim());
            int result = Result.minSum(num, k);
            //  textWriter.WriteLine(result);
            Console.WriteLine("Result (sum) =" + result);
            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadKey();
        }
    }
}
