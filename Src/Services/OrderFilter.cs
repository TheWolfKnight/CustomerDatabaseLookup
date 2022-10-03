using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerDatabaseLookup.Src.Models;


namespace CustomerDatabaseLookup.Src.Services
{
    public static class OrderFilter
    {

        /// <summary>
        /// Sorts the given list of orders by the orders time of the orders Orderd field.
        /// The sort is limited by the amt variable, and will by default show the 3 latest orders
        /// </summary>
        /// <param name="orders"> The customers orders that will be sorted </param>
        /// <param name="amt"> The amount of orders that are returnd by the function </param>
        /// <returns> A list of orders </returns>
        public static List<Order> GetRecentOrders(List<Order> orders, int amt = 3)
        {
            List<Order> result = orders.OrderBy(order => order.Orderd).Reverse().ToList();
            return result.GetRange(0, amt);
        }


        /// <summary>
        /// Sorts the orders by where or not they are completed, then returns the completed orders
        /// </summary>
        /// <param name="orders"> The customers orders that will be sorted </param>
        /// <returns> A list of orders </returns>
        public static List<Order> GetCompletedOrder(List<Order> orders)
        {
            List<Order> result = orders.Where(order => order.Status is OrderStatus.Complete).ToList();
            return result;
        }

        /// <summary>
        /// Sortes the orders by incressing price
        /// </summary>
        /// <param name="orders"> The customers orders that will be sorted </param>
        public static List<Order> SortPricesIncresse(List<Order> orders)
        {
            List<Order> result = orders.OrderBy(order => order.TotalPrice).ToList();
            return result;
        }

    }
    
}
