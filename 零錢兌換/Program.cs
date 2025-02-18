using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 零錢兌換
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //貪婪演算法
            int[] coins = { 10, 7, 5, 1 };
            int amount = 14;
            //硬幣數量最少
            //hint :遞迴，函式化

            int coin_number = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                coin_number += amount / coins[i];
                amount = amount % coins[i];
            }

            Console.WriteLine($"{coin_number}");
            Console.ReadLine();
        }
    }
}
