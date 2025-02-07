using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Todo
            //1. 未處理多組配對可滿足條件的狀況(只會輸出最後找到的一組)
            //2. 風險 :  重複如果值重複，key-value 會被跳過
            int ArrayLength = GetIntValue("陣列長度");
            int[] IntArray = FillIntArray(ArrayLength);

            while (true)
            {
                int target = GetIntValue("目標總和");
                PairSearch(IntArray, target);
            }

        }
        static int GetIntValue(string name)
        {
            int value = 0;
            bool TypeValid = false;
            while (true)
            {
                Console.WriteLine($"請輸入{name}");
                TypeValid = int.TryParse(Console.ReadLine(), out value);
                if (TypeValid)
                {
                    Console.WriteLine($"您輸入的{name}為{value}");
                    break;
                }
                else { Console.WriteLine("輸入格式有誤，請再試一次(僅能為整數)"); }
            }
            return value;
        }
        static int[] FillIntArray(int length)
        {
            int[] output = new int[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = GetIntValue($"第{i + 1}個元素");
            }
            Console.WriteLine("您輸入的陣列為");
            for (int i = 0; i < length; i++)
            { Console.WriteLine($"[{i + 1}]:{output[i]}"); }
            return output;
        }
        static Dictionary<int, int> BuildDictionay(int[] IntArray)
        {
            Dictionary<int, int> IntPair = new Dictionary<int, int>();
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (!(IntPair.ContainsKey(IntArray[i])))
                    IntPair.Add(IntArray[i], i);
            }
            return IntPair;
        }
        static void PairSearch(int[] IntArray, int target)
        {
            Dictionary<int, int> Intpair = BuildDictionay(IntArray);
            int[] result = new int[2];
            result[0] = 0;
            result[1] = 0;

            for (int i = 0; i < IntArray.Length; i++)
            {
                int complement = target - IntArray[i];
                if (Intpair.ContainsKey(complement) && (!((Intpair[complement] == i)))) // 排除自己跟自己配對
                {
                    result[0] = Intpair[complement] + 1;
                    result[1] = i + 1;
                    //break; 可在找到第一組時就跳出
                }
            }

            if (result[0] == 0 && result[1] == 0)
            {
                Console.WriteLine("未找到符合條件的兩個數字");
            }
            else
            {
                Console.WriteLine($"找到答案，索引值為: {result[0]}, {result[1]}");
            }
        }
    }
}
