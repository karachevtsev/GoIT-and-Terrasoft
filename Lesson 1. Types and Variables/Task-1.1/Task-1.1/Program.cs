using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Целые типы
            // 8-bits == 1 byte
            // Целое без знака. Диапазон - от 0 до 255
            byte a = 0;
            Byte b = 255;
            Console.WriteLine("Type byte:   default value {0}, min {1}, max {2}", 0, a, b);

            // Целое со знаком. Диапазон - от -128 до +127
            sbyte c = -128;
            SByte d = +127;
            Console.WriteLine("Type sbyte:  default value {0}, min {1}, max {2}", 0, c, d);

            // 16-bits == 2 bytes
            // Целое без знака. Диапазон - от 0 до 65535
            ushort e = 0;
            UInt16 f = 65535;
            Console.WriteLine("Type ushort: default value {0}, min {1}, max {2}", 0, e, f);

            // Целое со знаком. Диапазон - от -32768 до +32767
            short g = -32768;
            Int16 h = +32767;
            Console.WriteLine("Type short:  default value {0}, min {1}, max {2}", 0, g, h);

            // 32-bits == 4 bytes
            // Целое без знака. Диапазон - от 0 до 4294967295
            uint i = 0;
            UInt32 j = 4294967295;
            Console.WriteLine("Type uint:   default value {0}, min {1}, max {2}", 0, i, j);

            // Целое со знаком. Диапазон - от -2147483648 до +2147483647
            int k = -2147483648;
            Int32 l = +2147483647;
            Console.WriteLine("Type int:    default value {0}, min {1}, max {2}", 0, k, l);

            // 64-bits == 8 bytes
            // Целое без знака. Диапазон - от 0 до 18446744073709551615
            ulong m = 0;
            UInt64 n = 18446744073709551615;
            Console.WriteLine("Type ulong:  default value {0}, min {1}, max {2}", 0, m, n);

            // Целое со знаком. Диапазон - от -9223372036854775808 до +9223372036854775807
            long o = -9223372036854775808;
            Int64 p = +9223372036854775807;
            Console.WriteLine("Type long:   default value {0}, min {1}, max {2}", 0L, o, p);
            #endregion

            #region Вещественные типы
            // Вещественные типы предназначены для представления дробных чисел
            // 32-bits == 4 bytes
            // Вещественное со знаком. Диапазон - от +/-1.5 x 10^-45 до +/-3.4 x 10^38
            float q = -0.123456789f;
            Single r = +1.123456789F;
            Console.WriteLine("Type float:    default value {0}, min {1}, max {2}", 0.0F, q, r);

            // 64-bits == 8 bytes
            // Вещественное со знаком. Диапазон - от +/-5.0 x 10^-324 до +/-1.7 x 10^308
            double s = -0.123456789d;
            Double t = +1.123456789;
            Console.WriteLine("Type double:   default value {0}, min {1}, max {2}", 0.0D, s, t);
            #endregion

            #region Десятичный тип
            // Десятичное со знаком. Диапазон - от от +/-1.0 x 10^-28 до +/-7.9 x 10^28
            decimal u = -0.12345m;
            Decimal v = +1.1234567M;
            Console.WriteLine("Type decimal:  default value {0}, min {1}, max {2}", 0.0M, u, v);
            #endregion

            #region Логический тип
            // 8-bits == 1 byte
            // Логическая величина Истина/Ложь
            bool w = true;
            Boolean x = false;
            Console.WriteLine("Type bool:     default value {0}", false);
            #endregion

            #region Символьный тип
            // 16-bits == 2 bytes
            // Символ в формате UNICODE
            char y = 'a';
            Char z = 'A';
            Console.WriteLine("Type char:     default value {0}", '\0');
            #endregion

            Console.ReadKey();
        }


    }
}
