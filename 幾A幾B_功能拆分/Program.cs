using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 幾A幾B_功能拆分
{
    internal class Program
    {
        //static int number = 10;

        //string res = "HELLO";
        static void Main(string[] args)
        {
            //res


            int[] answer = NonRepeatDigitsGen(4);
            while (true)
            {
                int[] input = GetUserInputs();
                var (A, B) = CalculateAB(answer, input);
                Console.WriteLine($"{A}A{B}B");

                if (A == 4)
                {
                    Console.WriteLine("You Win!");
                    break;
                }
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 產生出長度為(length)的不重複隨機數字組
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] NonRepeatDigitsGen(int length)
        {
            int[] answer = new int[length];

            do
            {
                answer = IntArrayGen(length);
            } while (DigitRepeat(answer));

            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write(answer[i]);
            }
            Console.WriteLine();

            return answer;
        }
        /// <summary>
        /// 取得使用者輸入的數字組，並確保為合法輸入
        /// </summary>
        /// <returns></returns>
        public static int[] GetUserInputs()
        {
            //實作檢查輸入答案部分(非重複數字)，不需要填只需要檢查
            bool retry = true;
            int[] input = new int[4];
            while (true)
            {
                retry = false;
                Console.WriteLine("請輸入答案");
                string InputStr = Console.ReadLine();
                input = StringToIntArray(InputStr);

                if (DigitRepeat(input))
                {
                    Console.WriteLine("數字重複，請再試一次");
                    continue;
                }

                if (!(LengthValid(input)))
                {
                    Console.WriteLine("數字長度錯誤，請再試一次");
                    continue;
                }
                break;
            }
            //Console.WriteLine("Valid answer");
            return input;
        }

        /// <summary>
        /// 計算位置與數值都符合的數量為A，數值相符但位置不符為B
        /// </summary>
        /// <param name="inputInt"></param>
        /// <param name="answer"></param>
        /// <returns></returns>
        public static (int A, int B) CalculateAB(int[] inputInt, int[] answer)
        {
            int[] OutputAB = { 0, 0 };
            Dictionary<int, int> ValueRepeat = new Dictionary<int, int>();
            for (int i = 0; i < answer.Length; i++)
            {
                if ((ValueRepeat.ContainsKey(answer[i])))
                { ValueRepeat[answer[i]]++; }
                else
                { ValueRepeat.Add(answer[i], 1); }
            }

            //計算幾A幾B
            int ACounter = 0;
            int BCounter = 0;
            for (int i = 0; i < answer.Length; i++)
            {

                //判斷A
                if (answer[i] == inputInt[i])
                {
                    ACounter++;
                    ValueRepeat[answer[i]]--;
                    continue;
                }
                //判斷B
                if (!(ValueRepeat.ContainsKey(inputInt[i])))
                {
                    continue;
                }
                else if (ValueRepeat[inputInt[i]] > 0)
                {
                    BCounter++;
                    ValueRepeat[inputInt[i]]--;
                }
            }
            return (ACounter, BCounter);
        }

        /// <summary>
        /// 判斷幾A幾B遊戲輸入長度是否合法(4)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool LengthValid(int[] input)
        {
            if (input.Length == 4)
                return true;
            else return false;
        }

        /// <summary>
        /// 判斷輸入的數字串是否有重複的數字
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool DigitRepeat(int[] input)
        {
            HashSet<int> Value = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Value.Add(input[i])))
                { return true; }
            }
            return false;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (input[i] == input[j])
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;
        }

        /// <summary>
        /// 將字串轉換為整數陣列
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int[] StringToIntArray(string input)
        {

            int[] inputInt = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputInt[i] = (int)input[i] - 48;
            }
            return inputInt;
        }


        /// <summary>
        /// 根據輸入長度產生一個隨機 (length)位數字，但並不保證是否重複
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private static int[] IntArrayGen(int length)
        {
            Random random = new Random();
            int[] input = new int[length];
            for (int i = 0; i < length; i++)
            {
                input[i] = random.Next(1, 10);
            }

            return input;
        }

        //static int[] AnswerGen()
        //{
        //    Random random = new Random();
        //    HashSet<int> digits = new HashSet<int>();

        //    while (digits.Count < 4)
        //    {
        //        digits.Add(random.Next(0, 10));
        //    }

        //    return digits.ToArray();
        //}
    }
}
