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
            Console.WriteLine("Type byte: default value {0}, min {1}, max {2}", default(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("Type sbyte: default value {0}, min {1}, max {2}", default(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Type short: default value {0}, min {1}, max {2}", default(short), short.MinValue, short.MaxValue);
            Console.WriteLine("Type ushort: default value {0}, min {1}, max {2}", default(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Type int: default value {0}, min {1}, max {2}", default(int), int.MinValue, int.MaxValue);
            Console.WriteLine("Type uint: default value {0}, min {1}, max {2}", default(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("Type long: default value {0}, min {1}, max {2}", default(long), long.MinValue, long.MaxValue);
            Console.WriteLine("Type ulong: default value {0}, min {1}, max {2}", default(ulong), ulong.MinValue, ulong.MaxValue);
            #endregion

            #region Вещественные типы
            Console.WriteLine("Type float: default value {0}, min {1}, max {2}", default(float), float.MinValue, float.MaxValue);
            Console.WriteLine("Type double: default value {0}, min {1}, max {2}", default(double), double.MinValue, double.MaxValue);
            #endregion

            #region Десятичный тип
            Console.WriteLine("Type decimal: default value {0}, min {1}, max {2}", default(decimal), decimal.MinValue, decimal.MaxValue);
            #endregion

            #region Логический тип
            Console.WriteLine("Type bool: default value {0}", default(bool));
            #endregion

            #region Символьный тип
            Console.WriteLine("Type char: default value {0}", default(char));
            #endregion

            Console.ReadKey();
        }


    }
}
