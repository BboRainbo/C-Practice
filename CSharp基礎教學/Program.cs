using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp基礎教學.Students;
using System.Runtime.InteropServices;

namespace CSharp基礎教學
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 基本資料型別 衍生型資料型別
            // 基本型(能夠用言語表達一個定值): int float double boolean string char 
            // 衍生(參考)型要分配到 new 記憶體): Program,Console,Random

            //class(call by reference) 和 structure(call by value) 的差異
            //記憶體溢位
            // int8(tinyint) int16 int32(int) -2147483647~2147483647 uint(不帶負號) int64(long)
            // 8bits 像素風 => 0~255
            //int number = 10;

            ////float 單精度浮點數, double 倍精度浮點數
            //double dob = 12.5;
            //float flo = 12.5F;

            //不同應用場景的容器選擇(list、dictionay...)

            //裝箱 boxing => 小類型 放到 大的類型
            //拆箱 unboxing => 將大的類型轉回去小類型

            //探討java和C# 的差異: 關於字串的處理
            // == 和 Equals 的差別(Java和 C# 都有為何 C#不用, find source code)?

            //方法簽名
            object obj = "abd";

            string result = (string)obj;

            string str = "123";
            //char 和 int 可直接轉換(ASCII)
            char chr = str[0];
            int num = (int)chr;
            Console.WriteLine(num);
        }
    }
}
