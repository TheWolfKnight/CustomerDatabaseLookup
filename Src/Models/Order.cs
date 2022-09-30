using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDatabaseLookup.Src.Models
{
    public class Order
    {

        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime Orderd { get; private set;  }
        public float TotalPrice { get; private set; }
        public OrderStatus Status { get; private set; }

        /// <summary>
        /// Creates a new Order instance, this tells the program the different thing that has been bought by different customers.
        /// </summary>
        /// <param name="id"> The id of the order </param>
        /// <param name="title"> The item that has been orderd </param>
        /// <param name="orderd"> The time the order was placed </param>
        /// <param name="totalPrice"> The total price of the order </param>
        /// <param name="status"> The status of the order. DEFAULT: OrderStatus.Processing </param>
        public Order( int id, string title, DateTime orderd, float totalPrice, OrderStatus status=OrderStatus.Processing )
        {
            Id = id;
            Title = title;
            Orderd = orderd;
            TotalPrice = totalPrice;
            Status = status;
        }

    }
    
    /// <summary>
    /// Tells the orders status. Can be Anulled, Processing, or Complete.
    /// </summary>
    public enum OrderStatus
    {
        Anulled,
        Processing,
        Complete
    }

}
