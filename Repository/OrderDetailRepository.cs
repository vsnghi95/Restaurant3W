using BussinessObject2;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetail> GetOrderDetails() => OrderDetailDAO.GetOrderDetails();

        public void AddOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.AddOrderDetial(orderDetail);
    }
}
