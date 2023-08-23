using BussinessObject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> listCus = new List<Customer>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listCus = context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listCus;
        }
        public static void AddCustomer(Customer Customer)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Add(Customer);
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
