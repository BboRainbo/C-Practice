using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 幾A幾B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //區分 public 與 private
            //1.出題功能，要自我檢查是否有重複 digit (bitwise) => 輸出字串
            //2.猜題功能，要自我檢查是否有重複 digit (stringwise)=> 輸出字串
            //3.比對功能，輸出幾A幾B = 給你兩個 input number array , 回傳 (int A,int B) => tuple
            //3-1.



            //1.設定題目(number only)
            //2.A代表位置與數值都正確，B代表有這個值但位置錯誤
            //用 dictionary 應該不錯 int<value, index>
            //如何排除重複猜中的B?比如題目為 1130 猜為0111<答案應該是1A1B而非1A2B => 用一個 counter 同時計算數字出現的次數，如果猜的答案中一次就-1，如果為0後B的數量不再增加
            //如何判斷A : 檢查 index 以及 value 是否相同
            //如何判斷B : 先把A檢查完並排除後，檢查 value查詢 dictionary是否存在
            Random random = new Random();


            //第一層迴圈數量 : 所需要的 bit數
            //第二層 : 檢查每個 bit 是否重複


            //加上題目重複檢查功能
            //加上隨機出題功能
            //加上答案重複檢查功能
            //前面的邏輯會影響到後面無法正常運作

            int[] answer = new int[4];

            for (int i = 0; i < 4; i++)
            {
                answer[i] = random.Next(0, 10);
                for (int j = 0; j < i; j++)
                {
                    if (answer[i] == answer[j])
                    {
                        answer[i] = random.Next(0, 10);
                        j = -1;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(answer[i]);
            }
            Console.WriteLine();
            Console.ReadLine();


            string input = Console.ReadLine();
            int[] inputInt = new int[input.Length];
            int[] outputInt = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputInt[i] = (int)input[i];
            }

            for (int i = 0; i < 4; i++)
            {
                outputInt[i] = inputInt[i];
                for (int j = 0; j < i; j++)
                {
                    if (inputInt[i] == outputInt[j])
                    {
                        //如果相等的話 ， 重新輸入一次

                        j = -1;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(answer[i]);
            }
            Console.WriteLine();
            Console.ReadLine();

            //HashSet<int> set = new HashSet<int>();
            //int BitCounter = 4;
            //while (BitCounter > 0)
            //{
            //    int CurrentBit = random.Next();
            //    if (set.Contains(CurrentBit))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        set.Add(CurrentBit);
            //        answer[BitCounter - 1] = CurrentBit;
            //        BitCounter--;
            //    }

            //}


            ////題目與輸入的答案都必須是不重複的數字
            //while (true)
            //{
            //    Dictionary<int, int> ValueRepeat = new Dictionary<int, int>();
            //    for (int i = 0; i < answer.Length; i++)
            //    {
            //        if ((ValueRepeat.ContainsKey(answer[i])))
            //        { ValueRepeat[answer[i]]++; }
            //        else
            //        { ValueRepeat.Add(answer[i], 1); }
            //    }
            //    Console.WriteLine("請輸入答案");
            //    string input = Console.ReadLine();
            //    Dictionary<int, int> InputValueRepeat = new Dictionary<int, int>();
            //    for (int i = 0; i < answer.Length; i++)
            //    {
            //        if ((ValueRepeat.ContainsKey(answer[i])))
            //        { ValueRepeat[answer[i]]++; }
            //        else
            //        { ValueRepeat.Add(answer[i], 1); }
            //    }

            //    //計算幾A幾B
            //    int ACounter = 0;
            //    int BCounter = 0;
            //    for (int i = 0; i < answer.Length; i++)
            //    {

            //        //判斷A
            //        if (answer[i] == input[i])
            //        {
            //            ACounter++;
            //            ValueRepeat[answer[i]]--;
            //            continue;
            //        }
            //        //判斷B
            //        if (!(ValueRepeat.ContainsKey(input[i])))
            //        {
            //            continue;
            //        }
            //        else if (ValueRepeat[input[i]] > 0)
            //        {
            //            BCounter++;
            //            ValueRepeat[input[i]]--;
            //        }
            //    }

            //    Console.WriteLine($"{ACounter}A{BCounter}B");
            //    Console.ReadLine();
            //}
        }
    }
}
