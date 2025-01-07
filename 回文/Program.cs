using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("請輸入字串");
            //StrInvert(Console.ReadLine());

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine($"{InputChar[i]}");
            //}

            // A man, a plan, a canal: Panama


            // nums = [2,7,11,15], target = 9


            // 時間複雜度 => O(n^2)
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            //HW1: 介紹甚麼是 時間複雜度 空間複雜度
            //Hw2: Dictionary是 O(1) => 只需要找一次就可以找到， 思考兩個問題:
            //1. 但是dicionary的資料建檔難道不用紀錄嗎?
            //Dictionay Read O(1), 那 Write 呢?

            //2. 為甚麼dcitionary 可以是O(1)
            // O(1) =>
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"{nums[i]}, {nums[j]}");
                        return;
                    }
                }
            }
        }
        //abccba
        //

        //for (i)
        //{
        ////str[i]==str[str.Length-i]
        ////跳出條件為不相等或者是旗標相遇
        //}

        //while (左右旗標未相遇)
        //{
        //左右旗標shift
        //比對字元
        //if 不相等跳出
        //}

        static void StrInvert(string input)
        {
            Char[] InputChar = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(InputChar[input.Length - i - 1]);
            }
        }
    }
}