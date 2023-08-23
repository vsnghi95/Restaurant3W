using BussinessObject2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class OrderDAO
    {
        public static List<Order> GetOrders()
        {
            List<Order> listOrd = new List<Order>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listOrd = context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrd;
        }
        public static void AddOrder(Order Order)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Orders.Add(Order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateOrder(Order Order)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Entry<Order>(Order).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
