using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("請輸入尋找範圍 X (1~X)");
            int Array_length;
            int.TryParse(Console.ReadLine(), out Array_length);

            Console.WriteLine("請輸入Fizz Number");
            int FizzNum;
            int.TryParse(Console.ReadLine(), out FizzNum);

            Console.WriteLine("請輸入Buzz Number");
            int BuzzNum;
            int.TryParse(Console.ReadLine(), out BuzzNum);

            Console.WriteLine("請輸入AIzz Number");
            int AIzzNum;
            int.TryParse(Console.ReadLine(), out AIzzNum);

            for (int i = 0; i < Array_length; i++)
            {
                string Output = "";
                if ((i + 1) % FizzNum == 0)
                { Output = Output + "Fizz"; }

                if ((i + 1) % BuzzNum == 0)
                { Output = Output + "Buzz"; }

                if ((i + 1) % AIzzNum == 0)
                { Output = Output + "AIzz"; }

                if (!((i + 1) % FizzNum == 0) && !((i + 1) % BuzzNum == 0) && !((i + 1) % AIzzNum == 0))
                { Output = $"{i + 1}"; }

                Console.WriteLine($"{Output}");
            }
        }
    }
}
