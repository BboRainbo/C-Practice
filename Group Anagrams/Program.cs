using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///aaabbbbccda = a4b4c2d1


            string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };

            string[] EigenSorted = new string[input.Length]; //儲存字串特徵值
            List<List<string>> groups = new List<List<string>>();
            Dictionary<string, int> GroupDict = new Dictionary<string, int>(); //儲存組別與特徵值的關係   

            //將
            for (int i = 0; i < input.Length; i++)
            {
                EigenSorted[i] = SortDictionary(BuildDictionary(input[i]));
            }

            int TeamNum = 0;
            for (int i = 0; i < EigenSorted.Length; i++)
            {

                if (!(GroupDict.ContainsKey(EigenSorted[i])))
                {
                    GroupDict.Add(EigenSorted[i], TeamNum);
                    TeamNum++;
                    //添加一個新組別
                    List<string> group = new List<string>();
                    groups.Add(group);
                    groups[TeamNum].Add(input[i]);
                }
                else
                {
                    //現有組別增加成員 ;
                    //1.讀取組別值
                    //2.放入 list
                    TeamNum = GroupDict[EigenSorted[i]];
                    groups[TeamNum].Add(input[i]);

                }
            }

            foreach (var list in groups)
            {
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine(list[i]);
            }
            O(3n)

            PrintDictionary(GroupDict);

            Console.WriteLine("各個數字的組別為");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{GroupDict[EigenSorted[i]]}");
            }
            Console.ReadKey();


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
                if (!(dict2.ContainsKey(kvp.Key)) || !(dict2[kvp.Key] == kvp.Value))
                {
                    result = false;
                }

            }
            if (result) { Console.WriteLine("Equal"); }
            else { Console.WriteLine("NotEqual"); }
        }
        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp}");
            }
        }

        static string SortDictionary(Dictionary<char, int> dict)
        {
            List<char> list = new List<char>();
            string output = null;
            foreach (var kvp in dict)
            {
                list.Add(kvp.Key);
            }
            list.Sort();

            //使用 string builder拼出排序好的字母與數量
            for (int i = 0; i < list.Count; i++)
            {
                output += list[i];
                output += dict[list[i]];
            }
            return output;
        }
    }



}

