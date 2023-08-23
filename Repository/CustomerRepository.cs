using BussinessObject2;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers() => CustomerDAO.GetCustomers();

        public void AddCustomer(Customer customer) => CustomerDAO.AddCustomer(customer);
    }
}
