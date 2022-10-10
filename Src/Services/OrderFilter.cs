using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerDatabaseLookup.Src.Models;


namespace CustomerDatabaseLookup.Src.Services
{
    public class OrderFilter
    {

        /// <summary>
        /// Sorts the given list of orders by the orders time of the orders Orderd field.
        /// The sort is limited by the amt variable, and will by default show the 3 latest orders
        /// </summary>
        /// <param name="AllOrderHistories"> The customers orders that will be sorted </param>
        /// <returns> A list of orders </returns>
        public List<Order> GetRecent3Orders(List<Order> AllOrderHistories)
        {
            IEnumerable<Order> SortedOrderList = AllOrderHistories.OrderByDescending(OH => OH.Orderdate);
            List<Order> result = SortedOrderList.Take(3).ToList();

            return result;
            
        }


        /// <summary>
        /// Sorts the orders by where or not they are completed, then returns the completed orders
        /// </summary>
        /// <param name="AllOrderHistories"> The customers orders that will be sorted </param>
        /// <returns> A list of orders </returns>
        public List<Order> GetCompletedOrder(List<Order> AllOrderHistories)
        {
            List<Order> result = AllOrderHistories.Where(OH => OH.Status == OrderStatus.Complete).ToList();
            return result;
        }

        /// <summary>
        /// Sortes the orders by incressing price
        /// </summary>
        /// <param name="orders"> The customers orders that will be sorted </param>
        public List<Order> SortPricesIncresse(List<Order> orders)
        {
            List<Order> result = orders.OrderBy(order => order.TotalPrice).ToList();
            return result;
        }

    }
    
}
