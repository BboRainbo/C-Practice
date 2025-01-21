using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxGroupIndex = 0;
            int GroupSize = GetIntValue("Group Size");
            int ArrayLength = GetIntValue("陣列長度");
            //可再加入保護: 陣列長度需>group size
            int[] IntArray =  FillIntArray(ArrayLength);
            MaxGroupIndex = FindMaxGroup(in IntArray, in GroupSize, out int Sum);
            Console.WriteLine($"最大 Group index 位於{MaxGroupIndex+1},總和為{Sum}");

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
            { Console.WriteLine($"{output[i]}"); }
            return output;
        }
        static int FindMaxGroup(in int[] InputArray, in int GroupSize, out int MaxGroupSum)
        {
            int MaxGroupIndex = 0;
            MaxGroupSum = 0;
            int GroupSum = 0;
            //先取第一組 group 並計算出 sum
            for (int i = 0; i < GroupSize; i++)
            {
                GroupSum += InputArray[i];
                MaxGroupSum += InputArray[i];
            }
            for (int i = 0; i < (InputArray.Length - GroupSize); i++)
            {

                GroupSum -= InputArray[i];
                GroupSum += InputArray[i + GroupSize];
                if (GroupSum > MaxGroupSum)
                {
                    MaxGroupSum = GroupSum;
                    MaxGroupIndex = i + 1;
                }
                Console.WriteLine($"目前Index為{i+2} ，GroupSum 為{GroupSum}");
            }
            return MaxGroupIndex;




        }
    }
}
