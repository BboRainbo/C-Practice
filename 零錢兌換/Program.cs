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
            //作業: 紀錄使用的硬幣種類

            int amount = 14;
            int[] coins = { 10, 7, 5, 1 };
            Console.WriteLine(MinCoins(coins, amount));
            Console.ReadLine();

            //


            //硬幣數量最少
            //hint :遞迴，函式化
            //輸出 =  餘額、當前硬幣數量
            //遞迴終止條件 : 餘額 = 0 或確認除不盡
            //先不做除不盡的狀況
            //若發現新的最少硬幣組合，則更新

            //貪婪演算法
            //for (int i = 0; i < coins.Length; i++)
            //{
            //    coin_number += amount / coins[i];
            //    amount = amount % coins[i];
            //}

            //Console.WriteLine($"{coin_number}");
            //Console.ReadLine();
        }


        //[10,50,300,1000]
        //400
        //[0.1.2.3....150....
        static int MinCoins(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];

            for (int i = 0; i < dp.Length; i++)
            { dp[i] = int.MaxValue; }
            dp[0] = 0;
            //一開始會有一個初始表放在DP裡面
            //一開始也會有一個 amount
            //有一個迴圈，執行次數就是幣值的數量，會扣掉每一個幣值後得到餘數，
            //拿這個餘數去查找現有的DP，並比較這些值找出最小的+1然後填進當前的DP
            for (int i = 1; i <= amount; i++) // DP 的長度
            {
                //int CurrenMin = int.MaxValue;
                for (int j = 0; j < coins.Length; j++) //幣值種類總量
                    //如果當前要求的DP欄位減去硬幣幣值大於0
                    //且
                    if ((i - coins[j]) >= 0 && (dp[i - coins[j]] != int.MaxValue))
                    {

                        if ((dp[i - coins[j]] + 1) < dp[i])
                        {

                            dp[i] = dp[i - coins[j]] + 1;
                            // CurrenMin = dp[i - coins[j]] + 1;
                        }
                    }
                // dp[i] = CurrenMin;
            }

            return dp[amount];



            //暴力破解
            //if (amount == 0) { return 0; }
            //if (amount < 0) { return int.MaxValue; }
            //int minCoins = int.MaxValue; //初始硬幣數量為無限大

            //foreach (int coin in coins)
            //{
            //    int res = MinCoins(coins, amount - coin);
            //    if (res != int.MaxValue) // 只有當餘額是有效結果時才更新
            //        minCoins = Math.Min(minCoins, res + 1);
            //}

            //return minCoins;
        }



    }
}
