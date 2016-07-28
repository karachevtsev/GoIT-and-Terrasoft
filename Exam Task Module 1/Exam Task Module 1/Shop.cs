using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Task_Module_1
{
    class Shop
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Goods[] listOfGoods = cart.CreateListOfGoods();
            Cart.ShowPriceList(listOfGoods);
            Purchase[] listOfPurchase = cart.CreateListOfPurchase(listOfGoods);          
            cart.AddGoodsToCart(ref listOfPurchase, ref listOfGoods);
        }
    } 
}
