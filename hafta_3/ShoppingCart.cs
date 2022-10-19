using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_3
{
    public class ShoppingCart
    {
        private List<CartItem> cartItems;

        public ShoppingCart()
        {
            cartItems = new List<CartItem>();
        }

        public void Add(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }
        public void Remove(int id)
        {
            var deleted = cartItems.FirstOrDefault(a=> a.CartId == id);
            if (deleted == null)
            {
                Console.WriteLine("Ürün bulunamadı.");
                return;
            }
            cartItems.Remove(deleted);
            Console.WriteLine("Ürün silindi.");
        }

        public void GetBalance()
        {
            double toplam = 0;
            foreach (var item in cartItems)
            {
                toplam += item.Quantity * item.Product.Price;
            }
            Console.WriteLine($"Toplam Fiyat={toplam}");
        }
        public void GetList()
        {
            foreach(var item in cartItems)
            {
                Console.WriteLine($"{item.CartId}, {item.Quantity}, {item.Product.ProductName}, {item.Product.Price}");
            }
        }



    }
}
