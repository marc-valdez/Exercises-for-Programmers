using static CSharp.DataValidation;

namespace CSharp.Calculations
{
    internal class SelfCheckout
    {
        private const float TAX_RATE = 0.055f;

        private class Item
        {
            private readonly float? price, quantity;
            public float? subtotal;
            public Item(int _i)
            {
                price = ValidatedNumber<float>($"Enter the price of item {_i}: ", _sentinel: "STOP");
                if (price == null)
                    throw new Exception();
                
                quantity = ValidatedNumber<float>($"Enter the quantity of item {_i}: ", _sentinel: "STOP");
                if (quantity == null)
                    throw new Exception();
                subtotal = price * quantity;
            }
        }

        private class Basket
        {
            private readonly float? subtotal, tax, total;
            public Basket(List<Item> _items)
            {
                foreach (Item item in _items)
                    subtotal += item.subtotal;
                tax = subtotal * TAX_RATE; 
                total = subtotal + tax;
            }

            public void DisplayTotals()
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Tax: ${tax:F2}");
                Console.WriteLine($"Total: ${total:F2}");
            }
        }

        public static void Main8()
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
