using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 前後序
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //tree and DFS

            //前序: -+2*319
            //後序: 231*+9-
            //中序: ((2+(3*1))-9)

            //前序
            //-(2+(3*1))9
            //-+2(3*1)9
            //-+2*319

            //後序
            //(2+(3*1))9-
            //2(3*1)+9-
            //231*+9-

            //功能分開
            //1.看到數字印數字
            //2.看到符號，檢查是否已經暫存符號，若有就倒出符號，沒有就存起來
            //3.判斷字串結束，倒出所有符號


            string input = "231*+9-";
            //物件容器 stack 可以讓你不必考慮 index 
            Stack<int> input_stack = new Stack<int>();
            string[] opers = { "+", "-", "*", "/" };

            for (int i = 0; i < input.Length; i++)
            {
                //switch case 內不要宣告變數 因為scope 都是共用的
                //只做分類器，不做任何操作
                //用stack 重做一次
                string current_char = input[i].ToString();
                if (!(opers.Contains(current_char)))
                {
                    input_stack.Push(int.Parse(current_char));
                }
                else
                {
                    int number2 = input_stack.Pop();
                    int number1 = input_stack.Pop();
                    int output = 0;
                    switch (current_char)
                    {
                        case "+":
                            output = number1 + number2;
                            break;
                        case "-":
                            output = number1 - number2;
                            break;
                        case "*":
                            output = number1 * number2;
                            break;
                        case "/":
                            output = number1 / number2;
                            break;
                    }
                    input_stack.Push(output);
                }

            }
            Console.WriteLine($"{input_stack.Pop()}");
            Console.ReadLine();
            //string input = "-+2*319";
            ////物件容器 stack 可以讓你不必考慮 index 
            //List<string> chars = input.Select(x => x.ToString()).ToList();
            //string[] opers = { "+", "-", "*", "/" };
            //while (true)
            //{

            //    for (int i = chars.Count; i >= 2; i--)
            //    {
            //        //switch case 內不要宣告變數 因為scope 都是共用的
            //        //只做分類器，不做任何操作
            //        //用stack 重做一次
            //        if (opers.Contains(chars[i - 2]))
            //        {
            //            int output = 0;
            //            int number1 = int.Parse(chars[i - 1]);
            //            int number2 = int.Parse(chars[i]);
            //            switch (chars[i - 2])
            //            {
            //                case "+":
            //                    output = number1 + number2;
            //                    break;
            //                case "-":
            //                    output = number1 - number2;
            //                    break;
            //                case "*":
            //                    output = number1 * number2;
            //                    break;
            //                case "/":
            //                    output = number1 / number2;
            //                    break;
            //            }

            //            chars.RemoveAt(i - 2);
            //            chars.RemoveAt(i - 2);
            //            chars.RemoveAt(i - 2);
            //            chars.Insert(i - 2, output.ToString());
            //        }
            //    }
            //    if (chars.Count == 1)
            //        break;
            //}
            //Console.WriteLine($"{chars[0]}");
            //Console.ReadLine();

            //LINQ =>處理數學、表格。從資料庫搜尋開始的

            //1.迴圈從右邊檢查2個數字+一個運算元
            //2.進行這兩個運算元的運算，並用結果更新字串
            //3.迴圈跑到剩下一個運算元為止

        }
    }
}
