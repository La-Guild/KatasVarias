using System.Collections.Generic;
using System.Linq;

namespace TellDontAskKata.Main.Domain
{
    public class Order
    {
        public decimal Tax => Items.Sum(i => i.Tax);
        public decimal Total => Items.Sum(i => i.TaxedAmount);
        public string Currency { get; set; }
        public IList<OrderItem> Items { get; } = new List<OrderItem>();
        public OrderStatus Status { get; set; }
        public int Id { get; set; }

        public void Add(OrderItem item)
        {
            Items.Add(item);
        }
    }
}