using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue_Reference
{
    internal class Program
    {
        readonly int MAX_INT = 7654321;

        static void Main(string[] args)
        {
            // 設定欄位和變數必須是唯獨的
            // 在類別的欄位 => readonly
            // 在函數內的變數 => const
            // 在函數內的參數 => in



            int output = 0;
            Console.WriteLine("請輸入字串");
            bool result = IntParse(Console.ReadLine(), ref output);
            Console.WriteLine(result);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        static bool IntParse(string input, ref int output)
        {
            output = 0;
            //1.輸入的字串 = str 
            for (int i = 0; i < input.Length; i++)
            {
                //判斷 each char 轉換成 int 值後是否落在ASCII code 中的整數 range~(48~57)
                if (48 < input[i] && input[i] < 57)
                {
                    output = output * 10 + input[i] - 48;
                }
                else { return false; }
            }
            return true;

        }
    }
}
