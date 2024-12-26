using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數判斷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Range = 0;
                int array_size = 0;

                //Get range
                Console.WriteLine("質數搜尋範圍");
                int.TryParse(Console.ReadLine(), out Range);

                //計算 array size，宣告陣列
                array_size = ((Range % 2) == 0) ? ((Range / 2) - 1) : ((Range - 1) / 2);
                int[] Numlist = new int[array_size];

                // 計時器開始
                Stopwatch stopwatch = Stopwatch.StartNew();

                ArrayGen(Numlist);
                FindPrime(Numlist);
                PrintArray(Numlist);

                // 計時器結束
                stopwatch.Stop();
                Console.WriteLine($"\n執行時間：{stopwatch.ElapsedMilliseconds} 毫秒");
            }

        }

        #region Function
        static void ArrayGen(int[] Numlist)
        {
            //去除偶數，填入陣列
            for (int i = 1; i <= Numlist.Length; i++)
            {
                Numlist[i - 1] = 2 * i + 1;
            }
        }

        static void FindPrime(int[] Array)
        {

            //平方根法求質數之最大除數

            int devider_upper = (int)Math.Floor(Math.Sqrt(Array.Max()));
            //Console.WriteLine($"最大除數為{devider_upper}");
            //兩層迴圈分別檢查(所有除數)以及(每一個陣列元素)

            for (int i = 0; i < Array.Length; i++)
            {
                for (int devider = 2; devider <= devider_upper; devider++)
                {
                    int red = Array[i] % devider;
                    //Console.WriteLine($"這次的除數為{devider}，被除數為{Numlist[i]}");

                    if (red == 0 && (Array[i] / devider > 1))
                    {
                        //Console.WriteLine($"第{i}個數字為{Numlist[i]}非質數");
                        //Console.WriteLine($"消除第{i}個數字,{Numlist[i]}");
                        Array[i] = 0;
                    }
                }
            }
        }

        static void PrintArray(int[] Numarray)
        {
            //把例外 2 補充進去，印出陣列非0元素
            Console.WriteLine("陣列內的數為:");
            Console.WriteLine($"2");
            for (int i = 0; i < Numarray.Length; i++)
            {
                if (!(Numarray[i] == 0))
                {
                    Console.WriteLine($"{Numarray[i]}");
                }
            }
        }
        #endregion
    }
}


