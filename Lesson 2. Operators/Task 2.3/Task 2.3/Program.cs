using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 12;
            int z = 2;

            int result = (x++ - --y + --x << z++) * (x + y + z);
            // ( 5 - (12 - 1) + (5 + 1 - 1) << 2 ) * ( (5 + 1 - 1) + 11 + (2 + 1) )
            // ( 5 - 11 + 5 << 2 ) * ( 5 + 11 + 3 )
            // ( -1 << 2) * 19
            // -1 в двоичном представлении - 1111 1111 1111 1111 1111 1111 1111 1111
            // сдвиг на два бита влево 1111 1111 1111 1111 1111 1111 1111 1100 - это число -4
            // -4 * 19 = -76
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
