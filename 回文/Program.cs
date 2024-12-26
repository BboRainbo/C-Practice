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
            StrInvert(Console.ReadLine());

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine($"{InputChar[i]}");
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
    }
}