using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SUM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ArrayLength = GetIntValue("陣列長度");
            int[] IntArray = FillIntArray(ArrayLength);

            while (true)
            {
                int target = GetIntValue("目標總和");
                //1.一樣先用target 算出一階 complement[arraylength]
                //2.拿出每一個 array compliment 算出[arraylength]本 dictionary(二階 compliment)
                //
                Dictionary<int, int> Complement_1st = new Dictionary<int, int>();
                for (int i = 0; i < ArrayLength; i++)
                {
                    Complement_1st.Add(i + 1, target - IntArray[i]);
                    //index, complement
                }

                foreach (var kvp in Complement_1st)
                {
                    //利用 Hashset 0防止尋找第三個 key 時重複
                    HashSet<int> index = new HashSet<int>();
                    int[] result_2SUM = PairSearch(IntArray, kvp.Key);
                    Console.WriteLine($"1stCompliment={Complement_1st[kvp.Key]}");
                    if ((result_2SUM[0] == 0))
                    { Console.WriteLine("2Sum is null!!}"); continue; }
                    if (!(result_2SUM[0] == 0))
                    {
                        index.Add(result_2SUM[0]);
                        index.Add(result_2SUM[1]);
                        Console.WriteLine($"2Sum[0]={result_2SUM[0]}");
                        Console.WriteLine($"2Sum[1]={result_2SUM[1]}");
                        if (!(index.Contains(Complement_1st[kvp.Key] + 1)))
                        {
                            Console.WriteLine("配對成功");
                            Console.WriteLine($"數字 index為{result_2SUM[0]},{result_2SUM[1]},{Complement_1st[kvp.Key] + 1}");
                            break;
                        }
                        else { Console.WriteLine("未找到可配對的數字組"); }
                    }

                }

                Console.ReadLine();
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
        static int[] PairSearch(int[] IntArray, int target) // 根據 target 找出不重複的配對
        {
            Dictionary<int, int> Intpair = BuildDictionay(IntArray);
            int[] result = new int[2];
            PrintDictionary<int, int>(Intpair);

            for (int i = 0; i < IntArray.Length; i++)
            {
                int complement = target - IntArray[i];
                //
                if (Intpair.ContainsKey(complement) && (!((Intpair[complement] == i)))) // 排除自己跟自己配對
                {

                    result[0] = Intpair[complement] + 1;
                    result[1] = i + 1;
                    return result;

                }
                else
                {
                    result[0] = 0;
                    result[1] = 0;
                }

            }
            return result;
        }

        static void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is null or empty.");
                return;
            }

            Console.WriteLine("Dictionary Contents:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
