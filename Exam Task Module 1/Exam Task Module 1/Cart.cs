using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Task_Module_1
{
    class Cart
    {
        public Purchase[] CreateListOfPurchase(Goods[] argArray)
        {
            Purchase[] arrayOfPurchase = new Purchase[5];
            for (int i = 0; i < arrayOfPurchase.Length; i++)
            {
                var tempArrayOfPurchase = new Purchase
                {
                    Amount = 0,
                    Name = argArray[i].Name
                };
                arrayOfPurchase[i] = tempArrayOfPurchase;
            }

            return arrayOfPurchase;
        }

        public Goods[] CreateListOfGoods()
        {
            Goods[] arrayOfGoods = new Goods[5];
            for (int i = 0; i < arrayOfGoods.Length; i++)
            {
                var tempArrayOfGoods = new Goods
                {
                    Id = i + 1
                };
                arrayOfGoods[i] = tempArrayOfGoods;
            }
            arrayOfGoods[0].Name = "Apple";
            arrayOfGoods[0].Price = 1.00M;
            arrayOfGoods[1].Name = "Milk";
            arrayOfGoods[1].Price = 1.50M;
            arrayOfGoods[2].Name = "Cola";
            arrayOfGoods[2].Price = 0.75M;
            arrayOfGoods[3].Name = "Bread";
            arrayOfGoods[3].Price = 2.55M;
            arrayOfGoods[4].Name = "Chocolate";
            arrayOfGoods[4].Price = 3.00M;

            return arrayOfGoods;
        }

        public static void ShowPriceList(Goods[] argArray)
        {
            Console.Write("Enter please your name: "); //вынести потом в отдельный метод приветствия
            string namePurchaser = Console.ReadLine(); //вынести потом в отдельный метод
            Console.WriteLine(); //вынести потом в отдельный метод
            Console.WriteLine("{0}, choose that your want to buy: \n", namePurchaser); //вынести потом в отдельный метод
            Console.WriteLine("-----------Products------------\n");
            for (int i = 0; i < argArray.Length; i++)
            {
                Console.WriteLine("{0}. {1,-10} : $ {2,4}", argArray[i].Id, argArray[i].Name, argArray[i].Price);
            }
            Console.WriteLine();
            Console.WriteLine("6. Exit");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }

        public static decimal ShowPurchaseList(Purchase[] argArrayOne, Goods[] argArrayTwo)
        {
            string isDiscount = default(string);
            bool isRightAnswer = default(bool);
            bool isRightValueOfDiscount = default(bool);
            decimal totalDiscount = default(decimal);
            decimal totalPayment = default(decimal);
            Console.Write("Do you have discount? (yes, no): ");
            while (!isRightAnswer)
            {
                isDiscount = Console.ReadLine();
                if ((isDiscount != "yes") && (isDiscount != "no"))
                {
                    Console.Write("Please, choose YES or NO: ");
                }
                else
                {
                    isRightAnswer = true;
                }

            }
            switch (isDiscount)
            {
                case "yes":
                    Console.Write("Enter a value of discount (in persentage from 1 to 99): ");
                    while (!isRightValueOfDiscount)
                    {
                        while (Decimal.TryParse(Console.ReadLine(), out totalDiscount) == false)
                        {
                            Console.Write("Please, enter correct value of discount (in persentage from 1 to 99): ");
                        }
                        if (totalDiscount >= 1 && totalDiscount < 100)
                        {
                            totalDiscount = totalDiscount / 100;
                            isRightValueOfDiscount = true;
                        }
                        else
                        {
                            Console.Write("Please, enter correct value of discount (in persentage from 1 to 99): ");
                        }
                    }
                    break;
                case "no": totalDiscount = 1; break;
            }
            Console.WriteLine("\r\n-------------Check-------------");
            for (int i = 0; i < argArrayOne.Length; i++)
            {
                if (argArrayOne[i].Amount > 0)
                {
                    totalPayment += argArrayOne[i].Amount * argArrayTwo[i].Price;
                    Console.WriteLine("{0,-10} x  {1,3} = $ {2,4}", argArrayOne[i].Name, argArrayOne[i].Amount, argArrayOne[i].Amount * argArrayTwo[i].Price);
                }
            }
            Console.WriteLine("-------------------------------");
            if (totalDiscount == 1)
            {
                Console.WriteLine("For payment : $ {0:0.00}\r\n", totalPayment);
            }
            else
            {
                Console.WriteLine("Total discount : $ {0:0.00}", totalPayment * totalDiscount);
                Console.WriteLine("For payment    : $ {0:0.00}\r\n", totalPayment - (totalDiscount * totalPayment));
            }

            return totalPayment;
        }

        public uint GetAmountOfGoods()
        {
            uint amountOfGoods;
            Console.Write("Count: ");
            while (uint.TryParse(Console.ReadLine(), out amountOfGoods) == false)
            {
                Console.Write("Please, enter correct amount value!: ");
            }
            return amountOfGoods;
        }

        public void AddGoodsToCart(ref Purchase[] argArrayOne, ref Goods[] argArrayTwo)
        {
            bool isExit = false;
            while (!isExit)
            {
                Console.Write("Point: ");
                string pointId = Console.ReadLine();
                switch (pointId)
                {
                    case "1": argArrayOne[0].Amount += GetAmountOfGoods(); break;
                    case "2": argArrayOne[1].Amount += GetAmountOfGoods(); break;
                    case "3": argArrayOne[2].Amount += GetAmountOfGoods(); break;
                    case "4": argArrayOne[3].Amount += GetAmountOfGoods(); break;
                    case "5": argArrayOne[4].Amount += GetAmountOfGoods(); break;
                    case "6": ShowPurchaseList(argArrayOne, argArrayTwo); isExit = true; Console.ReadKey(); break;
                    default: Console.Write("Please, choose point from the current product list!\r\n"); break;
                }
            }
        }
    }
}
