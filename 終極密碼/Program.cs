using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 終極密碼
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                bool flag = false;
                Random random = new Random();
                int guess = 0;
                int upper_bound = 101;
                int lower_bound = 0;
                int answer = random.Next(0, 101);
                Console.WriteLine("新遊戲! \n");
                //Console.WriteLine($"這次的目標是{answer}");

                while (!(flag))
                {
                    Console.WriteLine($"{lower_bound}---{upper_bound}");
                    //bool parseflag = false;
                    //while (!(parseflag))
                    //{
                    //Console.WriteLine("請輸入一個數字(整數)");
                    guess = random.Next(lower_bound, upper_bound);
                    Console.WriteLine($"這次猜的數字是{guess}");
                    //parseflag = int.TryParse(Console.ReadLine(), out guess);

                    //}


                    if (guess == answer)
                    {
                        Console.WriteLine("答對了!");
                        Console.ReadLine();
                        flag = true;
                    }

                    if (guess < answer)
                    {
                        if (guess > lower_bound) { lower_bound = guess; }
                        Console.WriteLine("數字太小!");
                        flag = false; ;
                    }

                    if (guess > answer)
                    {
                        if (guess < upper_bound) { upper_bound = guess; }
                        Console.WriteLine("數字太大!");
                        flag = false; ;
                    }


                }
            }
        }
    }
}
