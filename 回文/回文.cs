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
            Console.WriteLine("請輸入字串");
            if (InverseCheck(StrTrim(Console.ReadLine())))
            { Console.WriteLine("輸入為回文!"); }
            else
            { Console.WriteLine("輸入非回文!"); }

            //Console.WriteLine($"{input_Trim}");
            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine($"{InputChar[i]}");
            //}
            // A man, a plan, a canal: Panama
            //    // 時間複雜度 => O(n^2)
            //    int[] nums = { 2, 7, 11, 15 };
            //    int target = 9;
            ////    Dictionary<int, int> dict = new Dictionary<int, int>();
            ////    for (int i = 0; i < nums.Length; i++)
            ////    {
            //        for (int j = 0; j < nums.Length; j++)
            //        {
            //            if (nums[i] + nums[j] == target)
            //            {
            //                Console.WriteLine($"{nums[i]}, {nums[j]}");
            //                return;
            //            }
            //        }
            //    }
            //}
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
        }
        static void StrInvert(string input)
        {
            Char[] InputChar = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(InputChar[input.Length - i - 1]);
            }
        }

        static string StrTrim(string input)
        {
            List<char> InputList = new List<char>(input);
            //define valid char
            HashSet<int> CharTable = new HashSet<int>();
            int ASC_0 = 48;
            int ASC_9 = 57;
            int ASC_A = 65;
            int ASC_Z = 90;
            int ASC_a = 97;
            int ASC_z = 122;
            //
            for (int i = input.Length; i > 0; i--)
            {
                if (!((ASC_0 <= (int)InputList[i - 1] && (int)InputList[i - 1] <= ASC_9) ||
                      (ASC_A <= (int)InputList[i - 1] && (int)InputList[i - 1] <= ASC_Z) ||
                      (ASC_a <= (int)InputList[i - 1] && (int)InputList[i - 1] <= ASC_z)))
                { 
                    InputList.RemoveAt(i-1);
                }
            }
            Console.WriteLine($"{string.Concat(InputList)}");
            Console.ReadLine();
            return string.Concat(InputList);
        }
        static bool InverseCheck(string input)
        {
            int L_flag = 0;
            int R_flag = input.Length-1;

            while (L_flag < R_flag)
            {
                if (input[L_flag] != input[R_flag])
                {
                    return false;
                }
                L_flag = L_flag + 1;
                R_flag = R_flag - 1;

            }
            return true;
        }
    }
}