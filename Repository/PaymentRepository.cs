using BussinessObject2;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PaymentRepository : IPayment
    {
        public List<DepositCate> GetDepositCates() => PaymentDAO.GetDepositCates();
    }
}
