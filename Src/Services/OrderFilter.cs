using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerDatabaseLookup.Src.Models;


namespace CustomerDatabaseLookup.Src.Services
{
    public  class OrderFilter
    {

        /// <summary>
        /// Sorts the given list of orders by the orders time of the orders Orderd field.
        /// The sort is limited by the amt variable, and will by default show the 3 latest orders
        /// </summary>
        /// <param name="AllOrderHistories"> The customers orders that will be sorted </param>
        /// <returns> A list of orders </returns>
        public List<OrderHistories> GetRecent3Orders(List<OrderHistories> AllOrderHistories)
        {
            var SortedOrderList = AllOrderHistories.OrderBy(OH => OH.Orderdate);
            var result = SortedOrderList.Take(3);

            return result.ToList(); 
            
        }


        /// <summary>
        /// Sorts the orders by where or not they are completed, then returns the completed orders
        /// </summary>
        /// <param name="AllOrderHistories"> The customers orders that will be sorted </param>
        /// <returns> A list of orders </returns>
        public List<OrderHistories> GetCompletedOrder(List<OrderHistories> AllOrderHistories)
        {
            var filteredList = AllOrderHistories.Where(OH => OH.OrderStatus == 2);

            return filteredList.ToList();


           
        }

        /// <summary>
        /// Sortes the orders by incressing price
        /// </summary>
        /// <param name="orders"> The customers orders that will be sorted </param>
        public static List<OrderHistories> SortPricesIncresse(List<OrderHistories> orders)
        {
            List<OrderHistories> result = orders.OrderBy(order => order.TotalPrice).ToList();
            return result;
        }

    }
    
}
