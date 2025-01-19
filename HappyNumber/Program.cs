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
            Console.WriteLine("請輸入數字");
            int.TryParse(Console.ReadLine(),out int input);
            

            while (true) 
            {
                int sum = 0;

                while (!(input==0)) //用input/10 = 0會導致單位數無窮迴圈
                 {
                sum += (input%10)*(input%10);
                input = (input/10);
                    Console.WriteLine($"sum={sum}");
                    Console.WriteLine($"input={input}");
                }

                if (sum == 1) { Console.WriteLine("Happy Number!");break; }
                if (sum == 4) { Console.WriteLine("UnHappy Number!");break; }
                input = sum;
            }
        }
    }
}
