using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubT_Shirts
{
    public class OrderItem
    {
        public string Size { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; private set; }

        public OrderItem(string size, int quantity)
        {
            Size = size;
            Quantity = quantity;
            CalculateCost();
        }

        private void CalculateCost()
        {
            decimal unitPrice = (Size == "XSmall" || Size == "XXLarge") ? 20 : 16;
            Cost = unitPrice * Quantity;
        }
    }
    public class OrderManager
    {
        private List<OrderItem> orders = new List<OrderItem>();

        public void AddOrder(string size, int quantity)
        {
            orders.Add(new OrderItem(size, quantity));
        }

        public List<OrderItem> GetOrders()
        {
            return orders;
        }

        public void ClearOrders()
        {
            orders.Clear();
        }
    }
}
