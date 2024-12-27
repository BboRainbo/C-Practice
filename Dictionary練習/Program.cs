using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Score = new Dictionary<string, int>();
            int NumOfStudent = GetIntValue("學生數量");

            AddScoreData(NumOfStudent, Score);
            SearchScore(Score);

        }

        #region Functions
        static void SearchScore(Dictionary<string, int> Score)
        {
            Console.WriteLine("現在可以開始查詢分數");
            while (true)
            {
                Console.WriteLine("請輸入學生姓名");
                String name = Console.ReadLine();
                //if (AllNames.Contains(name))
                if (Score.ContainsKey(name))
                { Console.WriteLine(Score[name]); }
                else { Console.WriteLine("無此資料，請再試一次"); }
            }
        }
        static void AddScoreData(int StudentNumber, Dictionary<string, int> dic)
        {
            for (int i = 0; i < StudentNumber; i++)
            {
                Console.WriteLine("請輸入學生姓名");
                string name = Console.ReadLine();
                //AllNames[i] = name;
                int value = GetIntValue("學生分數");
                dic.Add(name, value);
            }
        }

        static int GetIntValue(string name)
        {
            int value = 0;
            while (true)
            {
                Console.WriteLine($"請輸入{name}");
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"您輸入的{name}為{value}");
                    break;
                }
                else { Console.WriteLine("輸入格式有誤，請再試一次(僅能為 int)"); }

            }
            return value;
        }
        #endregion

    }
}