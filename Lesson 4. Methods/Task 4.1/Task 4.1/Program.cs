using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double calcResult;
            char btnForExit;
            bool exitFromCalculator = false;

            calcResult = default(double);
            calcResult = GetValue();

            while (!exitFromCalculator)
            {
                SelectMathOperator(ref calcResult);
                ShowMessageForResult(calcResult);
                ShowMessageForExitOrContinue();
                btnForExit = Console.ReadKey().KeyChar;
                if (btnForExit == 'q')
                {
                    exitFromCalculator = true;
                }
            }
        }

        #region Method and cases for math operations
        static void SelectMathOperator(ref double calcResult)
        {
            ShowMessageForChooseOperators();
            char selectedOperator = Console.ReadKey().KeyChar;
            switch (selectedOperator)
            {
                case '+': calcResult = Add(calcResult); break;
                case '-': calcResult = Sub(calcResult); break;
                case '/': calcResult = Div(calcResult); break;
                case '*': calcResult = Mult(calcResult); break;
                case '%': calcResult = Mod(calcResult); break;
                case 'p': calcResult = Pow(calcResult); break;
                default: ShowMessageForIncorrectOperation(); Console.ReadKey(); break;
            }
        }
        #endregion

        #region Messages for user

        static void ShowMessageForEnterValue()
        {
            Console.WriteLine("Please, enter value for calculation and press Enter:");
        }

        static void ShowMessageForChooseOperators()
        {
            Console.WriteLine("Please, choose operator: +, -, /, *, %, p - raising to power");
        }

        static void ShowMessageForExitOrContinue()
        {
            Console.WriteLine("Please, press q to finish calculation or press Enter for continue calculation");
        }

        static void ShowMessageForResult(double value)
        {
            Console.WriteLine("Your result for calculation is {0}", value);
        }

        static void ShowMessageForIncorrectOperation()
        {
            Console.WriteLine("Error! You should choose valid operation! Please, try again!");
        }

        static void ShowMessageForIncorrectValue()
        {
            Console.WriteLine("Error! You should enter only numbers! Please, enter the number!");
        }

        static void ShowMessageForDividedByZero()
        {
            Console.WriteLine("Error! Divided by zero! Please, enter the number!");
        }


        #endregion

        #region Method for get values for calculation
        static double GetValue()
        {
            double value;

            ShowMessageForEnterValue();
            while (double.TryParse(Console.ReadLine(), out value) == false)
            {
                ShowMessageForIncorrectValue();
            }
            return value;
        }
        #endregion

        #region Simple maths methods

        static double Add(double valueFirst)
        {
            double valueSecond = GetValue();
            return valueFirst + valueSecond;
        }

        static double Sub(double valueFirst)
        {
            double valueSecond = GetValue();
            return valueFirst - valueSecond;
        }

        static double Div(double valueFirst)
        {
            double valueSecond = GetValue();
            if (valueSecond == 0)
            {
                ShowMessageForDividedByZero();
                return valueFirst;
            }
            else
            {
                return valueFirst / valueSecond;
            }
        }

        static double Mult(double valueFirst)
        {
            double valueSecond = GetValue();
            return valueFirst * valueSecond;
        }

        static double Mod(double valueFirst)
        {
            double valueSecond = GetValue();
            return valueFirst % valueSecond;
        }

        static double Pow(double valueFirst)
        {
            double valueSecond = GetValue();
            return Math.Pow(valueFirst, valueSecond);
        }

        #endregion
    }
}
