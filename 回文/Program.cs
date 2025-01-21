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
        }


        static string StrTrim(string input)
        {
            List<char> InputList = new List<char>(input);
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