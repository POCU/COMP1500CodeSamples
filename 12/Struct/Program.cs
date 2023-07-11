using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            CartItem cartItem = new CartItem
            {
                Name = "Hello World! Programming Book",
                Price = 10.99m,
                Quantity = 5
            };

            ModifyCartItem(cartItem);

            Console.WriteLine($"Name: {cartItem.Name}");
            Console.WriteLine($"Price: {cartItem.Price}");
            Console.WriteLine($"Quantity: {cartItem.Quantity}");
        }

        public static void ModifyCartItem(CartItem cartItem)
        {
            cartItem.Name = "How to suck at programming";
            cartItem.Price = 0.99m;
            cartItem.Quantity = 1;
        }
    }
}
