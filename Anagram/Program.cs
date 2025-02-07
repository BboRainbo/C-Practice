using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個字串");
            Dictionary<char, int> dict1 = BuildDictionary(Console.ReadLine());
            Console.WriteLine("請輸入第二個字串");
            Dictionary<char, int> dict2 = BuildDictionary(Console.ReadLine());
            DictionaryEqual(dict1, dict2);

        }
        static Dictionary<char, int> BuildDictionary(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>(); //用來記錄出現的字母與次數
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                { dict[input[i]] = dict[input[i]] + 1; }
                else
                { dict.Add(input[i], 1); }
            }
            return dict;
        }
        static void DictionaryEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            bool result = true;
            //若 dictionary 內部元素數量不同
            if (!(dict1.Count == dict2.Count))
            {
                result = false;
            }

            foreach (var kvp in dict1)
            {
                //若dict2 不包含 dict1 的 key 或 value 不相等
                if (!(dict2.Contains(kvp)) || !(dict2[kvp.Key] == kvp.Value))
                {
                    result = false;
                }
            }
            if (result) { Console.WriteLine("是Anagram"); }
            else { Console.WriteLine("非Anagram"); }
        }
    }
}
