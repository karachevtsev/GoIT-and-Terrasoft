using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
           string str = "Hello world";

            for (int i = 0; i < str.Length; i++)
            {
                int value = Convert.ToInt32(str[i]);
                string hexOutput = String.Format("{0:X}", value);
                Console.WriteLine("Char {0,2}: dec{1,5} hex {2,4}", str[i], value, hexOutput);
            }

            Console.ReadKey();
        }
    }
}
