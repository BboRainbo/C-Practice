using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 貸款償還
{
    internal class Program
    {

        static void Main(string[] args)
        {

            double LoanTotal = 0;
            double LoanRate = 0;
            double LoanCurrentPay = 0;
            double LoanRemain = 0;


            Console.WriteLine("請輸入貸款總額(NTD)");
            LoanTotal = MyTryParseDouble();
            Console.WriteLine("請輸入年利率(%)");
            LoanRate = MyTryParseDouble();
            LoanRemain = LoanTotal * (1 + (LoanRate / 100));
            Console.WriteLine($"您的貸款總額為{LoanTotal} (NTD),年利率為{LoanRate}%, 待償還總額為{LoanRemain}");

            while (LoanRemain > 0)
            {
                Console.WriteLine("本期之還款金額(NTD)");
                LoanCurrentPay = MyTryParseDouble();
                LoanRemain -= LoanCurrentPay;
                Console.WriteLine($"您目前的貸款餘額為{LoanRemain}(NTD)");

            }
            Console.WriteLine($"您的貸款已還清! 貸款餘額為{LoanRemain}");
        }

        static double MyTryParseDouble()
        {
            double result = 0;
            string input = Console.ReadLine();
            while (!(Double.TryParse(input, out result)))
            {
                Console.WriteLine("輸入格式有誤(僅能為double)，請再試一次!");
                input = Console.ReadLine();
            }
            Console.WriteLine($"您輸入的數值為{input}\n");
            return result;
        }
    }
}
