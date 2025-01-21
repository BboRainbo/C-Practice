using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HappyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入數字");
                int.TryParse(Console.ReadLine(), out int input);
                HashSet<int> loop = new HashSet<int>();

                while (true)
                {
                    int sum = 0;
                    while (!(input == 0)) 
                    {
                        sum += (input % 10) * (input % 10);
                        input = (input / 10);
                        //Console.WriteLine($"sum={sum}");
                        //Console.WriteLine($"input={input}");
                    }

                    //foreach (int number in loop)
                    //{
                    //    Console.WriteLine(number);
                    //}

                    if (sum == 1) { Console.WriteLine("Happy Number!"); break; }
                    if (loop.Contains(sum))
                    {
                        Console.WriteLine($"本次平方和為{sum}，已於 loop 中重複");
                        Console.WriteLine("UnHappy Number!");
                        break; 
                    }
                    loop.Add(sum);
                    Console.WriteLine("current loop:");

                    input = sum;
                }
            }
        }
    }
}
