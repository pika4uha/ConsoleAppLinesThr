using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinesThr
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string str = "penis+penis*anus+blackcock=gay";
            int strSec = 0;
            int strThr = 0;
            int strFor = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+') //проверяем на условие верно ли что символ = +
                {
                    strSec++;//счетчик в нем будет храниться кол-во в строке элементов "+"
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*') //проверяем на условие верно ли что символ = *
                {
                    strThr++;//счетчик в нем будет храниться кол-во в строке элементов "*"
                }
            }

            strFor = strSec + strThr;

            Console.WriteLine("Всего символов: " + strFor);
            Console.WriteLine("Символов + : " + strSec);
            Console.WriteLine("Символов * : " + strThr);
            
            Console.ReadKey();
            
        }
    }
}
    

