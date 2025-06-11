using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penjualan_Buku.Customer
{
    public class CartService
    {
        public static List<CartItem> Items { get; set; } = new List<CartItem>();
        public static decimal Total => Items.Sum(i => i.subtotal);

        public static Action OnCartChanged;

        public static void AddToCart(CartItem item)
        {
            var existing = Items.FirstOrDefault(i => i.IdBuku == item.IdBuku);
            if (existing != null)
            {
                existing.qty += item.qty;
            }
            else
            {
                Items.Add(item);
            }
            OnCartChanged?.Invoke();
        }
        public static void RemoveFromCart(int id)
        {
            var item = Items.FirstOrDefault(i => i.IdBuku == id);
            if(item != null)
            {
                Items.Remove(item);
                OnCartChanged?.Invoke();
            }
        }
        public static void UpdateQuantity(int idBuku, int newQty)
        {
            var item = Items.FirstOrDefault(i => i.IdBuku == idBuku);
            if(item != null)
            {
                item.qty = newQty;
                OnCartChanged?.Invoke();
            }
        }
    }
}
