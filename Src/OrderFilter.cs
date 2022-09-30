using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerDatabaseLookup.Src.Models;


namespace CustomerDatabaseLookup.Src
{
    public static class OrderFilter
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="amt"></param>
        /// <returns></returns>
        public static List<Order> GetRecentOrders( List<Order> orders, int amt=3 )
        {
            List<Order> result = orders.OrderBy( order => order.Orderd ).Reverse().ToList();
            return result.GetRange(0, amt);

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public static List<Order> GetCompletedOrder( List<Order> orders )
        {
            List<Order> result = orders.Where(order => order.Status is OrderStatus.Complete).ToList();
            return result;
        }

    }
}
