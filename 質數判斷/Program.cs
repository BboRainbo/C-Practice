using System;
using System.Collections.Generic;
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
                int upper_bound = 0;
                int array_size = 0;

                //Get range
                Console.WriteLine("質數搜尋範圍");
                int.TryParse(Console.ReadLine(), out upper_bound);

                //計算 array size
                if ((upper_bound % 2) == 0) { array_size = (upper_bound / 2) - 1; }
                else { array_size = (upper_bound - 1) / 2; }
                int[] Numlist = new int[array_size];

                //去除偶數，填入陣列
                for (int i = 1; i <= array_size; i++)
                {
                    Numlist[i - 1] = 2 * i + 1;
                }

                //平方根法求質數之最大除數
                int devider_upper = (int)Math.Floor(Math.Sqrt(upper_bound));
                //Console.WriteLine($"最大除數為{devider_upper}");

                //兩層迴圈分別檢查(所有除數)以及(每一個陣列元素)
                for (int i = 0; i < array_size; i++)
                {
                    for (int devider = 2; devider <= devider_upper; devider++)
                    {
                        int red = Numlist[i] % devider;
                        //Console.WriteLine($"這次的除數為{devider}，被除數為{Numlist[i]}");
                        if (red == 0 && (Numlist[i] / devider > 1))
                        {
                            //Console.WriteLine($"第{i}個數字為{Numlist[i]}非質數");
                            //Console.WriteLine($"消除第{i}個數字,{Numlist[i]}");
                            Numlist[i] = 0;
                        }
                    }
                }

                //把例外 2 補充進去，印出陣列非0元素
                Console.WriteLine("陣列內的質數為:");
                Console.WriteLine($"2");
                for (int i = 0; i < array_size; i++)
                {
                    if (!(Numlist[i] == 0))
                    {
                        Console.WriteLine($"{Numlist[i]}");
                    }
                }
            }
        }
    }
}

