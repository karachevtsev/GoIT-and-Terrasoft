using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Сalculation area of a circle
            Console.WriteLine("Сalculation area of a circle");
            Console.Write("Please, input radius of a circle: ");
            double radiusCircle = Convert.ToDouble(Console.ReadLine());
            double areaCircle = (Math.Pow(radiusCircle, 2)) * Math.PI;
            Console.WriteLine("Square of a circle equals: {0}", areaCircle);
            Console.WriteLine();
            #endregion

            #region Сalculation volume of a spheree
            Console.WriteLine("Сalculation volume of a spheree");
            Console.Write("Please, input radius of a sphere: ");
            double radiusShere = Convert.ToDouble(Console.ReadLine());
            double volumeSphere = (Math.PI / 3 * 4) * (Math.Pow(radiusShere, 3));
            Console.WriteLine("Volume of a circle equals: {0}", volumeSphere);
            Console.WriteLine();
            #endregion

            #region Сalculation area of a rectangle
            Console.WriteLine("Сalculation volume of a rectangle");
            Console.Write("Please, input value of side a: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please, input value of side b: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            double areaRectangle = sideA * sideB;
            Console.WriteLine("Square of a rectangle equals: {0}", areaRectangle);
            Console.WriteLine();
            #endregion

            #region Сalculation volume of a parallelepiped
            Console.WriteLine("Сalculation volume of a parallelepiped");
            Console.Write("Please, input length of a parallelepiped: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please, input width of a parallelepiped: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please, input height of a parallelepiped: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double volumeParallelepiped = length * width * height;
            Console.WriteLine("Volume of a parallelepiped equals: {0}", volumeParallelepiped);
            #endregion

            Console.ReadKey();
        }
    }
}
