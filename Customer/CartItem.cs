using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penjualan_Buku.Customer
{
    public class CartItem
    {
        public int IdBuku { get; set; }
        public string judul { get; set; }
        public decimal? harga { get; set; }
        public int qty { get; set; }
        public decimal subtotal => (harga ?? 0 ) * qty;
    }
}
