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
            List<object> types = new List<object>()
            {
                default(byte), byte.MinValue, byte.MaxValue,
                default(sbyte), sbyte.MinValue, sbyte.MaxValue,
                default(short), short.MinValue, short.MaxValue,
                default(ushort), ushort.MinValue, ushort.MaxValue,
                default(int), int.MinValue, int.MaxValue,
                default(uint), uint.MinValue, uint.MaxValue,
                default(long), long.MinValue, long.MaxValue,
                default(ulong), ulong.MinValue, ulong.MaxValue,
                default(float), float.MinValue, float.MaxValue,
                default(double), double.MinValue, double.MaxValue,
                default(decimal), decimal.MinValue, decimal.MaxValue,
                default(bool),"____","____",
                default(char),"____","____"
            };
            Types.ShowTypeList(types);
            Console.ReadKey();
        }

        public class Types
        {
            public static void ShowTypeList(List<object> typesList)
            {
                for (int i = 0; i < typesList.Count; i = i + 3)
                {
                    Console.WriteLine("Type " + typesList[i].GetType() + ": default value " + typesList[i] + ", min " + typesList[i + 1] + ", max " + typesList[i + 2]);
                }
            }
        }

       

    }
}
