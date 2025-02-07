using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中序轉後序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //功能分開
            //1.看到數字印數字
            //2.看到符號，檢查運算元的優先級，若為高優先級，繼續存起來，若為低優先級(倒出並替換)
            //3.判斷字串結束，倒出所有符號
            string input = "3+5+7-9*8-6+3";
            string[] opers = { "+", "-", "*", "/" };
            string[] HighPriOpers = { "*", "/" };
            Stack<char> SignBuffer = new Stack<char>();
            string lastOper = "";
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i].ToString();
                if (!(opers.Contains(current)))
                {
                    Console.WriteLine($"{int.Parse(current)}");
                }

                else
                {

                    //流程不變的原則，隨著判斷邏輯變多，主程式看起來不應該變
                    //if 內的條件應該是清晰的邏輯表達 => 重新包裝的優先程度較高

                    //if (HighPriOpers.Contains(current))
                    //{ SignBuffer.Push(input[i]); }

                    //else
                    //{
                    //    while (SignBuffer.Count > 0)
                    //    {
                    //        Console.WriteLine($"{SignBuffer.Pop()}");
                    //    }
                    //    SignBuffer.Push(input[i]);
                    //}


                    if (!CheckPriorityIsHigher(lastOper, current))
                    {
                        while (SignBuffer.Count > 0)
                        {
                            Console.WriteLine($"{SignBuffer.Pop()}");
                        }
                    }
                    SignBuffer.Push(input[i]);
                    lastOper = current;

                }
            }

            for (int i = 0; i < SignBuffer.Count; i++)
            { Console.WriteLine($"{SignBuffer.Pop()}"); }
            Console.ReadLine();
        }


        private static bool CheckPriorityIsHigher(string lastOper, string currentOper)
        {
            return true;
        }
    }
}
