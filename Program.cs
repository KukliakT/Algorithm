using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{

    static class AlgorithmTask
    {
        public static int Func178b()
        {
            int[] arr = { 1, 2, 6, 5, 3, 8, 0, 9, 1, 30, 0 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 5 != 0)
                {
                    count += 1;
                }
            }
            return count;
        }

        public static int Func178v()
        {
            int[] arr = { 1, 36, 8, 5, 25, 16, 11, 4, 64, 32, 88 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Math.Sqrt(arr[i]);
                if (a % 2 == 0)
                {
                    count += 1;
                }
            }
            return count;
        }

        public static List<int> Func554()
        {
            List<int> Result = new List<int>();
            int n = 122;
            int a, b, c;
            for(a = 1; a < n; a++)
            {
                for(b = a; b < n; b++)
                {
                    c = ((a * a) + (b * b));

                    //fraction remainder
                    double d = Math.Sqrt(c);
                    int l = (int)d;
                    double remainder = d - l;
                    //

                    if (remainder == 0 && d < n)
                    {
                        Result.Add(a);
                        Result.Add(b);
                        Result.Add(Convert.ToInt32(Math.Sqrt(c)));
                    }
                }
            }

            return Result;
        }

        }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(36.001 % 2);
           // Console.WriteLine("Func178b: " + AlgorithmTask.Func178b());
           // Console.WriteLine("Func178v: " + AlgorithmTask.Func178v());
            
            // AlgorithmTask.Func554();
            Console.WriteLine("Func554: ");
            int time = 0;
            foreach(int i in AlgorithmTask.Func554())
            {
                Console.Write(i + " ");
                time += 1;
                if(time % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
