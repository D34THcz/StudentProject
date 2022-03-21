using System.Collections.Generic;
using System.Text;

namespace StudentProject.BL
{
    public enum OrderState
    {
        Completed,
        NeedSend,
        NeedComplete
    }

    public class Order : IRepositoryModel
    {
        public int Id { get; set; }
        public OrderState OrderStatus { get; set; }
        public List<OrderItem> Products = new List<OrderItem>();
        public Customer Customer { get; set; }
        private int orderPrice;
        public int OrderPrice
        {
            get
            {
                GetTotalPrice();
                return orderPrice;
            }
        } 
        private static int orderId = 0;

        private Order(Customer customer)
        {
            orderId += 1;
            Id = orderId;
            Customer = customer;
            OrderStatus = OrderState.NeedComplete;
        }
        
        public Order(Customer customer, List<OrderItem> products) : this(customer)
        {   
            Products = products;
        }

        public Order(Customer customer, OrderItem product) : this(customer)
        {
            Products.Add(product);
        }

        public override string ToString()
        {
            string returnString = $"{Customer.FullName}\n";
            return returnString + OrderItems();
        }

        private int GetTotalPrice()
        {
            orderPrice = 0;
            
                foreach (var item in Products)
                {
                    orderPrice += item.TotalPrice;
                }
            
            return orderPrice;   
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            Products.Add(orderItem);      
        }

        public string OrderItems()
        {
            var sb = new StringBuilder();

            foreach (var item in Products)
            {
                sb.Append(item.ToString());
                sb.Append("\n");
            }
            sb.Append($"Total order price: {OrderPrice}EUR");
            return sb.ToString();
        }

        public string OrderStatusNow()
        {
            string orderStatus;
            switch (OrderStatus)
            {
                case OrderState.Completed:
                    orderStatus = "Completed";
                    break;
                case OrderState.NeedSend:
                    orderStatus = "Need to ship";
                    break;
                case OrderState.NeedComplete:
                    orderStatus = "Need to complete";
                    break;
                default:
                    orderStatus = "Unknown status";
                    break;
            }
            return orderStatus;
        }
       
        public object Clone()
        {
            return new Order(Customer)
            {
                Id = Id,
                OrderStatus = OrderStatus,
                Products = Products,
                Customer = Customer
            };
        }

    }
}
