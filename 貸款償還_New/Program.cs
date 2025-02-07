using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace 貸款償還_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input = 0;
                int house = 0;
                int married = 0;

                Console.WriteLine("下一筆資料 : ");
                if (YNquestion("擁有房產"))
                {
                    Console.WriteLine("可償還");
                    Console.ReadLine();
                    continue;
                }

                if (YNquestion("已婚"))
                {
                    Console.WriteLine("可償還");
                    Console.ReadLine();
                    continue;
                }

                double value = GetDoubleValue("請輸入年收入");
                if (IncomeTrans(GetDoubleValue("年收入")) >= 500000)
                {
                    Console.WriteLine("可償還");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("無法償還");
                Console.ReadLine();
            }
        }

        #region Function
        static bool YNquestion(string question)
        {
            bool output = false;
            while (true)
            {
                Console.WriteLine($"是否{question}?(Y/N)");
                string answer = Console.ReadLine();
                //char YN = char.ToLower(answer[0]);
                string[] PosWord = { "有", "是", "Y", "y" };
                string[] NegWord = { "無", "否", "N", "n" };
                //if ((YN) == 'y')
                if (PosWord.Any(element => answer.Contains(element)))
                {
                    output = true;
                    break;
                }
                //if ((YN) == 'n')
                if (NegWord.Any(element => answer.Contains(element)))
                {
                    output = false;
                    break;
                }
                Console.WriteLine("輸入錯誤，請再試一次(Y/N)");
            }
            return output;
        }
        /// <summary>
        ///  取得使用者輸入的浮點數，若使用者輸入非浮點數則會要求反覆輸入，直到能回傳浮點數為止
        /// </summary>
        /// <param name="name">要顯示的標題</param>
        /// <returns>使用者輸入的浮點數</returns>
        static double GetDoubleValue(string name)
        {
            double value = 0;
            while (true)
            {
                Console.WriteLine($"請輸入{name}");
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"您輸入的{name}為{value}");
                    break;
                }
                else { Console.WriteLine("輸入格式有誤，請再試一次(僅能為 double)"); }
            }
            return value;
        }
        static double IncomeTrans(double income_input)
        {
            if (income_input < 100000)
            { return income_input * 10000; }
            else return income_input;
        }
        #endregion

    }
}
