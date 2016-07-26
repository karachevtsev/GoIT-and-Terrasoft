using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string res = "";

            a = 1234567890;

            while (a > 0)
            {
                b = a % 10; 
                if (b % 2 != 0 && b != 9)
                {
                    b++;
                }
                else if (b == 9)
                {
                    b = 0;
                }
                string str = b.ToString();
                res = str + res;
                a /= 10;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
