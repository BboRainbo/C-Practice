using System;
using System.Diagnostics; // 用於計時

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("請輸入質數搜尋範圍：");
            if (!int.TryParse(Console.ReadLine(), out int max) || max < 2)
            {
                Console.WriteLine("請輸入有效的正整數範圍（大於 1）！");
                return;
            }

            // 計時器開始
            Stopwatch stopwatch = Stopwatch.StartNew();

            // 找出質數（暴力破解法）
            FindPrimesByBruteForce(max);

            // 計時器結束
            stopwatch.Stop();
            Console.WriteLine($"\n執行時間：{stopwatch.ElapsedMilliseconds} 毫秒");
        }
    }

    static void FindPrimesByBruteForce(int max)
    {
        Console.WriteLine("質數列表：");
        for (int i = 2; i <= max; i++)
        {
            if (IsPrime(i)) // 呼叫質數檢查函數
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        // 暴力檢查：從 2 檢查到 number - 1
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0) // 如果能被整除，則不是質數
            {
                return false;
            }
        }
        return true; // 沒有發現因數，則是質數
    }
}