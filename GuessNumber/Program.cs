using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace guessnumber
{
    class Program
    {
        static Random rnd = new Random();
        static int Gemrndnum()
        {
            var num = rnd.Next(0, 100);
            return num;
        }
        static int totalCount = 0;
        static void Main(string[] args)
        {
            int systemNum = Gemrndnum();
            int inputNum;
            do
            {
                Console.WriteLine("猜數字 from 0 to 99");
                totalCount++;
                inputNum = int.Parse(Console.ReadLine());
                string EnterNum(int inputNum) => inputNum == systemNum ? $"太厲害你猜對了，只用了{totalCount}幾次" : inputNum > systemNum ? "猜錯了請繼續，小一點" : inputNum < systemNum ? "猜錯了請繼續，大一點" : "null";
                Console.WriteLine(EnterNum(inputNum));
            } while (inputNum != systemNum);

        }

    }
}