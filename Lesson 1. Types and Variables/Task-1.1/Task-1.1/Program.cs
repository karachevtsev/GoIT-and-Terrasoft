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
            byte myByte = new byte();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myByte.GetType(), myByte, byte.MinValue, byte.MaxValue);

            // Целое со знаком. Диапазон - от -128 до +127
            sbyte mySbyte = new sbyte();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", mySbyte.GetType(), mySbyte, sbyte.MinValue, sbyte.MaxValue);

            // 16-bits == 2 bytes
            // Целое без знака. Диапазон - от 0 до 65535
            ushort myUshort = new ushort();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myUshort.GetType(), myUshort, ushort.MinValue, ushort.MaxValue);

            // Целое со знаком. Диапазон - от -32768 до +32767
            ushort myShort = new ushort();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myShort.GetType(), myShort, short.MinValue, short.MaxValue);

            // 32-bits == 4 bytes
            // Целое без знака. Диапазон - от 0 до 4294967295
            uint myUint = new uint();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myUint.GetType(), myUint, uint.MinValue, uint.MaxValue);

            // Целое со знаком. Диапазон - от -2147483648 до +2147483647
            int myInt = new int();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myInt.GetType(), myInt, int.MinValue, int.MaxValue);

            // 64-bits == 8 bytes
            // Целое без знака. Диапазон - от 0 до 18446744073709551615
            ulong myUlong = new ulong();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myUlong.GetType(), myUlong, ulong.MinValue, ulong.MaxValue);

            // Целое со знаком. Диапазон - от -9223372036854775808 до +9223372036854775807
            long myLong = new long();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myLong.GetType(), myLong, long.MinValue, long.MaxValue);
            #endregion

            #region Вещественные типы
            // Вещественные типы предназначены для представления дробных чисел
            // 32-bits == 4 bytes
            // Вещественное со знаком. Диапазон - от +/-1.5 x 10^-45 до +/-3.4 x 10^38
            float myFloat = new float();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myFloat.GetType(), myFloat, float.MinValue, float.MaxValue);

            // 64-bits == 8 bytes
            // Вещественное со знаком. Диапазон - от +/-5.0 x 10^-324 до +/-1.7 x 10^308
            double myDouble = new double();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myDouble.GetType(), myDouble, double.MinValue, double.MaxValue);
            #endregion

            #region Десятичный тип
            // Десятичное со знаком. Диапазон - от от +/-1.0 x 10^-28 до +/-7.9 x 10^28
            decimal myDecimal = new decimal();
            Console.WriteLine("Type {0}: default value {1}, min {2}, max {3}", myDecimal.GetType(), myDecimal, decimal.MinValue, decimal.MaxValue);
            #endregion

            #region Логический тип
            // 8-bits == 1 byte
            // Логическая величина Истина/Ложь
            bool myBool = new bool();
            Console.WriteLine("Type {0}: default value {1}", myBool.GetType(), myBool);
            #endregion

            #region Символьный тип
            // 16-bits == 2 bytes
            // Символ в формате UNICODE
            char myСhar = new char();
            Console.WriteLine("Type {0}: default value {1}", myСhar.GetType(), myСhar);
            #endregion

            


            Console.ReadKey();
        }


    }
}
