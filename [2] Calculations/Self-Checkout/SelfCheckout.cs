using System;
using System.Collections.Generic;
using static CSharp._2__Calculations.DataValidation;

namespace CSharp._2__Calculations.Self_Checkout
{
    internal class SelfCheckout
    {
        private const float TAX = 0.055f;

        private class Item
        {
            private readonly float? price, quantity;
            public float? subtotal;
            public Item(int _i)
            {
                price = ValidatedNumber($"Enter the price of item {_i}: ", _sentinel: "STOP");
                if (price == null)
                    throw new Exception();
                
                quantity = ValidatedNumber($"Enter the quantity of item {_i}: ", _sentinel: "STOP");
                if (quantity == null)
                    throw new Exception();
                subtotal = price * quantity;
            }
        }

        private class Basket
        {
            private readonly List<Item> items;
            private readonly float subtotal, tax, total;
            public Basket(List<Item> _items)
            {
                items = _items;
                foreach (Item item in items)
                    subtotal += (float)item.subtotal;
                tax = subtotal * TAX; 
                total = subtotal + tax;
            }

            public void DisplayTotals()
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Tax: ${tax:F2}");
                Console.WriteLine($"Total: ${total:F2}");
            }
        }

        static void Main8()
        {
            List<Item> items = [];
            for (int i = 1; true; i++)
            {
                try { items.Add(new Item(i)); }
                catch { break; }
            }
            Basket checkout = new(items);
            checkout.DisplayTotals();
        }
    }
}
