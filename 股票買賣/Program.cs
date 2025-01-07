using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 股票買賣
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double EarnMax = double.MinValue;
            double PriceMin = double.MaxValue;
            int BuyDay = 0;
            int SellDay = 0;
            int BuyDaytmp = 0;
            int period = 0;
            period = GetIntValue("搜尋天數");
            double[] price = new double[period];

            for (int i = 1; i <= period; i++)
            {
                price[i - 1] = GetDoubleValue($"第{i}天價格");
            }

            //為什麼可以簡化成單層迴圈?
            //因為賣日必定會比買日晚，
            //其中只有出現新低價才"有可能"打破獲利紀錄
            //且新找到的最低賣價只有可能在"往後"破收益紀錄，因此不需要往前檢查
            //因此遇到更低價時，更新最低價並重新累計獲利看是否破紀錄
            //沒有低於最低價就檢查最大收益是否被更新
            for (int i = 0; i < period; i++)
            {
                double Earn = 0;
                if (price[i] < PriceMin)
                {
                    PriceMin = price[i];
                    BuyDaytmp = i;
                }

                Earn = price[i] - PriceMin;
                if (Earn > EarnMax)
                {
                    EarnMax = Earn;
                    SellDay = i;
                    BuyDay = BuyDaytmp;
                }
                Console.WriteLine($"EarnMax={EarnMax}");
                Console.WriteLine($"PriceMin={PriceMin}");
                Console.WriteLine($"BuyDay = {BuyDay}");
                Console.WriteLine($"SellDay = {SellDay}");
            }
            Console.WriteLine($"最佳買進日為第{BuyDay + 1}天，最佳賣出日為第{SellDay + 1}天");
            Console.WriteLine($"收益為{EarnMax}");
            Console.ReadKey();
        }

        static int GetIntValue(string name)
        {
            int value = 0;
            while (true)
            {
                Console.WriteLine($"請輸入{name}");
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"您輸入的{name}為{value}");
                    break;
                }
                else { Console.WriteLine("輸入格式有誤，請再試一次(僅能為 int)"); }
            }
            return value;
        }
        static double GetDoubleValue(string name)
        {
            double value = 0;
            while (true)
            {
                Console.WriteLine($"請輸入{name}");
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"您輸入的{name}為{value}");
                    break;
                }
                else { Console.WriteLine("輸入格式有誤，請再試一次(僅能為 double)"); }
            }
            return value;
        }
    }
}
