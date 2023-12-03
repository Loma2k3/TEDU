using AnimeShope.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeShope.Data.entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
