using Enumeration.Entities;
using Enumeration.Entities.Enums;

namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { 
            Id = 1920,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}