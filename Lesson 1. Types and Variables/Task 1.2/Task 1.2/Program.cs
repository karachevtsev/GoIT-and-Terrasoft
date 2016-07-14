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
            char h = 'H';
            char e = 'e';
            char l = 'l';
            char o = 'o';
            char w = 'w';
            char r = 'r';
            char d = 'd';

            int valueH = Convert.ToInt32(h);
            int valueE = Convert.ToInt32(e);
            int valueL = Convert.ToInt32(l);
            int valueO = Convert.ToInt32(o);
            int valueW = Convert.ToInt32(w);
            int valueR = Convert.ToInt32(r);
            int valueD = Convert.ToInt32(d);

            string hexOutputH = String.Format("{0:X}", valueH);
            string hexOutputE = String.Format("{0:X}", valueE);
            string hexOutputL = String.Format("{0:X}", valueL);
            string hexOutputO = String.Format("{0:X}", valueO);
            string hexOutputW = String.Format("{0:X}", valueW);
            string hexOutputR = String.Format("{0:X}", valueR);
            string hexOutputD = String.Format("{0:X}", valueD);

            decimal convertDecimalH = Convert.ToDecimal(valueH);
            decimal convertDecimalE = Convert.ToDecimal(valueE);
            decimal convertDecimalL = Convert.ToDecimal(valueL);
            decimal convertDecimalO = Convert.ToDecimal(valueO);
            decimal convertDecimalW = Convert.ToDecimal(valueW);
            decimal convertDecimalR = Convert.ToDecimal(valueR);
            decimal convertDecimalD = Convert.ToDecimal(valueD);

            Console.WriteLine("Hexadecimal value of {0} is {1}", h, hexOutputH);
            Console.WriteLine("Hexadecimal value of {0} is {1}", e, hexOutputE);
            Console.WriteLine("Hexadecimal value of {0} is {1}", l, hexOutputL);
            Console.WriteLine("Hexadecimal value of {0} is {1}", l, hexOutputL);
            Console.WriteLine("Hexadecimal value of {0} is {1}", o, hexOutputO);
            Console.WriteLine("Hexadecimal value of {0} is {1}", w, hexOutputW);
            Console.WriteLine("Hexadecimal value of {0} is {1}", o, hexOutputO);
            Console.WriteLine("Hexadecimal value of {0} is {1}", r, hexOutputR);
            Console.WriteLine("Hexadecimal value of {0} is {1}", l, hexOutputL);
            Console.WriteLine("Hexadecimal value of {0} is {1}", d, hexOutputD);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Decimal value of {0} is {1}", h, convertDecimalH);
            Console.WriteLine("Decimal value of {0} is {1}", e, convertDecimalE);
            Console.WriteLine("Decimal value of {0} is {1}", l, convertDecimalL);
            Console.WriteLine("Decimal value of {0} is {1}", l, convertDecimalL);
            Console.WriteLine("Decimal value of {0} is {1}", o, convertDecimalO);
            Console.WriteLine("Decimal value of {0} is {1}", w, convertDecimalW);
            Console.WriteLine("Decimal value of {0} is {1}", o, convertDecimalO);
            Console.WriteLine("Decimal value of {0} is {1}", r, convertDecimalR);
            Console.WriteLine("Decimal value of {0} is {1}", l, convertDecimalL);
            Console.WriteLine("Decimal value of {0} is {1}", d, convertDecimalD);


            Console.ReadKey();
        }
    }
}
